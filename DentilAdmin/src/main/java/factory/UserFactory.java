package factory;

import java.util.*;

import dto.*;
import jakarta.servlet.http.HttpServletRequest;
import validation.*;

public abstract class UserFactory {
	protected List<IValidation> arrValidation = new ArrayList<IValidation>();
	//Arrays.asList(new ValidationLength(), new ValidationRegex());
	
	public abstract UserDTO get(HttpServletRequest request);
	
	protected boolean check(UserDTO dto) {
		for (IValidation i : arrValidation) {
			if (!i.check(dto)) {
				return false;
			}
		}
		
		return true;
	}
	
	protected List<String> getElements(HttpServletRequest request){
		List<String> arr = new ArrayList<String>();
		arr.add(request.getParameter("id"));
		arr.add(request.getParameter("name"));
		arr.add(request.getParameter("surname"));
		arr.add(request.getParameter("address"));
		arr.add(request.getParameter("phone"));
		arr.add(request.getParameter("email"));
		arr.add(request.getParameter("username"));
		arr.add(request.getParameter("password"));
		arr.add(request.getParameter("role_name"));
		arr.add(request.getParameter("jobStart"));
		arr.add(request.getParameter("jobEnd"));
		arr.add(request.getParameter("secretKey"));
		
		return arr;
	}
}
