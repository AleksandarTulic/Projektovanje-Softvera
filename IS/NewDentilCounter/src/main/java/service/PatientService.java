package service;

import java.util.List;

import dao.PatientDAO;
import dto.PatientDTO;

public class PatientService {
	private PatientDAO dao = new PatientDAO();
	private static final Boolean active = true;
	
	public Long getNumberOfPatients(String value) {
		return dao.getNumberOfPatients(value, active);
	}
	
	public List<PatientDTO> getPatients(String value, String orderBy, String orderByType, Long left, Long right){
		return dao.getPatients(value, orderBy, orderByType, left, right, active);
	}
	
	public boolean insert(PatientDTO dto) {
		return dao.insert(dto);
	}
	
	public boolean update(PatientDTO dto, String oldID) {
		return dao.update(dto, oldID);
	}
	
	public boolean updateSetActive(String id) {
		return dao.updateSetActive(id, active);
	}
	
	public boolean delete(String id) {
		return dao.delete(id);
	}
	
	public PatientDTO selectWithIdPatient(String id) {
		return dao.selectWithIdPatient(id);
	}
}
