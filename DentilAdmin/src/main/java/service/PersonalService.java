package service;

import dao.PersonalDAO;
import dto.PersonalDTO;
import java.util.*;

public class PersonalService {
	private PersonalDAO dao = new PersonalDAO();
	
	public boolean insert(PersonalDTO dto) {
		return dao.insert(dto);
	}
	
	public boolean update(PersonalDTO dto) {
		return dao.update(dto);
	}
	
	public boolean delete(String id) {
		return dao.delete(id);
	}
	
	public List<PersonalDTO> select(){
		return dao.select();
	}
	
	public List<PersonalDTO> selectWithoutSchedule(){
		return dao.selectWithoutSchedule();
	}
}
