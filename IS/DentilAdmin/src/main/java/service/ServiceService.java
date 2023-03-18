package service;

import java.util.List;

import dao.ServiceDAO;
import dto.PairDTO;

public class ServiceService {
	private ServiceDAO dao = new ServiceDAO();
	
	public List<PairDTO<Long, String>> select(){
		return dao.select();
	}
}
