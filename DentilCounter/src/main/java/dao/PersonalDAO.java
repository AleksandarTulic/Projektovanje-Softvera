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
	private static final String SQL_SELECT = "select w.id, w.name, w.surname, w.email, w.phone, w.address, w.username, null as password, w.role_name, p.jobStart, p.jobEnd from personal as p inner join working as w on w.id=p.id where w.username=?;";
	private static final String SQL_SELECT_WITH_IDPERSONAL = "select s.date, sh.begin, sh.end from schedule as s inner join shift as sh on sh.id=s.idShift where s.idPersonal=? order by s.date desc;";
	
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
		Object []values = new Object[] {dto.getJobStart(), dto.getJobEnd(), dto.getId()};
		
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
	
	public PersonalDTO select(String username){
		PersonalDTO dto = null;
		Connection conn = null;
		ResultSet rs = null;
		Object []values = new Object[] {username};
		
		try {
			conn = connectionPool.checkOut();
			PreparedStatement pre = DAOUtil.prepareStatement(conn, SQL_SELECT, false, values);
			rs = pre.executeQuery();
			
			
			if (rs.next()) {
				if ("dentist".equals(rs.getString("role_name"))) {
					DentistFactory dFactory = DentistFactory.getInstance();
					dto = dFactory.get(rs);
				}else if ("counter".equals(rs.getString("role_name"))) {
					CounterFactory cFactory = CounterFactory.getInstance();
					dto = cFactory.get(rs);
				}
			}
			
			pre.close();
		}catch (Exception e) {
			MyLogger.logger.log(Level.SEVERE, e.getMessage());
		}finally {
			connectionPool.checkIn(conn);
		}
		
		return dto;
	}
	
	public PairDTO<List<ScheduleDTO>, List<ShiftDTO>> selectWithIdPersonal(String idPersonal){
		Connection conn = null;
		ResultSet rs = null;
		Object []values = new Object[] {idPersonal};
		PairDTO<List<ScheduleDTO>, List<ShiftDTO>> dto = new PairDTO<>();
		List<ScheduleDTO> arrSchedule = new ArrayList<>();
		List<ShiftDTO> arrShift = new ArrayList<>();
		
		try {
			conn = connectionPool.checkOut();
			PreparedStatement pre = DAOUtil.prepareStatement(conn, SQL_SELECT_WITH_IDPERSONAL, false, values);
			rs = pre.executeQuery();
			
			
			while (rs.next()) {
				arrSchedule.add(new ScheduleDTO(rs.getDate("date")));
				arrShift.add(new ShiftDTO(rs.getTime("begin"), rs.getTime("end")));
			}
			
			pre.close();
		}catch (Exception e) {
			MyLogger.logger.log(Level.SEVERE, e.getMessage());
		}finally {
			connectionPool.checkIn(conn);
		}
		
		dto.setA(arrSchedule);
		dto.setB(arrShift);
		return dto;
	}
}
