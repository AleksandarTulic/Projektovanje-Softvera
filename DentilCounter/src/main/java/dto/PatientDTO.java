package dto;

import java.util.Objects;

public class PatientDTO{
	private String id;
	private String name;
	private String surname;
	private String address;
	private String phone;
	private String email;
	
	public PatientDTO() {
	}
	
	public PatientDTO(String id, String name, String surname, String address, String phone, String email) {
		super();
		this.id = id;
		this.name = name;
		this.surname = surname;
		this.address = address;
		this.phone = phone;
		this.email = email;
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

	@Override
	public int hashCode() {
		return Objects.hash(address, email, id, name, phone, surname);
	}

	@Override
	public boolean equals(Object obj) {
		if (this == obj)
			return true;
		if (obj == null)
			return false;
		if (getClass() != obj.getClass())
			return false;
		PatientDTO other = (PatientDTO) obj;
		return Objects.equals(id, other.id);
	}

	@Override
	public String toString() {
		return "PatientDTO [id=" + id + ", name=" + name + ", surname=" + surname + ", address=" + address + ", phone="
				+ phone + ", email=" + email + "]";
	}
}
