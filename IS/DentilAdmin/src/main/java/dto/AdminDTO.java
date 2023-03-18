package dto;

public class AdminDTO extends UserDTO{
	private String secretKey;
	
	public AdminDTO() {
		super();
	}
	
	public AdminDTO(String id, String name, String surname, String address, String phone, 
			String email, String username, String password, 
			String role_name, String secretKey, Boolean active) {
		super(id, name, surname, address, phone, email, username, password, role_name, active);
		
		this.secretKey = secretKey;
	}

	public String getSecretKey() {
		return secretKey;
	}

	public void setSecretKey(String secretKey) {
		this.secretKey = secretKey;
	}
}
