<!-- Modal HTML Markup -->
<div id="myModal3" class="modal fade">
    <div class="modal-dialog">
        <div class="modal-content">
            <div class="modal-header">
                <div class="col-sm-4" style="padding-left: 0px;">
                	<h2 class="modal-title">View More</h2>
                </div>
                
                <div class="col-sm-1">
                	&nbsp;
                </div>
                
                <div class="col-sm-7" id="insertMessage">
                </div>
            </div>
            <div class="modal-body">
                <form action="Patient?what=insertPatientWithReload" method="POST" id="formInsertPatient">
                	<div class="row">
                		<div class="col-sm-6">
                			<div class="form-group">
		                        <label class="control-label">ID</label>
		                        <div>
		                            <input readonly required pattern="[0-9]{13}"  type="text" class="form-control" name="viewID" id="viewID" value="" maxlength="13">
		                        </div>
		                    </div>
		                    
		                    <div class="form-group">
		                    	<label class="control-label">Name</label>
		                        <div>
		                            <input readonly required pattern="[a-zA-Z]{2,}[\s]*[a-zA-Z]*"  type="text" class="form-control" name="viewName" id="viewName" maxlength="100" value="">
		                        </div>
		                    </div>
		                    
		                    <div class="form-group">
		                    	<label class="control-label">Surname</label>
		                        <div>
		                            <input readonly required pattern="[a-zA-Z]{2,}"  type="text" class="form-control" name="viewSurname" id="viewSurname" maxlength="100" value="">
		                        </div>
		                    </div>
                		</div>
                		
                		<div class="col-sm-6">
                			<div class="form-group">
                				<label class="control-label">Email</label>
		                        <div>
		                            <input readonly type="email" class="form-control" name="viewEmail" id="viewEmail" maxlength="200"> <!-- OVO VRSI REGEX VALIDACIJU AUTOMATSKI -->
		                        </div>
                			</div>
                			
                			<div class="form-group">
                				<label class="control-label">Phone</label>
		                        <div>
		                            <input readonly pattern="[0-9]{2,}"  type="text" class="form-control" maxlength="30" name="viewPhone" id="viewPhone">
		                        </div>
                			</div>
                			
                			<div class="form-group">
                				<label class="control-label">Address</label>
		                        <div>
		                            <input readonly pattern="^[a-zA-Z]{2,}[0-9a-zA-Z\s]*"  type="text" maxlength="250" class="form-control" name="viewAddress" id="viewAddress">
		                        </div>
                			</div>
                		</div>
                	</div>
                </form>
            </div>
        </div><!-- /.modal-content -->
    </div><!-- /.modal-dialog -->
</div><!-- /.modal -->