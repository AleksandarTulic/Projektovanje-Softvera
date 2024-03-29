package dao;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.util.logging.Level;

import dto.CounterDTO;
import logger.MyLogger;

public class CounterDAO {
	private static ConnectionPool connectionPool = ConnectionPool.getConnectionPool();
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
			MyLogger.logger.log(Level.SEVERE, e.getMessage());
		}finally {
			connectionPool.checkIn(conn);
		}
		
		return res;
	}
}
