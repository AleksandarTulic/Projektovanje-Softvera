package other;

import jakarta.servlet.http.HttpServletRequest;
import jakarta.servlet.http.HttpSession;

public class Notification {
	public static String getMessage(boolean flag) {
		return flag ? "Operation Successful" : "Operation Failed";
	}
	
	public static String getAlert(boolean flag) {
		return flag ? "alert alert-success" : "alert alert-danger";
	}
	
	public static void setMessage(HttpServletRequest request, boolean flag) {
		HttpSession session = request.getSession();
		session.setAttribute("message", Notification.getMessage(flag));
		session.setAttribute("alertType", Notification.getAlert(flag));
	}
}
