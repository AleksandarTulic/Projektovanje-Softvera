<!-- Modal HTML Markup -->
<div id="myModal1" class="modal fade">
    <div class="modal-dialog">
        <div class="modal-content">
            <div class="modal-header">
                <h2 class="modal-title">Add User</h2>
            </div>
            <div class="modal-body">
                <form action="Insert" method="POST">
                	<div class="row">
                		<div class="col-sm-6">
                			<div class="form-group">
		                        <label class="control-label">ID</label>
		                        <div>
		                            <input required pattern="[0-9]{13}"  type="text" class="form-control" name="id" value="" maxlength="13">
		                        </div>
		                    </div>
		                    
		                    <div class="form-group">
		                    	<label class="control-label">Name</label>
		                        <div>
		                            <input required pattern="[a-zA-Z]{2,}[\s]*[a-zA-Z]*"  type="text" class="form-control" name="name" maxlength="100" value="">
		                        </div>
		                    </div>
		                    
		                    <div class="form-group">
		                    	<label class="control-label">Surname</label>
		                        <div>
		                            <input required pattern="[a-zA-Z]{2,}"  type="text" class="form-control" name="surname" maxlength="100" value="">
		                        </div>
		                    </div>
                		</div>
                		
                		<div class="col-sm-6">
                			<div class="form-group">
                				<label class="control-label">Email</label>
		                        <div>
		                            <input required  type="email" class="form-control" name="email" maxlength="200" value=""> <!-- OVO VRSI REGEX VALIDACIJU AUTOMATSKI -->
		                        </div>
                			</div>
                			
                			<div class="form-group">
                				<label class="control-label">Phone</label>
		                        <div>
		                            <input required pattern="[0-9]{2,}"  type="text" class="form-control" maxlength="30" name="phone" value="">
		                        </div>
                			</div>
                			
                			<div class="form-group">
                				<label class="control-label">Address</label>
		                        <div>
		                            <input required pattern="^[a-zA-Z]{2,}[0-9a-zA-Z\s]*"  type="text" maxlength="250" class="form-control" name="address" value="">
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
		                            <input required pattern=".{2,}"  type="text" class="form-control" maxlength="100" name="username" maxlength="100" value="">
		                        </div>
	                        </div>
	                        
	                        <div class="col-sm-6">
		                        <label class="control-label">Password</label>
		                        <div>
		                            <input required pattern=".{6,}"  type="password" class="form-control" name="password" maxlength="40" value="">
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
                       			<select required onchange="changeReadonly(this.value)" class="form-control" id="role_name" name="role_name">
                       				<option value="admin">Admin</option>
                       				<option value="counter">Counter</option>
                       				<option value="dentist">Dentist</option>
                       			</select>
                        	</div>
                        	
                        	<div class="col-sm-6">
                       			<label class="control-label">Job Start Date</label>
                       			<input id="insertJobStartDate" readonly type="date" class="form-control" name="jobStart">
                        	</div>
                        </div>
                    </div>
                    
                    <div class="form-group">
                    	<div class="row">
                    		<div class="col-sm-4">
                    			&nbsp;
                    		</div>
                    		
	                        <div class="col-sm-4" style="text-align: center">
	                            <button type="submit" class="btn normalButton">Add</button>
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
			document.getElementById("insertJobStartDate").setAttribute("readonly", "");
			document.getElementById("insertJobStartDate").removeAttribute("required");
		}else{
			document.getElementById("insertJobStartDate").removeAttribute("readonly");
			document.getElementById("insertJobStartDate").setAttribute("required", "");
		}
	}
</script>