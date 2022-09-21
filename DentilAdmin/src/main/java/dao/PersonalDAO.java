package dao;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.util.ArrayList;
import java.util.List;
import java.util.logging.Level;

import dto.*;
import factory.CounterFactory;
import factory.DentistFactory;
import logger.MyLogger;

public class PersonalDAO {
	private static ConnectionPool connectionPool = ConnectionPool.getConnectionPool();
	private static final String SQL_INSERT = "insert into Personal(id, jobStart, jobEnd) values(?, ?, ?);";
	private static final String SQL_DELETE = "delete from Personal as p where p.id=?;";
	private static final String SQL_UPDATE = "update Personal as p set p.jobStart=?,p.jobEnd=? where p.id=?;";
	private static final String SQL_SELECT = "select w.id, w.name, w.surname, w.email, w.phone, w.address, w.username, null as password, w.role_name, p.jobStart, p.jobEnd, sh.id as 'idShift', sh.begin, sh.end, s.date, s.idAdmin from personal as p inner join working as w on w.id=p.id"
			+ " inner join schedule as s on s.idPersonal=p.id"
			+ "	inner join shift as sh on sh.id=s.idShift;";
	private static final String SQL_SELECT_WITHOUT_SCHEDULE = "select w.id, w.name, w.surname, w.email, w.phone, w.address, w.username, null as password, w.role_name, p.jobStart, p.jobEnd from working as w inner join personal as p on p.id=w.id;";
	
	public boolean insert(PersonalDTO dto) {
		boolean res = false;
		Connection conn = null;
		Object []values = new Object[] {dto.getId(), dto.getJobStart(), dto.getJobEnd()};
		
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
	
	public List<PersonalDTO> select(){
		Connection conn = null;
		Object []values = new Object[] {};
		ResultSet rs = null;
		List<PersonalDTO> res = new ArrayList<>();
		
		try {
			conn = connectionPool.checkOut();
			PreparedStatement pre = DAOUtil.prepareStatement(conn, SQL_SELECT, false, values);
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
	
	public List<PersonalDTO> selectWithoutSchedule(){
		Connection conn = null;
		Object []values = new Object[] {};
		ResultSet rs = null;
		List<PersonalDTO> res = new ArrayList<>();
		
		try {
			conn = connectionPool.checkOut();
			PreparedStatement pre = DAOUtil.prepareStatement(conn, SQL_SELECT_WITHOUT_SCHEDULE, false, values);
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
}
