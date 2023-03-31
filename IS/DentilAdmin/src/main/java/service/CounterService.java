package service;

import dao.CounterDAO;
import dto.CounterDTO;
import dto.UserDTO;

public class CounterService extends PersonalService{
	private CounterDAO dao = new CounterDAO();
	
	public boolean insert(CounterDTO dto) {
		boolean flag1 = super.insert((UserDTO)dto);
		boolean flag2 = super.insert(dto);
		boolean flag3 = false;
		
		if (flag1 && flag2) {
			flag3 = dao.insert(dto);
		}
		
		return flag3;
	}
	
	public boolean update(CounterDTO dto, String oldID) {
		boolean flag1 = super.update(dto, oldID);
		boolean flag2 = super.update(dto);
		
		return flag1 && flag2;
	}
}
