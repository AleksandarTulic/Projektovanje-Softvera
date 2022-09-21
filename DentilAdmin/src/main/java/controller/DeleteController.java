package controller;

import jakarta.servlet.RequestDispatcher;
import jakarta.servlet.ServletException;
import jakarta.servlet.annotation.WebServlet;
import jakarta.servlet.http.HttpServlet;
import jakarta.servlet.http.HttpServletRequest;
import jakarta.servlet.http.HttpServletResponse;
import logger.MyLogger;

import java.io.IOException;
import java.util.logging.Level;

import dto.AdminDTO;
import service.*;
import other.*;

@WebServlet("/Delete")
public class DeleteController extends HttpServlet {
	private static final long serialVersionUID = 1L;
       
    public DeleteController() {
        super();
    }

	protected void doGet(HttpServletRequest request, HttpServletResponse response) {
		String address = "index.jsp";
		String id = request.getParameter("id");
		String role = request.getParameter("role_name");
		
		try {
			if (id != null && role != null) {
				if ("admin".equals(role)) {
					address = "/WEB-INF/view/view.jsp";
					AdminService aService = new AdminService();
					
					boolean flag = aService.delete(id);
					Notification.setMessage(request, flag);
					
					AdminDTO dto = (AdminDTO)request.getSession().getAttribute("aaaa");
					if (flag && id.equals(dto.getId())) {
						address = "logout.jsp";
					}
				}else if ("counter".equals(role)) {
					address = "/WEB-INF/view/view.jsp";
					CounterService cService = new CounterService();
					
					boolean flag = cService.delete(id);
					Notification.setMessage(request, flag);
				}else if ("dentist".equals(role)) {
					address = "/WEB-INF/view/view.jsp";
					DentistService dService = new DentistService();
					
					boolean flag = dService.delete(id);
					Notification.setMessage(request, flag);
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
