package factory;

import dto.PatientDTO;
import jakarta.servlet.http.HttpServletRequest;

public class PatientFactory extends PFactory{
	private static PatientFactory factory = new PatientFactory();
	
	private PatientFactory() {
	}
	
	public PatientDTO get(HttpServletRequest request) {
		String id = request.getParameter("id");
		String name = request.getParameter("name");
		String surname = request.getParameter("surname");
		String phone = request.getParameter("phone");
		String email = request.getParameter("email");
		String address = request.getParameter("address");
		
		PatientDTO dto = new PatientDTO(id, name, surname, address, phone, email);
		
		return super.check(dto);
	}
	
	public static PatientFactory getInstance() {
		return factory;
	}
}
