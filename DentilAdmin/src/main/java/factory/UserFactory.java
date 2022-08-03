package factory;

import java.util.*;

import dto.*;
import jakarta.servlet.http.HttpServletRequest;
import validation.*;

public class UserFactory {
	protected List<IValidation> arrValidation = Arrays.asList(new ValidationLength(), new ValidationRegex());

	private static UserFactory uFactory = new UserFactory();
	
	private UserFactory() {
	}
	
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
		
		UserDTO dto = null;
		if ("admin".equals(role_name)) {
			dto = new AdminDTO(id, name, surname, address, phone, email, username, password, role_name);
		}else if ("dentist".equals(role_name)) {
			dto = new DentistDTO(id, name, surname, address, phone, email, username, password, role_name);
		}else if ("counter".equals(role_name)){
			dto = new CounterDTO(id, name, surname, address, phone, email, username, password, role_name);
		}

		if (check(dto)) {
			return dto;
		}
		
		return null;
	}
	
	protected boolean check(UserDTO dto) {
		for (IValidation i : arrValidation) {
			if (!i.check(dto)) {
				return false;
			}
		}
		
		return true;
	}
	
	public static UserFactory getInstance() {
		return uFactory;
	}
}
