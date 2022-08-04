package factory;

import dto.*;
import jakarta.servlet.http.HttpServletRequest;
import validation.*;

import java.util.*;

public class CounterFactory extends UserFactory{
	private static CounterFactory cFactory = new CounterFactory();
	
	private CounterFactory() {
		super.arrValidation.add(new ValidationPersonal(new ValidationRegex()));
		super.arrValidation.add(new ValidationLength());
	}
	
	public UserDTO get(HttpServletRequest request) {
		List<String> arr = super.getElements(request);
		CounterDTO dto = new CounterDTO(arr.get(0), arr.get(1),
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
	
	public static CounterFactory getInstance() {
		return cFactory;
	}
}
