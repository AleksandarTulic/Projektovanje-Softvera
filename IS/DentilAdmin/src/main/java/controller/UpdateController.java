package controller;

import jakarta.servlet.ServletException;
import jakarta.servlet.annotation.WebServlet;
import jakarta.servlet.http.HttpServlet;
import jakarta.servlet.http.HttpServletRequest;
import jakarta.servlet.http.HttpServletResponse;
import logger.MyLogger;
import other.Notification;
import service.*;

import java.io.IOException;
import java.util.logging.Level;

import com.google.gson.Gson;

import factory.*;
import dto.*;
import enums.UserType;

@WebServlet("/Update")
public class UpdateController extends HttpServlet {
	private static final long serialVersionUID = 1L;
	private DentistService dService = new DentistService();
	private AdminService aService = new AdminService();
	private CounterService cService = new CounterService();
	private UserService userService = new UserService();
	
    public UpdateController() {
        super();
    }

	protected void doGet(HttpServletRequest request, HttpServletResponse response) {
		String userType = request.getParameter("role_name");
		
		try {
			String json = "";
			boolean flag = true;
			
			if (UserType.admin.getValue().equals(userType)) {
				AdminFactory aFactory = AdminFactory.getInstance();
				AdminDTO dto = aFactory.get(request);
				String oldID = request.getParameter("oldID");
				
				flag = aService.update(dto, oldID);
			}else if (UserType.counter.getValue().equals(userType)) {
				CounterFactory cFactory = CounterFactory.getInstance();
				CounterDTO dto = cFactory.get(request);
				String oldID = request.getParameter("oldID");
				
				flag = cService.update(dto, oldID);
			}else if (UserType.dentist.getValue().equals(userType)) {
				DentistFactory dFactory = DentistFactory.getInstance();
				DentistDTO dto = dFactory.get(request);
				String oldID = request.getParameter("oldID");
				
				flag = dService.update(dto, oldID);
			}else if ("recoverWorker".equals(request.getParameter("what"))) {
				flag = userService.updateWorkerActive(request.getParameter("id"));
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
