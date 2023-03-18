package controller;

import jakarta.servlet.ServletException;
import jakarta.servlet.annotation.WebServlet;
import jakarta.servlet.http.HttpServlet;
import jakarta.servlet.http.HttpServletRequest;
import jakarta.servlet.http.HttpServletResponse;
import logger.MyLogger;
import service.*;

import java.io.IOException;
import java.util.List;
import java.util.logging.Level;
import java.util.stream.Collectors;

import com.google.gson.Gson;

import dto.UserDTO;
import enums.UserType;

@WebServlet("/Data")
public class DataController extends HttpServlet {
	private static final long serialVersionUID = 1L;
	private TypeProblemService typeProblemService = new TypeProblemService();
	private ServiceService serviceService = new ServiceService();
	private UserService userService = new UserService();
	private AdminService adminService = new AdminService();
	private PersonalService personalService = new PersonalService();
	private ScheduleService scheduleService = new ScheduleService();
	private ShiftService shiftService = new ShiftService();
	
    public DataController() {
        super();
    }
	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
	}

	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		String what = request.getParameter("what");
		
		try {
			String json = "";
			
			if ("selectTypeProblems".equals(what)) {
				json = new Gson().toJson(typeProblemService.select());
			}else if ("selectServices".equals(what)) {
				json = new Gson().toJson(serviceService.select());
			}else if ("selectWorkers".equals(what)) {
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
				
				json = new Gson().toJson(userService.getWorkers(value == null ? "" : value, orderBy, orderByType, left, right));
			}else if ("selectNumberOfWorkers".equals(what)) {
				String value = request.getParameter("value");
				json = new Gson().toJson(userService.getNumberOfWorkers(value == null ? "" : value));
			}else if ("selectWorkerWithId".equals(what)) {
				String id = request.getParameter("id");
				String role = request.getParameter("role");
				
				if (UserType.admin.getValue().equals(role)) {
					json = new Gson().toJson(adminService.selectWithId(id));
				}else if (UserType.counter.getValue().equals(role) || UserType.dentist.getValue().equals(role)) {
					json = new Gson().toJson(personalService.selectWithId(id));
				}
			}else if ("selectNumberOfSchedules".equals(what)) {
				json = new Gson().toJson(scheduleService.selectNumberOfSchedules());
			}else if ("selectSchedules".equals(what)) {
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
				
				json = new Gson().toJson(personalService.select(orderBy, orderByType, left, right));	
			}else if ("selectShifts".equals(what)) {
				json = new Gson().toJson(shiftService.select());
			}else if ("selectWorkersWithoutAdmins".equals(what)) {
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
				
				List<UserDTO> arrRec = userService.getWorkers(value == null ? "" : value, orderBy, orderByType, left, right);
				List<UserDTO> arrSend = arrRec.stream().filter(t -> !UserType.admin.getValue().equals(t.getRole_name())).collect(Collectors.toList());
				json = new Gson().toJson(arrSend);
			}
			
			response.setContentType("application/json");
			response.setCharacterEncoding("UTF-8");
			response.getWriter().write(json);
		}catch (Exception e) {
			MyLogger.logger.log(Level.SEVERE, e.getMessage());
		}
	}

}
