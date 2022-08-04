package service;

import java.io.File;
import dao.AdminDAO;
import dto.AdminDTO;
import security.QR;

public class AdminService {
	private AdminDAO dao = new AdminDAO();
	private UserService service = UserService.getInstance();
	private EmailService email = new EmailService();
	private QR qr = new QR();
	
	public boolean insert(AdminDTO dto) {
		boolean flag1 = service.insert(dto);
		String value = null;
		boolean flag2 = false;
		
		if (flag1) {
			value = qr.generateQR(dto.getId());
			dto.setSecretKey(value);
			System.out.println("Secret Key: " + value);
			
			flag2 = dao.insert(dto);
		}
		
		if (flag1 && flag2 && value != null) {
			email.send("", 
				System.getProperty("catalina.home") 
				+ File.separator + "Dentil" 
				+ File.separator + "qr" 
				+ File.separator + dto.getId() + ".png");
		
			return true;
		}
		
		return false;
	}
	
	public boolean update(AdminDTO dto, String oldID) {
		return service.update(dto, oldID);
	}
	
	public boolean delete(String id) {
		boolean flag1 = dao.delete(id);
		boolean flag2 = false;
		
		if (flag1) {
			flag2 = service.delete(id);
		}
		
		return flag1 && flag2;
	}
}
