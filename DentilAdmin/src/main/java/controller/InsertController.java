package controller;

import jakarta.servlet.RequestDispatcher;
import jakarta.servlet.ServletException;
import jakarta.servlet.annotation.WebServlet;
import jakarta.servlet.http.HttpServlet;
import jakarta.servlet.http.HttpServletRequest;
import jakarta.servlet.http.HttpServletResponse;
import jakarta.servlet.http.HttpSession;
import logger.MyLogger;

import java.io.IOException;
import java.util.logging.Level;

import dto.*;
import factory.*;
import service.*;
import other.*;

@WebServlet("/Insert")
public class InsertController extends HttpServlet {
	private static final long serialVersionUID = 1L;
       
    public InsertController() {
        super();
    }

	protected void doGet(HttpServletRequest request, HttpServletResponse response){
		String address = "index.jsp";
		String userType = request.getParameter("role_name");
		
		try {
			if ("admin".equals(userType)) {
				address = "/WEB-INF/view/view.jsp";
				AdminFactory aFactory = AdminFactory.getInstance();
				
				AdminDTO dto = aFactory.get(request);
				
				if (dto != null) {
					AdminService aService = new AdminService();
					
					boolean flag = aService.insert(dto);
					HttpSession session = request.getSession();
					session.setAttribute("message", Notification.getMessage(flag));
					session.setAttribute("alertType", Notification.getAlert(flag));
				}
			}else if ("counter".equals(userType)) {
				address = "/WEB-INF/view/view.jsp";
				CounterFactory cFactory = CounterFactory.getInstance();
				
				CounterDTO dto = cFactory.get(request);
				if (dto != null) {
					CounterService cService = new CounterService();
					
					boolean flag = cService.insert(dto);
					HttpSession session = request.getSession();
					session.setAttribute("message", Notification.getMessage(flag));
					session.setAttribute("alertType", Notification.getAlert(flag));
				}
			}else if ("dentist".equals(userType)) {
				address = "/WEB-INF/view/view.jsp";
				DentistFactory dFactory = DentistFactory.getInstance();
				
				DentistDTO dto = dFactory.get(request);
				
				if (dto != null) {
					DentistService dService = new DentistService();
					
					boolean flag = dService.insert(dto);
					HttpSession session = request.getSession();
					session.setAttribute("message", Notification.getMessage(flag));
					session.setAttribute("alertType", Notification.getAlert(flag));
				}
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
