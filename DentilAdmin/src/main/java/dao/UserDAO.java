package dao;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;

import dto.UserDTO;

public class UserDAO {
	private static ConnectionPool connectionPool = ConnectionPool.getConnectionPool();
	private static final String SQL_SELECT = "select * from working";
	private static final String SQL_DELETE = "delete from working as w where w.id=?;";
	private static final String SQL_UPDATE = "update working as w set w.id=?,w.name=?,w.surname=?, w.address=?, w.phone=?, w.email=?, w.username=?, w.password=?, w.role_name=? where w.id=?";
	private static final String SQL_INSERT = "insert into Working(id, name, surname, email, phone, address, username, password, role_name) values(?, ?, ?, ?, ?, ?, ?, ?, ?);";
	
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
	
	public void get(){
		Connection conn = null;
		ResultSet rs = null;
		
		try {
			conn = connectionPool.checkOut();
			PreparedStatement pre = DAOUtil.prepareStatement(conn, SQL_SELECT, false);
			rs = pre.executeQuery();
			
			while (rs.next()) {
				System.out.println(rs.getString("id"));
			}
			
			pre.close();
		}catch (Exception e) {
			e.printStackTrace();
		}finally {
			connectionPool.checkIn(conn);
		}
	}
	
	public boolean update(UserDTO dto, String oldID) {
		boolean res = false;
		Connection conn = null;
		Object []values = new Object[] {dto.getId(), dto.getName(), dto.getSurname(), dto.getEmail(), dto.getPhone(),
				dto.getAddress(), dto.getUsername(), dto.getPassword(), dto.getRole_name(), oldID};
		
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
	
	public boolean insert(UserDTO dto) {
		boolean res = false;
		Connection conn = null;
		Object []values = new Object[] {dto.getId(), dto.getName(), dto.getSurname(), dto.getEmail(), dto.getPhone(),
				dto.getAddress(), dto.getUsername(), dto.getPassword(), dto.getRole_name()};
		
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
}
