<%@ include file="../../index.jsp" %>

<div class="container">
	<div class="row">
		<div class="col-sm-12">
			<div class="panel panel-default">
			  	<div class="panel-heading">
				  	<div class="row">
				  		<div class="col-sm-6">How To Add a Worker?</div>
				  		<div class="col-sm-5"></div>
				  		<div class="col-sm-1" style="text-align: right;"><b data-toggle="collapse" data-target="#demo1" style="cursor: grab;">&plus;</b></div>
					</div>
				</div>
			
				<div class="panel-body collapse" id="demo1">
					<p>There is only one way to add a worker: </p>
					<ul>
						<li><a href="Navigation?what=viewUsers">Going to tab Users</a></li>
					</ul>
					
					<h4 style="margin-top: 20px;"><b>Going to tab Users</b></h4>
					
					<p>First you click the "Patient" tab on the navigation. After that you will notice 
					a button on the page with the "Add" text on it. Click on it and you will be shown a Modal.
					Through which you can fill the desirable values. </p>
				
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
								<td>Must be of email form. For more info <a href="https://en.wikipedia.org/wiki/Email_address">see here</a>. <b>Max Length: 200, Min Length: 5</b>.</td>
							</tr>
							<tr>
								<th>Phone</th>
								<td>Must only contain number characters. <b>Max Length: 200, Min Length: 2</b>.</td>
							</tr>
							<tr>
								<th>Address</th>
								<td>Must only contain letter characters and white space, while white space can only occur after two consecutive characters. <b>Max Length: 200, Min Length: 2</b>.</td>
							</tr>
							<tr>
								<th>Username</th>
								<td>Can contain any character and. <b>Max Length: 100, Min Length: 2</b>.</td>
							</tr>
							<tr>
								<th>Password</th>
								<td>Can contain any character. <b>Max Length: 40, Min Length: 6</b>.</td>
							</tr>
						</tbody>
					</table>
					
					<br>
					<p>Using this "Add" option previously mentioned we can add different types of Workers. Using the ComboBox "User Type". If you choose counter or dentist than you will need to enter their starting job date.</p>
				</div>
			</div>
		</div>
		
		<div class="col-sm-12">
			<div class="panel panel-default">
			  	<div class="panel-heading">
				  	<div class="row">
				  		<div class="col-sm-6">How To Delete a Worker?</div>
				  		<div class="col-sm-5"></div>
				  		<div class="col-sm-1" style="text-align: right;"><b data-toggle="collapse" data-target="#demo2" style="cursor: grab;">&plus;</b></div>
					</div>
				</div>
			
				<div class="panel-body collapse" id="demo2">
					<p>There is only one way to delete a worker:</p>
					<ul>
						<li><a href="Navigation?what=viewUsers">Going to tab Worker</a></li>
					</ul>
					
					<h4 style="margin-top: 20px;"><b>Going to tab Worker</b></h4>
					
					<p>First you click the "Users" tab on the navigation. After that you will notice 
					a button on every row of the table, if there are any workers(<i>Also depends on what you have inserted in "Search By"</i>) that is of red color, on which writes "Delete".
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
				  		<div class="col-sm-6">How To Update a Worker?</div>
				  		<div class="col-sm-5"></div>
				  		<div class="col-sm-1" style="text-align: right;"><b data-toggle="collapse" data-target="#demo3" style="cursor: grab;">&plus;</b></div>
					</div>
				</div>
			
				<div class="panel-body collapse" id="demo3">
					<p>There is only one way to update a worker:</p>
					<ul>
						<li><a href="Navigation?what=viewUsers">Going to tab Worker</a></li>
					</ul>
					
					<h4 style="margin-top: 20px;"><b>Going to tab Worker</b></h4>
					
					<p>First you click the "Users" tab on the navigation. After that you will notice 
					a button on every row of the table, if there are any patients(<i>Also depends on what you have inserted in "Search By"</i>) that is of yellow color, on which writes "Update".
					</p>
					
					<p>Click on it and you will be shown the same modal that you would use if you were trying to add a Worker. 
					But know the input fields are already filled with default patient info. You can then choose to change something and click on the button to update. But you need 
					to respect the Allowed values defined earlier in the question <b data-toggle="collapse" data-target="#demo1" style="cursor: grab;">"How To Add a Worker?"</b>. </p>
				</div>
			</div>
		</div>
		
		<div class="col-sm-12">
			<div class="panel panel-default">
			  	<div class="panel-heading">
				  	<div class="row">
				  		<div class="col-sm-6">How To See More Info about a Worker?</div>
				  		<div class="col-sm-5"></div>
				  		<div class="col-sm-1" style="text-align: right;"><b data-toggle="collapse" data-target="#demo4" style="cursor: grab;">&plus;</b></div>
					</div>
				</div>
			
				<div class="panel-body collapse" id="demo4">
					<p>There are multiple ways to see every personal information of a patient, but we will here explain the default one:</p>
					<ul>
						<li><a href="Navigation?what=viewUsers">Going to tab Users</a></li>
					</ul>
					
					<h4 style="margin-top: 20px;"><b>Going to tab Worker</b></h4>
					
					<p>First you click the "Users" tab on the navigation. After that you will notice 
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
				  		<div class="col-sm-6">How To Add Worker's Schedule?</div>
				  		<div class="col-sm-5"></div>
				  		<div class="col-sm-1" style="text-align: right;"><b data-toggle="collapse" data-target="#demo5" style="cursor: grab;">&plus;</b></div>
					</div>
				</div>
			
				<div class="panel-body collapse" id="demo5">
					<p>There is only one way to add worker's schedule:</p>
					<ul>
						<li><a href="Navigation?what=schedule">Going to tab Schedule</a></li>
					</ul>
					
					<h4 style="margin-top: 20px;"><b>Going to tab Schedule</b></h4>
					
					<p>First you click the "Schedule" tab on the navigation. After that you will notice 
					a three tab buttons. Click the one that says "Add Schedule". Now you need to select certain values and press the button "Add".
					</p>
				</div>
			</div>
		</div>
		
		<div class="col-sm-12">
			<div class="panel panel-default">
			  	<div class="panel-heading">
				  	<div class="row">
				  		<div class="col-sm-6">How To Delete Worker's Schedule?</div>
				  		<div class="col-sm-5"></div>
				  		<div class="col-sm-1" style="text-align: right;"><b data-toggle="collapse" data-target="#demo6" style="cursor: grab;">&plus;</b></div>
					</div>
				</div>
			
				<div class="panel-body collapse" id="demo6">
					<p>There is only one way to delete worker's schedule:</p>
					<ul>
						<li><a href="Navigation?what=schedule">Going to tab Schedule</a></li>
					</ul>
					
					<h4 style="margin-top: 20px;"><b>Going to tab Schedule</b></h4>
					
					<p>First you click the "Schedule" tab on the navigation. After that you will notice 
					a three tab buttons. Click the one that says "View Schedule". Now you need to select which schedules you want to delete and press the "Delete" button. The checkbox "Select All"
					only selects rows that you currently see.
					</p>
				</div>
			</div>
		</div>
		
		<div class="col-sm-12">
			<div class="panel panel-default">
			  	<div class="panel-heading">
				  	<div class="row">
				  		<div class="col-sm-6">How To Add a New Shift?</div>
				  		<div class="col-sm-5"></div>
				  		<div class="col-sm-1" style="text-align: right;"><b data-toggle="collapse" data-target="#demo7" style="cursor: grab;">&plus;</b></div>
					</div>
				</div>
			
				<div class="panel-body collapse" id="demo7">
					<p>There is only one way to add a new shift:</p>
					<ul>
						<li><a href="Navigation?what=schedule">Going to tab Schedule</a></li>
					</ul>
					
					<h4 style="margin-top: 20px;"><b>Going to tab Schedule</b></h4>
					
					<p>First you click the "Schedule" tab on the navigation. After that you will notice 
					a three tab buttons. Click the one that says "Shift". Choose certain values and press the button "Add".
					</p>
				</div>
			</div>
		</div>
		
		<div class="col-sm-12">
			<div class="panel panel-default">
			  	<div class="panel-heading">
				  	<div class="row">
				  		<div class="col-sm-6">How To Delete a Shift?</div>
				  		<div class="col-sm-5"></div>
				  		<div class="col-sm-1" style="text-align: right;"><b data-toggle="collapse" data-target="#demo8" style="cursor: grab;">&plus;</b></div>
					</div>
				</div>
			
				<div class="panel-body collapse" id="demo8">
					<p>There is only one way to delete a shift:</p>
					<ul>
						<li><a href="Navigation?what=schedule">Going to tab Schedule</a></li>
					</ul>
					
					<h4 style="margin-top: 20px;"><b>Going to tab Schedule</b></h4>
					
					<p>First you click the "Schedule" tab on the navigation. After that you will notice 
					a three tab buttons. Click the one that says "Shift". Choose certain value from combobox and press the button "Delete". <b>But 
					be careful because if you delete a shift every schedule connected to that shift will also be deleted.</b>
					</p>
				</div>
			</div>
		</div>
		
		<div class="col-sm-12">
			<div class="panel panel-default">
			  	<div class="panel-heading">
				  	<div class="row">
				  		<div class="col-sm-6">I can not add a Worker but all values are correct, Why?</div>
				  		<div class="col-sm-5"></div>
				  		<div class="col-sm-1" style="text-align: right;"><b data-toggle="collapse" data-target="#demo9" style="cursor: grab;">&plus;</b></div>
					</div>
				</div>
			
				<div class="panel-body collapse" id="demo9">
					<p>There is a possibility that this person was a member/worker of your organization but for some reason he/she was deleted. To recover his/her
					information go to the "Recover Worker" tab and fill the form with his/her id. If successfull you will see the person in the list of "Users" tab. </p>
					
					<p>Of course the other reason you could not add a person is because the person is already in the database and is not deleted like the previous case.
					</p>
					
					<p>As we explained in the first case we do not really delete all the data we just make it not available for the users, but we use it to make some statistical analysis.
					</p>
				</div>
			</div>
		</div>
		
	</div>
</div>

<script>

	var current = document.getElementsByClassName("active");
	current[0].className = "";
	document.getElementById("MenuHelp").className += "active";

</script>