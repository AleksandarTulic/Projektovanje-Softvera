package controller;

import jakarta.servlet.RequestDispatcher;
import jakarta.servlet.ServletException;
import jakarta.servlet.annotation.WebServlet;
import jakarta.servlet.http.HttpServlet;
import jakarta.servlet.http.HttpServletRequest;
import jakarta.servlet.http.HttpServletResponse;
import jakarta.servlet.http.HttpSession;
import logger.MyLogger;

import java.io.File;
import java.io.IOException;
import java.util.logging.Level;
import dto.*;
import factory.*;
import service.*;

@WebServlet("/Operation")
public class Operation extends HttpServlet {
	private static final long serialVersionUID = 1L;
	private static AdminService adminService = new AdminService();
	private static EmailService email = new EmailService();
	private static DentistService dentistService = new DentistService();
	private static CounterService counterService = new CounterService();
	private static AdminFactory aFactory = AdminFactory.getInstance();
	private static DentistFactory dFactory = DentistFactory.getInstance();
	private static CounterFactory cFactory = CounterFactory.getInstance();
       
    public Operation() {
        super();
    }

	protected void doGet(HttpServletRequest request, HttpServletResponse response) {
		String address = "";
		String message = "";
		String where = request.getParameter("what");
		
		try {
			if ("insert".equals(where)) {
				address = "/WEB-INF/insert.jsp";
				
				if ("do".equals(request.getParameter("operation"))) {
					
					if ("admin".equals(request.getParameter("role_name"))) {
						AdminDTO dto = (AdminDTO) aFactory.get(request);
						
						if (dto == null) {
							message = "Operation not possible.";
						}else {
							boolean flag = adminService.insert(dto);
							
							if (flag) {
								message = "Operation not possible.";
							}else {
								message = "Operation successful.";
							}
						}
					}else if ("dentist".equals(request.getParameter("role_name"))) {
						DentistDTO dto = (DentistDTO) dFactory.get(request);
						
						if (dto == null) {
							message = "Operation not possible.";
						}else {
							boolean flag = dentistService.insert(dto);
							
							if (flag) {
								message = "Operation not possible.";
							}else {
								message = "Operation successful.";
							}
						}
					}else if ("counter".equals(request.getParameter("role_name"))) {
						CounterDTO dto = (CounterDTO) cFactory.get(request);
						
						if (dto == null) {
							message = "Operation not possible.";
						}else {
							boolean flag = counterService.insert(dto);
							
							if (flag) {
								message = "Operation not possible.";
							}else {
								message = "Operation successful.";
							}
						}
					}
				}
			}else if ("delete".equals(where) && request.getParameter("idOld") != null) {
				address = "index.jsp";
				
				counterService.delete("9999999999999");
			}else if ("update".equals(where)) {
				address = "/WEB-INF/update.jsp";
				if ("do".equals(request.getParameter("operation"))) {
					CounterDTO dto = (CounterDTO) cFactory.get(request);
				
					counterService.update(dto, "9999999999999");
				}
			}else if ("qr".equals(where)) {
				System.out.println("EMAIL: " + email.send("", System.getProperty("catalina.home") 
						+ File.separator + "Dentil" + File.separator + "qr" + File.separator + "slika.png"));
			}
			
			HttpSession session = request.getSession();
			session.setAttribute("message", message);
			
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
