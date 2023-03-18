package controller;

import jakarta.servlet.ServletException;
import jakarta.servlet.annotation.WebServlet;
import jakarta.servlet.http.HttpServlet;
import jakarta.servlet.http.HttpServletRequest;
import jakarta.servlet.http.HttpServletResponse;
import logger.MyLogger;
import service.AppointmentService;
import service.DentistService;
import service.PatientService;
import service.PersonalService;

import java.io.IOException;
import java.sql.Date;
import java.util.List;
import java.util.logging.Level;

import com.google.gson.Gson;

import dto.AppointmentDTO;
import dto.DentistDTO;
import dto.PairDTO;
import dto.PatientDTO;
import dto.ScheduleDTO;
import dto.ShiftDTO;

@WebServlet("/Data/*")
public class DataController extends HttpServlet {
	private static final long serialVersionUID = 1L;
    private static final PatientService pService = new PatientService();
    private static final PersonalService personalService = new PersonalService();
      
    public DataController() {
        super();
    }

	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
	}

	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		String what = request.getParameter("what");
		
		try {
			if ("getNumberOfPatients".equals(what)) {
				String value = request.getParameter("value");
				String json = new Gson().toJson(pService.getNumberOfPatients(value == null ? "" : value));
				
				response.setContentType("application/json");
				response.setCharacterEncoding("UTF-8");
				response.getWriter().write(json);
			}else if ("getPatients".equals(what)) {
				String value = request.getParameter("value");
				Long left = 0L;
				Long right = Long.MAX_VALUE;
				String orderBy = request.getParameter("orderBy");
				String orderByType = request.getParameter("orderByType");
				
				try {
					left = Long.parseLong(request.getParameter("left"));
					right = Long.parseLong(request.getParameter("right"));
				}catch (Exception e) {
					MyLogger.logger.log(Level.SEVERE, e.getMessage());
				}
				
				String json = new Gson().toJson(pService.getPatients(value == null ? "" : value, orderBy, orderByType, left, right));
				
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
			}else if ("getAppointments".equals(what)) {
				String idPatient = request.getParameter("idPatient");
				String patientName = request.getParameter("patientName");
				String patientSurname = request.getParameter("patientSurname");
				String dentistName = request.getParameter("dentistName");
				String dentistSurname = request.getParameter("dentistSurname");
				String date = request.getParameter("date");
				
				String orderBy = request.getParameter("orderBy");
				String orderByType = request.getParameter("orderByType");
				Long left = 0L;
				Long right = Long.MAX_VALUE;
				
				try {
					left = Long.parseLong(request.getParameter("left"));
					right = Long.parseLong(request.getParameter("right"));
				}catch (Exception e) {
					MyLogger.logger.log(Level.SEVERE, e.getMessage());
				}
				
				AppointmentService aService = new AppointmentService();
				List<AppointmentDTO> dto = aService.selectWithLike(idPatient, patientName, 
						patientSurname, dentistName, 
						dentistSurname, date,
						orderBy, orderByType,
						left, right);
				String json = new Gson().toJson(dto);
				
				response.setContentType("application/json");
				response.setCharacterEncoding("UTF-8");
				response.getWriter().write(json);
			}else if ("getNumberOfAppointments".equals(what)) {
				String idPatient = request.getParameter("idPatient");
				String patientName = request.getParameter("patientName");
				String patientSurname = request.getParameter("patientSurname");
				String dentistName = request.getParameter("dentistName");
				String dentistSurname = request.getParameter("dentistSurname");
				String date = request.getParameter("date");
				
				AppointmentService aService = new AppointmentService();
				String json = new Gson().toJson(aService.getNumberOfAppointments(idPatient, patientName, 
						patientSurname, dentistName, 
						dentistSurname, date));
				
				response.setContentType("application/json");
				response.setCharacterEncoding("UTF-8");
				response.getWriter().write(json);
			}else if ("getAppointmentsSameDayAndDentist".equals(what)) {
				String date = request.getParameter("date");
				String idDentist = request.getParameter("idDentist");
				Date dateValue = null;
				Long left = 0L;
				Long right = Long.MAX_VALUE;
				
				try {
					dateValue = Date.valueOf(date);
					left = Long.parseLong(request.getParameter("left"));
					right = Long.parseLong(request.getParameter("right"));
				}catch (Exception e) {
					MyLogger.logger.log(Level.SEVERE, e.getMessage());
				}
				
				AppointmentService aService = new AppointmentService();
				List<AppointmentDTO> dto = aService.selectSameDayAndDentist(dateValue, idDentist, left, right);
				String json = new Gson().toJson(dto);
				
				response.setContentType("application/json");
				response.setCharacterEncoding("UTF-8");
				response.getWriter().write(json);
			}else if ("getDentist".equals(what)) {
				String value = request.getParameter("value");
				DentistService dService = new DentistService();
				List<DentistDTO> dto = dService.selectWithDateWorker(value);
				String json = new Gson().toJson(dto);
				
				response.setContentType("application/json");
				response.setCharacterEncoding("UTF-8");
				response.getWriter().write(json);
			}else if ("getDentists".equals(what)) {
				DentistService dService = new DentistService();
				List<DentistDTO> dto = dService.select();
				String json = new Gson().toJson(dto);
				
				response.setContentType("application/json");
				response.setCharacterEncoding("UTF-8");
				response.getWriter().write(json);
			}else if ("getPersonalSchedule".equals(what)) {
				String id = request.getParameter("id");
				String orderBy = request.getParameter("orderBy");
				String orderByType = request.getParameter("orderByType");
				Long left = 0L;
				Long right = Long.MAX_VALUE;
				
				try {
					left = Long.parseLong(request.getParameter("left"));
					right = Long.parseLong(request.getParameter("right"));
				}catch (Exception e) {
					MyLogger.logger.log(Level.SEVERE, e.getMessage());
				}
				
				PairDTO<List<ScheduleDTO>, List<ShiftDTO>> res = personalService.selectPersonalSchedule(id, orderBy, orderByType, left, right);
				String json = new Gson().toJson(res);
				
				response.setContentType("application/json");
				response.setCharacterEncoding("UTF-8");
				response.getWriter().write(json);
			}else if ("getNumberOfPersonalSchedule".equals(what)) {
				String id = request.getParameter("id");
				String json = new Gson().toJson(personalService.selectNumberOfPersonalSchedule(id));
				
				response.setContentType("application/json");
				response.setCharacterEncoding("UTF-8");
				response.getWriter().write(json);
			}
		}catch (Exception e) {
			MyLogger.logger.log(Level.SEVERE, e.getMessage());
		}
	}

}
