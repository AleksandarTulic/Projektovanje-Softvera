package dto;

public class DentistDTO extends PersonalDTO{
	
	public DentistDTO() {
		super();
	}
	
	public DentistDTO(String id, String name, String surname, String address, String phone, String email, String username, String password, String role_name, String jobStart, String jobEnd) {
		super(id, name, surname, address, phone, email, username, password, role_name, jobStart, jobEnd);
	}
}
