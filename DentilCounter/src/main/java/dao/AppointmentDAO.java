package dao;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;

import dto.*;
import java.util.*;

public class AppointmentDAO {
	private static ConnectionPool connectionPool = ConnectionPool.getConnectionPool();
	private static final String SQL_INSERT = "insert into appointment(idDentist, startDate, startTime, idPatient, howLong, idPersonal) values(?, ?, ?, ?, ?, ?);";
	private static final String SQL_DELETE_1 = "delete from appointment as a where a.idDentist=? and a.startDate=? and a.startTime=?;";
	private static final String SQL_DELETE_2 = "delete from appointment as a where a.idDentist=?;";
	private static final String SQL_UPDATE = "update appointment as a set a.idDentist=?,a.startDate=?,a.startTime=?,a.idPatient=?,a.howLong=?,a.idPersonal=? where a.idDentist=? and a.startDate=? and a.startTime=?;";
	private static final String SQL_SELECT = "select * from appointment;";
	
	public boolean insert(AppointmentDTO dto) {
		boolean res = false;
		Connection conn = null;
		Object []values = new Object[] {dto.getIdDentist(), dto.getStartDate(), dto.getStartTime(),
				dto.getIdPatient(), dto.getHowLong(), dto.getIdPersonal()};
		
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
	
	public boolean update(AppointmentDTO dto, AppointmentDTO oldDTO) {
		boolean res = false;
		Connection conn = null;
		
		Object []values = new Object[] {dto.getIdDentist(), dto.getStartDate(), dto.getStartTime(),
				dto.getIdPatient(), dto.getHowLong(), dto.getIdPersonal(),
				oldDTO.getIdDentist(), oldDTO.getStartDate() + "", oldDTO.getStartTime() + ""};
		
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
	
	public boolean delete(AppointmentDTO dto) {
		boolean res = false;
		Connection conn = null;
		Object []values = new Object[] {dto.getIdDentist(), dto.getStartDate(), dto.getStartTime()};
		
		try {
			conn = connectionPool.checkOut();
			PreparedStatement pre = DAOUtil.prepareStatement(conn, SQL_DELETE_1, false, values);
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
	
	public boolean deleteAllPatientsAppointments(AppointmentDTO dto) {
		boolean res = false;
		Connection conn = null;
		Object []values = new Object[] {dto.getIdDentist(), dto.getStartDate(), dto.getStartTime()};
		
		try {
			conn = connectionPool.checkOut();
			PreparedStatement pre = DAOUtil.prepareStatement(conn, SQL_DELETE_2, false, values);
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
	
	public List<AppointmentDTO> select(){
		List<AppointmentDTO> arr = new ArrayList<AppointmentDTO>();
		Connection conn = null;
		ResultSet rs = null;
		
		try {
			conn = connectionPool.checkOut();
			PreparedStatement pre = DAOUtil.prepareStatement(conn, SQL_SELECT, false);
			rs = pre.executeQuery();
			
			while (rs.next()) {
				arr.add(new AppointmentDTO(rs.getString("idDentist"), rs.getDate("startDate"), rs.getTime("startTime"),
						rs.getString("idPatient"), rs.getInt("howLong"), rs.getString("idPersonal")));
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
