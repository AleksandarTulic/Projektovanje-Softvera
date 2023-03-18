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
	
	@Override
	public AppointmentDTO get(HttpServletRequest request, boolean flag) {
		List<String> arr = super.getElements(request);
		AppointmentDTO dto = null;
		
		for (String i : arr) {
			System.out.println(i);
		}
		
		if (arr.size() >= 6) {
			try {
				dto = new AppointmentDTO(arr.get(0), Date.valueOf(arr.get(1)), Time.valueOf(arr.get(2)), arr.get(3), Integer.parseInt(arr.get(4)), arr.get(5));
			}catch (Exception e) {
				dto = null;
				MyLogger.logger.log(Level.SEVERE, e.getMessage());
			}
		}
		
		return flag ? check(dto) : dto;
	}
	
	@Override
	public AppointmentDTO get(ResultSet rs) {
		List<String> arr = super.getElements(rs);

		if (arr.size() >= 10) {
			try {
				return new AppointmentDTO(arr.get(0), Date.valueOf(arr.get(1)), Time.valueOf(arr.get(2)), arr.get(3), Integer.valueOf(arr.get(4)), arr.get(5),
						arr.get(6), arr.get(7), arr.get(8), arr.get(9));
			}catch (Exception e) {
				MyLogger.logger.log(Level.SEVERE, e.getMessage());
			}
		}else if (arr.size() >= 6) {
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
