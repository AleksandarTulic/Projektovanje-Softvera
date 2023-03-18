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
import dto.PatientDTO;
import factory.PatientFactory;
import logger.MyLogger;

public class PatientDAO {
	private static ConnectionPool connectionPool = ConnectionPool.getConnectionPool();
	private static final String SQL_GET_NUMBER_OF_PATIENTS = "select count(*) as numberOfPatients "
			+ "from patient as p where (p.id like ? or p.name like ? or p.surname like ?) and p.active=?;";
	private static final String SQL_SELECT_PATIENTS_1 = "select * "
			+ "from patient as p where (p.id like ? or p.name like ? or p.surname like ?) and p.active=? order by ";
	private static final String SQL_SELECT_PATIENTS_2 = " limit ?, ?;";
	private static final String SQL_INSERT = "insert into patient(id, name, surname, email, phone, address) values(?, ?, ?, ?, ?, ?);";		
	private static final String SQL_UPDATE = "update patient as p set p.id=?,p.name=?,p.surname=?,p.email=?,p.phone=?,p.address=? where p.id=?;";
	private static final String SQL_DELETE = "update patient as p set p.active=0 where p.id=?;";
	private static final String SQL_SELECT_WITH_ID_PATIENT = "select * from patient as p where p.id=?;";
	private static final String SQL_UPDATE_SET_ACTIVE = "update patient as p set p.active=? where p.id=?;";
	
	private static final Map<PairDTO<String, String>, String> mapSelectPatients = 
			new HashMap<>();
	
	static {
		mapSelectPatients.put(new PairDTO<String, String>("id", "asc"), SQL_SELECT_PATIENTS_1 + "id asc" + SQL_SELECT_PATIENTS_2 );
		mapSelectPatients.put(new PairDTO<String, String>("id", "desc"), SQL_SELECT_PATIENTS_1 + "id desc" + SQL_SELECT_PATIENTS_2);

		mapSelectPatients.put(new PairDTO<String, String>("name", "asc"), SQL_SELECT_PATIENTS_1 + "name asc" + SQL_SELECT_PATIENTS_2);
		mapSelectPatients.put(new PairDTO<String, String>("name", "desc"), SQL_SELECT_PATIENTS_1 + "name desc" + SQL_SELECT_PATIENTS_2);

		mapSelectPatients.put(new PairDTO<String, String>("surname", "asc"), SQL_SELECT_PATIENTS_1 + "surname asc" + SQL_SELECT_PATIENTS_2);
		mapSelectPatients.put(new PairDTO<String, String>("surname", "desc"), SQL_SELECT_PATIENTS_1 + "surname desc" + SQL_SELECT_PATIENTS_2);
	}
	
	public Long getNumberOfPatients(String value, Boolean active) {
		Long res = 0L;
		Connection conn = null;
		Object []values = new Object[] { "%" + value + "%", "%" + value + "%", "%" + value + "%", active};
		ResultSet rs = null;
		
		try {
			conn = connectionPool.checkOut();
			PreparedStatement pre = DAOUtil.prepareStatement(conn, SQL_GET_NUMBER_OF_PATIENTS, false, values);
			rs = pre.executeQuery();
			
			while (rs.next()) {
				res = rs.getLong("numberOfPatients");
			}
			
			pre.close();
		}catch (Exception e) {
			MyLogger.logger.log(Level.SEVERE, e.getMessage());
		}finally {
			connectionPool.checkIn(conn);
		}
		
		return res;
	}
	
	public List<PatientDTO> getPatients(String value, String orderBy, String orderByType, Long left, Long right, Boolean active) {
		List<PatientDTO> arr = new ArrayList<>();
		Connection conn = null;
		Object []values = new Object[] { "%" + value + "%", "%" + value + "%", "%" + value + "%", 
				active, left, right};
		ResultSet rs = null;

		try {
			conn = connectionPool.checkOut();
			PreparedStatement pre = DAOUtil.prepareStatement(conn, mapSelectPatients.get(new PairDTO<String, String>(orderBy, orderByType)), false, values);	
			rs = pre.executeQuery();
			
			PatientFactory pFactory = PatientFactory.getInstance();
			while (rs.next()) {
				arr.add(pFactory.get(rs));
			}
			
			pre.close();
		}catch (Exception e) {
			MyLogger.logger.log(Level.SEVERE, e.getMessage());
		}finally {
			connectionPool.checkIn(conn);
		}
		
		return arr;
	}
	
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
			MyLogger.logger.log(Level.SEVERE, e.getMessage());
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
			MyLogger.logger.log(Level.SEVERE, e.getMessage());
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
			
			res = result >= 1 ? true : false;
			pre.close();
		}catch (Exception e) {
			MyLogger.logger.log(Level.SEVERE, e.getMessage());
		}finally {
			connectionPool.checkIn(conn);
		}
		
		return res;
	}
	
	public PatientDTO selectWithIdPatient(String id){
		PatientDTO dto = null;
		Connection conn = null;
		ResultSet rs = null;
		Object []values = new Object[] {id};
		
		try {
			conn = connectionPool.checkOut();
			PreparedStatement pre = DAOUtil.prepareStatement(conn, SQL_SELECT_WITH_ID_PATIENT, false, values);
			rs = pre.executeQuery();
			
			PatientFactory pFactory = PatientFactory.getInstance();
			if (rs.next()) {
				dto = pFactory.get(rs);
			}
			
			pre.close();
		}catch (Exception e) {
			MyLogger.logger.log(Level.SEVERE, e.getMessage());
		}finally {
			connectionPool.checkIn(conn);
		}
		
		return dto;
	}
	
	public boolean updateSetActive(String id, Boolean active) {
		boolean res = false;
		Connection conn = null;
		Object []values = new Object[] {active, id};
		
		try {
			conn = connectionPool.checkOut();
			PreparedStatement pre = DAOUtil.prepareStatement(conn, SQL_UPDATE_SET_ACTIVE, false, values);
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
