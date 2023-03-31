package dao;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.util.logging.Level;

import logger.MyLogger;

public class AppointmentDAO {
	private static ConnectionPool connectionPool = ConnectionPool.getConnectionPool();
	private static final String SQL_CHANGE_APPOINTMENT_STATE = "update appointment as a set a.active=? where a.idDentist=?;";
	
	public boolean dentistChangeAppointmentState(String idDentist, Boolean active) {
		boolean res = false;
		Connection conn = null;
		Object []values = new Object[] {active, idDentist};
		
		try {
			conn = connectionPool.checkOut();
			PreparedStatement pre = DAOUtil.prepareStatement(conn, SQL_CHANGE_APPOINTMENT_STATE, false, values);
			int result = pre.executeUpdate();
			
			res = result > 0 ? true : false;
			pre.close();
		}catch (Exception e) {
			MyLogger.logger.log(Level.SEVERE, e.getMessage());
		}finally {
			connectionPool.checkIn(conn);
		}
		
		return res;
	}
}
