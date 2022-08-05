<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
    pageEncoding="ISO-8859-1"%>
<!DOCTYPE html>
<html>
	<head>
		<meta charset="ISO-8859-1">
		<title>Dentil</title>
	</head>
	<body>
		<h2>INSERT APPOINTMENT</h2>
		<form action="Operation?what=insertAppointment&operation=do" method="POST">
			Id Dentist: <input type="text" name="idDentist" pattern="^[0-9]{13}$"><br>
			Start Date: <input type="date" name="startDate" required pattern="\d{4}-\d{2}-\d{2}"><br>
			Start Time: <input type="time" name="startTime"><br>
			Id Patient: <input type="text" name="idPatient" pattern="^[0-9]{13}$"><br>
			How Long: <input type="number" name="howLong" max="1000" min="15"><br>
			Id Personal: <input type="text" name="idPersonal" pattern="^[0-9]{13}$">
			<input type="submit" value="INSERT">
		</form>
	</body>
</html>