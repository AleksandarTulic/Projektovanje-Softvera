package dto;

import java.sql.Time;
import java.util.Objects;


//https://stackoverflow.com/questions/2731443/cast-a-string-to-sql-time
//convert string to java.sql.time

public class ShiftDTO {
	private int id;
	private Time begin;
	private Time end;
	
	public ShiftDTO() {
	}
	
	public ShiftDTO(Time begin, Time end) {
		this.begin = begin;
		this.end = end;
	}
	
	public ShiftDTO(int id, Time begin, Time end) {
		super();
		this.id = id;
		this.begin = begin;
		this.end = end;
	}
	
	public int getId() {
		return id;
	}
	public void setId(int id) {
		this.id = id;
	}
	public Time getBegin() {
		return begin;
	}
	public void setBegin(Time begin) {
		this.begin = begin;
	}
	public Time getEnd() {
		return end;
	}
	public void setEnd(Time end) {
		this.end = end;
	}

	@Override
	public int hashCode() {
		return Objects.hash(begin, end, id);
	}

	@Override
	public boolean equals(Object obj) {
		if (this == obj)
			return true;
		if (obj == null)
			return false;
		if (getClass() != obj.getClass())
			return false;
		ShiftDTO other = (ShiftDTO) obj;
		return id == other.id;
	}

	@Override
	public String toString() {
		return "ShiftDTO [id=" + id + ", begin=" + begin + ", end=" + end + "]";
	}
}
