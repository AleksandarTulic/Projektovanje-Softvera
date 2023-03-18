package controller;

import jakarta.servlet.ServletException;
import jakarta.servlet.annotation.WebServlet;
import jakarta.servlet.http.HttpServlet;
import jakarta.servlet.http.HttpServletRequest;
import jakarta.servlet.http.HttpServletResponse;
import logger.MyLogger;
import service.StatisticsService;

import java.io.IOException;
import java.util.logging.Level;

import com.google.gson.Gson;

@WebServlet("/Statistics")
public class StatisticsController extends HttpServlet {
	private static final long serialVersionUID = 1L;
	private static final StatisticsService statisticsService = new StatisticsService();
       
    public StatisticsController() {
        super();
    }

	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
	}

	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		String what = request.getParameter("what");
		String json = "";
			
		if ("getNumberOfDentists".equals(what)) {
			json = new Gson().toJson(statisticsService.getNumberOfDentists());
		}else if ("getNumberOfPersonal".equals(what)) {
			json = new Gson().toJson(statisticsService.getNumberOfPersonal());
		}else if ("getNumberOfPatients".equals(what)) {
			json = new Gson().toJson(statisticsService.getNumberOfPatients());
		}else if ("selectDentistEarned".equals(what)) {
			json = new Gson().toJson(statisticsService.selectDentistEarned());
		}else if ("selectTypeProblemsEncountered".equals(what)) {
			Long id = 0L;
			
			try {
				id = Long.parseLong(request.getParameter("id"));
			}catch (Exception e) {
				MyLogger.logger.log(Level.SEVERE, e.getMessage());
			}
			
			json = new Gson().toJson(statisticsService.selectTypeProblemsEncountered(id));
		}else if ("selectVisitServicesEncountered".equals(what)) {
			Long id = 0L;
			
			try {
				id = Long.parseLong(request.getParameter("id"));
			}catch (Exception e) {
				MyLogger.logger.log(Level.SEVERE, e.getMessage());
			}
			
			json = new Gson().toJson(statisticsService.selectVisitServicesEncountered(id));
		}else if ("selectEmployed".equals(what)) {
			json = new Gson().toJson(statisticsService.selectEmployed());
		}else if ("selectUnemployed".equals(what)) {

			json = new Gson().toJson(statisticsService.selectUnemployed());
		}
		
		response.setContentType("application/json");
		response.setCharacterEncoding("UTF-8");
		response.getWriter().write(json);
	}

}
