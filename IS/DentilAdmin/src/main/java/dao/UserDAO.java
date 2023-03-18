package dao;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;
import java.util.logging.Level;

import dto.PairDTO;
import dto.UserDTO;
import factory.UserFactory;
import logger.MyLogger;

public class UserDAO {
	private static ConnectionPool connectionPool = ConnectionPool.getConnectionPool();
	private static final String SQL_DELETE = "update worker as w set w.active=? where w.id=?";
	private static final String SQL_UPDATE = "update worker as w set w.id=?,w.name=?,w.surname=?, w.address=?, w.phone=?, w.email=?, w.username=?, w.password=?, w.role_name=? where w.id=?";
	private static final String SQL_INSERT = "insert into worker(id, name, surname, email, phone, address, username, password, role_name) values(?, ?, ?, ?, ?, ?, ?, ?, ?);";
	private static final String SQL_SELECT_1 = "select w.id, w.name, w.surname, w.email, w.phone, w.address, w.username, null as 'password', w.role_name from worker as w where w.active=? and (w.id like ? or w.name like ? or w.surname like ? or w.role_name like ?) order by ";
	private static final String SQL_SELECT_2 = " limit ?, ?;";
	private static final String SQL_GET_NUMBER_OF_WORKERS = "select count(*) as 'numberOf' from worker as w where w.active=? and (w.id like ? or w.name like ? or w.surname like ? or w.role_name like ?)";
	private static final String SQL_UPDATE_WORKER_ACTIVE = "update worker as w set w.active=? where w.id=?;";
	
	private static final Map<PairDTO<String, String>, String> map = 
			new HashMap<>();
	
	static {
		map.put(new PairDTO<String, String>("id", "asc"), SQL_SELECT_1 + "id asc" + SQL_SELECT_2 );
		map.put(new PairDTO<String, String>("id", "desc"), SQL_SELECT_1 + "id desc" + SQL_SELECT_2);

		map.put(new PairDTO<String, String>("name", "asc"), SQL_SELECT_1 + "name asc" + SQL_SELECT_2);
		map.put(new PairDTO<String, String>("name", "desc"), SQL_SELECT_1 + "name desc" + SQL_SELECT_2);

		map.put(new PairDTO<String, String>("surname", "asc"), SQL_SELECT_1 + "surname asc" + SQL_SELECT_2);
		map.put(new PairDTO<String, String>("surname", "desc"), SQL_SELECT_1 + "surname desc" + SQL_SELECT_2);
		
		map.put(new PairDTO<String, String>("role", "asc"), SQL_SELECT_1 + "role_name asc" + SQL_SELECT_2);
		map.put(new PairDTO<String, String>("role", "desc"), SQL_SELECT_1 + "role_name desc" + SQL_SELECT_2);
	}
	
	public boolean delete(String id, Boolean active) {
		boolean res = false;
		Connection conn = null;
		Object []values = new Object[] {active, id};
		
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
	
	public boolean update(UserDTO dto, String oldID) {
		boolean res = false;
		Connection conn = null;
		Object []values = new Object[] {dto.getId(), dto.getName(), dto.getSurname(), dto.getAddress(), dto.getPhone(),
				dto.getEmail(), dto.getUsername(), dto.getPassword(), dto.getRole_name(), oldID};
		
		try {
			conn = connectionPool.checkOut();
			PreparedStatement pre = DAOUtil.prepareStatement(conn, SQL_UPDATE, false, values);
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
			MyLogger.logger.log(Level.SEVERE, e.getMessage());
		}finally {
			connectionPool.checkIn(conn);
		}
		
		return res;
	}
	
	public Long getNumberOfWorkers(String value, Boolean active) {
		Long res = 0L;
		Connection conn = null;
		Object []values = new Object[] { active, "%" + value + "%", "%" + value + "%", "%" + value + "%", "%" + value + "%"};
		ResultSet rs = null;
		
		try {
			conn = connectionPool.checkOut();
			PreparedStatement pre = DAOUtil.prepareStatement(conn, SQL_GET_NUMBER_OF_WORKERS, false, values);
			rs = pre.executeQuery();
			
			while (rs.next()) {
				res = rs.getLong("numberOf");
			}
			
			pre.close();
		}catch (Exception e) {
			MyLogger.logger.log(Level.SEVERE, e.getMessage());
		}finally {
			connectionPool.checkIn(conn);
		}
		
		return res;
	}
	
	public List<UserDTO> getWorkers(String value, String orderBy, String orderByType, Long left, Long right, Boolean active) {
		List<UserDTO> arr = new ArrayList<>();
		Connection conn = null;
		Object []values = new Object[] { active, "%" + value + "%", "%" + value + "%", "%" + value + "%", "%" + value + "%", 
				 left, right};
		ResultSet rs = null;

		try {
			conn = connectionPool.checkOut();
			PreparedStatement pre = DAOUtil.prepareStatement(conn, map.get(new PairDTO<String, String>(orderBy, orderByType)), false, values);	
			rs = pre.executeQuery();
			
			UserFactory userFactory = UserFactory.getInstance();
			while (rs.next()) {
				arr.add(userFactory.get(rs));
			}
			
			pre.close();
		}catch (Exception e) {
			MyLogger.logger.log(Level.SEVERE, e.getMessage());
		}finally {
			connectionPool.checkIn(conn);
		}
		
		return arr;
	}
	
	public boolean updateWorkerActive(String id, Boolean active) {
		boolean res = false;
		Connection conn = null;
		Object []values = new Object[] {active, id};
		
		try {
			conn = connectionPool.checkOut();
			PreparedStatement pre = DAOUtil.prepareStatement(conn, SQL_UPDATE_WORKER_ACTIVE, false, values);
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
