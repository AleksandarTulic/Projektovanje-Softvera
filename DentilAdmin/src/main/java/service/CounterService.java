package service;

import dao.CounterDAO;
import dto.CounterDTO;
import dao.PersonalDAO;

public class CounterService {
	private CounterDAO dao = new CounterDAO();
	private PersonalDAO personalDAO = new PersonalDAO();
	private UserService service = UserService.getInstance();
	
	public boolean insert(CounterDTO dto) {
		boolean flag1 = service.insert(dto);
		boolean flag2 = personalDAO.insert(dto);
		boolean flag3 = false;
		
		if (flag1 && flag2) {
			flag3 = dao.insert(dto);
		}
		
		return flag1 && flag2 && flag3;
	}
	
	public boolean update(CounterDTO dto, String oldID) {
		boolean flag1 = personalDAO.update(dto);
		boolean flag2 = service.update(dto, oldID);
		
		return flag1 && flag2;
	}
	
	public boolean delete(String id) {
		boolean flag1 = dao.delete(id);
		boolean flag2 = personalDAO.delete(id);
		boolean flag3 = false;
		
		if (flag1 && flag2) {
			flag3 = service.delete(id);
		}
		
		return flag1 && flag2 && flag3;
	}
}
