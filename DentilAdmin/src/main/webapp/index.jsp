<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
    pageEncoding="ISO-8859-1"%>
<!DOCTYPE html>
<html>
	<head>
		<meta charset="ISO-8859-1">
		<title>Dentil</title>
	</head>
	<body>
		<h2>Login</h2>
		<form name="loginForm" method="POST" action="Controller">
			<p>Username: <input type="text" name="j_username" class="form-control"/></p>
			<p>Password: <input type="password" class="form-control" name="j_password"/></p>
			<p>  <input type="submit" value="Login"/></p>
		</form>
	</body>
</html>