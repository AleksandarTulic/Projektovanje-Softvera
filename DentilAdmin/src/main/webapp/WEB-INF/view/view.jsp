<jsp:useBean id='personalService' class='service.PersonalService' scope='application'></jsp:useBean>  
<jsp:useBean id='adminService' class='service.AdminService' scope='application'></jsp:useBean>  
<%@ page import="java.util.*" %>
<%@ page import="dto.*" %>

<%@ include file="../../index.jsp" %>

<script src="js/view.js"></script>
<!-- <script src="js/sortByTableColumns.js"></script> -->
<script src="js/sort.js"></script>
<script src="js/areYouSure.js"></script>
<link rel="stylesheet" href="css/view.css">

<%
	List<AdminDTO> arrAdmin = adminService.select();
	List<PersonalDTO> arrPersonal = personalService.selectWithoutSchedule();
%>

<div class="container">
	<%
	
		//System.out.println(session.getAttribute("message"));
		if (session.getAttribute("message")!=null){
			out.println("<div class=\"row\">");
			out.println("<div class=\"col-sm-1\">&nbsp;");
			out.println("</div>");
			
			out.println("<div class=\"col-sm-10\">");
				out.println("<div class=\"" + session.getAttribute("alertType") + "\">");
				out.println(session.getAttribute("message") + "</div>");
			out.println("</div>");
			
			out.println("<div class=\"col-sm-1\">&nbsp;");
			out.println("</div>");
			out.println("</div>");
		}
		
		session.setAttribute("message", null);
		session.setAttribute("alertType", null);
	
	%>
	<h2>View Users</h2>

	<div class="row">
		<div class="row" style="margin-right: 0px;margin-top: 15px;">
			<div class="col-sm-6 centerThem">
				<label id="labelSearchBy" class="centerThem">Search By</label>
				<input type="text" name="searchBy" id="searchBy" onkeyup="searchByInputValue(this.value)">
			</div>
			
			<div class="col-sm-4">
				&nbsp;
			</div>
			
			<div class="col-sm-2 centerThem" style="padding-right: 0px;text-align: right;">
				<input type="submit" class="btn normalButton" value="Add" data-toggle="modal" data-target="#myModal1">
			</div>
		</div>
		<div class="table-responsive" style="margin-top: 10px;">
	    	<table id="myTable" class="table table-striped">
	    		<thead>
	    			<tr>
	    				<th onclick="sortTable(0, 'myTable')">ID</th>
	    				<th onclick="sortTable(1, 'myTable')">Name</th>
	    				<th onclick="sortTable(2, 'myTable')">Surname</th>
	    				<th onclick="sortTable(3, 'myTable')">Role</th>
	    				<th>Update</th>
	    				<th>Delete</th>
	    			</tr>
	    		</thead>
	    		
	    		<tbody id="myTableBody">
	    			<%
	    			
	    				int counter = 0;
	    				for (AdminDTO i : arrAdmin){
	    					if (i.getUsername().equals(request.getRemoteUser())){
	    						out.println("<tr data-toggle=\"tooltip\" title=\"This is You!\" id=\"element_" + counter + "\" onclick=\"showMore(" + counter + ")\" class=\"paintInGrey danger\">");
	    					}else{
	    						out.println("<tr id=\"element_" + counter + "\" onclick=\"showMore(" + counter + ")\" class=\"paintInGrey\">");
	    					}
							out.println("<td>" + i.getId() + "</td>");
							out.println("<td>" + i.getName() + "</td>");
							out.println("<td>" + i.getSurname() + "</td>");
							out.println("<td>" + i.getRole_name() + "</td>");
							out.println("<td><a onclick=\"updateUserDefaultInput(" + counter + ")\" data-toggle=\"modal\" data-target=\"#myModal2\" href=\"#\" class=\"btn btn-warning\">Update</a></td>");
							out.println("<td><a onclick=\"return areYouSure()\" href=\"Delete?id=" + i.getId() + "&role_name=" + i.getRole_name() + "\" class=\"btn btn-danger\">Delete</a></td>");
							
							out.println("<tr class=\"child_" + counter + " paintInWhite\">");
								out.println("<td>&nbsp;</td>");
								out.println("<td>Email:</td>");
								out.println("<td>" + i.getEmail() + "</td>");
								out.println("<td>&nbsp;</td>");
								out.println("<td>&nbsp;</td>");
								out.println("<td>&nbsp;</td>");
							out.println("</tr>");
							
							out.println("<tr class=\"child_" + counter + " paintInWhite\">");
								out.println("<td>&nbsp;</td>");
								out.println("<td>Phone:</td>");
								out.println("<td>" + i.getPhone() + "</td>");
								out.println("<td>&nbsp;</td>");
								out.println("<td>&nbsp;</td>");
								out.println("<td>&nbsp;</td>");
							out.println("</tr>");
							
							out.println("<tr class=\"child_" + counter + " paintInWhite\">");
								out.println("<td>&nbsp;</td>");
								out.println("<td>Address:</td>");
								out.println("<td>" + i.getAddress() + "</td>");
								out.println("<td>&nbsp;</td>");
								out.println("<td>&nbsp;</td>");
								out.println("<td>&nbsp;</td>");
							out.println("</tr>");
							
							out.println("<tr class=\"child_" + counter + " paintInWhite\">");
								out.println("<td>&nbsp;</td>");
								out.println("<td>Username:</td>");
								out.println("<td>" + i.getUsername() + "</td>");
								out.println("<td>&nbsp;</td>");
								out.println("<td>&nbsp;</td>");
								out.println("<td>&nbsp;</td>");
							out.println("</tr>");
							
							counter++;
	    				}
	    			
	    				for (PersonalDTO i : arrPersonal){
	    					out.println("<tr onclick=\"showMore(" + counter + ")\" id=\"element_" + counter + "\" class=\"paintInGrey\">");
							out.println("<td>" + i.getId() + "</td>");
							out.println("<td>" + i.getName() + "</td>");
							out.println("<td>" + i.getSurname() + "</td>");
							out.println("<td>" + i.getRole_name() + "</td>");
							out.println("<td><a onclick=\"updateUserDefaultInput(" + counter + ")\" data-toggle=\"modal\" data-target=\"#myModal2\" href=\"#\" class=\"btn btn-warning\">Update</a></td>");
							out.println("<td><a onclick=\"return areYouSure()\" href=\"Delete?id=" + i.getId() + "&role_name=" + i.getRole_name() + "\" class=\"btn btn-danger\">Delete</a></td>");
	    					out.println("</tr>");
	    					
	    					out.println("<tr class=\"child_" + counter + " paintInWhite\">");
								out.println("<td>&nbsp;</td>");
								out.println("<td>Email:</td>");
								out.println("<td>" + i.getEmail() + "</td>");
								out.println("<td>&nbsp;</td>");
								out.println("<td>&nbsp;</td>");
								out.println("<td>&nbsp;</td>");
							out.println("</tr>");
						
							out.println("<tr class=\"child_" + counter + " paintInWhite\">");
								out.println("<td>&nbsp;</td>");
								out.println("<td>Phone:</td>");
								out.println("<td>" + i.getPhone() + "</td>");
								out.println("<td>&nbsp;</td>");
								out.println("<td>&nbsp;</td>");
								out.println("<td>&nbsp;</td>");
							out.println("</tr>");
						
							out.println("<tr class=\"child_" + counter + " paintInWhite\">");
								out.println("<td>&nbsp;</td>");
								out.println("<td>Address:</td>");
								out.println("<td>" + i.getAddress() + "</td>");
								out.println("<td>&nbsp;</td>");
								out.println("<td>&nbsp;</td>");
								out.println("<td>&nbsp;</td>");
							out.println("</tr>");
							
							out.println("<tr class=\"child_" + counter + " paintInWhite\">");
								out.println("<td>&nbsp;</td>");
								out.println("<td>Username:</td>");
								out.println("<td>" + i.getUsername() + "</td>");
								out.println("<td>&nbsp;</td>");
								out.println("<td>&nbsp;</td>");
								out.println("<td>&nbsp;</td>");
							out.println("</tr>");
							
							out.println("<tr class=\"child_" + counter + " paintInWhite\">");
								out.println("<td>&nbsp;</td>");
								out.println("<td>Job Start:</td>");
								out.println("<td>" + i.getJobStart() + "</td>");
								out.println("<td>&nbsp;</td>");
								out.println("<td>&nbsp;</td>");
								out.println("<td>&nbsp;</td>");
							out.println("</tr>");
							
							out.println("<tr class=\"child_" + counter + " paintInWhite\">");
								out.println("<td>&nbsp;</td>");
								out.println("<td>Job End:</td>");
								out.println("<td>" + (i.getJobEnd() == null ? "" : i.getJobEnd()) + "</td>");
								out.println("<td>&nbsp;</td>");
								out.println("<td>&nbsp;</td>");
								out.println("<td>&nbsp;</td>");
							out.println("</tr>");
	    					
	    					counter++;
	    				}
	    			
	    			%>
	    		</tbody>
	    	</table>
    		
	    	<div class="col-md-12 text-center">
	           <ul class="pagination pagination-lg pager" id="myPager"></ul>
	        </div>
	        
	        <div class="col-sm-3">
    			<label>How many</label>
   				<input onchange="changePerPage(this.value)" type="number" id="perPageIDView" value="8" style="max-width: 40px" min="4" max="20">
    		</div>
	        <div class="col-sm-9">
	        	&nbsp;
    		</div>
	       
	        <script>
	       		$('#myTableBody').pageMe({pagerSelector:'#myPager',showPrevNext:true,hidePageNumbers:false,perPage:8});
	       	</script>
	    	
	    	<script>
	    		function showMore(someClassName){
	    			var elements = document.getElementsByClassName("child_" + someClassName);
	    			for (let i=0; i<elements.length;i++){
	    				if (elements[i].hidden == true){
	    					elements[i].removeAttribute("hidden");
	    				}else{
	    					elements[i].setAttribute("hidden", "");
	    				}
	    			}
	    		}
	    		
	    		var arrPaintInWhite = document.getElementsByClassName("paintInWhite");
	    		for (let i=0;i<arrPaintInWhite.length;i++){
	    			if (typeof arrPaintInWhite[i] !== "undefined")
	    				arrPaintInWhite[i].style.backgroundColor = "white";
	    			arrPaintInWhite[i].setAttribute("hidden", "");
	    		}
	    		
	    		var arrPaintInGrey = document.getElementsByClassName("paintInGrey");
	    		for (let i=0;i<arrPaintInWhite.length;i++){
	    			if (typeof arrPaintInGrey[i] !== "undefined")
	    				arrPaintInGrey[i].style.backgroundColor = "#f9f9f9";
	    		}
	    		
	    		$(document).ready(function(){
	    			  $('[data-toggle="tooltip"]').tooltip();   
    			});
	    	</script>
	    	
	    	<script src="js/changePerPage.js"></script>
		</div>
	</div>
</div>

<%@ include file="../insert/insert.jsp" %>
<%@ include file="../update/update.jsp" %>