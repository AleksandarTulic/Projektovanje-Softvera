package validation;

import dto.UserDTO;

public class ValidationLength implements IValidation{
	private static final int ID_LENGTH = 13;
	
	private static final int NAME_LENGTH_MAX = 100;
	private static final int NAME_LENGTH_MIN = 2;
	
	private static final int SURNAME_LENGTH_MAX = 100;
	private static final int SURNAME_LENGTH_MIN= 2;
	
	private static final int EMAIL_LENGTH_MAX = 200;
	private static final int EMAIL_LENGTH_MIN = 5;
	
	private static final int PHONE_LENGTH_MAX = 200;
	private static final int PHONE_LENGTH_MIN = 2;
	
	private static final int ADDRESS_LENGTH_MAX = 200;
	private static final int ADDRESS_LENGTH_MIN = 2;
	
	private static final int USERNAME_LENGTH_MAX = 100;
	private static final int USERNAME_LENGTH_MIN = 2;
	
	private static final int PASSWORD_LENGTH_MAX = 40;
	private static final int PASSWORD_LENGTH_MIN = 6;
	
	@Override
	public boolean check(UserDTO dto) {
		if (dto == null)
			return false;
		
		return checkLength(dto.getId(), ID_LENGTH, ID_LENGTH) 
				&& checkLength(dto.getName(), NAME_LENGTH_MAX, NAME_LENGTH_MIN) 
				&& checkLength(dto.getSurname(), SURNAME_LENGTH_MAX, SURNAME_LENGTH_MIN) 
				&& checkLength(dto.getEmail(), EMAIL_LENGTH_MAX, EMAIL_LENGTH_MIN)
				&& checkLength(dto.getPhone(), PHONE_LENGTH_MAX, PHONE_LENGTH_MIN) 
				&& checkLength(dto.getAddress(), ADDRESS_LENGTH_MAX, ADDRESS_LENGTH_MIN) 
				&& checkLength(dto.getUsername(), USERNAME_LENGTH_MAX, USERNAME_LENGTH_MIN)
				&& checkLength(dto.getPassword(), PASSWORD_LENGTH_MAX, PASSWORD_LENGTH_MIN);
	}

	private boolean checkLength(String value, int maxLength, int minLength) {
		if (value == null)
			return false;
		
		return value.length() >= minLength && value.length() <= maxLength; 
	}
}
