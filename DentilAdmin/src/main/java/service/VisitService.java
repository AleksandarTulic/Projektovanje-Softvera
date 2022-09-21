package service;

import dao.VisitDAO;

public class VisitService {
	private VisitDAO dao = new VisitDAO();
	
	public boolean deleteVisitWithIdDentist(String id) {
		return dao.delete(id);
	}
}
