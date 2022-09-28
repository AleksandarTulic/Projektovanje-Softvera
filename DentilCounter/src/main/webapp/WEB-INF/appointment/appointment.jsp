<%@ include file="../../index.jsp" %>

<jsp:useBean id='dentistService' class='service.DentistService' scope='application'></jsp:useBean>  
<%@ page import="java.util.*" %>
<%@ page import="dto.*" %>
<%

	List<DentistDTO> arr = dentistService.select();

%>

<script src="js/appointment.js"></script>

<div class="container">
	<h2>Appointment</h2>
	
	<ul class="nav nav-tabs">
	    <li><a data-toggle="tab" href="#menu1">View Appointments</a></li>
	    <li><a data-toggle="tab" href="#menu2">Add Appointment</a></li>
  	</ul>
  	
	<div class="tab-content">
    	<div id="menu1" class="tab-pane fade">
    		<h3>Menu 1</h3>
    	</div>
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
	    					<div class="col-sm-6">
	    						<div class="form-group">
	    							<label for="howLong">How Long:</label>
	    							<input value="0" type="number" class="form-control" required min="0" max="480" name="howLong" id="howLong"> <!-- 480 = 8h * 60min -->
	    						</div>
	    					</div>
	    					
	    					<div class="col-sm-6 centerThem" style="padding-top: 24px;">
	    						<div class="form-group">
	    							<input onclick="getAllPatients()" type="button" class="btn normalButton" style="min-width: 240px;" value="Add Patient" data-toggle="modal" data-target="#myModal1">
	    							<input disabled type="checkbox" style="margin-left: 20px;" name="checkIfPatientInputed" id="checkIfPatientInputed">
	    						</div>
	    					</div>
	    				</div>
	    				
	    				<%
	    					
	    					PersonalDTO dto = (PersonalDTO)request.getSession().getAttribute("aaaa");
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
	    							<input onclick="insertAppointment()" type="button" value="Add" class="btn normalButton" style="min-width: 140px;">
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

<%@ include file="insertPatient.jsp" %>
<script src="js/insertAppointment.js"></script>