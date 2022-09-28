package factory;

import dto.*;
import jakarta.servlet.http.HttpServletRequest;

import java.sql.ResultSet;
import java.util.*;

public class CounterFactory extends UserFactory{
	private static CounterFactory cFactory = new CounterFactory();
	
	private CounterFactory() {
	}
	
	public static CounterFactory getInstance() {
		return cFactory;
	}

	@Override
	public UserDTO get(HttpServletRequest request) {
		return null;
	}
	
	@Override
	public CounterDTO get(ResultSet rs) {
		List<String> arr = super.getElements(rs);
		CounterDTO dto = null;

		dto = new CounterDTO(arr.get(0), arr.get(1),
				arr.get(2), arr.get(3), arr.get(4), 
				arr.get(5), arr.get(6), arr.get(7), 
				arr.get(8), arr.get(9), arr.get(10));
		
		return dto;
	}
}
