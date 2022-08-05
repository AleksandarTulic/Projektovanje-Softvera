<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
    pageEncoding="ISO-8859-1"%>
<!DOCTYPE html>
<html>
	<head>
		<meta charset="ISO-8859-1">
		<title>Dentil</title>
	</head>
	<body>
		<h2>UPDATE APPOINTMENT</h2>
		<form action="Operation?what=updatePatient&operation=do&oldID=4444444444444" method="POST">
			ID: <input type="text" name="id" maxlength="13" pattern="[0-9]{13}"><br>
			NAME: <input type="text" name="name" maxlength="100" pattern="[a-zA-Z]{2,}"><br>
			SURNAME: <input type="text" name="surname" maxlength="100" pattern="[a-zA-Z]{2,}"><br>
			EMAIL: <input type="text" name="email" maxlength="100" pattern="^([a-zA-Z0-9_\-\.]+)@([a-zA-Z0-9_\-\.]+)\.([a-zA-Z]{2,5})$"><br>
			PHONE: <input type="text" name="phone" maxlength="100" pattern="[0-9]{2,}"><br>
			TEXT: <input type="text" name="address" maxlength="100" pattern="[a-zA-Z0-9\s]{2,}"><br>
			<input type="submit" value="INSERT">
		</form>
	</body>
</html>