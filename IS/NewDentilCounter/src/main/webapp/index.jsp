<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
    pageEncoding="ISO-8859-1"%>

<%@ page import="dto.AppointmentDTO" %>
<%@ page import="java.util.*" %>
<%@ page import="java.sql.Time" %>

<jsp:useBean id='personalService' class='service.PersonalService' scope='application'></jsp:useBean>
<%@ page import="dto.*" %>

<!DOCTYPE html>
<html>
	<jsp:include page="/WEB-INF/pages/common/commonOther.jsp"></jsp:include>
	
	<body>
		<%@ include file="/WEB-INF/pages/common/header.jsp" %>
	</body>
</html>

<% 

PersonalDTO dto = (PersonalDTO)request.getSession().getAttribute("aaaa");
if (dto == null){
	dto = personalService.select(request.getRemoteUser());
	request.getSession().setAttribute("aaaa", dto);
}
	    					
%>