package factory;

import dto.*;
import jakarta.servlet.http.HttpServletRequest;

public class AdminFactory extends UserFactory{
	@Override
	public UserDTO get(HttpServletRequest request) {
		String id = request.getParameter("id");
		String name = request.getParameter("name");
		String surname = request.getParameter("surname");
		String email = request.getParameter("email");
		String phone = request.getParameter("phone");
		String address = request.getParameter("address");
		String username = request.getParameter("username");
		String password = request.getParameter("password");
		String role_name = request.getParameter("role_name");
		
		return new AdminDTO();
	}
}
