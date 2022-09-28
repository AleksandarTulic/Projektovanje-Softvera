package dao;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.util.logging.Level;

import logger.MyLogger;

public class VisitTreatmentDAO {
	private static ConnectionPool connectionPool = ConnectionPool.getConnectionPool();
	private static final String SQL_DELETE_WITH_IDPATIENT = "delete from VisitTreatment as v where v.idVisit in (select id from visit as vi where vi.idPatient=?)";
	
	public boolean deleteWithIdPatient(String id) {
		boolean res = false;
		Connection conn = null;
		Object []values = new Object[] {id};
		
		try {
			conn = connectionPool.checkOut();
			PreparedStatement pre = DAOUtil.prepareStatement(conn, SQL_DELETE_WITH_IDPATIENT, false, values);
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
