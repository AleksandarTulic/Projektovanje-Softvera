<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
    pageEncoding="ISO-8859-1"%>

<%

	HttpSession se = request.getSession();
	if (se.getAttribute("aaaa") != null){
		response.sendRedirect("index.jsp");
	}

%>

<!DOCTYPE html>
<html>
	<head>
		<meta charset="ISO-8859-1">
		<meta name="viewport" content="width=device-width, initial-scale=1.0">
		
		<title>Dentil Admin</title>
	</head>
	<body>
		<p>Oooppps something happened ...</p>
	</body>
</html>