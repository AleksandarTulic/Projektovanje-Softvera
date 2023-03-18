package controller;

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

import com.google.gson.Gson;

import dto.ShiftDTO;

@WebServlet("/Shift")
public class ShiftController extends HttpServlet {
	private static final long serialVersionUID = 1L;
	private ShiftService service = new ShiftService();

    public ShiftController() {
        super();
    }

	protected void doGet(HttpServletRequest request, HttpServletResponse response) {
		String where = request.getParameter("what");
		
		try {
			String json = "";
			boolean flag = true;
			if ("addShift".equals(where)) {
				try {
					ShiftDTO dto = new ShiftDTO(0, Time.valueOf(request.getParameter("begin") + ":00"), Time.valueOf(request.getParameter("end") + ":00"));
					flag = service.insert(dto);
				}catch (Exception e) {
					flag = false;
					MyLogger.logger.log(Level.SEVERE, e.getMessage());
				}
			}else if ("deleteShift".equals(where)) {
				try {
					Integer value = Integer.valueOf(request.getParameter("idShift"));
					flag = service.delete(value);
				}catch (Exception e) {
					flag = false;
					MyLogger.logger.log(Level.SEVERE, e.getMessage());
				}
			}
			
			json = new Gson().toJson("{\"message\": \"" + Notification.getMessage(flag) + "\", \"alertType\": \"" + Notification.getAlert(flag) + "\", \"flag\": \"" + flag + "\"}");
			
			response.setContentType("application/json");
			response.setCharacterEncoding("UTF-8");
			response.getWriter().write(json);
		}catch (Exception e) {
			MyLogger.logger.log(Level.SEVERE, e.getMessage());
		}
	}

	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		doGet(request, response);
	}

}
