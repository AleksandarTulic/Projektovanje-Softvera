package factory;

import jakarta.servlet.http.HttpServletRequest;
import validation.*;

import java.sql.ResultSet;
import java.util.List;

import dto.*;

public class AdminFactory extends UserFactory{
	private static AdminFactory aFactory = new AdminFactory();
	
	private AdminFactory() {
		super.arrValidation.add(new ValidationLength());
		super.arrValidation.add(new ValidationRegex());
	}
	
	@Override
	public AdminDTO get(HttpServletRequest request) {
		List<String> arr = super.getElements(request);
		AdminDTO dto = new AdminDTO(arr.get(0), arr.get(1), arr.get(2), 
				arr.get(3), arr.get(4), arr.get(5), 
				arr.get(6), arr.get(7), arr.get(8), 
				arr.get(arr.size()-1));
		
		if (dto != null) {
			if (super.check(dto)) {
				return dto;
			}
		}
		
		return null;
	}
	
	public AdminDTO get(ResultSet rs) {
		List<String> arr = super.getElements(rs);
		AdminDTO dto = new AdminDTO(arr.get(0), arr.get(1), arr.get(2), 
				arr.get(3), arr.get(4), arr.get(5),
				arr.get(6), arr.get(7), arr.get(8), 
				arr.get(11)); //11 - secretKey
		
		return dto;
	}
	
	public static AdminFactory getInstance() {
		return aFactory;
	}
}
