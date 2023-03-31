package controller;

import jakarta.servlet.ServletException;
import jakarta.servlet.annotation.WebServlet;
import jakarta.servlet.http.HttpServlet;
import jakarta.servlet.http.HttpServletRequest;
import jakarta.servlet.http.HttpServletResponse;
import logger.MyLogger;
import other.Notification;
import service.PatientService;

import java.io.IOException;
import java.util.logging.Level;

import com.google.gson.Gson;

import dto.PatientDTO;
import factory.PatientFactory;

@WebServlet("/Patient/*")
public class PatientController extends HttpServlet {
	private static final long serialVersionUID = 1L;
	private static final PatientService pService = new PatientService();

    public PatientController() {
        super();
    }

	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
	}

	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		String what = request.getParameter("what");
		
		try {
			String json = "";
			if ("insertPatient".equals(what)) {
				PatientFactory pFactory = PatientFactory.getInstance();
				PatientDTO dto = pFactory.get(request);
				String patientExists = "";
				boolean flag = false;

				if (dto != null) {
					flag = pService.insert(dto);
				}
				
				if (!flag)
					if (pService.selectWithIdPatient(dto.getId()) != null)
						patientExists = "Patient already exists with given id.";
				
				json = new Gson().toJson("{\"message\": \"" + (patientExists.equals("") ? Notification.getMessage(flag) : patientExists) + "\", \"alertType\": \"" + Notification.getAlert(flag) + "\", \"flag\": \"" + flag + "\"}");
			}else if ("updatePatient".equals(what)) {
				PatientFactory pFactory = PatientFactory.getInstance();
				PatientDTO dto = pFactory.get(request);
				String oldId = request.getParameter("oldID");
				
				boolean flag = pService.update(dto, oldId);
				json = new Gson().toJson("{\"message\": \"" + Notification.getMessage(flag) + "\", \"alertType\": \"" + Notification.getAlert(flag) + "\", \"flag\": \"" + flag + "\"}");
			}else if ("deletePatient".equals(what)) {
				String id = request.getParameter("id");
				
				boolean flag = pService.delete(id);
				json = new Gson().toJson("{\"message\": \"" + Notification.getMessage(flag) + "\", \"alertType\": \"" + Notification.getAlert(flag) + "\", \"flag\": \"" + flag + "\"}");
			}else if ("recoverPatient".equals(what)) {
				String id = request.getParameter("id");
				
				boolean flag = pService.updateSetActive(id);
				json = new Gson().toJson("{\"message\": \"" + Notification.getMessage(flag) + "\", \"alertType\": \"" + Notification.getAlert(flag) + "\", \"flag\": \"" + flag + "\"}");
			}
			
			response.setContentType("application/json");
			response.setCharacterEncoding("UTF-8");
			response.getWriter().write(json);
		}catch (Exception e) {
			MyLogger.logger.log(Level.SEVERE, e.getMessage());
		}
	}

}
