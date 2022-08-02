package dto;

public class AdminDTO extends UserDTO{
	public AdminDTO() {
		super();
	}
	
	public AdminDTO(String id, String name, String surname, String address, String phone, String email, String username, String password, String role_name) {
		super(id, name, surname, address, phone, email, username, password, role_name);
	}
}
