package validation;

import java.util.regex.Pattern;

import dto.*;

public class ValidationPersonal extends ValidationPersonalDecorator{
	private static final String REGEX_PATTERN_DATE_JOBSTART = "^[0-9]{4}-[0-9]{2}-[0-9]{2}$";
	private static final String REGEX_PATTERN_DATE_JOBEND = "^[0-9]{4}-[0-9]{2}-[0-9]{2}$|^null$";
	
	public ValidationPersonal(IValidation iValidation) {
		super(iValidation);
	}
	
	@Override
	public boolean check(UserDTO dto) {
		boolean flag1 = super.check(dto);
		
		if (flag1) {
			PersonalDTO personalDTO = null;
			
			try {
				personalDTO = (PersonalDTO)dto;
				
				return check(personalDTO);
			}catch (Exception e) {
				personalDTO = null;
			}
			
			return personalDTO != null;
		}
		
		return false;
	}
	
	private boolean check(PersonalDTO personalDTO) {
		String jobStart = personalDTO.getJobStart() + "";
		String jobEnd = personalDTO.getJobEnd() + "";
		
		Pattern REGEX_PATTERN_1 = Pattern.compile(REGEX_PATTERN_DATE_JOBSTART, Pattern.CASE_INSENSITIVE);
		Pattern REGEX_PATTERN_2 = Pattern.compile(REGEX_PATTERN_DATE_JOBEND, Pattern.CASE_INSENSITIVE);
		return REGEX_PATTERN_1.matcher(jobStart).find() &&
			   REGEX_PATTERN_2.matcher(jobEnd).find();
	}
}
