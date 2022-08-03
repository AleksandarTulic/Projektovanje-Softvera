package service;

import dao.CounterDAO;
import dto.CounterDTO;

public class CounterService {
	private CounterDAO dao = new CounterDAO();
	private UserService service = UserService.getInstance();
	
	public boolean insert(CounterDTO dto) {
		boolean flag1 = service.insert(dto);
		boolean flag2 = false;
		
		if (flag1) {
			flag2 = dao.insert(dto);
		}
		
		return flag1 && flag2;
	}
	
	public boolean update(CounterDTO dto, String oldID) {
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
