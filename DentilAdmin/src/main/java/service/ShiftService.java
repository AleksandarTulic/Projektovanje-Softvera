package service;

import java.util.*;
import dto.ShiftDTO;
import dao.ShiftDAO;

public class ShiftService {
	private ShiftDAO dao = new ShiftDAO();
	private ScheduleService scheduleService = new ScheduleService();
	
	public boolean insert(ShiftDTO dto) {
		return dto.getBegin().compareTo(dto.getEnd()) <= 0 ? dao.insert(dto) : false;
	}
	
	public boolean delete(Integer id) {
		scheduleService.deleteScheduleWithIdShift(id);
		boolean flag = dao.delete(id);
		
		return flag;
	}
	
	public List<ShiftDTO> select(){
		return dao.select();
	}
}
