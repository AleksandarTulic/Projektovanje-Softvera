package validation;

import java.time.LocalDateTime;
import java.util.List;
import java.util.regex.Pattern;

import dto.AppointmentDTO;
import dto.DentistDTO;
import service.AppointmentService;
import service.DentistService;

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
				&& checkRegex(dto.getIdPatient(), REGEX_PATTERN_ID)
				&& checkWorkingTime(dto)
				&& checkIfAvailable(dto);
	}
	
	private boolean checkRegex(String value, String pattern){
		if (value == null)
			return false;
		
		Pattern REGEX_PATTERN = Pattern.compile(pattern, Pattern.CASE_INSENSITIVE);
		return REGEX_PATTERN.matcher(value).find();
	}
	
	@SuppressWarnings("deprecation")
	private boolean checkIfAvailable(AppointmentDTO dto) {
		AppointmentService aService = new AppointmentService();
		List<AppointmentDTO> arrDTO = aService.selectSameDayAndDentist(dto.getStartDate(), dto.getIdDentist());
		
		LocalDateTime ldt1 = LocalDateTime.of(dto.getStartDate().getYear(),
				  dto.getStartDate().getMonth() + 1,
				  dto.getStartDate().getDate(),
				  dto.getStartTime().getHours(),
				  dto.getStartTime().getMinutes(),
				  dto.getStartTime().getSeconds());
		LocalDateTime ldt2 = ldt1.plusMinutes(dto.getHowLong());

		for (AppointmentDTO i : arrDTO) {
			LocalDateTime ldt3 = LocalDateTime.of(i.getStartDate().getYear(),
					  i.getStartDate().getMonth() + 1,
					  i.getStartDate().getDate(),
					  i.getStartTime().getHours(),
					  i.getStartTime().getMinutes(),
					  i.getStartTime().getSeconds());
			LocalDateTime ldt4 = ldt3.plusMinutes(i.getHowLong());
			
			if (!(ldt1.compareTo(ldt3) < 0 || ldt1.compareTo(ldt4) > 0))
				return false;
			
			if (!(ldt2.compareTo(ldt3) < 0 || ldt2.compareTo(ldt4) > 0))
				return false;
		}
		
		return true;
	}
	
	@SuppressWarnings("deprecation")
	private boolean checkWorkingTime(AppointmentDTO dto) {
		DentistService dService = new DentistService();
		DentistDTO dentistDTO = dService.selectWithDateWorkingAndDentist(dto.getStartDate() + "", dto.getIdDentist());
		
		LocalDateTime ldt1 = LocalDateTime.of(dentistDTO.getSchedule().getDate().getYear(), 
											  dentistDTO.getSchedule().getDate().getMonth() + 1, 
											  dentistDTO.getSchedule().getDate().getDate(), 
											  dentistDTO.getShift().getBegin().getHours(), 
											  dentistDTO.getShift().getBegin().getMinutes(), 
											  dentistDTO.getShift().getBegin().getSeconds());
		LocalDateTime ldt2 = LocalDateTime.of(dentistDTO.getSchedule().getDate().getYear(), 
											  dentistDTO.getSchedule().getDate().getMonth() + 1, 
											  dentistDTO.getSchedule().getDate().getDate(), 
											  dentistDTO.getShift().getEnd().getHours(), 
											  dentistDTO.getShift().getEnd().getMinutes(), 
											  dentistDTO.getShift().getEnd().getSeconds());
		LocalDateTime ldt3 = LocalDateTime.of(dto.getStartDate().getYear(),
											  dto.getStartDate().getMonth() + 1,
											  dto.getStartDate().getDate(),
											  dto.getStartTime().getHours(),
											  dto.getStartTime().getMinutes(),
											  dto.getStartTime().getSeconds());
		LocalDateTime ldt4 = ldt3.plusMinutes(dto.getHowLong());
		
		return ldt3.compareTo(ldt1) >= 0 && ldt3.compareTo(ldt2) <= 0 && ldt4.compareTo(ldt1) >= 0 && ldt4.compareTo(ldt2) <= 0;
	}
}
