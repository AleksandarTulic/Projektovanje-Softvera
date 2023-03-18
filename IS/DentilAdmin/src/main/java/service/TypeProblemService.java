package service;

import java.util.*;

import dao.TypeProblemDAO;
import dto.TypeProblemDTO;

public class TypeProblemService {
	private TypeProblemDAO dao = new TypeProblemDAO();
	
	public List<TypeProblemDTO> select(){
		return dao.select();
	}
}
