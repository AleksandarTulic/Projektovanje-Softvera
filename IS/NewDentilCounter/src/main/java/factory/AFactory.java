package factory;

import dto.AppointmentDTO;
import jakarta.servlet.http.HttpServletRequest;
import logger.MyLogger;
import validation.AppointmentValidation;

import java.sql.ResultSet;
import java.sql.ResultSetMetaData;
import java.util.*;
import java.util.logging.Level;

public abstract class AFactory {
	private List<String> headers = Arrays.asList("idDentist", "startDate", "startTime", "idPatient", 
			"howLong", "idPersonal", "patientName", "patientSurname", "dentistName", "dentistSurname");
	private List<AppointmentValidation> arrValidation = Arrays.asList(new AppointmentValidation());
	
	public abstract AppointmentDTO get(HttpServletRequest request, boolean flag);
	
	protected AppointmentDTO check(AppointmentDTO dto) {
		for (AppointmentValidation i : arrValidation) {
			if (!i.check(dto)) {
				return null;
			}
		}
		
		return dto;
	}
	
	public abstract AppointmentDTO get(ResultSet rs);
	
	protected List<String> getElements(HttpServletRequest request){
		List<String> res = new ArrayList<>();
		
		try {
			for (String i : headers) {
				//System.out.println(i + " " + request.getParameter(i));
				res.add(request.getParameter(i));
			}
		}catch (Exception e) {
			MyLogger.logger.log(Level.SEVERE, e.getMessage());
		}
		
		return res;
	}
	
	protected List<String> getElements(ResultSet rs){
		List<String> res = new ArrayList<>();
		
		try {
			ResultSetMetaData rsmd = rs.getMetaData();
			List<String> columnNames = new ArrayList<>();
			for (int i=1;i<=rsmd.getColumnCount();i++)
				columnNames.add(rsmd.getColumnLabel(i));
			
			for (String i : headers) {
				res.add(columnNames.contains(i) ? rs.getString(i) : null);
			}
		}catch (Exception e) {
			MyLogger.logger.log(Level.SEVERE, e.getMessage());
		}
		
		return res;
	}
}
