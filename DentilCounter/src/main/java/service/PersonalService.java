package service;

import dto.PersonalDTO;
import dto.ScheduleDTO;
import dto.ShiftDTO;
import dto.PairDTO;
import java.util.List;
import dao.PersonalDAO;

public class PersonalService {
	private PersonalDAO dao = new PersonalDAO();
	
	public PersonalDTO select(String username) {
		return dao.select(username);
	}
	
	public PairDTO<List<ScheduleDTO>, List<ShiftDTO>> selectWithIdPersonal(String idPersonal){
		return dao.selectWithIdPersonal(idPersonal);
	}
}
