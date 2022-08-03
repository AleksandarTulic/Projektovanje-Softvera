package service;

import dto.*;
import dao.UserDAO;

public class UserService {
	private UserDAO dao = new UserDAO();
	private static UserService service = new UserService();
	
	private UserService() {
	}
	
	public boolean insert(UserDTO dto) {
		return dao.insert(dto);
	}
	
	public boolean update(UserDTO dto, String oldID) {
		return dao.update(dto, oldID);
	}
	
	public boolean delete(String id) {
		return dao.delete(id);
	}
	
	public static UserService getInstance() {
		return service;
	}
}
