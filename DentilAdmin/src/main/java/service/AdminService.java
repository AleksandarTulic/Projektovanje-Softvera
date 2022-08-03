package service;

import dao.AdminDAO;
import dto.AdminDTO;

public class AdminService {
	private AdminDAO dao = new AdminDAO();
	private UserService service = UserService.getInstance();
	
	public boolean insert(AdminDTO dto) {
		boolean flag1 = service.insert(dto);
		boolean flag2 = false;
		
		if (flag1) {
			flag2 = dao.insert(dto);
		}
		
		return flag1 && flag2;
	}
	
	public boolean update(AdminDTO dto, String oldID) {
		return service.update(dto, oldID);
	}
	
	public boolean delete(String id) {
		boolean flag1 = dao.delete(id);
		boolean flag2 = false;
		
		if (flag1) {
			flag2 = service.delete(id);
		}
		
		return flag1 && flag2;
	}
}
