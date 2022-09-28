package factory;

import dto.AppointmentDTO;
import jakarta.servlet.http.HttpServletRequest;
import logger.MyLogger;
import validation.AppointmentValidation;

import java.sql.ResultSet;
import java.util.*;
import java.util.logging.Level;

public abstract class AFactory {
	private List<String> headers = Arrays.asList("idDentist", "startDate", "startTime", "idPatient", "howLong", "idPersonal");
	private List<AppointmentValidation> arrValidation = Arrays.asList(new AppointmentValidation());
	
	public abstract AppointmentDTO get(HttpServletRequest request);
	
	protected AppointmentDTO check(AppointmentDTO dto) {
		for (AppointmentValidation i : arrValidation) {
			if (!i.check(dto)) {
				return null;
			}
		}
		
		return dto;
	}
	
	public abstract AppointmentDTO get(ResultSet rs);
	
	protected List<String> getElements(HttpServletRequest request){
		List<String> res = new ArrayList<>();
		
		try {
			for (String i : headers) {
				res.add(request.getParameter(i));
			}
		}catch (Exception e) {
			MyLogger.logger.log(Level.SEVERE, e.getMessage());
		}
		
		return res;
	}
	
	protected List<String> getElements(ResultSet rs){
		List<String> res = new ArrayList<>();
		
		try {
			for (String i : headers) {
				res.add(rs.getString(i));
			}
		}catch (Exception e) {
			MyLogger.logger.log(Level.SEVERE, e.getMessage());
		}
		
		return res;
	}
}
