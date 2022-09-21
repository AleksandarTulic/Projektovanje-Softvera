package dto;

import java.sql.Date;

public abstract class PersonalDTO extends UserDTO{
	private Date jobStart;
	private Date jobEnd;
	private ShiftDTO shift;
	private ScheduleDTO schedule;
	
	public PersonalDTO() {
		super();
	}
	
	public PersonalDTO(String id, String name, String surname, String address, String phone, String email, String username, String password, String role_name, String jobStart, String jobEnd) {
		super(id, name, surname, address, phone, email, username, password, role_name);
		
		try {
			this.jobStart = Date.valueOf(jobStart);
			if (jobEnd != null && !"".equals(jobEnd)) {
				this.jobEnd = Date.valueOf(jobEnd);
			}
		}catch (Exception e) {
			e.printStackTrace();
		}
	}
	
	public PersonalDTO(String id, String name, String surname, String address, 
			String phone, String email, String username, String password, 
			String role_name, String jobStart, String jobEnd, ShiftDTO shift, ScheduleDTO schedule) {
		super(id, name, surname, address, phone, email, username, password, role_name);
		this.schedule = schedule;
		this.shift = shift;
		
		try {
			this.jobStart = Date.valueOf(jobStart);
			if (jobEnd != null && !"".equals(jobEnd)) {
				this.jobEnd = Date.valueOf(jobEnd);
			}
		}catch (Exception e) {
			e.printStackTrace();
		}
	}
	
	public Date getJobStart() {
		return jobStart;
	}

	public void setJobStart(Date jobStart) {
		this.jobStart = jobStart;
	}

	public Date getJobEnd() {
		return jobEnd;
	}

	public void setJobEnd(Date jobEnd) {
		this.jobEnd = jobEnd;
	}
	
	public ShiftDTO getShift() {
		return shift;
	}
	
	public ScheduleDTO getSchedule() {
		return schedule;
	}
}
