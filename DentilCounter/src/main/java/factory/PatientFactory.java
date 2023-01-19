package factory;

import dto.PatientDTO;
import jakarta.servlet.http.HttpServletRequest;
import logger.MyLogger;
import validation.PatientValidation;

import java.sql.ResultSet;
import java.util.*;
import java.util.logging.Level;

public class PatientFactory extends UserFactory{
	private static PatientFactory factory = new PatientFactory();
	private List<PatientValidation> arrValidation = Arrays.asList(new PatientValidation());
	
	private PatientFactory() {
	}
	
	protected PatientDTO check(PatientDTO dto) {
		for (PatientValidation i : arrValidation) {
			if (!i.check(dto)) {
				return null;
			}
		}
		
		return dto;
	}
	
	/*
	public PatientDTO get(HttpServletRequest request) {
		List<String> arr = super.getElements(request);
		if (arr.size() == 6) {
			try {
				String id = arr.get(0);
				String name = arr.get(1);
				String surname = arr.get(2);
				String email = arr.get(3);
				String phone = arr.get(4);
				String address = arr.get(5);
			
				if ("".equals(email)) 
					email = null;
				
				if ("".equals(phone)) 
					phone = null;
				
				if ("".equals(address)) 
					address = null;
				
				PatientDTO dto = new PatientDTO(id, name, surname, address, phone, email);
				
				return super.check(dto);
			}catch (Exception e) {
				MyLogger.logger.log(Level.SEVERE, e.getMessage());
			}
		}

		return null;
	}
	
	public PatientDTO get(ResultSet rs) {
		List<String> arr = super.getElements(rs);
		
		if (arr.size() == 6) {
			try {
				return new PatientDTO(arr.get(0), arr.get(1), arr.get(2), arr.get(3), arr.get(4), arr.get(5));
			}catch (Exception e) {
				MyLogger.logger.log(Level.SEVERE, e.getMessage());
			}
		}
		
		return null;
	}
	
	*/
	
	public static PatientFactory getInstance() {
		return factory;
	}

	@Override
	public PatientDTO get(HttpServletRequest request) {
		List<String> arr = super.getElements(request);
		if (arr.size() >= 6) {
			try {
				String id = arr.get(0);
				String name = arr.get(1);
				String surname = arr.get(2);
				String email = arr.get(3);
				String phone = arr.get(4);
				String address = arr.get(5);
			
				if ("".equals(email)) 
					email = null;
				
				if ("".equals(phone)) 
					phone = null;
				
				if ("".equals(address)) 
					address = null;
				
				PatientDTO dto = new PatientDTO(id, name, surname, email, phone, address);
				//System.out.println(dto);
				return check(dto);
			}catch (Exception e) {
				MyLogger.logger.log(Level.SEVERE, e.getMessage());
			}
		}

		return null;
	}
	
	@Override
	public PatientDTO get(ResultSet rs) {
		List<String> arr = super.getElements(rs);

		if (arr.size() >= 6) {
			try {
				return new PatientDTO(arr.get(0), arr.get(1), arr.get(2), arr.get(3), arr.get(4), arr.get(5));
			}catch (Exception e) {
				MyLogger.logger.log(Level.SEVERE, e.getMessage());
			}
		}
		
		return null;
	}
}
