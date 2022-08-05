<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
    pageEncoding="ISO-8859-1"%>

<%@ page import="dto.AppointmentDTO" %>
<%@ page import="java.util.*" %>
<%@ page import="java.sql.Time" %>

<!DOCTYPE html>
<html>
	<head>
		<meta charset="ISO-8859-1">
		<title>Dentil</title>
	</head>
	
	<body>
		<h2>INDEX</h2>
		<a href="Operation?what=insertPatient">INSERT PATIENT</a><br><br>
		<a href="Operation?what=insertAppointment">INSERT APPOINTMENT</a><br><br>
		<a href="Operation?what=updatePatient">UPDATE Patient</a><br><br>
		<a href="Operation?what=updateAppointment">UPDATE APPOINTMENT</a><br><br>
	</body>
	
	<%
	
		List<AppointmentDTO> arr = Arrays.asList(
				new AppointmentDTO("", null, Time.valueOf("10:15:00"), "", 30, ""),
				new AppointmentDTO("", null, Time.valueOf("11:00:00"), "", 45, ""),
				new AppointmentDTO("", null, Time.valueOf("14:15:00"), "", 120, ""),
				new AppointmentDTO("", null, Time.valueOf("16:45:00"), "", 15, ""),
				new AppointmentDTO("", null, Time.valueOf("20:45:00"), "", 30, "")
				);
	
	%>
</html>