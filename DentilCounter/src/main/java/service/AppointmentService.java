package service;

import dto.AppointmentDTO;
import dao.AppointmentDAO;
import java.util.*;
import java.sql.Date;

public class AppointmentService {
	private AppointmentDAO dao = new AppointmentDAO();
	
	public boolean insert(AppointmentDTO dto) {
		return dao.insert(dto);
	}
	
	public boolean update(AppointmentDTO dto, AppointmentDTO oldDTO) {
		return dao.update(dto, oldDTO);
	}
	
	public boolean delete(AppointmentDTO dto) {
		return dao.delete(dto);
	}
	
	public List<AppointmentDTO> select(){
		return dao.select();
	}
	
	public List<AppointmentDTO> selectWithLike(String idPatient, String patientName, String patientSurname,
			String dentistName, String dentistSurname, String date){
		return dao.selectWithLike(idPatient, patientName, patientSurname, dentistName, dentistSurname, date);
	}
	
	public List<AppointmentDTO> selectSameDayAndDentist(Date date, String idDentist) {
		return dao.selectSameDayAndDentist(date, idDentist);
	}
	
	public boolean deleteWithIdPatient(String id) {
		return dao.deleteWithIdPatient(id);
	}
}
