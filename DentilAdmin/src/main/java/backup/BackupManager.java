package backup;

import java.util.concurrent.Executors;
import java.util.concurrent.ScheduledExecutorService;
import java.util.concurrent.TimeUnit;
import jakarta.servlet.annotation.WebListener;
import jakarta.servlet.ServletContextEvent;
import jakarta.servlet.ServletContextListener;

@WebListener
public class BackupManager implements ServletContextListener {
	private ScheduledExecutorService scheduler;
	
	@Override
	public void contextInitialized(ServletContextEvent event) {
		scheduler = Executors.newSingleThreadScheduledExecutor();
		scheduler.scheduleAtFixedRate(new Backup(), 0, 7, TimeUnit.DAYS);
	}
	
	@Override
	public void contextDestroyed(ServletContextEvent event) {
		scheduler.shutdownNow();
	}
}
