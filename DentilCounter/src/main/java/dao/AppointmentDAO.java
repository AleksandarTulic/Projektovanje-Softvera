package dao;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;

import dto.*;
import factory.AppointmentFactory;
import logger.MyLogger;

import java.util.*;
import java.util.logging.Level;
import java.sql.Date;

public class AppointmentDAO {
	private static ConnectionPool connectionPool = ConnectionPool.getConnectionPool();
	private static final String SQL_INSERT = "insert into appointment(idDentist, startDate, startTime, idPatient, howLong, idPersonal) values(?, ?, ?, ?, ?, ?);";
	private static final String SQL_DELETE_1 = "delete from appointment as a where a.idDentist=? and a.startDate=? and a.startTime=?;";
	private static final String SQL_DELETE_2 = "delete from appointment as a where a.idDentist=?;";
	private static final String SQL_UPDATE = "update appointment as a set a.idDentist=?,a.startDate=?,a.startTime=?,a.idPatient=?,a.howLong=?,a.idPersonal=? where a.idDentist=? and a.startDate=? and a.startTime=?;";
	private static final String SQL_SELECT = "select * from appointment;";
	private static final String SQL_SELECT_SAME_DAY_AND_DENTIST = "select * from appointment as a where a.idDentist=? and a.startDate=? order by startTime;";
	private static final String SQL_DELETE_WITH_IDPATIENT = "delete from appointment as a where a.idPatient=?;";
	private static final String SQL_SELECT_WITH_LIKE = "select p.name as 'patientName', p.surname as 'patientSurname', a.idDentist, w.name as 'dentistName', w.surname as 'dentistSurname', a.startDate, a.startTime, a.howLong from appointment as a inner join working as w on w.id=a.idDentist inner join patient as p on a.idPatient=p.id " + 
	"where p.id like ? or p.name like ? or p.surname like ? or w.name like ? or w.surname like ? or a.startDate like ?";
	
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
	
	public boolean update(AppointmentDTO dto, AppointmentDTO oldDTO) {
		boolean res = false;
		Connection conn = null;
		
		Object []values = new Object[] {dto.getIdDentist(), dto.getStartDate(), dto.getStartTime(),
				dto.getIdPatient(), dto.getHowLong(), dto.getIdPersonal(),
				oldDTO.getIdDentist(), oldDTO.getStartDate() + "", oldDTO.getStartTime() + ""};
		
		try {
			conn = connectionPool.checkOut();
			PreparedStatement pre = DAOUtil.prepareStatement(conn, SQL_UPDATE, false, values);
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
	
	public boolean delete(AppointmentDTO dto) {
		boolean res = false;
		Connection conn = null;
		Object []values = new Object[] {dto.getIdDentist(), dto.getStartDate() + "", dto.getStartTime() + ""};
		
		try {
			conn = connectionPool.checkOut();
			PreparedStatement pre = DAOUtil.prepareStatement(conn, SQL_DELETE_1, false, values);
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
	
	public boolean deleteAllPatientsAppointments(AppointmentDTO dto) {
		boolean res = false;
		Connection conn = null;
		Object []values = new Object[] {dto.getIdDentist(), dto.getStartDate(), dto.getStartTime()};
		
		try {
			conn = connectionPool.checkOut();
			PreparedStatement pre = DAOUtil.prepareStatement(conn, SQL_DELETE_2, false, values);
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
	
	public List<AppointmentDTO> select(){
		List<AppointmentDTO> arr = new ArrayList<AppointmentDTO>();
		Connection conn = null;
		ResultSet rs = null;
		
		try {
			conn = connectionPool.checkOut();
			PreparedStatement pre = DAOUtil.prepareStatement(conn, SQL_SELECT, false);
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
	
	public List<AppointmentDTO> selectWithLike(String idPatient, String patientName, String patientSurname,
			String dentistName, String dentistSurname, String date){
		List<AppointmentDTO> arr = new ArrayList<AppointmentDTO>();
		Connection conn = null;
		ResultSet rs = null;
		Object []values = new Object[] {"%" + setRightValue(idPatient) + "%", "%" + setRightValue(patientName) + "%", 
				"%" + setRightValue(patientSurname) + "%", "%" + setRightValue(dentistName) + "%", 
				"%" + setRightValue(dentistSurname) + "%", "%" + setRightValue(date) + "%"};
		
		try {
			conn = connectionPool.checkOut();
			PreparedStatement pre = DAOUtil.prepareStatement(conn, SQL_SELECT_WITH_LIKE, false, values);
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
	
	private String setRightValue(String value) {
		return "".equals(value) ? "-" : value;
	}
	
	public List<AppointmentDTO> selectSameDayAndDentist(Date date, String idDentist){
		List<AppointmentDTO> arr = new ArrayList<AppointmentDTO>();
		Connection conn = null;
		ResultSet rs = null;
		Object []values = new Object[] {idDentist, date + ""};
		
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
	
	public boolean deleteWithIdPatient(String id) {
		boolean res = false;
		Connection conn = null;
		Object []values = new Object[] {id};
		
		try {
			conn = connectionPool.checkOut();
			PreparedStatement pre = DAOUtil.prepareStatement(conn, SQL_DELETE_WITH_IDPATIENT, false, values);
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
