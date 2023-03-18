package controller;

import jakarta.servlet.ServletException;
import jakarta.servlet.annotation.WebServlet;
import jakarta.servlet.http.HttpServlet;
import jakarta.servlet.http.HttpServletRequest;
import jakarta.servlet.http.HttpServletResponse;
import logger.MyLogger;
import other.Notification;
import service.ScheduleService;

import java.io.IOException;
import java.sql.Date;
import java.util.logging.Level;

import com.google.gson.Gson;

import dto.ScheduleDTO;
import dto.UserDTO;

@WebServlet("/Schedule")
public class ScheduleController extends HttpServlet {
	private static final long serialVersionUID = 1L;
	private ScheduleService service = new ScheduleService();
	
    public ScheduleController() {
        super();
    }

	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		String where = request.getParameter("what");
		
		try {
			String json = "";
			boolean flag = true;
			
			if ("addSchedule".equals(where)) {
				String[] arrIdPersonal = request.getParameterValues("idPersonal[]");
				String stringIdShift = request.getParameter("idShift");
				String date = request.getParameter("date");
				
				try{
					UserDTO userDTO = (UserDTO)request.getSession().getAttribute("aaaa");
					for (String i : arrIdPersonal) {
						ScheduleDTO dto = new ScheduleDTO(Integer.valueOf(stringIdShift), Date.valueOf(date), i, userDTO.getId());

						flag = flag && service.insert(dto);
					}
				}catch (Exception e) {
					MyLogger.logger.log(Level.SEVERE, e.getMessage());
					flag = false;
				}
			}else if ("deleteSchedule".equals(where)) {
				String[] arrIdPersonal = request.getParameterValues("idPersonal[]");
				String[] arrIdShift = request.getParameterValues("idShift[]");
				String[] arrDate = request.getParameterValues("date[]");
				
				try {
					for (int i=0;i<arrIdPersonal.length;i++) {
						ScheduleDTO dto = new ScheduleDTO(Integer.valueOf(arrIdShift[i]), Date.valueOf(arrDate[i]), arrIdPersonal[i]);
					
						flag = flag && service.delete(dto);
					}
				}catch (Exception e) {
					MyLogger.logger.log(Level.SEVERE, e.getMessage());
					flag = false;
				}
			}
			
			json = new Gson().toJson("{\"message\": \"" + Notification.getMessage(flag) + "\", \"alertType\": \"" + Notification.getAlert(flag) + "\", \"flag\": \"" + flag + "\"}");
			
			response.setContentType("application/json");
			response.setCharacterEncoding("UTF-8");
			response.getWriter().write(json);
		}catch(Exception e) {
			MyLogger.logger.log(Level.SEVERE, e.getMessage());
		}
	}

	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		doGet(request, response);
	}
}
