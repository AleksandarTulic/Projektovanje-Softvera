package service;

import dto.PersonalDTO;
import java.util.*;

import dao.ConnectionPool;

public class PersonalService extends UserService{
	
	public boolean insert(PersonalDTO dto) {
		return super.personalDAO.insert(dto);
	}
	
	public boolean update(PersonalDTO dto) {
		return super.personalDAO.update(dto);
	}
	
	public List<PersonalDTO> select(String orderBy, String orderByType, Long left, Long right){
		return super.personalDAO.select(ConnectionPool.ACTIVE, orderBy, orderByType, left, right);
	}
	
	public PersonalDTO selectWithId(String id){
		return super.personalDAO.selectWithId(id);
	}
}
