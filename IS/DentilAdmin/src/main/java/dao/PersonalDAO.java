package dao;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;
import java.util.logging.Level;

import dto.*;
import enums.UserType;
import factory.CounterFactory;
import factory.DentistFactory;
import factory.UserFactory;
import logger.MyLogger;

public class PersonalDAO {
	private static ConnectionPool connectionPool = ConnectionPool.getConnectionPool();
	private static final String SQL_INSERT = "insert into Personal(id, jobStart, jobEnd) values(?, ?, ?);";
	private static final String SQL_UPDATE = "update Personal as p set p.jobStart=?,p.jobEnd=? where p.id=?;";
	private static final String SQL_SELECT_1 = "select w.id, w.name, w.surname, w.email, w.phone, w.address, w.username, null as password, w.role_name, p.jobStart, p.jobEnd, sh.id as 'idShift', sh.begin, sh.end, s.date, s.idAdmin from personal as p inner join worker as w on w.id=p.id"
			+ " inner join schedule as s on s.idPersonal=p.id"
			+ "	inner join shift as sh on sh.id=s.idShift where w.active=? order by ";
	private static final String SQL_SELECT_2 = " limit ?, ?;";
	private static final String SQL_SELECT_NUMBER_OF_PERSONAL = "select count(*) as 'numberOf' from personal as p inner join worker as w on w.id=p.id where w.active=?;";
	private static final String SQL_SELECT_EMPLOYED_BY_YEAR = "select count(*) as 'column1', YEAR(jobStart) as 'column2' from personal where jobEnd is null group by YEAR(jobStart);";
	private static final String SQL_SELECT_UNEMPLOYED_BY_YEAR = "select count(*) as 'column1', YEAR(jobEnd) as 'column2' from personal where jobEnd is not null group by YEAR(jobStart);";
	private static final String SQL_SELECT_WITH_ID = "select w.id, w.name, w.surname, w.email, w.phone, w.address, w.username, null as 'password', w.role_name, w.active, p.jobStart, null as 'jobEnd' from personal as p inner join worker as w on w.id=p.id where w.id=?;";
	private static final String SQL_DELETE = "update personal as p set p.jobEnd=date(now()) where p.id=?;";
	
	private static final Map<PairDTO<String, String>, String> map = 
			new HashMap<>();
	
	static {
		map.put(new PairDTO<String, String>("name", "asc"), SQL_SELECT_1 + "concat(w.name, w.surname) asc" + SQL_SELECT_2 );
		map.put(new PairDTO<String, String>("name", "desc"), SQL_SELECT_1 + "concat(w.name, w.surname) desc" + SQL_SELECT_2);

		map.put(new PairDTO<String, String>("role", "asc"), SQL_SELECT_1 + "w.role_name asc" + SQL_SELECT_2);
		map.put(new PairDTO<String, String>("role", "desc"), SQL_SELECT_1 + "w.role_name desc" + SQL_SELECT_2);

		map.put(new PairDTO<String, String>("date", "asc"), SQL_SELECT_1 + "s.date asc" + SQL_SELECT_2);
		map.put(new PairDTO<String, String>("date", "desc"), SQL_SELECT_1 + "s.date desc" + SQL_SELECT_2);
		
		map.put(new PairDTO<String, String>("shift", "asc"), SQL_SELECT_1 + "concat(sh.begin, sh.end) asc" + SQL_SELECT_2);
		map.put(new PairDTO<String, String>("shift", "desc"), SQL_SELECT_1 + "concat(sh.begin, sh.end) desc" + SQL_SELECT_2);
	}
	
	public boolean insert(PersonalDTO dto) {
		boolean res = false;
		Connection conn = null;
		Object []values = new Object[] {dto.getId(), dto.getJobStart() + "", dto.getJobEnd() == null ? null : dto.getJobEnd() + ""};
		
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
	
	public boolean update(PersonalDTO dto) {
		boolean res = false;
		Connection conn = null;
		Object []values = new Object[] {dto.getJobStart() + "", dto.getJobEnd() == null ? null : dto.getJobEnd() + "", dto.getId()};
		
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
	
	public List<PersonalDTO> select(Boolean active, String orderBy, String orderByType, Long left, Long right){
		Connection conn = null;
		Object []values = new Object[] {active, left, right};
		ResultSet rs = null;
		List<PersonalDTO> res = new ArrayList<>();
		
		try {
			conn = connectionPool.checkOut();
			PreparedStatement pre = DAOUtil.prepareStatement(conn, map.get(new PairDTO<String, String>(orderBy, orderByType)), false, values);
			rs = pre.executeQuery();

			CounterFactory cf = CounterFactory.getInstance();
			DentistFactory df = DentistFactory.getInstance();
			while(rs.next()) {
				if ("counter".equals(rs.getString("role_name"))) {
					PersonalDTO dto = cf.get(rs);

					if (dto != null)
						res.add(dto);
				}else if ("dentist".equals(rs.getString("role_name"))) {
					PersonalDTO dto = df.get(rs);

					if (dto != null)
						res.add(dto);
				}
			}
			
			pre.close();
		}catch (Exception e) {
			MyLogger.logger.log(Level.SEVERE, e.getMessage());
		}finally {
			connectionPool.checkIn(conn);
		}
		
		return res;
	}
	
	public Long selectNumberOfPersonal(Boolean active){
		Long res = 0L;
		Connection conn = null;
		ResultSet rs = null;
		Object []values = new Object[] {active};
		
		try {
			conn = connectionPool.checkOut();
			PreparedStatement pre = DAOUtil.prepareStatement(conn, SQL_SELECT_NUMBER_OF_PERSONAL, false, values);
			rs = pre.executeQuery();
			
			if (rs.next()) {
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
	
	public List<PairDTO<Long, Integer>> selectEmployed(){
		Connection conn = null;
		Object []values = new Object[] {};
		ResultSet rs = null;
		List<PairDTO<Long, Integer>> res = new ArrayList<>();
		
		try {
			conn = connectionPool.checkOut();
			PreparedStatement pre = DAOUtil.prepareStatement(conn, SQL_SELECT_EMPLOYED_BY_YEAR, false, values);
			rs = pre.executeQuery();
			
			while(rs.next()) {
				res.add(new PairDTO<Long, Integer>(rs.getLong("column1"), rs.getInt("column2")));
			}
			
			pre.close();
		}catch (Exception e) {
			MyLogger.logger.log(Level.SEVERE, e.getMessage());
		}finally {
			connectionPool.checkIn(conn);
		}
		
		return res;
	}
	
	public List<PairDTO<Long, Integer>> selectUnemployed(){
		Connection conn = null;
		Object []values = new Object[] {};
		ResultSet rs = null;
		List<PairDTO<Long, Integer>> res = new ArrayList<>();
		
		try {
			conn = connectionPool.checkOut();
			PreparedStatement pre = DAOUtil.prepareStatement(conn, SQL_SELECT_UNEMPLOYED_BY_YEAR, false, values);
			rs = pre.executeQuery();

			while(rs.next()) {
				res.add(new PairDTO<Long, Integer>(rs.getLong("column1"), rs.getInt("column2")));
			}
			
			pre.close();
		}catch (Exception e) {
			MyLogger.logger.log(Level.SEVERE, e.getMessage());
		}finally {
			connectionPool.checkIn(conn);
		}
		
		return res;
	}
	
	public PersonalDTO selectWithId(String id){
		PersonalDTO res = null;
		Connection conn = null;
		ResultSet rs = null;
		Object []values = new Object[] {id};
		
		try {
			conn = connectionPool.checkOut();
			PreparedStatement pre = DAOUtil.prepareStatement(conn, SQL_SELECT_WITH_ID, false, values);
			rs = pre.executeQuery();
			
			if (rs.next()) {
				UserFactory uFactory = null;
				if (UserType.dentist.getValue().equals(rs.getString("role_name"))) {
					uFactory = DentistFactory.getInstance();
				}else if (UserType.counter.getValue().equals(rs.getString("role_name"))) {
					uFactory = CounterFactory.getInstance();
				}
				
				res = (PersonalDTO) uFactory.get(rs);
			}
			
			pre.close();
		}catch (Exception e) {
			MyLogger.logger.log(Level.SEVERE, e.getMessage());
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
			MyLogger.logger.log(Level.SEVERE, e.getMessage());
		}finally {
			connectionPool.checkIn(conn);
		}
		
		return res;
	}
}
