package service;

import dto.ScheduleDTO;
import dao.ConnectionPool;
import dao.ScheduleDAO;

public class ScheduleService {
	private ScheduleDAO dao = new ScheduleDAO();
	
	public boolean insert(ScheduleDTO dto) {
		return dao.insert(dto);
	}
	
	public boolean delete(ScheduleDTO dto) {
		return dao.delete(dto);
	}
	
	public Long selectNumberOfSchedules(){
		return dao.selectNumberOfSchedules(ConnectionPool.ACTIVE);
	}
}
