package dto;

import java.util.Objects;

public abstract class UserDTO {
	protected String id;
	protected String name;
	protected String surname;
	protected String address;
	protected String phone;
	protected String email;
	protected String username;
	protected String password;
	protected String role_name;
	
	public UserDTO() {
	}
	
	public UserDTO(String name, String surname) {
		super();
		this.name = name;
		this.surname = surname;
	}
	
	public UserDTO(String id, String name, String surname) {
		super();
		this.id = id;
		this.name = name;
		this.surname = surname;
	}
	
	public UserDTO(String id, String name, String surname, String address, String phone, String email) {
		super();
		this.id = id;
		this.name = name;
		this.surname = surname;
		this.address = address;
		this.phone = phone;
		this.email = email;
	}

	public UserDTO(String id, String name, String surname, String address, String phone, String email, String username,
			String password, String role_name) {
		super();
		this.id = id;
		this.name = name;
		this.surname = surname;
		this.address = address;
		this.phone = phone;
		this.email = email;
		this.username = username;
		this.password = password;
		this.role_name = role_name;
	}

	public String getId() {
		return id;
	}

	public void setId(String id) {
		this.id = id;
	}

	public String getName() {
		return name;
	}

	public void setName(String name) {
		this.name = name;
	}

	public String getSurname() {
		return surname;
	}

	public void setSurname(String surname) {
		this.surname = surname;
	}

	public String getAddress() {
		return address;
	}

	public void setAddress(String address) {
		this.address = address;
	}

	public String getPhone() {
		return phone;
	}

	public void setPhone(String phone) {
		this.phone = phone;
	}

	public String getEmail() {
		return email;
	}

	public void setEmail(String email) {
		this.email = email;
	}

	public String getUsername() {
		return username;
	}

	public void setUsername(String username) {
		this.username = username;
	}

	public String getPassword() {
		return password;
	}

	public void setPassword(String password) {
		this.password = password;
	}

	public String getRole_name() {
		return role_name;
	}

	public void setRole_name(String role_name) {
		this.role_name = role_name;
	}

	@Override
	public int hashCode() {
		return Objects.hash(address, email, id, name, password, phone, role_name, surname, username);
	}

	@Override
	public boolean equals(Object obj) {
		if (this == obj)
			return true;
		if (obj == null)
			return false;
		if (getClass() != obj.getClass())
			return false;
		UserDTO other = (UserDTO) obj;
		return Objects.equals(id, other.id);
	}

	@Override
	public String toString() {
		return "UserDTO [id=" + id + ", name=" + name + ", surname=" + surname + ", address=" + address + ", phone="
				+ phone + ", email=" + email + ", username=" + username + ", password=" + password + ", role_name="
				+ role_name + "]";
	}
}
