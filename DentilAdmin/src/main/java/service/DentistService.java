package service;

import dao.DentistDAO;
import dto.DentistDTO;

public class DentistService {
	private DentistDAO dao = new DentistDAO();
	private UserService service = UserService.getInstance();
	
	public boolean insert(DentistDTO dto) {
		boolean flag1 = service.insert(dto);
		boolean flag2 = false;
		
		if (flag1) {
			flag2 = dao.insert(dto);
		}
		
		return flag1 && flag2;
	}
	
	public boolean update(DentistDTO dto, String oldID) {
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
