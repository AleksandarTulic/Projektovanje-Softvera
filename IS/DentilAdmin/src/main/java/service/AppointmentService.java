package service;

import dao.AppointmentDAO;

public class AppointmentService {
	private AppointmentDAO dao = new AppointmentDAO();
	
	public boolean deleteWithIdPersonal(String id) {
		return dao.deleteWithIdPersonal(id);
	}
}
