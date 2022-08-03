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
import factory.UserFactory;
import service.*;

@WebServlet("/Operation")
public class Operation extends HttpServlet {
	private static final long serialVersionUID = 1L;
	private static UserFactory factory = UserFactory.getInstance();
	private static UserService service = UserService.getInstance();
       
    public Operation() {
        super();
    }

	protected void doGet(HttpServletRequest request, HttpServletResponse response) {
		String address = "";
		String where = request.getParameter("what");
		
		try {
			if ("insert".equals(where)) {
				address = "/WEB-INF/insert.jsp";
				
				if ("do".equals(request.getParameter("operation"))) {
					UserDTO dto = factory.get(request);
					String message = "";
					
					if (dto == null) {
						message = "Operation not possible.";
					}else {
						service.insert(dto);
						message = "Operation successful.";
					}
					
					HttpSession session = request.getSession();
					session.setAttribute("message", message);
				}
			}else if ("delete".equals(where) && request.getParameter("idOld") != null) {
				address = "index.jsp";
				String message = "";
				
				if (service.delete(request.getParameter("idOld"))) {
					message = "Operation successful.";
				}else {
					message = "Operation not possible.";
				}
				
				HttpSession session = request.getSession();
				session.setAttribute("message", message);
			}else if ("update".equals(where)) {
				address = "/WEB-INF/update.jsp";
				
				if ("do".equals(request.getParameter("operation"))) {
					UserDTO dto = factory.get(request);
					String message = "";
					
					if (dto == null || request.getParameter("idOld") == null) {
						message = "Operation not possible.";
					}else {
						service.update(dto, request.getParameter("idOld"));
						message = "Operation successful.";
					}
					
					HttpSession session = request.getSession();
					session.setAttribute("message", message);
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
