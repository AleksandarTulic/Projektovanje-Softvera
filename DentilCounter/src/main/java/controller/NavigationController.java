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

@WebServlet("/Navigation")
public class NavigationController extends HttpServlet {
	private static final long serialVersionUID = 1L;
      
    public NavigationController() {
        super();
    }

	protected void doGet(HttpServletRequest request, HttpServletResponse response) {
		String address = "index.jsp";
		String where = request.getParameter("what");
		
		try {
			if ("viewAppointments".equals(where)) {
				address = "/WEB-INF/appointment/appointment.jsp";
			}else if ("viewPatients".equals(where)) {
				address = "/WEB-INF/patient/patient.jsp";
			}else if ("view".equals(where)) {
				address = "/WEB-INF/view.jsp";
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
