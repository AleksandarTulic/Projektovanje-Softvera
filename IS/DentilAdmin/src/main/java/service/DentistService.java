package service;

import dao.DentistDAO;
import dto.DentistDTO;
import dto.UserDTO;

public class DentistService extends PersonalService{
	private DentistDAO dao = new DentistDAO();
	
	public boolean insert(DentistDTO dto) {
		boolean flag1 = super.insert((UserDTO)dto);
		boolean flag2 = super.insert(dto);
		boolean flag3 = false;
		
		if (flag1 && flag2) {
			flag3 = dao.insert(dto);
		}
		
		return flag3;
	}
	
	public boolean update(DentistDTO dto, String oldID) {
		boolean flag1 = super.update(dto, oldID);
		boolean flag2 = super.update(dto);
		
		return flag1 && flag2;
	}
}
