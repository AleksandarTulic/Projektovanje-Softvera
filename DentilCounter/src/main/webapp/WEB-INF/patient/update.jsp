<!-- Modal HTML Markup -->
<div id="myModal2" class="modal fade">
    <div class="modal-dialog">
        <div class="modal-content">
            <div class="modal-header">
                <div class="col-sm-4" style="padding-left: 0px;">
                	<h2 class="modal-title">Update Patient</h2>
                </div>
                
                <div class="col-sm-1">
                	&nbsp;
                </div>
                
                <div class="col-sm-7" id="updateMessage">
                </div>
            </div>
            <div class="modal-body">
                <form action="Patient?what=updatePatient" method="POST">
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
                    		<div class="col-sm-4">
                    			&nbsp;
                    		</div>
                    		
	                        <div class="col-sm-4" style="text-align: center">
	                            <input onclick="updatePatient()" type="button" class="btn normalButton" value="Update">
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