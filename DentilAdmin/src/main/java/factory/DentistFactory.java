package factory;

import java.util.List;

import dto.*;
import jakarta.servlet.http.HttpServletRequest;
import validation.ValidationLength;
import validation.ValidationPersonal;
import validation.ValidationRegex;

public class DentistFactory extends UserFactory{
	private static DentistFactory dFactory = new DentistFactory();
	
	private DentistFactory() {
		super.arrValidation.add(new ValidationPersonal(new ValidationRegex()));
		super.arrValidation.add(new ValidationLength());
	}
	
	public UserDTO get(HttpServletRequest request) {
		List<String> arr = super.getElements(request);
		DentistDTO dto = new DentistDTO(arr.get(0), arr.get(1),
				arr.get(2), arr.get(3), arr.get(4), 
				arr.get(5), arr.get(6), arr.get(7), 
				arr.get(8), arr.get(9), arr.get(10));
		
		if (dto != null) {
			if (super.check(dto)) {
				return dto;
			}
		}
		
		return null;
	}
	
	public static DentistFactory getInstance() {
		return dFactory;
	}
}
