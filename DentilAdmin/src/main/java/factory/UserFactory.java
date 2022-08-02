package factory;

import dto.*;
import jakarta.servlet.http.HttpServletRequest;

public abstract class UserFactory {
	public abstract UserDTO get(HttpServletRequest request);
}
