package controller;

import java.util.logging.Level;

import jakarta.servlet.FilterChain;
import jakarta.servlet.RequestDispatcher;
import jakarta.servlet.annotation.WebFilter;
import jakarta.servlet.http.HttpFilter;
import jakarta.servlet.http.HttpServletRequest;
import jakarta.servlet.http.HttpServletResponse;
import jakarta.servlet.http.HttpSession;
import logger.MyLogger;

@WebFilter("/*")
public class TokenFilter extends HttpFilter {
	private static final long serialVersionUID = 1L;
	private static final String ADDRESS = "/WEB-INF/tokenLogin.jsp";
	
	public TokenFilter() {
		super();
    }

	public void destroy() {
	}

	public void doFilter(HttpServletRequest request, HttpServletResponse response, FilterChain chain) {
		try {
			HttpSession session = request.getSession();
			
			String []sp = request.getRequestURI().split("/");
			//why use "aaaa" ? because userLogedIn didn't work
			if (session.getAttribute("aaaa") != null || (session.getAttribute("aaaa") == null &&
					(sp[2].equals("TokenController") || sp[2].equals("logout.jsp")))) {
				chain.doFilter(request, response);
			}else {
				RequestDispatcher dispatcher = request.getRequestDispatcher(ADDRESS);
				dispatcher.forward(request, response);
			}
		}catch (Exception e) {
			MyLogger.logger.log(Level.SEVERE, e.getMessage());
		}
	}
	
	public void init(FilterChain filterConfig) {
	}
}
