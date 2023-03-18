package factory;

import java.sql.ResultSet;
import java.sql.ResultSetMetaData;
import java.util.*;
import java.util.logging.Level;

import dto.*;
import jakarta.servlet.http.HttpServletRequest;
import logger.MyLogger;
import validation.*;

public class UserFactory {
	private static UserFactory uFactory = new UserFactory();
	protected List<IValidation> arrValidation = new ArrayList<IValidation>();
	protected static final String SQL_ACTIVE = "1";
	private static List<String> headers = Arrays.asList("id", "name", "surname", "address", "phone", 
			"email", "username", "password", "role_name", "jobStart", "jobEnd", "secretKey", "idShift", "begin", 
			"end", "date", "idAdmin", "active");
	//Arrays.asList(new ValidationLength(), new ValidationRegex());
	
	public static UserFactory getInstance() {
		return uFactory;
	}
	
	public UserDTO get(HttpServletRequest request) {
		return null;
	}
	
	public UserDTO get(ResultSet rs) {
		List<String> arr = getElements(rs);
		
		try {
			return new UserDTO(arr.get(0), arr.get(1), arr.get(2),
					arr.get(3), arr.get(4), arr.get(5),
					arr.get(6), arr.get(7), arr.get(8));
		}catch (Exception e) {
			MyLogger.logger.log(Level.SEVERE, e.getMessage());
		}
		
		return null;
	}
	
	protected boolean check(UserDTO dto) {
		for (IValidation i : arrValidation) {
			if (!i.check(dto)) {
				return false;
			}
		}
		
		return true;
	}
	
	protected List<String> getElements(HttpServletRequest request){
		List<String> arr = new ArrayList<String>();
		arr.add(request.getParameter("id"));
		arr.add(request.getParameter("name"));
		arr.add(request.getParameter("surname"));
		arr.add(request.getParameter("address"));
		arr.add(request.getParameter("phone"));
		arr.add(request.getParameter("email"));
		arr.add(request.getParameter("username"));
		arr.add(request.getParameter("password"));
		arr.add(request.getParameter("role_name"));
		arr.add(request.getParameter("jobStart"));
		arr.add(request.getParameter("jobEnd"));
		arr.add(request.getParameter("secretKey"));
		
		return arr;
	}
	
	protected List<String> getElements(ResultSet rs){
		List<String> arr = new ArrayList<String>();
		try {
			ResultSetMetaData rsmd = rs.getMetaData();
			List<String> columnNames = new ArrayList<>();
			for (int i=1;i<=rsmd.getColumnCount();i++)
				columnNames.add(rsmd.getColumnLabel(i));
			
			for (String i : headers) {
				arr.add(columnNames.contains(i) ? rs.getString(i) : null);
			}
			
		}catch (Exception e) {
			MyLogger.logger.log(Level.SEVERE, e.getMessage());
		}
		
		return arr;
	}
}
