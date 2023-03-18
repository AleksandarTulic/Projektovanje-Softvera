package dao;

import dto.DentistDTO;
import factory.DentistFactory;
import logger.MyLogger;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.util.*;
import java.util.logging.Level;

public class DentistDAO {
	private static ConnectionPool connectionPool = ConnectionPool.getConnectionPool();
	private static final String SQL_SELECT = "select w.id, w.name, w.surname, w.email, w.phone, w.address, w.username, null as password, w.role_name, p.jobStart, p.jobEnd from worker as w inner join personal as p on w.id=p.id inner join dentist as d on w.id=d.id;";
	private static final String SQL_SELECT_WITH_DATE_WORKER = "select w.id, w.name, w.surname, w.email, w.phone, w.address, w.username, null as password, w.role_name, p.jobStart, p.jobEnd, sh.id as 'idShift', sh.begin, sh.end, s.date, s.idAdmin from worker as w inner join personal as p on w.id=p.id "
			+ "						   inner join dentist as d on p.id=d.id "
			+ "						   inner join schedule as s on d.id=s.idPersonal "
			+ "						   inner join shift as sh on s.idShift=sh.id where s.date=?;";
	private static final String SQL_SELECT_WITH_DATE_WORKER_AND_DENTIST = "select w.id, w.name, w.surname, w.email, w.phone, w.address, w.username, null as password, w.role_name, p.jobStart, p.jobEnd, sh.id as 'idShift', sh.begin, sh.end, s.date, s.idAdmin from worker as w inner join personal as p on w.id=p.id "
			+ "						   inner join dentist as d on p.id=d.id "
			+ "						   inner join schedule as s on d.id=s.idPersonal "
			+ "						   inner join shift as sh on s.idShift=sh.id where s.date=? and w.id=?;";
	
	public List<DentistDTO> selectWithDateWorker(String date){
		Connection conn = null;
		Object []values = new Object[] {date};
		ResultSet rs = null;
		List<DentistDTO> res = new ArrayList<>();

		try {
			conn = connectionPool.checkOut();
			PreparedStatement pre = DAOUtil.prepareStatement(conn, SQL_SELECT_WITH_DATE_WORKER, false, values);
			rs = pre.executeQuery();
			
			DentistFactory dFactory = DentistFactory.getInstance();
			while (rs.next()) {
				res.add(dFactory.get(rs));
			}
		}catch (Exception e) {
			MyLogger.logger.log(Level.SEVERE, e.getMessage());
		}finally {
			connectionPool.checkIn(conn);
		}
		
		return res;
	}
	
	public DentistDTO selectWithDateWorkerAndDentist(String date, String idDentist){
		Connection conn = null;
		Object []values = new Object[] {date, idDentist};
		ResultSet rs = null;
		DentistDTO res = null;

		try {
			conn = connectionPool.checkOut();
			PreparedStatement pre = DAOUtil.prepareStatement(conn, SQL_SELECT_WITH_DATE_WORKER_AND_DENTIST, false, values);
			rs = pre.executeQuery();
			
			DentistFactory dFactory = DentistFactory.getInstance();
			while (rs.next()) {
				res = dFactory.get(rs);
			}
		}catch (Exception e) {
			MyLogger.logger.log(Level.SEVERE, e.getMessage());
		}finally {
			connectionPool.checkIn(conn);
		}
		
		return res;
	}
	
	public List<DentistDTO> select(){
		Connection conn = null;
		Object []values = new Object[] {};
		ResultSet rs = null;
		List<DentistDTO> res = new ArrayList<>();

		try {
			conn = connectionPool.checkOut();
			PreparedStatement pre = DAOUtil.prepareStatement(conn, SQL_SELECT, false, values);
			rs = pre.executeQuery();
			
			DentistFactory dFactory = DentistFactory.getInstance();
			while (rs.next()) {
				res.add(dFactory.get(rs));
			}
		}catch (Exception e) {
			MyLogger.logger.log(Level.SEVERE, e.getMessage());
		}finally {
			connectionPool.checkIn(conn);
		}
		
		return res;
	}
}	
