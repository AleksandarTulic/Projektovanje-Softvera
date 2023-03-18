package service;

import java.util.*;

import dao.DentistDAO;
import dto.DentistDTO;

public class DentistService {
	private DentistDAO dao = new DentistDAO();
	
	public List<DentistDTO> selectWithDateWorker(String date) {
		return dao.selectWithDateWorker(date);
	}
	
	public List<DentistDTO> select(){
		return dao.select();
	}
	
	public DentistDTO selectWithDateWorkerAndDentist(String date, String idDentist) {
		return dao.selectWithDateWorkerAndDentist(date, idDentist);
	}
}
