package controller;

import jakarta.servlet.RequestDispatcher;
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
import java.util.ArrayList;
import java.util.Enumeration;
import java.util.List;
import java.util.logging.Level;

import dto.ScheduleDTO;
import dto.UserDTO;

@WebServlet("/ScheduleController")
public class ScheduleController extends HttpServlet {
	private static final long serialVersionUID = 1L;

    public ScheduleController() {
        super();
    }

	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		String address = "index.jsp";
		String where = request.getParameter("what");
		boolean flag = false;
		
		try {
			if ("addSchedule".equals(where)) {
				address = "/WEB-INF/schedule/schedule.jsp";
				List<String> arr = getCheckValues(request);
				
				UserDTO userDTO = (UserDTO)request.getSession().getAttribute("aaaa");
				ScheduleService service = new ScheduleService();
				for (String i : arr) {
					try {
						ScheduleDTO dto = new ScheduleDTO(Integer.valueOf(request.getParameter("idShift")), 
								Date.valueOf(request.getParameter("date")), 
								i, 
								userDTO.getId());
						
						flag = service.insert(dto);
					}catch (Exception e) {
						MyLogger.logger.log(Level.SEVERE, e.getMessage());
					}
				}
				
			}else if ("deleteSchedule".equals(where)) {
				address = "/WEB-INF/schedule/schedule.jsp";
				List<String> arr = getCheckValues(request);
				
				ScheduleService service = new ScheduleService();
				for (String i : arr) {
					String []sp = i.split("_");
					
					String idPersonal = sp[0];
					String idShift = sp[1];
					String date = sp[2];
					
					ScheduleDTO dto = new ScheduleDTO(Integer.valueOf(idShift), Date.valueOf(date), idPersonal);
					flag = service.delete(dto);
				}
			}
			
			Notification.setMessage(request, flag);
			
			RequestDispatcher dispatcher = request.getRequestDispatcher(address);
			dispatcher.forward(request, response);
		}catch(Exception e) {
			MyLogger.logger.log(Level.SEVERE, e.getMessage());
		}
	}

	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		doGet(request, response);
	}

	private List<String> getCheckValues(HttpServletRequest request) {
		List<String> arr = new ArrayList<>();
		
		try {
			Enumeration<String> ite = request.getParameterNames();
			
			while (ite.hasMoreElements()) {
				String header = ite.nextElement();

				if (header.startsWith("check_"))
					arr.add(request.getParameter(header));
			}
		}catch(Exception e) {
			MyLogger.logger.log(Level.SEVERE, e.getMessage());
		}
		
		return arr;
	}
}
