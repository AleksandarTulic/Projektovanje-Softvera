package dao;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.util.logging.Level;

import dto.AdminDTO;
import factory.AdminFactory;
import logger.MyLogger;

public class AdminDAO {
	private static ConnectionPool connectionPool = ConnectionPool.getConnectionPool();
	private static final String SQL_INSERT = "insert into admin(id, secretKey) values(?, ?);";
	private static final String SQL_SELECT_WITH_USERNAME = "select w.id, name, surname, email, phone, address, username, null as password, role_name, secretKey, w.active from worker as w inner join admin as a on w.id=a.id where w.username=?;";
	private static final String SQL_SELECT_WITH_ID = "select w.id, name, surname, email, phone, address, username, null as password, role_name, null as 'secretKey', w.active from worker as w inner join admin as a on w.id=a.id where w.id=?;";
	
	public boolean insert(AdminDTO dto) {
		boolean res = false;
		Connection conn = null;
		Object []values = new Object[] {dto.getId(), dto.getSecretKey()};
		
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
	
	public AdminDTO selectAdminWithUsername(String username){
		AdminDTO res = null;
		Connection conn = null;
		Object []values = new Object[] {username};
		ResultSet rs = null;
		
		try {
			conn = connectionPool.checkOut();
			PreparedStatement pre = DAOUtil.prepareStatement(conn, SQL_SELECT_WITH_USERNAME, false, values);
			rs = pre.executeQuery();
			
			AdminFactory aFactory = AdminFactory.getInstance();
			
			if (rs.next()) {
				res = aFactory.get(rs);
			}
		}catch (Exception e) {
			MyLogger.logger.log(Level.SEVERE, e.getMessage());
		}finally {
			connectionPool.checkIn(conn);
		}
		
		return res;
	}
	
	public AdminDTO selectWithId(String id){
		AdminDTO res = null;
		Connection conn = null;
		Object []values = new Object[] {id};
		ResultSet rs = null;
		
		try {
			conn = connectionPool.checkOut();
			PreparedStatement pre = DAOUtil.prepareStatement(conn, SQL_SELECT_WITH_ID, false, values);
			rs = pre.executeQuery();
			
			AdminFactory aFactory = AdminFactory.getInstance();
			
			if (rs.next()) {
				res = aFactory.get(rs);
			}
		}catch (Exception e) {
			MyLogger.logger.log(Level.SEVERE, e.getMessage());
		}finally {
			connectionPool.checkIn(conn);
		}
		
		return res;
	}
}
