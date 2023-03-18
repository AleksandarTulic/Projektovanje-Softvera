<!-- Modal HTML Markup -->
<div id="myModalUpdate" class="modal fade">
    <div class="modal-dialog">
        <div class="modal-content">
            <div class="modal-header">
                <h2 class="modal-title">Update User</h2>
            </div>
            <div class="modal-body">
                <form id="updateForm">
                	<div class="row">
                		<div class="col-sm-6">
                			<div class="form-group">
		                        <label class="control-label">ID</label>
		                        <div>
		                            <input id="updateID" required pattern="[0-9]{13}"  type="text" class="form-control" name="id" value="" maxlength="13">
		                        </div>
		                    </div>
		                    
		                    <div class="form-group">
		                    	<label class="control-label">Name</label>
		                        <div>
		                            <input id="updateName" required pattern="[a-zA-Z]{2,}[\s]*[a-zA-Z]*"  type="text" class="form-control" name="name" maxlength="100" value="">
		                        </div>
		                    </div>
		                    
		                    <div class="form-group">
		                    	<label class="control-label">Surname</label>
		                        <div>
		                            <input id="updateSurname" required pattern="[a-zA-Z]{2,}"  type="text" class="form-control" name="surname" maxlength="100" value="">
		                        </div>
		                    </div>
                		</div>
                		
                		<div class="col-sm-6">
                			<div class="form-group">
                				<label class="control-label">Email</label>
		                        <div>
		                            <input id="updateEmail" required  type="email" class="form-control" name="email" maxlength="200" value=""> <!-- OVO VRSI REGEX VALIDACIJU AUTOMATSKI -->
		                        </div>
                			</div>
                			
                			<div class="form-group">
                				<label class="control-label">Phone</label>
		                        <div>
		                            <input id="updatePhone" required pattern="[0-9]{2,}"  type="text" class="form-control" maxlength="30" name="phone" value="">
		                        </div>
                			</div>
                			
                			<div class="form-group">
                				<label class="control-label">Address</label>
		                        <div>
		                            <input id="updateAddress" required pattern="^[a-zA-Z]{2,}[0-9a-zA-Z\s]*"  type="text" maxlength="250" class="form-control" name="address" value="">
		                        </div>
                			</div>
                		</div>
                	</div>
                	
                	<div class="row">
                		<div class="col-sm-12">
                			<div class="form-group">
                				<label class="control-label">Role</label>
		                        <div>
		                            <input id="updateRole" required type="text" maxlength="20" class="form-control" name="role_name" readonly value="admin">
		                        </div>
                			</div>
                		</div>
                	</div>
                	
                	<div class="row" style="display: none;">
                		<div class="col-sm-12">
                			<div class="form-group">
		                        <label class="control-label">ID</label>
		                        <div>
		                            <input id="updateOldID" required pattern="[0-9]{13}"  type="text" class="form-control" name="oldID" value="" maxlength="13">
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
		                            <input id="updateUsername" required pattern=".{2,}"  type="text" class="form-control" maxlength="100" name="username" maxlength="100" value="">
		                        </div>
	                        </div>
	                        
	                        <div class="col-sm-6">
		                        <label class="control-label">Password</label>
		                        <div>
		                            <input id="updatePassword" required pattern=".{6,}"  type="password" class="form-control" name="password" maxlength="40" value="">
		                        </div>
	                        </div>
                        </div>
                        
                        <div class="row">
                        	<div class="col-sm-12">
                        		&nbsp;
                        	</div>
                        </div>
                        
                        <div class="row" id="dateOfStartEndWork">
                        	<div class="col-sm-12">
                       			<label class="control-label">Job Start Date</label>
                       			<input id="updateJobStart" required  type="date" class="form-control" name="jobStart">
                        	</div>
                        </div>
                    </div>
                    
                    <div class="form-group">
                    	<div class="row">
                    		<div class="col-sm-4">
                    			&nbsp;
                    		</div>
                    		
	                        <div class="col-sm-4" style="text-align: center">
	                            <button type="button" onclick="update()" class="btn normalButton">Update</button>
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

	function update(){
		console.log(document.getElementById("updateForm").checkValidity());
		
		if (document.getElementById("updateForm").checkValidity()){
			var obj = {
				"id": document.getElementById("updateID").value,
				"oldID": document.getElementById("updateOldID").value,
				"name": document.getElementById("updateName").value,
				"surname": document.getElementById("updateSurname").value,
				"email": document.getElementById("updateEmail").value,
				"phone": document.getElementById("updatePhone").value,
				"address": document.getElementById("updateAddress").value,
				"role_name": document.getElementById("updateRole").value,
				"username": document.getElementById("updateUsername").value,	
				"password": document.getElementById("updatePassword").value,
				"jobStart": document.getElementById("updateJobStart").value	
			};
			
			$.ajax({
				url: "Update",
				type: "POST",
				data: obj,
				success: function(res){
					var resObj = JSON.parse(res);
					var elements = document.getElementById("messageResult");
					elements.innerHTML = "<div class=\"" + resObj.alertType + "\"> " + resObj.message + "</div>";
					
					setInterval(function(){
						document.getElementById("messageResult").innerHTML = "";
					}, 3000);
					
					if (resObj.flag + "" === "true"){
						resetPagination();
						loadElements(setTableValues, GET_WORKERS, GET_NUMBER_OF_WORKERS);
					}
				}
			});
		}else{
			var elements = document.getElementById("messageResult");
			elements.innerHTML = "<div class=\"" + "alert alert-danger" + "\"> " + "Inserted values are not corrent.\nLook up in help correct form of values." + "</div>";
			
			setInterval(function(){
				document.getElementById("messageResult").innerHTML = "";
			}, 3000);
		}
	}

</script>