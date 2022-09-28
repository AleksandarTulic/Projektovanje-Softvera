package filter;

import dto.PersonalDTO;
import jakarta.servlet.FilterChain;
import jakarta.servlet.annotation.WebFilter;
import jakarta.servlet.http.HttpFilter;
import jakarta.servlet.http.HttpServletRequest;
import jakarta.servlet.http.HttpServletResponse;
import jakarta.servlet.http.HttpSession;
import service.PersonalService;

@WebFilter("/*")
public class LoginFilter extends HttpFilter {
	private static final long serialVersionUID = 1L;

	public LoginFilter() {
        super();
    }

	public void destroy() {
	}

	public void doFilter(HttpServletRequest request, HttpServletResponse response, FilterChain chain){
		try {
			HttpSession session = request.getSession();
			PersonalDTO dto = (PersonalDTO)session.getAttribute("aaaa");
			
			if (dto == null && request.getRemoteUser() != null) {
				PersonalService pService = new PersonalService();
				dto = pService.select(request.getRemoteUser());
				session.setAttribute("aaaa", dto);
			}
			
			chain.doFilter(request, response);
		}catch (Exception e) {
			e.printStackTrace();
		}
	}

	public void init(FilterChain filterConfig) {
	}

}
