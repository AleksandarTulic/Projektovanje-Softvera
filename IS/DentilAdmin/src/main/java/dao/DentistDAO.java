package dao;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.util.ArrayList;
import java.util.List;
import java.util.logging.Level;

import dto.DentistDTO;
import dto.PairDTO;
import logger.MyLogger;

public class DentistDAO {
	private static ConnectionPool connectionPool = ConnectionPool.getConnectionPool();
	private static final String SQL_INSERT = "insert into dentist(id) values(?);";
	private static final String SQL_SELECT_NUMBER_OF_DENTISTS = "select count(*) as 'numberOf' from dentist as d inner join worker as w on w.id=d.id where w.active=?;";
	private static final String SQL_SELECT_MONEY_EARNED = "select w.name, w.surname, sum(s.cost) as 'costOf' from visit as v inner join visitservice as vs on vs.idVisit=v.id "
			+ "inner join service as s on s.id=vs.idService "
			+ "inner join worker as w on w.id=v.idDentist "
			+ "group by w.name, w.surname;";
	private static final String SQL_SELECT_PROBLEMS_ENCOUNTERED = "select w.name, w.surname, count(s.name) as 'numberOf' from visit as v inner join problem as vs on vs.idVisit=v.id "
			+ "inner join typeproblem as s on s.id=vs.idTypeProblem "
			+ "inner join worker as w on w.id=v.idDentist "
			+ "where s.id=? "
			+ "group by w.name, w.surname;";
	private static final String SQL_SELECT_VISIT_SERVICES_ENCOUNTERED = "select w.name, w.surname, count(s.cost) as 'numberOf' from visit as v inner join visitservice as vs on vs.idVisit=v.id "
			+ "inner join service as s on s.id=vs.idService "
			+ "inner join worker as w on w.id=v.idDentist "
			+ "where s.id=? "
			+ "group by w.name, w.surname;";
	
	public boolean insert(DentistDTO dto) {
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
	
	public List<PairDTO<String, Double>> selectDentistEarned(){
		List<PairDTO<String, Double>> arr = new ArrayList<>();
		Connection conn = null;
		Object []values = new Object[] {};
		ResultSet rs = null;
		
		try {
			conn = connectionPool.checkOut();
			PreparedStatement pre = DAOUtil.prepareStatement(conn, SQL_SELECT_MONEY_EARNED, false, values);
			rs = pre.executeQuery();
			
			while (rs.next()) {
				arr.add(new PairDTO<String, Double>(rs.getString("name") + " " + rs.getString("surname"), rs.getDouble("costOf")));
			}
		}catch (Exception e) {
			MyLogger.logger.log(Level.SEVERE, e.getMessage());
		}finally {
			connectionPool.checkIn(conn);
		}
		
		return arr;
	}
	
	public Long selectNumberOfDentists(Boolean active){
		Long res = 0L;
		Connection conn = null;
		Object []values = new Object[] {active};
		ResultSet rs = null;
		
		try {
			conn = connectionPool.checkOut();
			PreparedStatement pre = DAOUtil.prepareStatement(conn, SQL_SELECT_NUMBER_OF_DENTISTS, false, values);
			rs = pre.executeQuery();
			
			if (rs.next()) {
				res = rs.getLong("numberOf");
			}
		}catch (Exception e) {
			MyLogger.logger.log(Level.SEVERE, e.getMessage());
		}finally {
			connectionPool.checkIn(conn);
		}
		
		return res;
	}
	
	public List<PairDTO<String, Long>> selectTypeProblemsEncountered(Long id){
		List<PairDTO<String, Long>> arr = new ArrayList<>();
		Connection conn = null;
		Object []values = new Object[] {id};
		ResultSet rs = null;
		
		try {
			conn = connectionPool.checkOut();
			PreparedStatement pre = DAOUtil.prepareStatement(conn, SQL_SELECT_PROBLEMS_ENCOUNTERED, false, values);
			rs = pre.executeQuery();
			
			while (rs.next()) {
				arr.add(new PairDTO<String, Long>(rs.getString("name") + " " + rs.getString("surname"), rs.getLong("numberOf")));
			}
		}catch (Exception e) {
			MyLogger.logger.log(Level.SEVERE, e.getMessage());
		}finally {
			connectionPool.checkIn(conn);
		}
		
		return arr;
	}
	
	public List<PairDTO<String, Long>> selectVisitServicesEncountered(Long id){
		List<PairDTO<String, Long>> arr = new ArrayList<>();
		Connection conn = null;
		Object []values = new Object[] {id};
		ResultSet rs = null;
		
		try {
			conn = connectionPool.checkOut();
			PreparedStatement pre = DAOUtil.prepareStatement(conn, SQL_SELECT_VISIT_SERVICES_ENCOUNTERED, false, values);
			rs = pre.executeQuery();
			
			while (rs.next()) {
				arr.add(new PairDTO<String, Long>(rs.getString("name") + " " + rs.getString("surname"), rs.getLong("numberOf")));
			}
		}catch (Exception e) {
			MyLogger.logger.log(Level.SEVERE, e.getMessage());
		}finally {
			connectionPool.checkIn(conn);
		}
		
		return arr;
	}
}
