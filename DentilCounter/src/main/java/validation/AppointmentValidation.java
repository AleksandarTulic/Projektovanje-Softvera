package validation;

import java.util.regex.Pattern;

import dto.AppointmentDTO;

public class AppointmentValidation {
	private static final String REGEX_PATTERN_START_DATE = "^[0-9]{4}-(0{1}[0-9]{1}|1{1}[0-2]{1})-[0-9]{2}$";
	private static final String REGEX_PATTERN_START_TIME = "^([0-1]{1}[0-9]{1}|2{1}[0-4]{1}):([0-5]{1}[0-9]{1}):([0-5]{1}[0-9]{1})$";
	private static final String REGEX_PATTERN_HOWLONG = "^[0-9]{1,}$";
	private static final String REGEX_PATTERN_ID = "[0-9]{13}";
	
	public boolean check(AppointmentDTO dto) {
		if (dto == null) 
			return false;
		
		
		return checkRegex(dto.getStartDate() + "", REGEX_PATTERN_START_DATE) 
				&& checkRegex(dto.getStartTime() + "", REGEX_PATTERN_START_TIME) 
				&& checkRegex(dto.getHowLong() + "", REGEX_PATTERN_HOWLONG) 
				&& checkRegex(dto.getIdDentist(), REGEX_PATTERN_ID)
				&& checkRegex(dto.getIdPersonal(), REGEX_PATTERN_ID)
				&& checkRegex(dto.getIdPatient(), REGEX_PATTERN_ID);
	}
	
	private boolean checkRegex(String value, String pattern){
		if (value == null)
			return false;
		
		Pattern REGEX_PATTERN = Pattern.compile(pattern, Pattern.CASE_INSENSITIVE);
		return REGEX_PATTERN.matcher(value).find();
	}
}
