package dto;

import java.sql.Date;
import java.util.Objects;

public class ScheduleDTO {
	private String idShift;
	private Date date;
	private String idPersonal;
	private String idAdmin;
	
	public ScheduleDTO() {
	}
	
	public ScheduleDTO(String idShift, Date date, String idPersonal) {
		super();
		this.idShift = idShift;
		this.date = date;
		this.idPersonal = idPersonal;
	}
	
	public ScheduleDTO(String idShift, Date date, String idPersonal, String idAdmin) {
		super();
		this.idShift = idShift;
		this.date = date;
		this.idPersonal = idPersonal;
		this.idAdmin = idAdmin;
	}

	public String getIdShift() {
		return idShift;
	}

	public void setIdShift(String idShift) {
		this.idShift = idShift;
	}

	public Date getDate() {
		return date;
	}

	public void setDate(Date date) {
		this.date = date;
	}

	public String getIdPersonal() {
		return idPersonal;
	}

	public void setIdPersonal(String idPersonal) {
		this.idPersonal = idPersonal;
	}

	public String getIdAdmin() {
		return idAdmin;
	}

	public void setIdAdmin(String idAdmin) {
		this.idAdmin = idAdmin;
	}

	@Override
	public int hashCode() {
		return Objects.hash(date, idAdmin, idPersonal, idShift);
	}

	@Override
	public boolean equals(Object obj) {
		if (this == obj)
			return true;
		if (obj == null)
			return false;
		if (getClass() != obj.getClass())
			return false;
		ScheduleDTO other = (ScheduleDTO) obj;
		return Objects.equals(date, other.date)
				&& Objects.equals(idPersonal, other.idPersonal) 
				&& Objects.equals(idShift, other.idShift);
	}

	@Override
	public String toString() {
		return "Schedule [idShift=" + idShift + ", date=" + date + ", idPersonal=" + idPersonal + ", idAdmin=" + idAdmin
				+ "]";
	}
}
