package service;

import dto.DentistDTO;
import java.util.*;
import dao.DentistDAO;

public class DentistService {
	private DentistDAO dao = new DentistDAO();
	
	public List<DentistDTO> selectWithDateWorking(String date) {
		return dao.selectWithDateWorking(date);
	}
	
	public List<DentistDTO> select(){
		return dao.select();
	}
	
	public DentistDTO selectWithDateWorkingAndDentist(String date, String idDentist) {
		return dao.selectWithDateWorkingAndDentist(date, idDentist);
	}
}
