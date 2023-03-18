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

		<link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css">
		
		<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css">
  		<script src="https://ajax.googleapis.com/ajax/libs/jquery/3.6.0/jquery.min.js"></script>
  		<script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js"></script>
		
		<title>Dentil Admin</title>
	</head>
	<body>
		<div class="container">
			<div class="row">
				<div class="col-sm-2">
				</div>
				<div class="col-sm-8" style="text-align:center;">
					<h2>Failed Login</h2>

					<a class="btn btn-default" href="login.jsp">Return &gt;&gt;&gt;</a>
				</div>
				<div class="col-sm-2">
				</div>
			</div>
		</div> 
	</body>
</html>