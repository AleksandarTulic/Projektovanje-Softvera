package dao;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.util.logging.Level;

import dto.ScheduleDTO;
import logger.MyLogger;

public class ScheduleDAO {
	private static ConnectionPool connectionPool = ConnectionPool.getConnectionPool();
	private static final String SQL_INSERT = "insert into schedule(idShift, date, idPersonal, idAdmin) values(?, ?, ?, ?);";
	private static final String SQL_DELETE = "delete from schedule as s where s.idShift=? and s.date=? and s.idPersonal=?;";
	private static final String SQL_SELECT_NUMBER_OF_SCHEDULES = "select count(*) as 'numberOf' from schedule as s inner join worker as w on w.id=s.idPersonal where w.active=?;";
	
	public Long selectNumberOfSchedules(Boolean active){
		Long res = 0L;
		Connection conn = null;
		Object []values = new Object[] {active};
		ResultSet rs = null;
		
		try {
			conn = connectionPool.checkOut();
			PreparedStatement pre = DAOUtil.prepareStatement(conn, SQL_SELECT_NUMBER_OF_SCHEDULES, false, values);
			rs = pre.executeQuery();
			
			if (rs.next()) {
				res = rs.getLong("numberOf");
			}
		}catch (Exception e) {
			MyLogger.logger.log(Level.SEVERE, e.getMessage());
		}finally {
			connectionPool.checkIn(conn);
		}
		
		return res;
	}
	
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
}
