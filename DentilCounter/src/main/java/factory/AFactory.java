package factory;

import dto.AppointmentDTO;
import jakarta.servlet.http.HttpServletRequest;
import validation.AppointmentValidation;

import java.util.*;

public abstract class AFactory {
	private List<AppointmentValidation> arrValidation = new ArrayList<AppointmentValidation>();
	
	public abstract AppointmentDTO get(HttpServletRequest request);
	
	protected AppointmentDTO check(AppointmentDTO dto) {
		for (AppointmentValidation i : arrValidation) {
			if (!i.check(dto)) {
				return null;
			}
		}
		
		return dto;
	}
}
