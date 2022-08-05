package factory;

import dto.PatientDTO;
import validation.PatientValidation;
import jakarta.servlet.http.HttpServletRequest;

import java.util.*;

public abstract class PFactory {
	private List<PatientValidation> arrValidation = Arrays.asList(new PatientValidation());
	
	public abstract PatientDTO get(HttpServletRequest request);
	
	protected PatientDTO check(PatientDTO dto) {
		for (PatientValidation i : arrValidation) {
			if (!i.check(dto)) {
				return null;
			}
		}
		
		return dto;
	}
}
