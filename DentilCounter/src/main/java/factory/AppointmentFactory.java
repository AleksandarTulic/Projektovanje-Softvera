package factory;

import dto.AppointmentDTO;
import jakarta.servlet.http.HttpServletRequest;
import logger.MyLogger;

import java.sql.Date;
import java.sql.ResultSet;
import java.sql.Time;
import java.util.*;
import java.util.logging.Level;

public class AppointmentFactory extends AFactory{
	private static AppointmentFactory factory = new AppointmentFactory();
	
	private AppointmentFactory() {
	}
	
	/*
	@Override
	public AppointmentDTO get(HttpServletRequest request) {
		Date startDate = null;
		Time startTime = null;
		String idDentist = request.getParameter("idDentist");
		
		try {
			startDate = Date.valueOf(request.getParameter("startDate"));
			startTime = Time.valueOf(request.getParameter("startTime"));
		}catch (Exception e) {
			startDate = null;
			startTime = null;
			e.printStackTrace();
		}
		
		if (startDate == null || startTime == null)
			return null;
		
		String idPersonal = request.getParameter("idPersonal");
		String idPatient = request.getParameter("idPatient");
		Integer howLong = Integer.parseInt(request.getParameter("howLong"));
		
		AppointmentDTO dto = new AppointmentDTO(idDentist, startDate, startTime, idPatient, howLong, idPersonal);
		
		return super.check(dto);
	}
	
	*/
	
	@Override
	public AppointmentDTO get(HttpServletRequest request) {
		List<String> arr = super.getElements(request);
		AppointmentDTO dto = null;
		
		if (arr.size() >= 6) {
			try {
				dto = new AppointmentDTO(arr.get(0), Date.valueOf(arr.get(1)), Time.valueOf(arr.get(2)), arr.get(3), Integer.parseInt(arr.get(4)), arr.get(5));
			}catch (Exception e) {
				dto = null;
				MyLogger.logger.log(Level.SEVERE, e.getMessage());
			}
		}
		
		return dto;
	}
	
	@Override
	public AppointmentDTO get(ResultSet rs) {
		List<String> arr = super.getElements(rs);
		
		if (arr.size() >= 6) {
			try {
				return new AppointmentDTO(arr.get(0), Date.valueOf(arr.get(1)), Time.valueOf(arr.get(2)), arr.get(3), Integer.valueOf(arr.get(4)), arr.get(5));
			}catch (Exception e) {
				MyLogger.logger.log(Level.SEVERE, e.getMessage());
			}
		}
		
		return null;
	}
	
	public static AppointmentFactory getInstance() {
		return factory;
	}
}
