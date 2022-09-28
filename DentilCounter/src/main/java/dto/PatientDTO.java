package dto;

import java.util.Objects;

public class PatientDTO extends UserDTO{
	public PatientDTO() {
	}
	
	public PatientDTO(String id, String name, String surname, String address, String phone, String email) {
		super(id, name, surname, address, phone, email);
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
		return Objects.equals(super.id, other.id);
	}

	@Override
	public String toString() {
		return "PatientDTO [id=" + id + ", name=" + name + ", surname=" + surname + ", address=" + address + ", phone="
				+ phone + ", email=" + email + "]";
	}
}
