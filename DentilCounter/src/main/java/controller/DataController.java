package controller;

import jakarta.servlet.annotation.WebServlet;
import jakarta.servlet.http.HttpServlet;
import jakarta.servlet.http.HttpServletRequest;
import jakarta.servlet.http.HttpServletResponse;
import logger.MyLogger;
import java.util.logging.Level;
import java.sql.Date;
import service.AppointmentService;
import service.DentistService;
import service.PatientService;

import com.google.gson.Gson;
import java.util.*;

import dto.AppointmentDTO;
import dto.DentistDTO;
import dto.PatientDTO;

@WebServlet("/Data/*")
public class DataController extends HttpServlet {
	private static final long serialVersionUID = 1L;

    public DataController() {
        super();
    }

	protected void doGet(HttpServletRequest request, HttpServletResponse response){
		String what = request.getParameter("what");
		
		try {
			if ("getDentist".equals(what)) {
				String value = request.getParameter("value");
				DentistService dService = new DentistService();
				List<DentistDTO> dto = dService.selectWithDateWorking(value);
				String json = new Gson().toJson(dto);
				
				response.setContentType("application/json");
				response.setCharacterEncoding("UTF-8");
				response.getWriter().write(json);
			}else if ("getAppointmentsSameDayAndDentist".equals(what)) {
				String date = request.getParameter("date");
				String idDentist = request.getParameter("idDentist");
				Date dateValue = null;
				
				try {
					dateValue = Date.valueOf(date);
				}catch (Exception e) {
					e.printStackTrace();
				}
				
				AppointmentService aService = new AppointmentService();
				List<AppointmentDTO> dto = aService.selectSameDayAndDentist(dateValue, idDentist);
				String json = new Gson().toJson(dto);
				
				response.setContentType("application/json");
				response.setCharacterEncoding("UTF-8");
				response.getWriter().write(json);
			}else if ("getPatients".equals(what)) {
				PatientService pService = new PatientService();
				List<PatientDTO> dto = pService.select();
				String json = new Gson().toJson(dto);
				
				response.setContentType("application/json");
				response.setCharacterEncoding("UTF-8");
				response.getWriter().write(json);
			}else if ("getPatient".equals(what)) {
				PatientService pService = new PatientService();
				String idPatient = request.getParameter("idPatient");
				PatientDTO dto = pService.selectWithIdPatient(idPatient);
				String json = new Gson().toJson(dto);
				
				response.setContentType("application/json");
				response.setCharacterEncoding("UTF-8");
				response.getWriter().write(json);
			}
		}catch (Exception e) {
			MyLogger.logger.log(Level.SEVERE, e.getMessage());
		}

	}

}
