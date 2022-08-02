package dto;

public class DentistDTO extends UserDTO{
	public DentistDTO() {
		super();
	}
	
	public DentistDTO(String id, String name, String surname, String address, String phone, String email, String username, String password, String role_name) {
		super(id, name, surname, address, phone, email, username, password, role_name);
	}
}
