package service;

import dto.PatientDTO;
import dao.PatientDAO;
import java.util.*;

public class PatientService {
	private PatientDAO dao = new PatientDAO();
	
	public boolean insert(PatientDTO dto) {
		return dao.insert(dto);
	}
	
	public boolean update(PatientDTO dto, String oldID) {
		return dao.update(dto, oldID);
	}
	
	public boolean delete(String ID) {
		ProblemService pService = new ProblemService();
		LastSeenService lsService = new LastSeenService();
		VisitTreatmentService vtService = new VisitTreatmentService();
		VisitService vService = new VisitService();
		AppointmentService aService = new AppointmentService();

		pService.deleteProblemWithIdDentist(ID);
		lsService.deleteWithIdDentist(ID);
		vtService.deleteWithIdDentist(ID);
		vService.deleteVisitWithIdDentist(ID);
		aService.deleteWithIdPatient(ID);

		return dao.delete(ID);
	}
	
	public List<PatientDTO> select(){
		return dao.select();
	}
	
	public PatientDTO selectWithIdPatient(String id) {
		return dao.selectWithIdPatient(id);
	}
}
