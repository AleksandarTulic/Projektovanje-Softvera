package dao;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.util.logging.Level;

import dto.ScheduleDTO;
import logger.MyLogger;

public class ScheduleDAO {
	private static ConnectionPool connectionPool = ConnectionPool.getConnectionPool();
	private static final String SQL_INSERT = "insert into schedule(idShift, date, idPersonal, idAdmin) values(?, ?, ?, ?);";
	private static final String SQL_DELETE = "delete from schedule as s where s.idShift=? and s.date=? and s.idPersonal=?;";
	private static final String SQL_DELETE_SCHEDULE_WITH_IDSHIFT = "delete from schedule as s where s.idShift=?;";
	private static final String SQL_DELETE_SCHEDULE_WITH_IDPERSONAL = "delete from schedule as s where s.idPersonal=?;";
	private static final String SQL_DELETE_SCHEDULE_WITH_IDADMIN = "delete from schedule as s where s.idAdmin=?;";
	
	public boolean insert(ScheduleDTO dto) {
		boolean res = false;
		Connection conn = null;
		Object []values = new Object[] {dto.getIdShift(), dto.getDate() + "", dto.getIdPersonal(), dto.getIdAdmin()};
		
		try {
			conn = connectionPool.checkOut();
			PreparedStatement pre = DAOUtil.prepareStatement(conn, SQL_INSERT, false, values);
			int result = pre.executeUpdate();
			
			res = result == 1 ? true : false;
			pre.close();
		}catch (Exception e) {
			MyLogger.logger.log(Level.SEVERE, e.getMessage());
		}finally {
			connectionPool.checkIn(conn);
		}
		
		return res;
	}
	
	public boolean delete(ScheduleDTO dto) {
		boolean res = false;
		Connection conn = null;
		Object []values = new Object[] {dto.getIdShift(), dto.getDate() + "", dto.getIdPersonal()};
		
		try {
			conn = connectionPool.checkOut();
			PreparedStatement pre = DAOUtil.prepareStatement(conn, SQL_DELETE, false, values);
			int result = pre.executeUpdate();
			
			res = result == 1 ? true : false;
			pre.close();
		}catch (Exception e) {
			MyLogger.logger.log(Level.SEVERE, e.getMessage());
		}finally {
			connectionPool.checkIn(conn);
		}
		
		return res;
	}
	
	public boolean deleteScheduleWithIdShift(Integer id) {
		boolean res = false;
		Connection conn = null;
		Object []values = new Object[] {id};
		
		try {
			conn = connectionPool.checkOut();
			PreparedStatement pre = DAOUtil.prepareStatement(conn, SQL_DELETE_SCHEDULE_WITH_IDSHIFT, false, values);
			int result = pre.executeUpdate();
			
			res = result > 0 ? true : false;
			pre.close();
		}catch (Exception e) {
			MyLogger.logger.log(Level.SEVERE, e.getMessage());
		}finally {
			connectionPool.checkIn(conn);
		}
		
		return res;
	}
	
	public boolean deleteScheduleWithIdPersonal(String id) {
		boolean res = false;
		Connection conn = null;
		Object []values = new Object[] {id};
		
		try {
			conn = connectionPool.checkOut();
			PreparedStatement pre = DAOUtil.prepareStatement(conn, SQL_DELETE_SCHEDULE_WITH_IDPERSONAL, false, values);
			int result = pre.executeUpdate();
			
			res = result > 0 ? true : false;
			pre.close();
		}catch (Exception e) {
			MyLogger.logger.log(Level.SEVERE, e.getMessage());
		}finally {
			connectionPool.checkIn(conn);
		}
		
		return res;
	}
	
	public boolean deleteScheduleWithIdAdmin(String id) {
		boolean res = false;
		Connection conn = null;
		Object []values = new Object[] {id};
		
		try {
			conn = connectionPool.checkOut();
			PreparedStatement pre = DAOUtil.prepareStatement(conn, SQL_DELETE_SCHEDULE_WITH_IDADMIN, false, values);
			int result = pre.executeUpdate();
			
			res = result > 0 ? true : false;
			pre.close();
		}catch (Exception e) {
			MyLogger.logger.log(Level.SEVERE, e.getMessage());
		}finally {
			connectionPool.checkIn(conn);
		}
		
		return res;
	}
}
