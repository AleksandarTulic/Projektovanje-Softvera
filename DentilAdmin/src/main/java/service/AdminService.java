package service;

import java.io.File;
import java.util.List;

import dao.AdminDAO;
import dto.AdminDTO;
import security.QR;

public class AdminService extends UserService{
	private AdminDAO dao = new AdminDAO();
	private EmailService email = new EmailService();
	private ScheduleService scheduleService = new ScheduleService();
	private QR qr = new QR();
	
	public boolean insert(AdminDTO dto) {
		boolean flag1 = super.insert(dto);
		String value = null;
		boolean flag2 = false;
		
		if (flag1) {
			value = qr.generateQR(dto.getId());
			dto.setSecretKey(value);
			
			flag2 = dao.insert(dto);
		}
		
		if (flag1 && flag2 && value != null) {
			email.send(dto.getEmail(), 
				System.getProperty("catalina.home") 
				+ File.separator + "Dentil" 
				+ File.separator + "qr" 
				+ File.separator + dto.getId() + ".png");
		
			return true;
		}
		
		return false;
	}
	
	public boolean update(AdminDTO dto, String oldID) {
		return super.update(dto, oldID);
	}
	
	public boolean delete(String id) {
		scheduleService.deleteScheduleWithIdAdmin(id);
		dao.delete(id);
		boolean flag = super.delete(id);
		
		return flag;
	}
	
	public List<AdminDTO> select(){
		return dao.select();
	}
	
	public AdminDTO selectAdminWithUsername(String username) {
		return dao.selectAdminWithUsername(username);
	}
}
