package factory;

import java.sql.ResultSet;
import java.util.List;

import dto.*;
import jakarta.servlet.http.HttpServletRequest;
import validation.ValidationLength;
import validation.ValidationPersonal;
import validation.ValidationRegex;
import java.sql.Time;
import java.sql.Date;

public class DentistFactory extends UserFactory{
	private static DentistFactory dFactory = new DentistFactory();
	
	private DentistFactory() {
		super.arrValidation.add(new ValidationPersonal(new ValidationRegex()));
		super.arrValidation.add(new ValidationLength());
	}
	
	public DentistDTO get(HttpServletRequest request) {
		List<String> arr = super.getElements(request);
		DentistDTO dto = new DentistDTO(arr.get(0), arr.get(1),
				arr.get(2), arr.get(3), arr.get(4), 
				arr.get(5), arr.get(6), arr.get(7), 
				arr.get(8), arr.get(9), arr.get(10));
		
		if (dto != null) {
			if (super.check(dto)) {
				return dto;
			}
		}
		
		return null;
	}
	
	public DentistDTO get(ResultSet rs) {
		List<String> arr = super.getElements(rs);
		DentistDTO dto = null;
		if (arr.get(12) != null && arr.get(13) != null && arr.get(14) != null && arr.get(15) != null && arr.get(16) != null) {
			ShiftDTO shift = new ShiftDTO(Integer.valueOf(arr.get(12)), Time.valueOf(arr.get(13)), Time.valueOf(arr.get(14)));
			ScheduleDTO schedule = new ScheduleDTO(Date.valueOf(arr.get(15)), arr.get(16));
			dto = new DentistDTO(arr.get(0), arr.get(1),
					arr.get(2), arr.get(3), arr.get(4), 
					arr.get(5), arr.get(6), arr.get(7), 
					arr.get(8), arr.get(9), arr.get(10), shift, schedule);
		}else {
			dto = new DentistDTO(arr.get(0), arr.get(1),
					arr.get(2), arr.get(3), arr.get(4), 
					arr.get(5), arr.get(6), arr.get(7), 
					arr.get(8), arr.get(9), arr.get(10));
		}
		
		return dto;
	}
	
	public static DentistFactory getInstance() {
		return dFactory;
	}
}
