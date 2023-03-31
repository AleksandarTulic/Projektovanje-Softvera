package service;

import java.util.List;

import dao.AppointmentDAO;
import dao.ConnectionPool;
import dao.PatientDAO;
import dao.VisitDAO;
import dto.PatientDTO;

public class PatientService {
	private PatientDAO dao = new PatientDAO();
	private AppointmentDAO appointmentDAO = new AppointmentDAO();
	private VisitDAO visitDAO = new VisitDAO();
	
	public Long getNumberOfPatients(String value) {
		return dao.getNumberOfPatients(value, ConnectionPool.ACTIVE);
	}
	
	public List<PatientDTO> getPatients(String value, String orderBy, String orderByType, Long left, Long right){
		return dao.getPatients(value, orderBy, orderByType, left, right, ConnectionPool.ACTIVE);
	}
	
	public boolean insert(PatientDTO dto) {
		return dao.insert(dto);
	}
	
	public boolean update(PatientDTO dto, String oldID) {
		return dao.update(dto, oldID);
	}
	
	public boolean updateSetActive(String id) {
		//appointmentDAO.deleteRecoverPatientsAppointments(id, ConnectionPool.ACTIVE);
		visitDAO.deleteRecoverPatientsVisitss(id, ConnectionPool.ACTIVE);
		return dao.updateSetActive(id, ConnectionPool.ACTIVE);
	}
	
	public boolean delete(String id) {
		appointmentDAO.deleteRecoverPatientsAppointments(id, !ConnectionPool.ACTIVE);
		visitDAO.deleteRecoverPatientsVisitss(id, !ConnectionPool.ACTIVE);
		return dao.delete(id);
	}
	
	public PatientDTO selectWithIdPatient(String id) {
		return dao.selectWithIdPatient(id);
	}
}
