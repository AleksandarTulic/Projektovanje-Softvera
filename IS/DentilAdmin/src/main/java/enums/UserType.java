package enums;

public enum UserType {
	admin("admin"),
	counter("counter"),
	dentist("dentist");
	
	private String value;
	
	UserType(String value){
		this.value = value;
	}
	
	public String getValue() {
		return value;
	}
}
