package dao;

import java.sql.Connection;
import java.sql.PreparedStatement;

import dto.*;

public class PersonalDAO {
	private static ConnectionPool connectionPool = ConnectionPool.getConnectionPool();
	private static final String SQL_INSERT = "insert into Personal(id, jobStart, jobEnd) values(?, ?, ?);";
	private static final String SQL_DELETE = "delete from Personal as p where p.id=?;";
	private static final String SQL_UPDATE = "update Personal as p set p.jobStart=?,p.jobEnd=? where p.id=?;";
	
	public boolean insert(PersonalDTO dto) {
		boolean res = false;
		Connection conn = null;
		Object []values = new Object[] {dto.getId(), dto.getJobStart(), dto.getJobEnd()};
		
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
	
	public boolean update(PersonalDTO dto) {
		boolean res = false;
		Connection conn = null;
		Object []values = new Object[] {dto.getJobStart(), dto.getJobEnd(), dto.getId()};
		
		try {
			conn = connectionPool.checkOut();
			PreparedStatement pre = DAOUtil.prepareStatement(conn, SQL_UPDATE, false, values);
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
	
	public boolean delete(String id) {
		boolean res = false;
		Connection conn = null;
		Object []values = new Object[] {id};
		
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
