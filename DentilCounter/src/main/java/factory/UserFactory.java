package factory;

import java.sql.ResultSet;
import java.sql.ResultSetMetaData;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;
import dto.UserDTO;
import jakarta.servlet.http.HttpServletRequest;

public abstract class UserFactory {
	private static List<String> headers = Arrays.asList("id", "name", "surname", "address", "phone", 
			"email", "username", "password", "role_name", "jobStart", "jobEnd", "secretKey", "idShift", "begin", 
			"end", "date", "idAdmin");
	
	public abstract UserDTO get(HttpServletRequest request);
	public abstract UserDTO get(ResultSet rs);
	
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
			e.printStackTrace();
		}
		
		return arr;
	}
}
