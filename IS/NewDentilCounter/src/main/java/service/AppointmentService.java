package service;

import java.sql.Date;
import java.util.List;

import dao.AppointmentDAO;
import dto.AppointmentDTO;

public class AppointmentService {
	private AppointmentDAO dao = new AppointmentDAO();
	private static final Boolean active = true;
	
	public List<AppointmentDTO> selectSameDayAndDentist(Date date, String idDentist,
			Long left, Long right) {
		return dao.selectSameDayAndDentist(date, idDentist, left, right, active);
	}
	
	public Long selectNumberOfSameDayAndDentist(Date date, String idDentist) {
		return dao.selectNumberOfSameDayAndDentist(date, idDentist, active);
	}
	
	public boolean insert(AppointmentDTO dto) {
		return dao.insert(dto);
	}
	
	public boolean delete(AppointmentDTO dto) {
		return dao.delete(dto, !active);
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
				active);
	}
	
	public Long getNumberOfAppointments(String idPatient, String patientName, 
			String patientSurname, String dentistName, 
			String dentistSurname, String date){
		return dao.getNumberOfAppointments(idPatient, patientName, 
				patientSurname, dentistName, 
				dentistSurname, date,
				active);
	}
}
