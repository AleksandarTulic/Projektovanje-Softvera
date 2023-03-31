package service;

import java.sql.Date;
import java.util.List;

import dao.AppointmentDAO;
import dao.ConnectionPool;
import dto.AppointmentDTO;

public class AppointmentService {
	private AppointmentDAO dao = new AppointmentDAO();
	
	public List<AppointmentDTO> selectSameDayAndDentist(Date date, String idDentist,
			Long left, Long right) {
		return dao.selectSameDayAndDentist(date, idDentist, left, right, ConnectionPool.ACTIVE);
	}
	
	public Long selectNumberOfSameDayAndDentist(Date date, String idDentist) {
		return dao.selectNumberOfSameDayAndDentist(date, idDentist, ConnectionPool.ACTIVE);
	}
	
	public boolean insert(AppointmentDTO dto) {
		return dao.insert(dto);
	}
	
	public boolean delete(AppointmentDTO dto) {
		return dao.delete(dto, !ConnectionPool.ACTIVE);
	}
	
	public List<AppointmentDTO> selectWithLike(String idPatient, String patientName, 
			String patientSurname, String dentistName, 
			String dentistSurname, String date,
			String orderBy, String orderByType,
			Long left, Long right){
		return dao.selectWithLike(idPatient, patientName, 
				patientSurname, dentistName, 
				dentistSurname, date,
				orderBy, orderByType,
				left, right,
				ConnectionPool.ACTIVE);
	}
	
	public Long getNumberOfAppointments(String idPatient, String patientName, 
			String patientSurname, String dentistName, 
			String dentistSurname, String date){
		return dao.getNumberOfAppointments(idPatient, patientName, 
				patientSurname, dentistName, 
				dentistSurname, date,
				ConnectionPool.ACTIVE);
	}
}
