<!-- Modal HTML Markup -->
<div id="myModal1" class="modal fade">
    <div class="modal-dialog">
        <div class="modal-content">
            <div class="modal-header">
                <div class="col-sm-4" style="padding-left: 0px;">
                	<h2 class="modal-title">Add User</h2>
                </div>
                
                <div class="col-sm-1">
                	&nbsp;
                </div>
                
                <div class="col-sm-7" id="insertMessage">
                </div>
            </div>
            <div class="modal-body">
                <form id="insertForm">
                	<div class="row">
                		<div class="col-sm-6">
                			<div class="form-group">
		                        <label class="control-label">ID</label>
		                        <div>
		                            <input required pattern="[0-9]{13}"  type="text" class="form-control" name="insertID" id="insertID" value="" maxlength="13">
		                        </div>
		                    </div>
		                    
		                    <div class="form-group">
		                    	<label class="control-label">Name</label>
		                        <div>
		                            <input required pattern="[a-zA-Z]{2,}[\s]*[a-zA-Z]*"  type="text" class="form-control" name="insertName" id="insertName" maxlength="100" value="">
		                        </div>
		                    </div>
		                    
		                    <div class="form-group">
		                    	<label class="control-label">Surname</label>
		                        <div>
		                            <input required pattern="[a-zA-Z]{2,}"  type="text" class="form-control" name="insertSurname" id="insertSurname" maxlength="100" value="">
		                        </div>
		                    </div>
                		</div>
                		
                		<div class="col-sm-6">
                			<div class="form-group">
                				<label class="control-label">Email</label>
		                        <div>
		                            <input required  type="email" class="form-control" name="insertEmail" id="insertEmail" maxlength="200" value=""> <!-- OVO VRSI REGEX VALIDACIJU AUTOMATSKI -->
		                        </div>
                			</div>
                			
                			<div class="form-group">
                				<label class="control-label">Phone</label>
		                        <div>
		                            <input required pattern="[0-9]{2,}"  type="text" class="form-control" maxlength="30" name="insertPhone" id="insertPhone" value="">
		                        </div>
                			</div>
                			
                			<div class="form-group">
                				<label class="control-label">Address</label>
		                        <div>
		                            <input required pattern="^[a-zA-Z]{2,}[0-9a-zA-Z\s]*"  type="text" maxlength="250" class="form-control" name="insertAddress" id="insertAddress" value="">
		                        </div>
                			</div>
                		</div>
                	</div>
                    
                    <hr>
                    <div class="form-group">
                    	<div class="row">
	                    	<div class="col-sm-6">
		                        <label class="control-label">Username</label>
		                        <div>
		                            <input required pattern=".{2,}"  type="text" class="form-control" maxlength="100" name="insertUsername" id="insertUsername" maxlength="100" value="">
		                        </div>
	                        </div>
	                        
	                        <div class="col-sm-6">
		                        <label class="control-label">Password</label>
		                        <div>
		                            <input required pattern=".{6,}"  type="password" class="form-control" name="insertPassword" id="insertPassword" maxlength="40" value="">
		                        </div>
	                        </div>
                        </div>
                        
                        <div class="row">
                        	<div class="col-sm-12">
                        		&nbsp;
                        	</div>
                        </div>
                        
                        <div class="row">
                        	<div class="col-sm-6">
                       			<label class="control-label">User Type</label>
                       			<select required onchange="changeReadonly(this.value)" class="form-control" name="insertRole" id="insertRole">
                       				<option value="admin">Admin</option>
                       				<option value="counter">Counter</option>
                       				<option value="dentist">Dentist</option>
                       			</select>
                        	</div>
                        	
                        	<div class="col-sm-6">
                       			<label class="control-label">Job Start Date</label>
                       			<input readonly type="date" class="form-control" name="insertJobStart" id="insertJobStart">
                        	</div>
                        </div>
                    </div>
                    
                    <div class="form-group">
                    	<div class="row">
                    		<div class="col-sm-4">
                    			&nbsp;
                    		</div>
                    		
	                        <div class="col-sm-4" style="text-align: center">
	                            <button type="button" onclick="insertWorker()" class="btn normalButton">Add</button>
	                        </div>
	                        
	                        <div class="col-sm-4">
                    			&nbsp;
                    		</div>
                        </div>
                    </div>
                </form>
            </div>
        </div><!-- /.modal-content -->
    </div><!-- /.modal-dialog -->
</div><!-- /.modal -->

<script>
	function changeReadonly(value){
		if (value == "admin"){
			document.getElementById("insertJobStart").setAttribute("readonly", "");
			document.getElementById("insertJobStart").removeAttribute("required");
		}else{
			document.getElementById("insertJobStart").removeAttribute("readonly");
			document.getElementById("insertJobStart").setAttribute("required", "");
		}
	}
	
	function insertWorker(){
		if (document.getElementById("insertForm").checkValidity()){
			var obj = {
				"id": document.getElementById("insertID").value,
				"name": document.getElementById("insertName").value,
				"surname": document.getElementById("insertSurname").value,
				"email": document.getElementById("insertEmail").value,
				"phone": document.getElementById("insertPhone").value,
				"address": document.getElementById("insertAddress").value,
				"role_name": document.getElementById("insertRole").value,
				"username": document.getElementById("insertUsername").value,	
				"password": document.getElementById("insertPassword").value,
				"jobStart": document.getElementById("insertJobStart").value	
			};
			
			$.ajax({
				url: "Insert",
				type: "POST",
				data: obj,
				success: function(res){
					var resObj = JSON.parse(res);
					var elements = document.getElementById("insertMessage");
					elements.innerHTML = "<div class=\"" + resObj.alertType + "\"> " + resObj.message + "</div>";
					
					setInterval(function(){
						document.getElementById("insertMessage").innerHTML = "";
					}, 3000);
					
					if (resObj.flag + "" === "true"){
						resetPagination();
						loadElements(setTableValues, GET_WORKERS, GET_NUMBER_OF_WORKERS);
						document.getElementById("insertForm").reset();
					}
				}
			});
		}else{
			var elements = document.getElementById("insertMessage");
			elements.innerHTML = "<div class=\"" + "alert alert-danger" + "\"> " + "Inserted values are not corrent.\nLook up in help correct form of values." + "</div>";
			
			setInterval(function(){
				document.getElementById("insertMessage").innerHTML = "";
			}, 3000);
		}
	}
</script>