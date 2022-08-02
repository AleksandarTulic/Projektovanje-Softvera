package dto;

public class CounterDTO extends UserDTO{
	public CounterDTO() {
		super();
	}
	
	public CounterDTO(String id, String name, String surname, String address, String phone, String email, String username, String password, String role_name) {
		super(id, name, surname, address, phone, email, username, password, role_name);
	}
}
