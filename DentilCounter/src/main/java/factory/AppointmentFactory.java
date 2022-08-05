package factory;

import dto.AppointmentDTO;
import jakarta.servlet.http.HttpServletRequest;
import java.sql.Date;
import java.sql.Time;

public class AppointmentFactory extends AFactory{
	private static AppointmentFactory factory = new AppointmentFactory();
	
	private AppointmentFactory() {
	}
	
	@Override
	public AppointmentDTO get(HttpServletRequest request) {
		Date startDate = null;
		Time startTime = null;
		String idDentist = request.getParameter("idDentist");
		
		try {
			startDate = Date.valueOf(request.getParameter("startDate"));
			startTime = Time.valueOf(request.getParameter("startTime") + ":00");
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
	
	public static AppointmentFactory getInstance() {
		return factory;
	}
}
