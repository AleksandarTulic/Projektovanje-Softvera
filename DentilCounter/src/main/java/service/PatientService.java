package service;

import dto.PatientDTO;
import dao.PatientDAO;
import java.util.*;

public class PatientService {
	private PatientDAO dao = new PatientDAO();
	
	public boolean insert(PatientDTO dto) {
		return dao.insert(dto);
	}
	
	public boolean update(PatientDTO dto, String oldID) {
		return dao.update(dto, oldID);
	}
	
	public boolean delete(String ID) {
		return dao.delete(ID);
	}
	
	public List<PatientDTO> select(){
		return dao.select();
	}
}
