package dto;

import java.util.Objects;

public class TypeProblemDTO {
	private Long id;
	private String name;
	
	public TypeProblemDTO() {
	}

	public TypeProblemDTO(Long id, String name) {
		super();
		this.id = id;
		this.name = name;
	}

	public Long getId() {
		return id;
	}

	public void setId(Long id) {
		this.id = id;
	}

	public String getName() {
		return name;
	}

	public void setName(String name) {
		this.name = name;
	}

	@Override
	public int hashCode() {
		return Objects.hash(id, name);
	}

	@Override
	public boolean equals(Object obj) {
		if (this == obj)
			return true;
		if (obj == null)
			return false;
		if (getClass() != obj.getClass())
			return false;
		TypeProblemDTO other = (TypeProblemDTO) obj;
		return Objects.equals(id, other.id);
	}

	@Override
	public String toString() {
		return "TypeProblemDTO [id=" + id + ", name=" + name + "]";
	}
	
}
