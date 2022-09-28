package service;

import dao.LastSeenDAO;

public class LastSeenService {
	private LastSeenDAO dao = new LastSeenDAO();
	
	public boolean deleteWithIdDentist(String id) {
		return dao.deleteWithIdPatient(id);
	}
}
