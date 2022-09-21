package service;

import dto.ScheduleDTO;
import dao.ScheduleDAO;

public class ScheduleService {
	private ScheduleDAO dao = new ScheduleDAO();
	
	public boolean insert(ScheduleDTO dto) {
		return dao.insert(dto);
	}
	
	public boolean delete(ScheduleDTO dto) {
		return dao.delete(dto);
	}
	
	public boolean deleteScheduleWithIdShift(Integer id) {
		return dao.deleteScheduleWithIdShift(id);	
	}
	
	public boolean deleteScheduleWithIdPersonal(String id) {
		return dao.deleteScheduleWithIdPersonal(id);
	}
	
	public boolean deleteScheduleWithIdAdmin(String id) {
		return dao.deleteScheduleWithIdAdmin(id);
	}
}
