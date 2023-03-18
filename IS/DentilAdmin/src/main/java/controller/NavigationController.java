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

	protected void doGet(HttpServletRequest request, HttpServletResponse response){
		String address = "index.jsp";
		String where = request.getParameter("what");
		
		try {
			if ("viewUsers".equals(where)) {
				address = "/WEB-INF/view/view.jsp";
			}else if ("schedule".equals(where)) {
				address = "/WEB-INF/schedule/schedule.jsp";
			}else if ("statistics".equals(where)) {
				address = "/WEB-INF/statistics/statistics.jsp";
			}else if ("recover".equals(where)) {
				address = "/WEB-INF/recover/recover.jsp";
			}else if ("help".equals(where)) {
				address = "/WEB-INF/help/help.jsp";
			}
			
			RequestDispatcher dispatcher = request.getRequestDispatcher(address);
			dispatcher.forward(request, response);
		}catch(Exception e) {
			MyLogger.logger.log(Level.SEVERE, e.getMessage());
		}
	}

	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException{
		doGet(request, response);
	}

}
