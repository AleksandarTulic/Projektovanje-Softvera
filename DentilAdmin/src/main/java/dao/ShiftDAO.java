package dao;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.Time;
import java.util.ArrayList;
import java.util.List;
import java.util.logging.Level;

import dto.ShiftDTO;
import logger.MyLogger;

public class ShiftDAO {
	private static ConnectionPool connectionPool = ConnectionPool.getConnectionPool();
	private static final String SQL_INSERT = "insert into shift(begin, end) values(?, ?);";
	private static final String SQL_DELETE = "delete from shift as s where s.id=?;";
	private static final String SQL_SELECT = "select * from shift;";
	
	public boolean insert(ShiftDTO dto) {
		boolean res = false;
		Connection conn = null;
		Object []values = new Object[] {dto.getBegin() + "", dto.getEnd() + ""};
		
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
	
	public boolean delete(Integer id) {
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
			MyLogger.logger.log(Level.SEVERE, e.getMessage());
		}finally {
			connectionPool.checkIn(conn);
		}
		
		return res;
	}
	
	public List<ShiftDTO> select(){
		Connection conn = null;
		Object []values = new Object[] {};
		ResultSet rs = null;
		List<ShiftDTO> res = new ArrayList<>();
		
		try {
			conn = connectionPool.checkOut();
			PreparedStatement pre = DAOUtil.prepareStatement(conn, SQL_SELECT, false, values);
			rs = pre.executeQuery();
			
			while (rs.next()) {
				res.add(new ShiftDTO(rs.getInt("id"), Time.valueOf(rs.getString("begin") + ""), Time.valueOf(rs.getString("end") + "")));
			}
		}catch (Exception e) {
			MyLogger.logger.log(Level.SEVERE, e.getMessage());
		}finally {
			connectionPool.checkIn(conn);
		}
		
		return res;
	}
}
