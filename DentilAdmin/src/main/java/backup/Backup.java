package backup;

import java.io.File;
import java.util.logging.Level;
import java.util.Date;
import logger.MyLogger;

public class Backup implements Runnable{
	private static final String SAVE_PATH = System.getProperty("catalina.home") 
			+ File.separator + "Dentil" + File.separator + "Backup";
	private static final String DB_NAME = "dentil";
	private static final String DB_USER = "root";
	
	@SuppressWarnings("deprecation")
	@Override
	public void run() {
		try {
			Date date = new Date(System.currentTimeMillis());
			String []query = new String[] {"cmd.exe", "/c", 
					"mysqldump --defaults-extra-file=" + SAVE_PATH + File.separator + "password.txt -u " + DB_USER + " --databases " + DB_NAME + " > " + SAVE_PATH + File.separator + (date.getYear() + 1900) + "-" + (date.getMonth() + 1) + "-" + date.getDate() + "_" + date.getHours() + "-" + date.getMinutes() + "-" + date.getSeconds() + ".sql"};

			Process runtimeProcess = Runtime.getRuntime().exec(query);
			
			if (runtimeProcess.waitFor() == 1) {
				MyLogger.logger.log(Level.WARNING, "Problem with database backup.");
			}
		}catch (Exception e) {
			MyLogger.logger.log(Level.SEVERE, e.getMessage());
		}
	}
}
