<%@ include file="../../../index.jsp" %>

<link rel="stylesheet" href="css/tableHelp.css">

<div class="container">
	<div class="row">
		<div class="col-sm-12">
			<div class="panel panel-default">
			  	<div class="panel-heading">
				  	<div class="row">
				  		<div class="col-sm-6">How To Add a Patient?</div>
				  		<div class="col-sm-5"></div>
				  		<div class="col-sm-1" style="text-align: right;"><b data-toggle="collapse" data-target="#demo1" style="cursor: grab;">&plus;</b></div>
					</div>
				</div>
			
				<div class="panel-body collapse" id="demo1">
					<p>There are two ways to add a patient:</p>
					<ul>
						<li><a href="Navigation?what=viewPatients">Going to tab Patient</a></li>
						<li><a href="Navigation?what=viewAppointments">Going to tab Appointment</a></li>
					</ul>
					
					<h4 style="margin-top: 20px;"><b>Going to tab Patient</b></h4>
					
					<p>First you click the "Patient" tab on the navigation. After that you will notice 
					a button on the page with the "Add" text on it. Click on it and you will be shown a Modal.
					Through which you can fill the desirable values. </p>
					
					
					<h4><b>Going to tab Appointment</b></h4>
					
					<p>First you click the "Appointment" tab on the navigation. After that you will notice 
					a button/tab on the page with the "Add Appointment" text on it. Click on it and you will be shown 
					a form. On the form you will see a button with the text "Select Patient" on it. Click on
					it and you will be shown a Modal. Through which you can fill the desirable values.</p>
				
					<hr>
				
					<h4><b>Allowed Values</b></h4>
					
					<table border="1">
						<tbody>
							<tr>
								<th style="padding: 10px;">ID</th>
								<td>Only numbers, must be 13 characters long.</td>
							</tr>
							<tr>
								<th>Name</th>
								<td>Must only contain letter characters and white space, while white space can only occur after two consecutive characters. <b>Max Length: 100, Min Length: 2</b>.</td>
							</tr>
							<tr>
								<th>Surname</th>
								<td>Must only contain letter characters. <b>Max Length: 100, Min Length: 2</b>.</td>
							</tr>
							<tr>
								<th>Email</th>
								<td><b>Optional.</b> Must be of email form. For more info <a href="https://en.wikipedia.org/wiki/Email_address">see here</a>. <b>Max Length: 200, Min Length: 3</b>.</td>
							</tr>
							<tr>
								<th>Phone</th>
								<td><b>Optional.</b> Must only contain number characters. <b>Max Length: 30, Min Length: 2</b>.</td>
							</tr>
							<tr>
								<th>Address</th>
								<td><b>Optional.</b>Must only contain letter characters and white space, while white space can only occur after two consecutive characters. <b>Max Length: 250, Min Length: 2</b>.</td>
							</tr>
						</tbody>
					</table>
				</div>
			</div>
		</div>
		
		<div class="col-sm-12">
			<div class="panel panel-default">
			  	<div class="panel-heading">
				  	<div class="row">
				  		<div class="col-sm-6">How To Delete a Patient?</div>
				  		<div class="col-sm-5"></div>
				  		<div class="col-sm-1" style="text-align: right;"><b data-toggle="collapse" data-target="#demo2" style="cursor: grab;">&plus;</b></div>
					</div>
				</div>
			
				<div class="panel-body collapse" id="demo2">
					<p>There is only one way to delete a patient:</p>
					<ul>
						<li><a href="Navigation?what=viewPatients">Going to tab Patient</a></li>
					</ul>
					
					<h4 style="margin-top: 20px;"><b>Going to tab Patient</b></h4>
					
					<p>First you click the "Patient" tab on the navigation. After that you will notice 
					a button on every row of the table, if there are any patients(<i>Also depends on what you have inserted in "Search By"</i>) that is of red color, on which writes "Delete".
					</p>
					
					<p>After you click it, you will be shown a modal which asks you to confirm your decision.
					You may ask yourself why? Because this is very dangerous action. 
					</p>
				</div>
			</div>
		</div>
		
		<div class="col-sm-12">
			<div class="panel panel-default">
			  	<div class="panel-heading">
				  	<div class="row">
				  		<div class="col-sm-6">How To Update a Patient?</div>
				  		<div class="col-sm-5"></div>
				  		<div class="col-sm-1" style="text-align: right;"><b data-toggle="collapse" data-target="#demo3" style="cursor: grab;">&plus;</b></div>
					</div>
				</div>
			
				<div class="panel-body collapse" id="demo3">
					<p>There is only one way to update a patient:</p>
					<ul>
						<li><a href="Navigation?what=viewPatients">Going to tab Patient</a></li>
					</ul>
					
					<h4 style="margin-top: 20px;"><b>Going to tab Patient</b></h4>
					
					<p>First you click the "Patient" tab on the navigation. After that you will notice 
					a button on every row of the table, if there are any patients(<i>Also depends on what you have inserted in "Search By"</i>) that is of yellow color, on which writes "Update".
					</p>
					
					<p>Click on it and you will be shown the same modal that you would use if you were trying to add a Patient. 
					But know the input fields are already filled with default patient info. You can then choose to change something and click on the button to update. But you need 
					to respect the Allowed values defined earlier in the question <b data-toggle="collapse" data-target="#demo1" style="cursor: grab;">"How To Add a Patient?"</b>. </p>
				</div>
			</div>
		</div>
		
		<div class="col-sm-12">
			<div class="panel panel-default">
			  	<div class="panel-heading">
				  	<div class="row">
				  		<div class="col-sm-6">How To See More Info about a Patient?</div>
				  		<div class="col-sm-5"></div>
				  		<div class="col-sm-1" style="text-align: right;"><b data-toggle="collapse" data-target="#demo4" style="cursor: grab;">&plus;</b></div>
					</div>
				</div>
			
				<div class="panel-body collapse" id="demo4">
					<p>There are multiple ways to see every personal information of a patient, but we will here explain the default one:</p>
					<ul>
						<li><a href="Navigation?what=viewPatients">Going to tab Patient</a></li>
					</ul>
					
					<h4 style="margin-top: 20px;"><b>Going to tab Patient</b></h4>
					
					<p>First you click the "Patient" tab on the navigation. After that you will notice 
					a button on every row of the table, if there are any patients(<i>Also depends on what you have inserted in "Search By"</i>) that is of blue color, on which writes "View More".
					Click on it and you will see the desired information.
					</p>
				</div>
			</div>
		</div>
		
		<div class="col-sm-12">
			<div class="panel panel-default">
			  	<div class="panel-heading">
				  	<div class="row">
				  		<div class="col-sm-6">How To Add an Appointment?</div>
				  		<div class="col-sm-5"></div>
				  		<div class="col-sm-1" style="text-align: right;"><b data-toggle="collapse" data-target="#demo5" style="cursor: grab;">&plus;</b></div>
					</div>
				</div>
			
				<div class="panel-body collapse" id="demo5">
					<p>There is only one way to delete a patient:</p>
					<ul>
						<li><a href="Navigation?what=viewPatients">Going to tab Appointment</a></li>
					</ul>
					
					<h4 style="margin-top: 20px;"><b>Going to tab Appointment</b></h4>
					
					<p>First you click the "Appointment" tab on the navigation. After that you will notice 
					a button/tab on the page with the "Add Appointment" text on it.
					</p>
					
					<p>Click on it and you will be shown a form that you need to fill with certain values.
					First you select the date and if any dentist is working on that day(<i>on some shift</i>) then the dropdown "Dentist" will be filled
					with names and surnames of dentists.
					</p>
					
					<p>Simultaneously dropdowns "Hours" and "Minutes" will be filled with values. "Hours" dropdown will be filled
					with hours in which the dentist works. But minutes will be filled only with the values in which the dentist is not occupied 
					with some other work(<i>has some other appointment</i>).
					</p>
				</div>
			</div>
		</div>
		
		<div class="col-sm-12">
			<div class="panel panel-default">
			  	<div class="panel-heading">
				  	<div class="row">
				  		<div class="col-sm-6">How To Delete an Appointment?</div>
				  		<div class="col-sm-5"></div>
				  		<div class="col-sm-1" style="text-align: right;"><b data-toggle="collapse" data-target="#demo6" style="cursor: grab;">&plus;</b></div>
					</div>
				</div>
			
				<div class="panel-body collapse" id="demo6">
					<p>There is only one way to delete a patient:</p>
					<ul>
						<li><a href="Navigation?what=viewAppointments">Going to tab Appointment</a></li>
					</ul>
					
					<h4 style="margin-top: 20px;"><b>Going to tab Appointment</b></h4>
					
					<p>First you click the "Appointment" tab on the navigation. After that you will notice 
					a button/tab on the page with the "View Appointments" text on it. Click on it and you will
					see a bar similar like the one you clicked here with "Search Options" written on it. Click it and you will see
					a form with fields in which you can input your values and then click on search button. If there are any 
					appointments that fulfill the certain requirements given the value it will be shown in the list below.	 
					</p>
					
					<p><b>What are those requirements?</b>
					We will retrieve those appointments that <b>contain</b> the array of characters given in the form previously specified
					on the corresponding labels. By default the field values of the form are empty array of characters so any appointment fulfills the 
					requirement.
					</p>
					
					<p>Then if you want to delete an appointment you just need to click on the red button "Delete", and it will just
					ask you to confirm the action.
					</p>
				</div>
			</div>
		</div>
		
		<div class="col-sm-12">
			<div class="panel panel-default">
			  	<div class="panel-heading">
				  	<div class="row">
				  		<div class="col-sm-6">How To See My Schedule?</div>
				  		<div class="col-sm-5"></div>
				  		<div class="col-sm-1" style="text-align: right;"><b data-toggle="collapse" data-target="#demo7" style="cursor: grab;">&plus;</b></div>
					</div>
				</div>
			
				<div class="panel-body collapse" id="demo7">
					<p>There is only one way to see you schedule:</p>
					<ul>
						<li><a href="Navigation?what=personalInfo">Going to tab which contains your Username</a></li>
					</ul>
					
					<h4 style="margin-top: 20px;"><b>Going to tab which contains your Username</b></h4>
					
					<p>
						After pressing the tab and selecting "View option"" you will see your personal information and below that you will see 
						a header with the name "View Schedule" and the table that represents your schedule. You can sort the values by clicking on
						column header names.
					</p>
				</div>
			</div>
		</div>
		
		<div class="col-sm-12">
			<div class="panel panel-default">
			  	<div class="panel-heading">
				  	<div class="row">
				  		<div class="col-sm-6">How To See My Personal Information?</div>
				  		<div class="col-sm-5"></div>
				  		<div class="col-sm-1" style="text-align: right;"><b data-toggle="collapse" data-target="#demo8" style="cursor: grab;">&plus;</b></div>
					</div>
				</div>
			
				<div class="panel-body collapse" id="demo8">
					<p>There is only one way to see you schedule:</p>
					<ul>
						<li><a href="Navigation?what=personalInfo">Going to tab which contains your Username</a></li>
					</ul>
					
					<h4 style="margin-top: 20px;"><b>Going to tab which contains your Username</b></h4>
					
					<p>
						After pressing the tab and selecting "View option"" you will see your personal information.
					</p>
				</div>
			</div>
		</div>
		
		<div class="col-sm-12">
			<div class="panel panel-default">
			  	<div class="panel-heading">
				  	<div class="row">
				  		<div class="col-sm-6">I can not add a Patient but all values are correct, Why?</div>
				  		<div class="col-sm-5"></div>
				  		<div class="col-sm-1" style="text-align: right;"><b data-toggle="collapse" data-target="#demo9" style="cursor: grab;">&plus;</b></div>
					</div>
				</div>
			
				<div class="panel-body collapse" id="demo9">
					<p>There is a possibility that this person was a member/patient of your organization but for some reason he/she was deleted. To recover his/her
					information go to the "Recover Patient" tab and fill the form with his/her id. If successfull you will see the person in the list of "Patient" tab. </p>
					
					<p>Of course the other reason you could not add a person is because the person is already in the database and is not deleted like the previous case.
					</p>
					
					<p>As we explained in the first case we do not really delete all the data we just make it not available for the users, but we use it to make some statistical analysis.
					</p>
				</div>
			</div>
		</div>
	</div>
</div>

<script src="js/help.js"></script>