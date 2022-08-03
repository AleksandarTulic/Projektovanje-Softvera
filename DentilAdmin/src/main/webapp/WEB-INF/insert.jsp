<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
    pageEncoding="ISO-8859-1"%>
<!DOCTYPE html>
<html>
	<head>
		<meta charset="ISO-8859-1">
		<title>Dentil</title>
	</head>
	<body>
		<h2>Insert</h2>
		<form action="Operation?what=insert&operation=do" method="POST">
			<input type="text" name="id" maxlength="13" pattern="[0-9]{13}">
			<input type="text" name="name" maxlength="100" pattern="[a-zA-Z]{2,}">
			<input type="text" name="surname" maxlength="100" pattern="[a-zA-Z]{2,}">
			<input type="text" name="email" maxlength="100" pattern="^([a-zA-Z0-9_\-\.]+)@([a-zA-Z0-9_\-\.]+)\.([a-zA-Z]{2,5})$">
			<input type="text" name="phone" maxlength="100" pattern="[0-9]{2,}">
			<input type="text" name="address" maxlength="100" pattern="[a-zA-Z0-9\s]{2,}">
			<input type="text" name="username" maxlength="100" pattern=".{2,}">
			<input type="text" name="password" maxlength="100" pattern=".{6, 30}">
			<input type="text" name="role_name"  maxlength="100">
			<input type="submit" value="Input">
		</form>
	</body>
</html>