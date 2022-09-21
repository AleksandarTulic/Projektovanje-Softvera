<jsp:useBean id='personalService' class='service.PersonalService' scope='application'></jsp:useBean>  
<jsp:useBean id='shiftService' class='service.ShiftService' scope='application'></jsp:useBean>  
<%@ page import="java.util.*" %>
<%@ page import="dto.*" %>

<%@ include file="../../index.jsp" %>
<script src="js/schedule.js"></script>
<script src="js/sortByTableColumns.js"></script>
<link rel="stylesheet" href="css/schedule.css">

<%
	List<PersonalDTO> arr = personalService.select();
	List<PersonalDTO> arrPersonal = personalService.selectWithoutSchedule();
	List<ShiftDTO> arrShift =  shiftService.select();
%>

<div class="container">
  <% 
  
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
  <h2>Schedule</h2>

  <ul class="nav nav-tabs">
    <li><a data-toggle="tab" href="#menu1">View Schedule</a></li>
    <li><a data-toggle="tab" href="#menu2">Add Schedule</a></li>
    <li><a data-toggle="tab" href="#menu3">Shift</a></li>
  </ul>

  <div class="tab-content">
    <div id="menu1" class="tab-pane fade">
   		<form action="ScheduleController?what=deleteSchedule" method="POST">
	   		<div class="container" style="padding: 0px;">
	   			<div class="row">
	      			<div class="col-sm-2" style="margin-top: 15px;">
	      				<h4 style="margin-top: 15px;display: inline;">View Schedule</h4>
	      			</div>
	      			
	      			<div class="col-sm-8">&nbsp;</div>
	      			
	      			<div class="col-sm-2" style="margin-top: 10px;">
	      				<input id="DeleteSchedule" class="btn" type="submit" value="Delete" style="margin-top: 8px;">
	      			</div>
	      		</div>
	      	</div>
	      	
	      	<div class="table-responsive" style="margin-top: 15px;">
		    	<table id="myTable" class="table table-striped">
		    	<thead>
				  <tr>
				   <!--When a header is clicked, run the sortTable function, with a parameter, 0 for sorting by names, 1 for sorting by country:-->  
				    <th onclick="sortTable(0, 'myTable')">Name</th>
				    <th onclick="sortTable(1, 'myTable')">Role</th>
				    <th onclick="sortTable(2, 'myTable')">Date</th>
				    <th onclick="sortTable(3, 'myTable')">Shift</th>
				    <th>Select For Delete</th>
				  </tr>
				  </thead>
				  
				  <tbody id="myTableBody">
				  <%
				  	  int counter = 0;
					  for (PersonalDTO dto : arr){
					    out.println("<tr>");
					    out.println("<td>" + dto.getName() + " " + dto.getSurname() + "</td>");
					    out.println("<td>" + dto.getRole_name() + "</td>");
					    out.println("<td>" + dto.getSchedule().getDate() + "</td>");
					    out.println("<td>" + dto.getShift().getBegin() + " - " + dto.getShift().getEnd() + "</td>");
					    out.println("<td><input class=\"checkThemAll\" type=\"checkbox\" name=\"check_" + counter++ + "\" value=\"" + dto.getId() + "_" + dto.getShift().getId() + "_" + dto.getSchedule().getDate() + "\"></td>");
					    out.println("</tr>");
					  }
				  %>
				  </tbody>
				</table>
				
				<div class="col-md-12 text-center">
		           <ul class="pagination pagination-lg pager" id="myPager"></ul>
		       </div>
		       
		       <script>
		       		$('#myTableBody').pageMe({pagerSelector:'#myPager',showPrevNext:true,hidePageNumbers:false,perPage:8});
		       	</script>
			</div>
			
			<div class="container" style="padding: 0px;">
	   			<div class="row">
	      			<div class="centerThem col-sm-3">
	      				<label>How many</label>
	      				<input onchange="changePerPage(this.value)" type="number" value="8" style="max-width: 40px" min="4" max="20">
	      			</div>
	      			
	      			<div class="col-sm-7">&nbsp;</div>
	      			
	      			<div class="centerThem col-sm-2" style="padding-left: 0px;padding-right: 35px;">
	      				<label style="padding-bottom: 10px;">Select All</label>
	      				<input type="checkbox" id="checkThemAllID" onclick="checkThemAll()" style="margin-top: 0px;">
	      			</div>
	      		</div>
	      	</div>
		</form>
		
		<script>
			function checkThemAll(){
				var elements = document.getElementsByClassName("checkThemAll");
				var flag = document.getElementById("checkThemAllID").checked;

				for (let i=0; i<elements.length;i++){
					elements[i].checked = flag ? true : false;
				}
			}
			
			function changePerPage(element){
				$('#myTableBody').pageMe({pagerSelector:'#myPager',showPrevNext:true,hidePageNumbers:false,perPage:element});
			}
		</script>
    </div>
    
    <div id="menu2" class="tab-pane fade">
      	<h4 style="margin-top: 15px;">Add Schedule</h4>
      	<form action="ScheduleController?what=addSchedule" method="POST">
    	<div class="container">
			<div class="row">
				<div class="col-sm-6" style="padding-left: 0px !important;">
					<div class="table-responsive" style="margin-top: 10px;">
						<table class="table table-striped" id="myTable1">
							<tr>
								<th onclick="sortTable(0, 'myTable1')">Name</th>
								<th>Select</th>
							</tr>
							
							<%
							
								for (PersonalDTO dto : arrPersonal){
									out.println("<tr>");
								    out.println("<td>" + dto.getName() + " " + dto.getSurname() + "</td>");
								    out.println("<td><input type=\"checkbox\" name=\"check_" + dto.getId() + "\" value=\"" + dto.getId() + "\"></td>");
								    out.println("</tr>");
								}
							
							%>
						</table>
					</div>
				</div>
				<div class="col-sm-6" style="margin-top: -10px;">
					<div class="form-group">
						  <label for="date">Date:</label>
					      <input required type="date" class="form-control" id="date" name="date">
					</div>
					
					<div class="form-group">
						<label for="shift">Shift:</label>
						<select required class="form-control" name="idShift" id="idShift">
							<%
								for (ShiftDTO dto : arrShift){
									out.println("<option value=\"" + dto.getId() + "\">");
									out.println(dto.getBegin() + " - " + dto.getEnd());
									out.println("</option>");
								}
							%>
						</select>
					</div>
				</div>
				
				<div class="col-sm-12 text-center">
					<input type="submit" id="AddSchedule" class="btn" value="Add">
				</div>
			</div>
		</div>
		</form>
    </div>
    
    <div id="menu3" class="tab-pane fade">
    	<div class="container" style="margin-top: 20px;padding-left: 0px;margin-left: 0px;">
	    		<div class="row">
	    			<div class="col-sm-6">
	    				<h4>Add Shift</h4>
			    		<form action="Shift?what=shiftAdd" method="POST" style="margin-top: 15px;">
			    			<div class="col-sm-12">
			    				<div class="form-group">
			    					<label for="date">Begin:</label>
			    					<input required type="time" class="form-control" id="begin" name="begin">
			    				</div>
			    			</div>
			    			
			    			<div class="col-sm-12">
			    				<div class="form-group">
			    					<label for="date">End:</label>
			    					<input required type="time" class="form-control" id="end" name="end">
			    				</div>
			    			</div>
			    			
			    			<div class="col-sm-12 text-center">
			    				<input type="submit" id="AddShift" class="btn" value="Add">
			    			</div>
		    			</form>
    				</div>
    				
    				<div class="col-sm-6">
    					<h4>Delete Shift</h4>
    					
    					<form onsubmit="return areYouSure()" action="Shift?what=shiftDelete" method="POST">
    						<div class="col-sm-12">
    							<div class="form-group">
    								<label for="shift">Shift:</label>
									<select required class="form-control" name="idShift" id="idShift">
										<%
											for (ShiftDTO dto : arrShift){
												out.println("<option value=\"" + dto.getId() + "\">");
												out.println(dto.getBegin() + " - " + dto.getEnd());
												out.println("</option>");
											}
										%>
									</select>
								</div>
    						</div>
    						
    						<div class="col-sm-12 text-center">
    							<input type="submit" id="DeleteShift" class="btn" value="Delete">
    						</div>
    					</form>
    					
    					<script>
							function areYouSure(){
								if (confirm("Are you sure?") == true){
									return true;
								}else{
									return false;
								}
							}
						</script>
    				</div>
	    		</div>
    	</div>
    </div>
  </div>
</div>