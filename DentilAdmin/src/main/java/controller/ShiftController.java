package controller;

import jakarta.servlet.RequestDispatcher;
import jakarta.servlet.ServletException;
import jakarta.servlet.annotation.WebServlet;
import jakarta.servlet.http.HttpServlet;
import jakarta.servlet.http.HttpServletRequest;
import jakarta.servlet.http.HttpServletResponse;
import logger.MyLogger;
import other.Notification;
import service.ShiftService;

import java.io.IOException;
import java.sql.Time;
import java.util.logging.Level;

import dto.ShiftDTO;

@WebServlet("/Shift")
public class ShiftController extends HttpServlet {
	private static final long serialVersionUID = 1L;

    public ShiftController() {
        super();
    }

	protected void doGet(HttpServletRequest request, HttpServletResponse response) {
		String address = "index.jsp";
		String where = request.getParameter("what");
		
		try {
			if ("shiftAdd".equals(where)) {
				address = "/WEB-INF/schedule/schedule.jsp";
				
				if (request.getParameter("begin") != null && request.getParameter("end") != null) {
					ShiftService shiftService = new ShiftService();
					ShiftDTO dto = null;
					
					try {
						dto = new ShiftDTO(0, Time.valueOf(request.getParameter("begin") + ":00"), Time.valueOf(request.getParameter("end") + ":00"));
					}catch (Exception e) {
						MyLogger.logger.log(Level.SEVERE, e.getMessage());
					}
					
					boolean flag = shiftService.insert(dto);
					Notification.setMessage(request, flag);
				}else {
					Notification.setMessage(request, false);
				}
			}else if ("shiftDelete".equals(where)) {
				address = "/WEB-INF/schedule/schedule.jsp";
				
				if (request.getParameter("idShift") != null) {
					ShiftService shiftService = new ShiftService();
					Integer value = -1;
					
					try {
						value = Integer.valueOf(request.getParameter("idShift"));
					}catch (Exception e) {
						MyLogger.logger.log(Level.SEVERE, e.getMessage());
					}
					
					boolean flag = shiftService.delete(value);
					Notification.setMessage(request, flag);
				}
			}
			
			RequestDispatcher dispatcher = request.getRequestDispatcher(address);
			dispatcher.forward(request, response);
		}catch (Exception e) {
			MyLogger.logger.log(Level.SEVERE, e.getMessage());
		}
	}

	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		doGet(request, response);
	}

}
