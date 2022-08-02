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

@WebServlet("/Operation")
public class Operation extends HttpServlet {
	private static final long serialVersionUID = 1L;
       
    public Operation() {
        super();
    }

	protected void doGet(HttpServletRequest request, HttpServletResponse response) {
		String address = "";
		String where = request.getParameter("what");
		
		try {
			if ("insert".equals(where)) {
				address = "/WEB-INF/insert.jsp";
				
				String id = request.getParameter(where);
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
