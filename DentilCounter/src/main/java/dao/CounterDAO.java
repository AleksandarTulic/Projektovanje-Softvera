package dao;

import java.sql.Connection;
import java.sql.PreparedStatement;

import dto.CounterDTO;

public class CounterDAO {
	private static ConnectionPool connectionPool = ConnectionPool.getConnectionPool();
	private static final String SQL_DELETE = "delete from counter as w where w.id=?;";
	private static final String SQL_INSERT = "insert into counter(id) values(?);";
	
	public boolean insert(CounterDTO dto) {
		boolean res = false;
		Connection conn = null;
		Object []values = new Object[] {dto.getId()};
		
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
