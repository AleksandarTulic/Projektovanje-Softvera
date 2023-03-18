package dao;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.util.logging.Level;

import logger.MyLogger;

public class PatientDAO {
	private static ConnectionPool connectionPool = ConnectionPool.getConnectionPool();
	private static final String SQL_SELECT_NUMBER_OF_PATIENTS = "select count(*) as 'numberOf' from patient as p where p.active=?;";
	//private static final String SQL_SELECT_NUMBER_OF_PREVIOUS_PATIENTS = "select count(*) from patient as p where p.active=0;";

	public Long selectNumberOfPatients(Boolean active){
		Long res = 0L;
		Connection conn = null;
		ResultSet rs = null;
		Object []values = new Object[] {active};
		
		try {
			conn = connectionPool.checkOut();
			PreparedStatement pre = DAOUtil.prepareStatement(conn, SQL_SELECT_NUMBER_OF_PATIENTS, false, values);
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
}
