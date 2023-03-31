package dao;

import java.sql.Connection;
import java.sql.Date;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;
import java.util.logging.Level;

import dto.AppointmentDTO;
import dto.PairDTO;
import factory.AppointmentFactory;
import logger.MyLogger;

public class AppointmentDAO {
	private static ConnectionPool connectionPool = ConnectionPool.getConnectionPool();
	private static final String SQL_INSERT = "insert into appointment(idDentist, startDate, startTime, idPatient, howLong, idWorker) values(?, ?, ?, ?, ?, ?);";
	private static final String SQL_SELECT_SAME_DAY_AND_DENTIST = "select * from appointment as a where a.idDentist=? and a.startDate=? and a.active=? order by startTime limit ?, ?;";
	private static final String SQL_SELECT_NUMBER_OF_SAME_DAY_AND_DENTIST = "select count(*) as 'numberOfElements' from appointment as a where a.idDentist=? and a.startDate=? and a.active=?;";
	private static final String SQL_DELETE = "update appointment as a set a.active=? where a.idDentist=? and a.startDate=? and a.startTime=?;";
	
	private static final String SQL_SELECT_WITH_LIKE_1 = "select p.name as 'patientName', p.surname as 'patientSurname', a.idDentist, w.name as 'dentistName', w.surname as 'dentistSurname', a.startDate, a.startTime, a.howLong from appointment as a inner join worker as w on w.id=a.idDentist inner join patient as p on a.idPatient=p.id " + 
			"where (p.id like ? and p.name like ? and p.surname like ? and w.name like ? and w.surname like ? and a.startDate like ?) and a.active=? order by ";
	
	private static final String SQL_SELECT_WITH_LIKE_2 = " limit ?, ?;";
	
	private static final Map<PairDTO<String, String>, String> mapSelectAppointments = 
			new HashMap<>();
	
	private static final String SQL_GET_NUMBER_OF_APPOINTMENTS = "select count(a.startDate) as numberOfAppointments from appointment as a inner join worker as w on w.id=a.idDentist inner join patient as p on a.idPatient=p.id where (p.id like ? and p.name like ? and p.surname like ? and w.name like ? and w.surname like ? and a.startDate like ?) and a.active=?";
	private static final String SQL_DELETE_RECOVER_PATIENTS_APPOINTMENTS = "update appointment as a set a.active=? where a.idPatient=?;";
	
	static {
		mapSelectAppointments.put(new PairDTO<String, String>("patient", "asc"), SQL_SELECT_WITH_LIKE_1 + "concat(p.name, p.surname) asc" + SQL_SELECT_WITH_LIKE_2 );
		mapSelectAppointments.put(new PairDTO<String, String>("patient", "desc"), SQL_SELECT_WITH_LIKE_1 + "concat(p.name, p.surname) desc" + SQL_SELECT_WITH_LIKE_2);

		mapSelectAppointments.put(new PairDTO<String, String>("dentist", "asc"), SQL_SELECT_WITH_LIKE_1 + "concat(w.name, w.surname) asc" + SQL_SELECT_WITH_LIKE_2);
		mapSelectAppointments.put(new PairDTO<String, String>("dentist", "desc"), SQL_SELECT_WITH_LIKE_1 + "concat(w.name, w.surname) desc" + SQL_SELECT_WITH_LIKE_2);

		mapSelectAppointments.put(new PairDTO<String, String>("date", "asc"), SQL_SELECT_WITH_LIKE_1 + "a.startDate asc" + SQL_SELECT_WITH_LIKE_2);
		mapSelectAppointments.put(new PairDTO<String, String>("date", "desc"), SQL_SELECT_WITH_LIKE_1 + "a.startDate desc" + SQL_SELECT_WITH_LIKE_2);
	}
	
	public boolean insert(AppointmentDTO dto) {
		boolean res = false;
		Connection conn = null;
		Object []values = new Object[] {dto.getIdDentist(), dto.getStartDate() + "", dto.getStartTime() + "",
				dto.getIdPatient(), dto.getHowLong(), dto.getIdPersonal()};
		
		try {
			conn = connectionPool.checkOut();
			PreparedStatement pre = DAOUtil.prepareStatement(conn, SQL_INSERT, false, values);
			int result = pre.executeUpdate();
			
			res = result >= 1 ? true : false;
			pre.close();
		}catch (Exception e) {
			MyLogger.logger.log(Level.SEVERE, e.getMessage());
		}finally {
			connectionPool.checkIn(conn);
		}
		
		return res;
	}
	
	public List<AppointmentDTO> selectWithLike(String idPatient, String patientName, String patientSurname,
			String dentistName, String dentistSurname, String date, String orderBy, String orderByType, Long left, Long right, Boolean active){
		List<AppointmentDTO> arr = new ArrayList<AppointmentDTO>();
		Connection conn = null;
		ResultSet rs = null;
		Object []values = new Object[] {"%" + idPatient + "%", "%" + patientName + "%",
				"%" + patientSurname + "%", "%" + dentistName + "%",
				"%" + dentistSurname + "%", "%" + date + "%", active, left, right};
		
		try {
			conn = connectionPool.checkOut();
			PreparedStatement pre = DAOUtil.prepareStatement(conn, mapSelectAppointments.get(new PairDTO<String, String>(orderBy, orderByType)), false, values);
			rs = pre.executeQuery();
			
			AppointmentFactory aFactory = AppointmentFactory.getInstance();
			while (rs.next()) {
				AppointmentDTO dto = aFactory.get(rs);
				if (dto != null)
					arr.add(dto);
			}
			
			pre.close();
		}catch (Exception e) {
			MyLogger.logger.log(Level.SEVERE, e.getMessage());
		}finally {
			connectionPool.checkIn(conn);
		}
		
		return arr;
	}
	
	public Long getNumberOfAppointments(String idPatient, String patientName, String patientSurname,
			String dentistName, String dentistSurname, String date, Boolean active){
		Long res = 0L;
		Connection conn = null;
		ResultSet rs = null;
		Object []values = new Object[] {"%" + idPatient + "%", "%" + patientName + "%",
				"%" + patientSurname + "%", "%" + dentistName + "%",
				"%" + dentistSurname + "%", "%" + date + "%", active};
		
		try {
			conn = connectionPool.checkOut();
			PreparedStatement pre = DAOUtil.prepareStatement(conn, SQL_GET_NUMBER_OF_APPOINTMENTS, false, values);
			rs = pre.executeQuery();
			
			while (rs.next()) {
				res = rs.getLong("numberOfAppointments");
			}
			
			pre.close();
		}catch (Exception e) {
			MyLogger.logger.log(Level.SEVERE, e.getMessage());
		}finally {
			connectionPool.checkIn(conn);
		}
		
		return res;
	}
	
	public List<AppointmentDTO> selectSameDayAndDentist(Date date, String idDentist, Long left, Long right, Boolean active){
		List<AppointmentDTO> arr = new ArrayList<AppointmentDTO>();
		Connection conn = null;
		ResultSet rs = null;
		Object []values = new Object[] {idDentist, date + "", active, left, right};
		
		try {
			conn = connectionPool.checkOut();
			PreparedStatement pre = DAOUtil.prepareStatement(conn, SQL_SELECT_SAME_DAY_AND_DENTIST, false, values);
			rs = pre.executeQuery();
			
			AppointmentFactory aFactory = AppointmentFactory.getInstance();
			while (rs.next()) {
				AppointmentDTO dto = aFactory.get(rs);
				if (dto != null)
					arr.add(dto);
			}
			
			pre.close();
		}catch (Exception e) {
			MyLogger.logger.log(Level.SEVERE, e.getMessage());
		}finally {
			connectionPool.checkIn(conn);
		}
		
		return arr;
	}
	
	public Long selectNumberOfSameDayAndDentist(Date date, String idDentist, Boolean active){
		Long res = 0L;
		Connection conn = null;
		ResultSet rs = null;
		Object []values = new Object[] {idDentist, date + "", active};
		
		try {
			conn = connectionPool.checkOut();
			PreparedStatement pre = DAOUtil.prepareStatement(conn, SQL_SELECT_NUMBER_OF_SAME_DAY_AND_DENTIST, false, values);
			rs = pre.executeQuery();
			
			while (rs.next()) {
				res = rs.getLong("numberOfElements");
			}
			
			pre.close();
		}catch (Exception e) {
			MyLogger.logger.log(Level.SEVERE, e.getMessage());
		}finally {
			connectionPool.checkIn(conn);
		}
		
		return res;
	}
	
	public boolean delete(AppointmentDTO dto, Boolean active) {
		boolean res = false;
		Connection conn = null;
		
		Object []values = new Object[] {active, dto.getIdDentist(), dto.getStartDate() + "", dto.getStartTime() + ""};
		
		try {
			conn = connectionPool.checkOut();
			PreparedStatement pre = DAOUtil.prepareStatement(conn, SQL_DELETE, false, values);
			int result = pre.executeUpdate();
			
			res = result >= 1 ? true : false;

			pre.close();
		}catch (Exception e) {
			MyLogger.logger.log(Level.SEVERE, e.getMessage());
		}finally {
			connectionPool.checkIn(conn);
		}
		
		return res;
	}
	
	public boolean deleteRecoverPatientsAppointments(String idPatient, Boolean active) {
		boolean res = false;
		Connection conn = null;
		
		Object []values = new Object[] {active, idPatient};
		
		try {
			conn = connectionPool.checkOut();
			PreparedStatement pre = DAOUtil.prepareStatement(conn, SQL_DELETE_RECOVER_PATIENTS_APPOINTMENTS, false, values);
			int result = pre.executeUpdate();
			
			res = result >= 1 ? true : false;

			pre.close();
		}catch (Exception e) {
			MyLogger.logger.log(Level.SEVERE, e.getMessage());
		}finally {
			connectionPool.checkIn(conn);
		}
		
		return res;
	}

}
