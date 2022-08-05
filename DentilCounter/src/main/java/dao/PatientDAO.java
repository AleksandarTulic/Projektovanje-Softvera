package dao;

import dto.*;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.util.*;

public class PatientDAO {
	private static ConnectionPool connectionPool = ConnectionPool.getConnectionPool();
	private static final String SQL_INSERT = "insert into patient(id, name, surname, email, phone, address) values(?, ?, ?, ?, ?, ?);";
	private static final String SQL_UPDATE = "update patient as p set p.id=?,p.name=?,p.surname=?,p.email=?,p.phone=?,p.address=? where p.id=?;";
	private static final String SQL_DELETE = "delete from patient as p where p.id=?;";
	private static final String SQL_SELECT = "select * from patient;";
	
	public boolean insert(PatientDTO dto) {
		boolean res = false;
		Connection conn = null;
		Object []values = new Object[] {dto.getId(), dto.getName(), dto.getSurname(), dto.getEmail(), dto.getPhone(),
				dto.getAddress()};
		
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
	
	public boolean update(PatientDTO dto, String oldID) {
		boolean res = false;
		Connection conn = null;
		Object []values = new Object[] {dto.getId(), dto.getName(), dto.getSurname(),
				dto.getEmail(), dto.getPhone(), dto.getAddress(), oldID};
		
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
	
	public boolean delete(String ID) {
		boolean res = false;
		Connection conn = null;
		Object []values = new Object[] {ID};
		
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
	
	public List<PatientDTO> select(){
		List<PatientDTO> arr = new ArrayList<PatientDTO>();
		Connection conn = null;
		ResultSet rs = null;
		
		try {
			conn = connectionPool.checkOut();
			PreparedStatement pre = DAOUtil.prepareStatement(conn, SQL_SELECT, false);
			rs = pre.executeQuery();
			
			while (rs.next()) {
				arr.add(new PatientDTO(rs.getString("id"), rs.getString("name"),
						rs.getString("surname"), rs.getString("address"), rs.getString("phone"), rs.getString("email")));
			}
			
			pre.close();
		}catch (Exception e) {
			e.printStackTrace();
		}finally {
			connectionPool.checkIn(conn);
		}
		
		return arr;
	}
}
