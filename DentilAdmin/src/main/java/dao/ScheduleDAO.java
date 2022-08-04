package dao;

import java.sql.Connection;
import java.sql.PreparedStatement;

import dto.ScheduleDTO;

public class ScheduleDAO {
	private static ConnectionPool connectionPool = ConnectionPool.getConnectionPool();
	private static final String SQL_INSERT = "insert into schedule(idShift, date, idPersonal, idAdmin) values(?, ?, ?, ?);";
	private static final String SQL_DELETE = "delete from shift as s where s.idShift=? and s.date=? and s.idPersonal=?;";
	
	public boolean insert(ScheduleDTO dto) {
		boolean res = false;
		Connection conn = null;
		Object []values = new Object[] {dto.getIdShift(), dto.getDate(), dto.getIdPersonal(), dto.getIdAdmin()};
		
		try {
			conn = connectionPool.checkOut();
			PreparedStatement pre = DAOUtil.prepareStatement(conn, SQL_INSERT, false, values);
			int result = pre.executeUpdate();
			
			res = result == 1 ? true : false;
			pre.close();
		}catch (Exception e) {
			e.printStackTrace();
		}finally {
			connectionPool.checkIn(conn);
		}
		
		return res;
	}
	
	public boolean delete(ScheduleDTO dto) {
		boolean res = false;
		Connection conn = null;
		Object []values = new Object[] {dto.getIdShift(), dto.getDate(), dto.getIdPersonal()};
		
		try {
			conn = connectionPool.checkOut();
			PreparedStatement pre = DAOUtil.prepareStatement(conn, SQL_DELETE, false, values);
			int result = pre.executeUpdate();
			
			res = result == 1 ? true : false;
			pre.close();
		}catch (Exception e) {
			e.printStackTrace();
		}finally {
			connectionPool.checkIn(conn);
		}
		
		return res;
	}
}
