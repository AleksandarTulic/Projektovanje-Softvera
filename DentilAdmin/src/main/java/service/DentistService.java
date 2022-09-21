package service;

import dao.DentistDAO;
import dto.DentistDTO;

public class DentistService extends UserService{
	private DentistDAO dao = new DentistDAO();
	private PersonalService personalService = new PersonalService();
	private LastSeenService lastSeenService = new LastSeenService();
	private AppointmentService appointmentService = new AppointmentService();
	private ScheduleService scheduleService = new ScheduleService();
	private VisitTreatmentService visitTreatmentService = new VisitTreatmentService();
	private ProblemService problemService = new ProblemService();
	private VisitService visitService = new VisitService();
	
	public boolean insert(DentistDTO dto) {
		boolean flag1 = super.insert(dto);
		boolean flag2 = personalService.insert(dto);
		boolean flag3 = false;
		
		if (flag1 && flag2) {
			flag3 = dao.insert(dto);
		}
		
		return flag3;
	}
	
	public boolean update(DentistDTO dto, String oldID) {
		boolean flag1 = super.update(dto, oldID);
		boolean flag2 = personalService.update(dto);
		
		return flag1 && flag2;
	}
	
	public boolean delete(String id) {
		lastSeenService.deleteWithIdDentist(id);
		appointmentService.deleteWithIdPersonal(id);
		scheduleService.deleteScheduleWithIdPersonal(id);
		visitTreatmentService.deleteWithIdDentist(id);
		problemService.deleteProblemWithIdDentist(id);
		visitService.deleteVisitWithIdDentist(id);
		dao.delete(id);
		personalService.delete(id);
		boolean flag = super.delete(id);
		
		return flag;
	}
}
