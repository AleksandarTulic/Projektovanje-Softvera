package validation;

import java.util.regex.Pattern;

import dto.PatientDTO;

public class PatientValidation {
	private static final String REGEX_PATTERN_ID = "^[0-9]{13}$";
	private static final String REGEX_PATTERN_NAME = "^[a-zA-Z]{2,}[\\s]*[a-zA-Z]*$";
	private static final String REGEX_PATTERN_SURNAME = "^[a-zA-Z]{2,}$";
	private static final String REGEX_PATTERN_EMAIL = "^[a-zA-Z0-9_]+@[a-zA-Z0-9_]+\\.[a-zA-Z0-9_]{2,4}$|^null$";
	private static final String REGEX_PATTERN_PHONE = "^[0-9]{2,}$|^null$";
	private static final String REGEX_PATTERN_ADDRESS = "^[a-zA-Z]{2,}[0-9a-zA-Z\\s]*$|^null$";
	
	public boolean check(PatientDTO dto) {
		if (dto == null) 
			return false;

		return checkRegex(dto.getId(), REGEX_PATTERN_ID) 
				&& checkRegex(dto.getName(), REGEX_PATTERN_NAME) 
				&& checkRegex(dto.getSurname(), REGEX_PATTERN_SURNAME) 
				&& checkRegex(dto.getEmail(), REGEX_PATTERN_EMAIL) 
				&& checkRegex(dto.getPhone(), REGEX_PATTERN_PHONE) 
				&& checkRegex(dto.getAddress(), REGEX_PATTERN_ADDRESS);
	}
	
	private boolean checkRegex(String value, String pattern){
		if (value == null && !(REGEX_PATTERN_ADDRESS.equals(pattern) || REGEX_PATTERN_PHONE.equals(pattern) || REGEX_PATTERN_EMAIL.equals(pattern)))
			return false;
		if (value == null && (REGEX_PATTERN_ADDRESS.equals(pattern) || REGEX_PATTERN_PHONE.equals(pattern) || REGEX_PATTERN_EMAIL.equals(pattern)))
			return true;
		
		Pattern REGEX_PATTERN = Pattern.compile(pattern, Pattern.CASE_INSENSITIVE);
		//System.out.println(value + " " + pattern + " " + REGEX_PATTERN.matcher(value).find());
		return REGEX_PATTERN.matcher(value).find();
	}
}
