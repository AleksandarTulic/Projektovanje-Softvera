package service;

import dao.VisitTreatmentDAO;

public class VisitTreatmentService {
	public VisitTreatmentDAO dao = new VisitTreatmentDAO();
	
	public boolean deleteWithIdDentist(String id) {
		return dao.deleteWithIdDentist(id);
	}
}
