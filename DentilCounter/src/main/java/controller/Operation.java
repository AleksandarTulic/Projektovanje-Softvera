package controller;

import java.io.IOException;
import java.sql.Date;
import java.sql.Time;

import jakarta.servlet.RequestDispatcher;
import jakarta.servlet.ServletException;
import jakarta.servlet.annotation.WebServlet;
import jakarta.servlet.http.HttpServlet;
import jakarta.servlet.http.HttpServletRequest;
import jakarta.servlet.http.HttpServletResponse;
import jakarta.servlet.http.HttpSession;
import service.*;
import factory.*;
import dto.*;

@WebServlet("/Operation")
public class Operation extends HttpServlet {
	private static final long serialVersionUID = 1L;
	private static AppointmentService aService = new AppointmentService();
	private static PatientService pService = new PatientService();
	private static AppointmentFactory aFactory = AppointmentFactory.getInstance();
	private static PatientFactory pFactory = PatientFactory.getInstance();
	
    public Operation() {
        super();
    }

	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		String address = "";
		String message = "";
		String where = request.getParameter("what");
		
		if ("insertPatient".equals(where)) {
			address = "/WEB-INF/insertPatient.jsp";
			
			if ("do".equals(request.getParameter("operation"))) {
				PatientDTO dto = pFactory.get(request);
				
				if (dto == null) {
					message = "Operation not possible.";
				}else {
					boolean flag = pService.insert(dto);
					
					if (flag) {
						message = "Operation not possible.";
					}else {
						message = "Operation successful.";
					}
				}
			}
		}else if ("insertAppointment".equals(where)) {
			address = "/WEB-INF/insertAppointment.jsp";

			if ("do".equals(request.getParameter("operation"))) {
				AppointmentDTO dto = aFactory.get(request);
				
				if (dto == null) {
					message = "Operation not possible.";
				}else {
					boolean flag = aService.insert(dto);
					
					if (flag) {
						message = "Operation not possible.";
					}else {
						message = "Operation successful.";
					}
				}
			}
		}else if ("updatePatient".equals(where)) {
			address = "/WEB-INF/updatePatient.jsp";

			if ("do".equals(request.getParameter("operation")) && request.getParameter("oldID") != null) {
				PatientDTO dto = pFactory.get(request);
				
				if (dto == null) {
					message = "Operation not possible.";
				}else {
					boolean flag = pService.update(dto, request.getParameter("oldID"));
					
					if (flag) {
						message = "Operation not possible.";
					}else {
						message = "Operation successful.";
					}
				}
			}
		}else if ("updateAppointment".equals(where)) {
			address = "/WEB-INF/updateAppointment.jsp";
			
			if ("do".equals(request.getParameter("operation"))) {
				AppointmentDTO dto = aFactory.get(request);
				
				if (dto == null) {
					message = "Operation not possible.";
				}else {
					boolean flag = aService.update(dto, new AppointmentDTO("3333333333333", Date.valueOf("2022-08-31"), 
							Time.valueOf("14:15:00"), null, null, null));
					
					if (flag) {
						message = "Operation not possible.";
					}else {
						message = "Operation successful.";
					}
				}
			}
		}
		
		HttpSession session = request.getSession();
		session.setAttribute("message", message);
		
		RequestDispatcher dispatcher = request.getRequestDispatcher(address);
		dispatcher.forward(request, response);
	}

	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		doGet(request, response);
	}

}
