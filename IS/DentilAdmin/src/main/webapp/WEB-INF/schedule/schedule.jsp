<%@ include file="../../index.jsp" %>
<link rel="stylesheet" href="css/schedule.css">

<div class="container">
	<h2>Schedule</h2>
	
	<div class="row">
		<div class="col-sm-12" id="messageResult">
		
		</div>
	</div>
	
	<div class="row">
		<ul class="nav nav-tabs">
		    <li><a data-toggle="tab" onclick="loadElements(setTableValues, 'Data?what=selectSchedules', 'Data?what=selectNumberOfSchedules')" href="#menu1">View Schedule</a></li>
		    <li><a data-toggle="tab" onclick="selectShiftsAndWorkers()" href="#menu2">Add Schedule</a></li>
		    <li><a data-toggle="tab" onclick="loadShifts('idShift2')" href="#menu3">Shift</a></li>
	  	</ul>
	</div>
	
	<div class="row">
		<div class="col-sm-12">
			<div class="tab-content">
			
				<!-- Menu 1 -->
				<div id="menu1" class="tab-pane fade">
			   		<form id="viewSchedules">
				   		<div class="col-sm-12" style="padding: 0px;">
				   			<div class="row">
				      			<div class="col-sm-2" style="margin-top: 15px;">
				      				<h4 style="margin-top: 15px;display: inline;">View Schedule</h4>
				      			</div>
				      			
				      			<div class="col-sm-8">&nbsp;</div>
				      			
				      			<div class="col-sm-2" style="margin-top: 10px;">
				      				<input id="DeleteSchedule" class="btn" type="button" onclick="deleteSchedule()" value="Delete" style="margin-top: 8px;">
				      			</div>
				      		</div>
				      	</div>
				      	
				      	<div class="col-sm-12" style="margin-top: 15px;">
							<table id="myTable" class="table table-striped">
								<thead>
									<tr>
										<th onclick="sortTable(0)">Name</th>
										<th onclick="sortTable(1)">Role</th>
										<th onclick="sortTable(2)">Date</th>
										<th onclick="sortTable(3)">Shift</th>
									  	<th>Select For Delete</th>
									</tr>
								</thead>
							
								<tbody id="myTableBody">
								</tbody>
							</table>
						</div>
						
						<div class="col-sm-12" style="text-align: center;" id="myPagination">
							<nav>
								<ul class="pagination">
								
									<li class="page-item disabled" id="previous"><a class="page-link" href="#" onclick="getNext(this, -1, setTableValues, 'Data?what=selectSchedules', 'Data?what=selectNumberOfSchedules', 'name', 'asc')">Previous</a></li>
									<li class="page-item active"><a id="currPage" class="page-link" href="#">1</a></li>
									<li class="page-item" id="next"><a class="page-link" href="#" onclick="getNext(this, 1, setTableValues, 'Data?what=selectSchedules', 'Data?what=selectNumberOfSchedules', 'name', 'asc')">Next</a></li>
								
								</ul>
							</nav>
						</div>
						

		      			<div class="col-sm-10">&nbsp;</div>
		      			
		      			<div class="centerThem col-sm-2" style="padding-left: 0px;padding-right: 35px;">
		      				<label style="padding-bottom: 10px;">Select All</label>
		      				<input type="checkbox" id="checkThemAllID" onclick="checkThemAll()" style="margin-top: 0px;">
		      			</div>
					</form>
			    </div>
			    
			    <!-- Menu 2 -->
			    <div id="menu2" class="tab-pane fade">
			      	<h4 style="margin-top: 15px;">Add Schedule</h4>
			      	<form action="ScheduleController?what=addSchedule" method="POST">
						<div class="row">
							<div class="col-sm-6" style="padding-left: 0px !important;">
								<div class="table-responsive" style="margin-top: 10px;">
									<table class="table table-striped" id="myTable1">
										<thead>
											<tr>
												<th>Name</th>
												<th>Select</th>
											</tr>
										</thead>
										
										<tbody id="workersSchedulesSelect">
										</tbody>
									</table>
								</div>
							</div>
							
							<div class="col-sm-6" style="margin-top: 15px;">
								<div class="form-group">
									  <label for="date">Date:</label>
								      <input required type="date" class="form-control" id="date" name="date">
								</div>
								
								<div class="form-group">
									<label for="shift">Shift:</label>
									<select required class="form-control" name="idShift1" id="idShift1">
									</select>
								</div>
							</div>
							
							<div class="col-sm-12 text-center">
								<input type="button" id="AddSchedule" class="btn" onclick="addSchedule()" value="Add">
							</div>
						</div>
					</form>
			    </div>
			    
			    <!-- Menu 3 -->
			    <div id="menu3" class="tab-pane fade">
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
				    				<input type="button" onclick="addShift()" id="AddShift" class="btn" value="Add">
				    			</div>
			    			</form>
	   					</div>
	    				
	    				<div class="col-sm-6">
	    					<h4>Delete Shift</h4>
	    					
	    					<form onsubmit="return areYouSure()" action="Shift?what=shiftDelete" method="POST">
	    						<div class="col-sm-12">
	    							<div class="form-group">
	    								<label for="shift">Shift:</label>
										<select required class="form-control" name="idShift2" id="idShift2">
										</select>
									</div>
	    						</div>
	    						
	    						<div class="col-sm-12 text-center">
	    							<input type="button" onclick="deleteShift()" id="DeleteShift" class="btn" value="Delete">
	    						</div>
	    					</form>
	    				</div>
			    	</div>
			    </div>
			</div>
		</div>
	</div>
</div>

<script>
	function checkThemAll(){
		var elements = document.getElementsByClassName("checkThemAll");
		var flag = document.getElementById("checkThemAllID").checked;

		for (let i=0; i<elements.length;i++){
			elements[i].checked = flag ? true : false;
		}
		
		if (flag === true){
			arrDelete = [];
			for (let i=0;i<arr.length;i++){
				arrDelete.push(i);
			}
		}else{
			arrDelete = [];
		}
		
		//console.log(arrDelete);
	}
</script>

<script src="js/global/parameterConfig.js"></script>
<script src="js/schedule/schedule.js"></script>
<script src="js/global/pagination.js"></script>