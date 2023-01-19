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

    public PatientController() {
        super();
    }

	protected void doGet(HttpServletRequest request, HttpServletResponse response){
		String what = request.getParameter("what");
		
		try {
			if ("insertPatient".equals(what)) {
				PatientFactory pFactory = PatientFactory.getInstance();
				PatientDTO dto = pFactory.get(request);
				//System.out.println(dto);
				boolean flag = false;

				if (dto != null) {
					PatientService pService = new PatientService();
					flag = pService.insert(dto);
				}
				
				String json = new Gson().toJson("{\"message\": \"" + Notification.getMessage(flag) + "\", \"alertType\": \"" + Notification.getAlert(flag) + "\", \"flag\": \"" + flag + "\"}");
				
				response.setContentType("application/json");
				response.setCharacterEncoding("UTF-8");
				response.getWriter().write(json);
			}else if ("updatePatient".equals(what)) {
				PatientFactory pFactory = PatientFactory.getInstance();
				PatientDTO dto = pFactory.get(request);
				String oldId = request.getParameter("oldID");
				PatientService pService = new PatientService();
				boolean flag = pService.update(dto, oldId);
				String json = new Gson().toJson("{\"message\": \"" + Notification.getMessage(flag) + "\", \"alertType\": \"" + Notification.getAlert(flag) + "\", \"flag\": \"" + flag + "\"}");
				
				response.setContentType("application/json");
				response.setCharacterEncoding("UTF-8");
				response.getWriter().write(json);
			}else if ("deletePatient".equals(what)) {
				String id = request.getParameter("idPatient");
				PatientService pService = new PatientService();
				boolean flag = pService.delete(id);
				String json = new Gson().toJson("{\"message\": \"" + Notification.getMessage(flag) + "\", \"alertType\": \"" + Notification.getAlert(flag) + "\", \"flag\": \"" + flag + "\"}");
				
				response.setContentType("application/json");
				response.setCharacterEncoding("UTF-8");
				response.getWriter().write(json);
			}
		}catch (Exception e) {
			MyLogger.logger.log(Level.SEVERE, e.getMessage());
		}
	}

	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		doGet(request, response);
	}

}
