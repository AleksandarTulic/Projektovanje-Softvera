package service;

import java.util.List;

import dao.PersonalDAO;
import dto.PairDTO;
import dto.PersonalDTO;
import dto.ScheduleDTO;
import dto.ShiftDTO;

public class PersonalService {
	private PersonalDAO dao = new PersonalDAO();
	
	public PersonalDTO select(String username) {
		return dao.select(username);
	}
	
	public PairDTO<List<ScheduleDTO>, List<ShiftDTO>> selectPersonalSchedule(String idPersonal, String orderBy,
			String orderByType, Long left, Long right){
		return dao.selectPersonalSchedule(idPersonal, orderBy, orderByType, left, right);
	}
	
	public Long selectNumberOfPersonalSchedule(String idPersonal) {
		return dao.selectNumberOfPersonalSchedule(idPersonal);
	}
}
