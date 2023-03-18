package service;

import java.util.*;

import dao.DentistDAO;
import dao.PatientDAO;
import dao.PersonalDAO;
import dto.PairDTO;

public class StatisticsService {
	private DentistDAO dentistDAO = new DentistDAO();
	private PatientDAO patientDAO = new PatientDAO();
	private PersonalDAO personalDAO = new PersonalDAO();
	private static final Boolean ACTIVE = true;
	
	public Long getNumberOfDentists() {
		return dentistDAO.selectNumberOfDentists(ACTIVE);
	}
	
	public Long getNumberOfPersonal() {
		return patientDAO.selectNumberOfPatients(ACTIVE);
	}
	
	public Long getNumberOfPatients() {
		return patientDAO.selectNumberOfPatients(ACTIVE);
	}
	
	public List<PairDTO<String, Double>> selectDentistEarned(){
		return dentistDAO.selectDentistEarned();
	}
	
	public List<PairDTO<String, Long>> selectTypeProblemsEncountered(Long id){
		return dentistDAO.selectTypeProblemsEncountered(id);
	}
	
	public List<PairDTO<String, Long>> selectVisitServicesEncountered(Long id){
		return dentistDAO.selectVisitServicesEncountered(id);
	}
	
	public List<PairDTO<Long, Integer>> selectEmployed(){
		return personalDAO.selectEmployed();
	}
	
	public List<PairDTO<Long, Integer>> selectUnemployed(){
		return personalDAO.selectUnemployed();
	}
}
