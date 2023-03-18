<jsp:include page="../../../index.jsp"></jsp:include>

<%@ page import="dto.*" %>
<%@ page import="java.util.List" %>
<jsp:useBean id='personalService' class='service.PersonalService' scope='application'></jsp:useBean> 

<%
	PersonalDTO dto = (PersonalDTO)request.getSession().getAttribute("aaaa");
%>

<div class="container">
	<div class="row">
		<div class="col-sm-4">
			<h3>View Personal Info</h3>
		</div>
		
		<div class="col-sm-8">
			&nbsp;
		</div>
	</div>
	<div class="row">
		<div class="col-sm-12">
			<div class="table-responsive" style="margin-top: 10px;">
		    	<table id="myTable1" class="table table-striped" style="text-align: center;">
		    		<tbody>
		    			<tr>
		    				<th style="text-align: center;">ID:</th>
		    				<%
		    				
		    					if (dto != null){
		    						out.println("<td id=\"idOfPersonalLogedIn\">" + dto.getId() + "</td>");
		    					}
		    				
		    				%>
		    			</tr>
		    			
		    			<tr>
		    				<th style="text-align: center;">Name:</th>
		    				<%
		    				
		    					if (dto != null){
		    						out.println("<td>" + dto.getName() + "</td>");
		    					}
		    				
		    				%>
		    			</tr>
		    			
		    			<tr>
		    				<th style="text-align: center;">Surname:</th>
		    				<%
		    				
		    					if (dto != null){
		    						out.println("<td>" + dto.getSurname() + "</td>");
		    					}
		    				
		    				%>
		    			</tr>
		    			
		    			<tr>
		    				<th style="text-align: center;">Email:</th>
		    				<%
		    				
		    					if (dto != null){
		    						out.println("<td>" + dto.getEmail() + "</td>");
		    					}
		    				
		    				%>
		    			</tr>
		    			
		    			<tr>
		    				<th style="text-align: center;">Phone:</th>
		    				<%
		    				
		    					if (dto != null){
		    						out.println("<td>" + dto.getPhone() + "</td>");
		    					}
		    				
		    				%>
		    			</tr>
		    			
		    			<tr>
		    				<th style="text-align: center;">Address:</th>
		    				<%
		    				
		    					if (dto != null){
		    						out.println("<td>" + dto.getAddress() + "</td>");
		    					}
		    				
		    				%>
		    			</tr>
		    			
		    			<tr>
		    				<th style="text-align: center;">Username:</th>
		    				<%
		    				
		    					if (dto != null){
		    						out.println("<td>" + dto.getUsername() + "</td>");
		    					}
		    				
		    				%>
		    			</tr>
		    			
		    			<tr>
		    				<th style="text-align: center;">JobStart:</th>
		    				<%
		    				
		    					if (dto != null){
		    						out.println("<td>" + dto.getJobStart() + "</td>");
		    					}
		    				
		    				%>
		    			</tr>
		    		</tbody>
	   			</table>
			</div>
		</div>
	</div>
	
	<div class="row">
		<div class="col-sm-4">
			<h3>View Schedule</h3>
		</div>
		
		<div class="col-sm-8">
			&nbsp;
		</div>
	</div>
	
	<div class="row">
		<div class="col-sm-12">
			<table id="myTable2" class="table table-striped" style="text-align: center;">
				<thead>
					<tr>
						<th class="hoverSortButton" onclick="sortTable(0)" style="text-align: center;">Date</th>
						<th class="hoverSortButton" onclick="sortTable(1)" style="text-align: center;">Shift</th>
					</tr>
				</thead>
	    		<tbody id="myTableBody">
	    		</tbody>
   			</table>
		</div>
		
		<div class="col-sm-12" style="text-align: center;" id="myPagination">
			<nav>
				<ul class="pagination">
				
					<li class="page-item disabled" id="previous"><a class="page-link" href="#" onclick="return getNext(this, -1, setTableValues, 'Data?what=getPersonalSchedule&id=' + document.getElementById('idOfPersonalLogedIn').innerHTML, 'Data?what=getNumberOfPersonalSchedule&id=' + document.getElementById('idOfPersonalLogedIn').innerHTML, 'date', 'asc')">Previous</a></li>
					<li class="page-item active"><a id="currPage" class="page-link" href="#">1</a></li>
					<li class="page-item" id="next"><a class="page-link" href="#" onclick="return getNext(this, 1, setTableValues, 'Data?what=getPersonalSchedule&id=' + document.getElementById('idOfPersonalLogedIn').innerHTML, 'Data?what=getNumberOfPersonalSchedule&id=' + document.getElementById('idOfPersonalLogedIn').innerHTML, 'date', 'asc')">Next</a></li>
				
				</ul>
			</nav>
		</div>
		
		<div class="col-sm-12" style="height: 200px;">
			&nbsp;
		</div>
	</div>
</div>

<script src="js/parameterConfig.js"></script>
<script src="js/pagination.js"></script>
<script src="js/personalInfo.js"></script>
<script src="js/personalInfoCall.js"></script>