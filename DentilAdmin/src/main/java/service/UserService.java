package service;

import dto.*;
import security.Crypt;
import dao.UserDAO;

public class UserService {
	private Crypt crypt = new Crypt();
	private UserDAO dao = new UserDAO();
	private static UserService service = new UserService();
	
	private UserService() {
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
		return dao.delete(id);
	}
	
	public static UserService getInstance() {
		return service;
	}
}
