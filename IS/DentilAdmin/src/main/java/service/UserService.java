package service;

import dto.*;
import security.Crypt;

import java.util.List;

import dao.AppointmentDAO;
import dao.ConnectionPool;
import dao.PersonalDAO;
import dao.UserDAO;

public class UserService {
	private Crypt crypt = new Crypt();
	private UserDAO dao = new UserDAO();
	private AppointmentDAO appointmentDAO = new AppointmentDAO();
	protected PersonalDAO personalDAO = new PersonalDAO();
	
	public UserService() {
	}
	
	public boolean insert(UserDTO dto) {
		dto.setPassword(crypt.sha256(dto.getPassword()));
		return dao.insert(dto);
	}
	
	public boolean update(UserDTO dto, String oldID) {
		dto.setPassword(crypt.sha256(dto.getPassword()));
		return dao.update(dto, oldID);
	}
	
	public boolean delete(String id) {
		appointmentDAO.dentistChangeAppointmentState(id, !ConnectionPool.ACTIVE);
		personalDAO.delete(id);
		return dao.delete(id, !ConnectionPool.ACTIVE);
	}
	
	public List<UserDTO> getWorkers(String value, String orderBy, String orderByType, Long left, Long right) {
		return dao.getWorkers(value, orderBy, orderByType, left, right, ConnectionPool.ACTIVE);
	}
	
	public Long getNumberOfWorkers(String value) {
		return dao.getNumberOfWorkers(value, ConnectionPool.ACTIVE);
	}
	
	public boolean updateWorkerActive(String id) {
		//appointmentDAO.dentistChangeAppointmentState(id, ACTIVE);
		//i don't return because dentist or counter can delete only certain appointments for this dentist and then
		//with previous action we would return all appointments of a dentist
		personalDAO.unDelete(id);
		return dao.updateWorkerActive(id, ConnectionPool.ACTIVE);
	}
}
