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

import dto.*;
import enums.UserType;
import factory.*;
import service.*;
import other.*;

@WebServlet("/Insert")
public class InsertController extends HttpServlet {
	private static final long serialVersionUID = 1L;
	private DentistService dService = new DentistService();
	private AdminService aService = new AdminService();
    private CounterService cService = new CounterService();
    
    public InsertController() {
        super();
    }

	protected void doGet(HttpServletRequest request, HttpServletResponse response){
		String userType = request.getParameter("role_name");
		
		try {
			String json = "";
			
			if (UserType.admin.getValue().equals(userType)) {
				AdminFactory aFactory = AdminFactory.getInstance();
				
				AdminDTO dto = aFactory.get(request);
				
				if (dto != null) {
					boolean flag = aService.insert(dto);
					json = new Gson().toJson("{\"message\": \"" + Notification.getMessage(flag) + "\", \"alertType\": \"" + Notification.getAlert(flag) + "\", \"flag\": \"" + flag + "\"}");
				}
			}else if (UserType.counter.getValue().equals(userType)) {
				CounterFactory cFactory = CounterFactory.getInstance();
				
				CounterDTO dto = cFactory.get(request);
				if (dto != null) {
					boolean flag = cService.insert(dto);
					json = new Gson().toJson("{\"message\": \"" + Notification.getMessage(flag) + "\", \"alertType\": \"" + Notification.getAlert(flag) + "\", \"flag\": \"" + flag + "\"}");
				}
			}else if (UserType.dentist.getValue().equals(userType)) {
				DentistFactory dFactory = DentistFactory.getInstance();
				
				DentistDTO dto = dFactory.get(request);
				
				if (dto != null) {
					boolean flag = dService.insert(dto);
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
