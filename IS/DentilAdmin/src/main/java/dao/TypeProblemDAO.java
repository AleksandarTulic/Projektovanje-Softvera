package dao;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.util.ArrayList;
import java.util.List;
import java.util.logging.Level;

import dto.TypeProblemDTO;
import logger.MyLogger;

public class TypeProblemDAO {
	private static ConnectionPool connectionPool = ConnectionPool.getConnectionPool();
	private static final String SQL_SELECT_TYPE_PROBLEMS = "select * from typeproblem as t;";
	
	public List<TypeProblemDTO> select(){
		Connection conn = null;
		Object []values = new Object[] {};
		ResultSet rs = null;
		List<TypeProblemDTO> res = new ArrayList<>();
		
		try {
			conn = connectionPool.checkOut();
			PreparedStatement pre = DAOUtil.prepareStatement(conn, SQL_SELECT_TYPE_PROBLEMS, false, values);
			rs = pre.executeQuery();
			
			while (rs.next()) {
				res.add(new TypeProblemDTO(rs.getLong("id"), rs.getString("name")));
			}
		}catch (Exception e) {
			MyLogger.logger.log(Level.SEVERE, e.getMessage());
		}finally {
			connectionPool.checkIn(conn);
		}
		
		return res;
	}
}
