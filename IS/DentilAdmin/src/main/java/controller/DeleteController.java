package controller;

import jakarta.servlet.ServletException;
import jakarta.servlet.annotation.WebServlet;
import jakarta.servlet.http.HttpServlet;
import jakarta.servlet.http.HttpServletRequest;
import jakarta.servlet.http.HttpServletResponse;
import logger.MyLogger;

import java.io.IOException;
import java.util.logging.Level;

import com.google.gson.Gson;

import dto.AdminDTO;
import enums.UserType;
import service.*;
import other.*;

@WebServlet("/Delete")
public class DeleteController extends HttpServlet {
	private static final long serialVersionUID = 1L;
	private UserService uService = new UserService();
       
    public DeleteController() {
        super();
    }

	protected void doGet(HttpServletRequest request, HttpServletResponse response) {
		String id = request.getParameter("id");
		String role = request.getParameter("role");
		
		try {
			String json = "";
			if (id != null && role != null) {
				boolean flagAction = false;
				
				if (UserType.admin.getValue().equals(role)) {
					AdminDTO dto = (AdminDTO)request.getSession().getAttribute("aaaa");
					if (dto.getId().equals(id)) {
						json = new Gson().toJson("{\"message\": \"" + Notification.getMessage(false) + "\", \"alertType\": \"" + Notification.getAlert(false) + "\", \"flag\": \"" + false + "\"}");
					}else {
						flagAction = true;
					}
				}else if (UserType.counter.getValue().equals(role) || UserType.dentist.getValue().equals(role)) {
					flagAction = true;
				}
				
				if (flagAction) {
					boolean flag = uService.delete(id);
					json = new Gson().toJson("{\"message\": \"" + Notification.getMessage(flag) + "\", \"alertType\": \"" + Notification.getAlert(flag) + "\", \"flag\": \"" + flag + "\"}");
				}
			}
			
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
