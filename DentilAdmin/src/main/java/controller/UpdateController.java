package controller;

import jakarta.servlet.RequestDispatcher;
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
import factory.*;
import dto.*;

@WebServlet("/Update")
public class UpdateController extends HttpServlet {
	private static final long serialVersionUID = 1L;

    public UpdateController() {
        super();
    }

	protected void doGet(HttpServletRequest request, HttpServletResponse response) {
		String address = "index.jsp";
		String userType = request.getParameter("role_name");
		
		try {
			if ("admin".equals(userType)) {
				address = "/WEB-INF/view/view.jsp";
				
				AdminFactory aFactory = AdminFactory.getInstance();
				AdminDTO dto = aFactory.get(request);
				String oldID = request.getParameter("oldID");
				
				AdminService aService = new AdminService();
				boolean flag = aService.update(dto, oldID);
				Notification.setMessage(request, flag);
			}else if ("counter".equals(userType)) {
				address = "/WEB-INF/view/view.jsp";
				
				CounterFactory cFactory = CounterFactory.getInstance();
				CounterDTO dto = cFactory.get(request);
				String oldID = request.getParameter("oldID");
				
				CounterService cService = new CounterService();
				boolean flag = cService.update(dto, oldID);
				Notification.setMessage(request, flag);
			}else if ("dentist".equals(userType)) {
				address = "/WEB-INF/view/view.jsp";
				
				DentistFactory dFactory = DentistFactory.getInstance();
				DentistDTO dto = dFactory.get(request);
				String oldID = request.getParameter("oldID");
				
				DentistService dService = new DentistService();
				boolean flag = dService.update(dto, oldID);
				Notification.setMessage(request, flag);
			}
			
			RequestDispatcher dispatcher = request.getRequestDispatcher(address);
			dispatcher.forward(request, response);
		}catch(Exception e) {
			MyLogger.logger.log(Level.SEVERE, e.getMessage());
		}
	}

	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		doGet(request, response);
	}

}
