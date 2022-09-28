package service;

import dao.ProblemDAO;

public class ProblemService {
	private ProblemDAO dao = new ProblemDAO();
	
	public boolean deleteProblemWithIdDentist(String id) {
		return dao.deleteWithIdPatient(id);
	}
}
