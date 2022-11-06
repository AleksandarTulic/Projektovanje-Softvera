package controller;

import jakarta.servlet.ServletException;
import jakarta.servlet.annotation.WebServlet;
import jakarta.servlet.http.HttpServlet;
import jakarta.servlet.http.HttpServletRequest;
import jakarta.servlet.http.HttpServletResponse;
import logger.MyLogger;
import other.Notification;
import service.AppointmentService;

import java.io.IOException;
import java.util.logging.Level;

import com.google.gson.Gson;

import dto.AppointmentDTO;
import factory.AppointmentFactory;

@WebServlet("/Appointment/*")
public class AppointmentController extends HttpServlet {
	private static final long serialVersionUID = 1L;

    public AppointmentController() {
        super();
    }

	protected void doGet(HttpServletRequest request, HttpServletResponse response){
		String what = request.getParameter("what");
		
		try {
			if ("insertAppointment".equals(what)) {
				AppointmentFactory aFactory = AppointmentFactory.getInstance();
				AppointmentDTO dto = aFactory.get(request);
				boolean flag = false;

				if (dto != null) {
					AppointmentService aService = new AppointmentService();
					flag = aService.insert(dto);
				}
				
				String json = new Gson().toJson("{\"message\": \"" + Notification.getMessage(flag) + "\", \"alertType\": \"" + Notification.getAlert(flag) + "\", \"flag\": \"" + flag + "\"}");
				
				response.setContentType("application/json");
				response.setCharacterEncoding("UTF-8");
				response.getWriter().write(json);
			}else if ("deleteAppointment".equals(what)) {
				request.setAttribute("howLong", "1");
				AppointmentFactory aFactory = AppointmentFactory.getInstance();
				AppointmentDTO dto = aFactory.get(request);
				boolean flag = false;
				
				if (dto != null) {
					AppointmentService aService = new AppointmentService();
					flag = aService.delete(dto);
				}
				
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
