package dao;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.util.ArrayList;
import java.util.List;
import java.util.logging.Level;

import dto.PairDTO;
import logger.MyLogger;

public class ServiceDAO {
	private static ConnectionPool connectionPool = ConnectionPool.getConnectionPool();
	private static final String SQL_SELECT_SERVICES = "select * from service as s;";
	
	public List<PairDTO<Long, String>> select(){
		Connection conn = null;
		Object []values = new Object[] {};
		ResultSet rs = null;
		List<PairDTO<Long, String>> res = new ArrayList<>();
		
		try {
			conn = connectionPool.checkOut();
			PreparedStatement pre = DAOUtil.prepareStatement(conn, SQL_SELECT_SERVICES, false, values);
			rs = pre.executeQuery();
			
			while(rs.next()) {
				res.add(new PairDTO<Long, String>(rs.getLong("id"), rs.getString("name")));
			}
			
			pre.close();
		}catch (Exception e) {
			MyLogger.logger.log(Level.SEVERE, e.getMessage());
		}finally {
			connectionPool.checkIn(conn);
		}
		
		return res;
	}
}
