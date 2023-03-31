package dao;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.util.logging.Level;

import logger.MyLogger;

public class VisitDAO {
	private static ConnectionPool connectionPool = ConnectionPool.getConnectionPool();
	private static final String SQL_DELETE_RECOVER_PATIENTS_VISITS = "update visit as v set v.active=? where v.idPatient=?;";

	public boolean deleteRecoverPatientsVisitss(String idPatient, Boolean active) {
		boolean res = false;
		Connection conn = null;
		
		Object []values = new Object[] {active, idPatient};
		
		try {
			conn = connectionPool.checkOut();
			PreparedStatement pre = DAOUtil.prepareStatement(conn, SQL_DELETE_RECOVER_PATIENTS_VISITS, false, values);
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
}
