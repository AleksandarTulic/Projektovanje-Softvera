package validation;

import java.util.regex.Pattern;

import dto.UserDTO;
import enums.UserType;

public class ValidationRegex implements IValidation{
	private static final String REGEX_PATTERN_ID = "[0-9]{13}";
	private static final String REGEX_PATTERN_NAME = "[a-zA-Z]{2,}[\\s]*[a-zA-Z]*";
	private static final String REGEX_PATTERN_SURNAME = "[a-zA-Z]{2,}";
	private static final String REGEX_PATTERN_EMAIL = "^([a-zA-Z0-9_\\-\\.]+)@([a-zA-Z0-9_\\-\\.]+)\\.([a-zA-Z]{2,5})$";
	private static final String REGEX_PATTERN_PHONE = "[0-9]{2,}";
	private static final String REGEX_PATTERN_ADDRESS = "^[a-zA-Z]{2,}[0-9a-zA-Z\\s]*";
	private static final String REGEX_PATTERN_USERNAME = ".{2,}";
	private static final String REGEX_PATTERN_ROLE_NAME = "^" + UserType.admin + "|" + UserType.dentist + "|" + UserType.counter;
	
	public boolean check(UserDTO dto) {
		if (dto == null)
			return false;
		
		return checkRegex(dto.getId(), REGEX_PATTERN_ID) && checkRegex(dto.getName(), REGEX_PATTERN_NAME) 
				&& checkRegex(dto.getSurname(), REGEX_PATTERN_SURNAME) 
				&& checkRegex(dto.getEmail(), REGEX_PATTERN_EMAIL) 
				&& checkRegex(dto.getPhone(), REGEX_PATTERN_PHONE) 
				&& checkRegex(dto.getAddress(), REGEX_PATTERN_ADDRESS) 
				&& checkRegex(dto.getUsername(), REGEX_PATTERN_USERNAME)
				&& checkRegex(dto.getPassword(), REGEX_PATTERN_ROLE_NAME); 
	}
	
	private boolean checkRegex(String value, String pattern){
		Pattern REGEX_PATTERN = Pattern.compile(REGEX_PATTERN_ID, Pattern.CASE_INSENSITIVE);
		return REGEX_PATTERN.matcher(value).find();
	}
}
