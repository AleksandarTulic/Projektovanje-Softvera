<%@ include file="../../../index.jsp" %>

<%@ page import="dto.*" %>

<div class="container">
	<ul class="nav nav-tabs">
	    <li><a data-toggle="tab" href="#menu1">View Appointments</a></li>
	    <li><a data-toggle="tab" href="#menu2">Add Appointment</a></li>
  	</ul>
  	
	<div class="tab-content">
    	<!-- TAB 1 -->
    	<div id="menu1" class="tab-pane fade" style="margin-top: 20px;">
    		<div class="row">
    			<div class="col-sm-12">
					<div class="panel panel-default">
					  <div class="panel-heading">
					  	<div class="row">
					  		<div class="col-sm-3">Search Options</div>
					  		<div class="col-sm-8"></div>
					  		<div class="col-sm-1" style="text-align: right;"><b data-toggle="collapse" data-target="#demo" style="cursor: grab;">&plus;</b></div>
					  	</div>
					  </div>
					  <div class="panel-body collapse" id="demo">
					  	<div class="row">
					  		<div class="col-sm-4">
					  			<h3 style="margin-top: 0px;margin-bottom: 30px;">Patient</h3>
					  			<div class="form-group">
			    					<label for="idView">ID:</label>
						        	<input type="text" class="form-control" id="patientIdView" name="idpatientIdView">
			    				</div>
			    				
			    				<div class="form-group">
			    					<label for="idName">Name:</label>
						        	<input type="text" class="form-control" id="patientNameView" name="patientNameView">
			    				</div>
			    				
			    				<div class="form-group">
			    					<label for="idSurname">Surname:</label>
						        	<input type="text" class="form-control" id="patientSurnameView" name="patientSurnameView">
			    				</div>
					  		</div>
					  		
					  		<div class="col-sm-4">
					  			<h3 style="margin-top: 0px;margin-bottom: 30px;">Dentist</h3>
			    				<div class="form-group">
			    					<label for="idName">Name:</label>
						        	<input type="text" class="form-control" id="dentistNameView" name="dentistNameView">
			    				</div>
			    				
			    				<div class="form-group">
			    					<label for="idSurname">Surname:</label>
						        	<input type="text" class="form-control" id="dentistSurnameView" name="dentistSurnameView">
			    				</div>
					  		</div>
					  		
					  		<div class="col-sm-4">
					  			<h3 style="margin-top: 0px;margin-bottom: 30px;">Date</h3>
					  			<div class="form-group">
					  				<label for="idName">&nbsp;</label>
						        	<input type="date" class="form-control" id="dateView" name="dateView">
			    				</div>
					  		</div>
					  	</div>
					  	
					  	<div class="row">
					  		<div class="col-sm-12" style="text-align: center;">
					  			<button class="btn normalButton" onclick="loadElements(setTableValues, 'Data?what=getAppointments', 'Data?what=getNumberOfAppointments')">Search</button>
					  		</div>
					  	</div>
					  </div>
					</div>
    			</div>
    		</div>
    		
    		<div class="row">
				<div class="col-sm-12" id="messageDeleteAppointment">
					
				</div>
			</div>
    		
    		<div class="row">
    			<div class="col-sm-12">
    				<h3>View Appointment</h3>
    			</div>
    			
    			<div class="col-sm-12">
    				<table class="table table-striped" id="myTable">
    					<thead>
    						<tr>
	    						<th class="hoverSortButton" onclick="sortTable(0)">Patient</th>
	    						<th class="hoverSortButton" onclick="sortTable(1)">Dentist</th>
	    						<th class="hoverSortButton" onclick="sortTable(2)">Date</th>
	    						<th>Time Range</th>
	    						<th>Delete</th>
    						</tr>
    					</thead>
    					
    					<tbody id="myTableBody">
    					</tbody>
    				</table>
    				
    				<div class="col-sm-12" style="text-align: center;" id="myPagination">
						<nav>
							<ul class="pagination">
							
								<li class="page-item disabled" id="previous"><a class="page-link" href="#" onclick="return getNext(this, -1, setTableValues, 'Data?what=getAppointments', 'Data?what=getNumberOfAppointments', 'id', 'asc')">Previous</a></li>
								<li class="page-item active"><a id="currPage" class="page-link" href="#">1</a></li>
								<li class="page-item" id="next"><a class="page-link" href="#" onclick="return getNext(this, 1, setTableValues, 'Data?what=getAppointments', 'Data?what=getNumberOfAppointments', 'id', 'asc')">Next</a></li>
							
							</ul>
						</nav>
					</div>
    			</div>
    		</div>
    	</div>
    	
    	<!-- TAB 2 -->
    	<div id="menu2" class="tab-pane fade" style="margin-top: 10px;">
    		<form action="Appointment" method="POST">
    			<div class="row">
	    			<div class="col-sm-1">
	    				&nbsp;
	    			</div>
	    			
	    			<div class="col-sm-10">
	    				<div class="row">
	    					<div class="col-sm-12" id="messageAppointment">
	    						
	    					</div>
	    				</div>
	    				<div class="row">
	    					<div class="col-sm-5 centerThem">
			    				<h3>Add Appointment</h3>
			    			</div>
			    			
			    			<div class="col-sm-4">
			    				&nbsp;
			    			</div>
			    			
			    			<div class="col-sm-3 centerThem" style="padding-left: 0px;text-align: right;padding-right: 15px;">
			    				<button onclick="resetAll()" style="margin-top: 20px;" class="btn normalButton">Reset</button>
			    			</div>
	    				</div>
	    				
	    				<div class="row">
	    					<div class="col-sm-6">
		    					<div class="form-group">
			    					<label for="date">Date:</label>
						        	<input onchange="dateChanged(this.value)" required type="date" class="form-control" id="date" name="date">
			    				</div>
	    					</div>
	    					
	    					<div class="col-sm-6">
	    						<div class="form-group">
				    				<label for="date">Dentist:</label>
							        <select onchange="dentistChange(this.value)" required class="form-control" name="idDentist" id="idDentist">
							        	<!-- FILLING WITH JS FUNCTION "dateChanged" FROM FILE JS/APPOINTMENT.JS -->
							        </select>
			    				</div>
	    					</div>
	    				</div>
	    				
	    				<div class="row">
	    					<div class="col-sm-6">
	    						<div class="form-group">
	    						<label for="hoursStart">Hours:</label>
	    						<select required onchange="hoursChanged(this.value)" class="form-control" name="hoursStart" id="hoursStart">
						        </select>
						        </div>
	    					</div>
	    					
	    					<div class="col-sm-6">
	    						<div class="form-group">
	    						<label for="minutesStart">Minutes:</label>
					        	<select required class="form-control" name="minutesStart" id="minutesStart">
						        </select>
						        </div>
	    					</div>
	    				</div>
	    				
	    				<div class="row">
	    					<div class="col-sm-12">
	    						<div class="form-group">
	    							<label for="howLong">How Long:</label>
	    							<input value="0" type="number" class="form-control" required min="0" max="480" name="howLong" id="howLong"> <!-- 480 = 8h * 60min -->
	    						</div>
	    					</div>
	    				</div>
	    				
	    				<div class="row" style="text-align:center;">
	    					<div class="col-sm-6 centerThem" style="padding-top: 24px;">
	    						<div class="form-group">
	    							<input onclick="getAllPatients()" type="button" class="btn normalButton" style="min-width: 240px;" value="Select Patient" data-toggle="modal" data-target="#myModal1">
	    						</div>
	    					</div>
	    					
	    					<div class="col-sm-6 centerThem" style="padding-top: 28px;">
	    						<div class="form-group">
	    							<label>Patient Selected</label>
	    							<input disabled type="checkbox" style="margin-left: 20px;" name="checkIfPatientInputed" id="checkIfPatientInputed">
	    						</div>
	    					</div>
	    				</div>
	    				
	    				<%
	    					if (dto != null){
	    						out.println("<input name=\"idPersonal\" id=\"idPersonal\" type=\"text\" style=\"display: none;\" value=\"" + dto.getId() + "\">");
	    					}
	    				%>
	    				
	    				<div class="row">
	    					<div class="col-sm-12">
	    						&nbsp;
	    					</div>
	    				</div>
	    				<div class="row">
	    					<div class="col-sm-12 centerThem" style="text-align: center;">
	    						<div class="form-group">
	    							<input onclick="insertAppointment()" type="button" value="Add Appointment" class="btn normalButton" style="min-width: 200px;padding: 20px;">
	    						</div>
	    					</div>
	    				</div>
	    			</div>
	    			
	    			<div class="col-sm-1">
	    				&nbsp;
	    			</div>
    			</div>
    		</form>
    	</div>
   	</div>
</div>

<div style="width: 100%;height:200px;">
	&nbsp;
</div>

<%@ include file="insertPatient.jsp" %>

<script src="js/parameterConfig.js"></script>
<script src="js/appointment.js"></script>
<script src="js/pagination.js"></script>