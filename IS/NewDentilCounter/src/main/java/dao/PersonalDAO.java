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
import dto.PersonalDTO;
import dto.ScheduleDTO;
import dto.ShiftDTO;
import factory.CounterFactory;
import factory.DentistFactory;
import logger.MyLogger;

public class PersonalDAO {
	private static ConnectionPool connectionPool = ConnectionPool.getConnectionPool();
	private static final String SQL_SELECT = "select w.id, w.name, w.surname, w.email, w.phone, w.address, w.username, null as password, w.role_name, p.jobStart, p.jobEnd from personal as p inner join worker as w on w.id=p.id where w.username=?;";
	
	private static final String SQL_SELECT_PERSONAL_SCHEDULE_1 = "select s.date, sh.begin, sh.end "
			+ "from schedule as s inner join shift as sh on sh.id=s.idShift "
			+ "where s.idPersonal=? order by ";
	
	private static final String SQL_SELECT_PERSONAL_SCHEDULE_2 = " limit ?, ?;";
	private static final String SQL_SELECT_NUMBER_PERSONAL_SCHEDULE = "select count(*) as 'numberOfSelectWithIdPersonal' "
			+ "from schedule as s inner join shift as sh on sh.id=s.idShift "
			+ "where s.idPersonal=?;";
	
	private static final Map<PairDTO<String, String>, String> map = 
			new HashMap<>();
	
	static {
		map.put(new PairDTO<String, String>("date", "asc"), SQL_SELECT_PERSONAL_SCHEDULE_1 + "date asc" + SQL_SELECT_PERSONAL_SCHEDULE_2 );
		map.put(new PairDTO<String, String>("date", "desc"), SQL_SELECT_PERSONAL_SCHEDULE_1 + "date desc" + SQL_SELECT_PERSONAL_SCHEDULE_2);

		map.put(new PairDTO<String, String>("shift", "asc"), SQL_SELECT_PERSONAL_SCHEDULE_1 + "concat(begin, end) asc" + SQL_SELECT_PERSONAL_SCHEDULE_2);
		map.put(new PairDTO<String, String>("shift", "desc"), SQL_SELECT_PERSONAL_SCHEDULE_1 + "concat(begin, end) desc" + SQL_SELECT_PERSONAL_SCHEDULE_2);
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
	
	public PairDTO<List<ScheduleDTO>, List<ShiftDTO>> selectPersonalSchedule(String idPersonal,
			String orderBy, String orderByType, Long left, Long right){
		Connection conn = null;
		ResultSet rs = null;
		Object []values = new Object[] {idPersonal, left, right};
		PairDTO<List<ScheduleDTO>, List<ShiftDTO>> dto = new PairDTO<>();
		List<ScheduleDTO> arrSchedule = new ArrayList<>();
		List<ShiftDTO> arrShift = new ArrayList<>();
		
		try {
			conn = connectionPool.checkOut();
			PreparedStatement pre = DAOUtil.prepareStatement(conn, map.get(new PairDTO<String, String>(orderBy, orderByType)), false, values);
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
	
	public Long selectNumberOfPersonalSchedule(String idPersonal){
		Connection conn = null;
		ResultSet rs = null;
		Object []values = new Object[] {idPersonal};
		Long res = 0L;
		
		try {
			conn = connectionPool.checkOut();
			PreparedStatement pre = DAOUtil.prepareStatement(conn, SQL_SELECT_NUMBER_PERSONAL_SCHEDULE, false, values);
			rs = pre.executeQuery();
			
			
			while (rs.next()) {
				res = rs.getLong("numberOfSelectWithIdPersonal");
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
