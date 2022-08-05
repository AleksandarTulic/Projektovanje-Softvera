package service;

import dto.AppointmentDTO;
import dao.AppointmentDAO;
import java.util.*;

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
}
