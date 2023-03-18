package controller;

import jakarta.servlet.RequestDispatcher;
import jakarta.servlet.ServletException;
import jakarta.servlet.annotation.WebServlet;
import jakarta.servlet.http.HttpServlet;
import jakarta.servlet.http.HttpServletRequest;
import jakarta.servlet.http.HttpServletResponse;
import jakarta.servlet.http.HttpSession;
import logger.MyLogger;
import service.AdminService;
import security.QR;
import java.io.IOException;
import java.util.logging.Level;

import dto.AdminDTO;

@WebServlet("/TokenController")
public class TokenController extends HttpServlet {
	private static final long serialVersionUID = 1L;
    
    public TokenController() {
        super();
    }

	protected void doGet(HttpServletRequest request, HttpServletResponse response){
		String address = "logout.jsp";

		try {
			if (request.getSession().getAttribute("aaaa") == null) {

				String username = request.getRemoteUser();
				String token = request.getParameter("tokenValue");
				
				if (token != null) {
					AdminService adminService = new AdminService();
					AdminDTO dto = adminService.selectAdminWithUsername(username);
					QR qr = new QR();

					try {
						if (qr.getTOTPCode(dto.getSecretKey()).equals(token)) {
							address = "index.jsp";
							HttpSession session = request.getSession(true);
							session.setAttribute("aaaa", dto);
							
							if (dto != null && !dto.getActive()) {
								address = "logout.jsp";
							}
						}
					}catch (Exception e) {
						MyLogger.logger.log(Level.SEVERE, e.getMessage());
					}
				}else {
					address = "/WEB-INF/tokenLogin.jsp";
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
