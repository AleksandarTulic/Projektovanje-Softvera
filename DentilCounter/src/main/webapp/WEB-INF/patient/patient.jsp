<%@ include file="../../index.jsp" %>

<jsp:useBean id='patientService' class='service.PatientService' scope='application'></jsp:useBean>  
<%@ page import="java.util.*" %>
<%@ page import="dto.*" %>


<%
	List<PatientDTO> arrPatient = patientService.select();
%>

<div class="container">
	<div class="row">
		<div class="row">
			<div class="col-sm-12" id="messagePatient">
				
			</div>
		</div>
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
	    				<th class="hoverSortButton" onclick="sortTable(0, 'myTable')">ID</th>
	    				<th class="hoverSortButton" onclick="sortTable(1, 'myTable')">Name</th>
	    				<th class="hoverSortButton" onclick="sortTable(2, 'myTable')">Surname</th>
	    				<th>Update</th>
	    				<th>Delete</th>
	    			</tr>
	    		</thead>
	    		
	    		<tbody id="myTableBody">
	    			<%
	    			
	    				int counter = 0;
	    				for (PatientDTO i : arrPatient){
	    					if ( i== null){
	    						continue;
	    					}
    						out.println("<tr id=\"element_" + counter + "\" onclick=\"showMore(" + counter + ")\" class=\"paintInGrey\">");
							out.println("<td>" + i.getId() + "</td>");
							out.println("<td>" + i.getName() + "</td>");
							out.println("<td>" + i.getSurname() + "</td>");
							out.println("<td><a onclick=\"updateUserDefaultInput(" + counter + ")\" data-toggle=\"modal\" data-target=\"#myModal2\" href=\"#\" class=\"btn btn-warning\">Update</a></td>");
							out.println("<td><button onclick=\"areYouSureDeletePatient(" + i.getId() + ", " + counter + ")\" class=\"btn btn-danger\">Delete</button></td>");
							
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
							
							counter++;
	    				}
	    			
	    			%>
	    		</tbody>
	    	</table>
	    	
	    	<div class="col-sm-12" style="text-align: center;">
	    		<ul class="pagination pagination-lg pager" id="myPager"></ul>
	    	</div>
	    	
	    	<script>
	       		$('#myTableBody').pageMe({pagerSelector:'#myPager',showPrevNext:true,hidePageNumbers:false,perPage:8});
	       	</script>
		</div>
	</div>
</div>

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
	
	function paintWhite(){
		var arrPaintInWhite = document.getElementsByClassName("paintInWhite");
		for (let i=0;i<arrPaintInWhite.length;i++){
			if (typeof arrPaintInWhite[i] !== "undefined")
				arrPaintInWhite[i].style.backgroundColor = "white";
			arrPaintInWhite[i].setAttribute("hidden", "");
		}
	}
	
	function paintGrey(){
		var arrPaintInWhite = document.getElementsByClassName("paintInWhite");
		var arrPaintInGrey = document.getElementsByClassName("paintInGrey");
		for (let i=0;i<arrPaintInWhite.length;i++){
			if (typeof arrPaintInGrey[i] !== "undefined")
				arrPaintInGrey[i].style.backgroundColor = "#f9f9f9";
		}
	}
	
	paintGrey();
	paintWhite();
	
	function reset(){
		document.getElementById("updateEmail").value = "";
		document.getElementById("updatePhone").value = "";
		document.getElementById("updateAddress").value = "";
		document.getElementById("updateName").value = "";
		document.getElementById("updateID").value = "";
		document.getElementById("updateSurname").value = "";
		document.getElementById("updateOldID").value = "";
	}
</script>

<script src="js/sort.js"></script>
<script src="js/pagination.js"></script>
<script src="js/areYouSure.js"></script>
<script src="js/searchByInputValue.js"></script>
<script src="js/updateUserDefaultInput.js"></script>

<%@ include file="update.jsp" %>
<%@ include file="insert.jsp" %>