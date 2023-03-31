package controller;

import jakarta.servlet.ServletException;
import jakarta.servlet.annotation.WebServlet;
import jakarta.servlet.http.HttpServlet;
import jakarta.servlet.http.HttpServletRequest;
import jakarta.servlet.http.HttpServletResponse;
import logger.MyLogger;
import service.AppointmentService;
import service.DentistService;

import java.io.IOException;
import java.sql.Date;
import java.util.List;
import java.util.logging.Level;

import com.google.gson.Gson;

import dto.AppointmentDTO;
import dto.DentistDTO;

@WebServlet("/SpecialData/*")
public class SpecialController extends HttpServlet {
	private static final long serialVersionUID = 1L;
	private static final DentistService dService = new DentistService();
    private static final AppointmentService aService = new AppointmentService();
    
    public SpecialController() {
        super();
    }

	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
	}

	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		String what = request.getParameter("what");
		
		try {
			String json = "";
			if ("getDentists".equals(what)) {
				List<DentistDTO> dto = dService.select();
				json = new Gson().toJson(dto);
			}else if ("getAppointmentsSameDayAndDentist".equals(what)) {
				String date = request.getParameter("date");
				String idDentist = request.getParameter("idDentist");
				Date dateValue = null;
				Long left = 0L;
				Long right = Long.MAX_VALUE;
				
				//System.out.println(date + " " + idDentist);
				
				try {
					dateValue = Date.valueOf(date);
					left = Long.parseLong(request.getParameter("left"));
					right = Long.parseLong(request.getParameter("right"));
				}catch (Exception e) {
					MyLogger.logger.log(Level.SEVERE, e.getMessage());
				}
				
				List<AppointmentDTO> dto = aService.selectSameDayAndDentist(dateValue, idDentist, left, right);
				
				json = new Gson().toJson(dto);
			}else if ("getNumberOfAppointmentsSameDayAndDentist".equals(what)){
				String date = request.getParameter("date");
				String idDentist = request.getParameter("idDentist");
				Date dateValue = null;
				
				try {
					dateValue = Date.valueOf(date);
				}catch (Exception e) {
					MyLogger.logger.log(Level.SEVERE, e.getMessage());
				}
				
				json = new Gson().toJson(aService.selectNumberOfSameDayAndDentist(dateValue, idDentist));
			}
			
			response.setContentType("application/json");
			response.setCharacterEncoding("UTF-8");
			response.getWriter().write(json);
		}catch (Exception e) {
			MyLogger.logger.log(Level.SEVERE, e.getMessage());
		}
	}

}
