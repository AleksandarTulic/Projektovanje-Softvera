<%

	HttpSession se = request.getSession();
	if (se.getAttribute("aaaa") != null){
		response.sendRedirect("index.jsp");
	}

%>