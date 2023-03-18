package service;

import dao.PersonalDAO;
import dto.PersonalDTO;
import java.util.*;

public class PersonalService {
	private PersonalDAO dao = new PersonalDAO();
	private static final Boolean ACTIVE = true;
	
	public boolean insert(PersonalDTO dto) {
		return dao.insert(dto);
	}
	
	public boolean update(PersonalDTO dto) {
		return dao.update(dto);
	}
	
	public List<PersonalDTO> select(String orderBy, String orderByType, Long left, Long right){
		return dao.select(ACTIVE, orderBy, orderByType, left, right);
	}
	
	public PersonalDTO selectWithId(String id){
		return dao.selectWithId(id);
	}
}
