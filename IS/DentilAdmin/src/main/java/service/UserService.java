package service;

import dto.*;
import security.Crypt;

import java.util.List;

import dao.PersonalDAO;
import dao.UserDAO;

public class UserService {
	private Crypt crypt = new Crypt();
	private UserDAO dao = new UserDAO();
	private PersonalDAO personalDAO = new PersonalDAO();
	private static final Boolean ACTIVE = true;
	
	public UserService() {
	}
	
	public boolean insert(UserDTO dto) {
		dto.setPassword(crypt.sha256(dto.getPassword()));
		return dao.insert(dto);
	}
	
	public boolean update(UserDTO dto, String oldID) {
		dto.setPassword(crypt.sha256(dto.getPassword()));
		return dao.update(dto, oldID);
	}
	
	public boolean delete(String id) {
		personalDAO.delete(id);
		return dao.delete(id, !ACTIVE);
	}
	
	public List<UserDTO> getWorkers(String value, String orderBy, String orderByType, Long left, Long right) {
		return dao.getWorkers(value, orderBy, orderByType, left, right, ACTIVE);
	}
	
	public Long getNumberOfWorkers(String value) {
		return dao.getNumberOfWorkers(value, ACTIVE);
	}
	
	public boolean updateWorkerActive(String id) {
		return dao.updateWorkerActive(id, ACTIVE);
	}
}
