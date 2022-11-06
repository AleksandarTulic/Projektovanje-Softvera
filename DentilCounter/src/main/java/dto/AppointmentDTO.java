package dto;

import java.sql.Date;
import java.sql.Time;
import java.util.Objects;

public class AppointmentDTO {
	private String idDentist;
	private Date startDate;
	private Time startTime;
	private String idPatient;
	private Integer howLong;
	private String idPersonal;
	private DentistDTO dentistDTO;
	private PatientDTO patientDTO;
	
	public AppointmentDTO(String idDentist, Date startDate, Time startTime, String idPatient, Integer howLong,
			String idPersonal, String patientName, String patientSurname, String dentistName, String dentistSurname) {
		this(idDentist, startDate, startTime, idPatient, howLong, idPersonal);
		this.dentistDTO = new DentistDTO(dentistName, dentistSurname);
		this.patientDTO = new PatientDTO(patientName, patientSurname);
	}
	
	public AppointmentDTO(String idDentist, Date startDate, Time startTime, String idPatient, Integer howLong,
			String idPersonal) {
		super();
		this.idDentist = idDentist;
		this.startDate = startDate;
		this.startTime = startTime;
		this.idPatient = idPatient;
		this.howLong = howLong;
		this.idPersonal = idPersonal;
	}
	
	public String getIdDentist() {
		return idDentist;
	}
	public void setIdDentist(String idDentist) {
		this.idDentist = idDentist;
	}
	public Date getStartDate() {
		return startDate;
	}
	public void setStartDate(Date startDate) {
		this.startDate = startDate;
	}
	public Time getStartTime() {
		return startTime;
	}
	public void setStartTime(Time startTime) {
		this.startTime = startTime;
	}
	public String getIdPatient() {
		return idPatient;
	}
	public void setIdPatient(String idPatient) {
		this.idPatient = idPatient;
	}
	public Integer getHowLong() {
		return howLong;
	}
	public void setHowLong(Integer howLong) {
		this.howLong = howLong;
	}
	public String getIdPersonal() {
		return idPersonal;
	}
	public void setIdPersonal(String idPersonal) {
		this.idPersonal = idPersonal;
	}
	
	public DentistDTO getDentist() {
		return dentistDTO;
	}
	
	public PatientDTO getPatient() {
		return patientDTO;
	}
	
	@Override
	public int hashCode() {
		return Objects.hash(howLong, idDentist, idPatient, idPersonal, startDate, startTime);
	}
	@Override
	public boolean equals(Object obj) {
		if (this == obj)
			return true;
		if (obj == null)
			return false;
		if (getClass() != obj.getClass())
			return false;
		AppointmentDTO other = (AppointmentDTO) obj;
		return Objects.equals(idDentist, other.idDentist)
				&& Objects.equals(startDate, other.startDate) 
				&& Objects.equals(startTime, other.startTime);
	}
	
	@Override
	public String toString() {
		return "AppointmentDTO [idDentist=" + idDentist + ", startDate=" + startDate + ", startTime=" + startTime
				+ ", idPatient=" + idPatient + ", howLong=" + howLong + ", idPersonal=" + idPersonal + "]";
	}
}
