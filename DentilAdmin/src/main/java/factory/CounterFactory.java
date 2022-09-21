package factory;

import dto.*;
import jakarta.servlet.http.HttpServletRequest;
import validation.*;

import java.sql.Date;
import java.sql.ResultSet;
import java.sql.Time;
import java.util.*;

public class CounterFactory extends UserFactory{
	private static CounterFactory cFactory = new CounterFactory();
	
	private CounterFactory() {
		super.arrValidation.add(new ValidationPersonal(new ValidationRegex()));
		super.arrValidation.add(new ValidationLength());
	}
	
	public CounterDTO get(HttpServletRequest request) {
		List<String> arr = super.getElements(request);
		CounterDTO dto = new CounterDTO(arr.get(0), arr.get(1),
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
	
	public CounterDTO get(ResultSet rs) {
		List<String> arr = super.getElements(rs);
		CounterDTO dto = null;
		if (arr.get(12) != null && arr.get(13) != null && arr.get(14) != null && arr.get(15) != null && arr.get(16) != null) {
			ShiftDTO shift = new ShiftDTO(Integer.valueOf(arr.get(12)), Time.valueOf(arr.get(13)), Time.valueOf(arr.get(14)));
			ScheduleDTO schedule = new ScheduleDTO(Date.valueOf(arr.get(15)), arr.get(16));
			dto = new CounterDTO(arr.get(0), arr.get(1),
					arr.get(2), arr.get(3), arr.get(4), 
					arr.get(5), arr.get(6), arr.get(7), 
					arr.get(8), arr.get(9), arr.get(10), shift, schedule);
		}else {
			dto = new CounterDTO(arr.get(0), arr.get(1),
					arr.get(2), arr.get(3), arr.get(4), 
					arr.get(5), arr.get(6), arr.get(7), 
					arr.get(8), arr.get(9), arr.get(10));
		}

		return dto;
	}
	
	public static CounterFactory getInstance() {
		return cFactory;
	}
}
