package service;

import dao.CounterDAO;
import dto.CounterDTO;

public class CounterService extends UserService{
	private CounterDAO dao = new CounterDAO();
	private PersonalService personalService = new PersonalService();
	private ScheduleService scheduleService = new ScheduleService();
	private AppointmentService appointmentService = new AppointmentService();
	
	public boolean insert(CounterDTO dto) {
		boolean flag1 = super.insert(dto);
		boolean flag2 = personalService.insert(dto);
		boolean flag3 = false;
		
		if (flag1 && flag2) {
			flag3 = dao.insert(dto);
		}
		
		return flag3;
	}
	
	public boolean update(CounterDTO dto, String oldID) {
		boolean flag1 = super.update(dto, oldID);
		boolean flag2 = personalService.update(dto);
		
		return flag1 && flag2;
	}
	
	public boolean delete(String id) {
		//delete from Counter table
		dao.delete(id);
		//delete from Schedule table
		scheduleService.deleteScheduleWithIdPersonal(id);
		//delete from Appointment table
		appointmentService.deleteWithIdPersonal(id);
		//delete from Personal table
		personalService.delete(id);
		//delete from Working table
		boolean flag = super.delete(id);
		
		return flag;
	}
}
