<!-- Modal HTML Markup -->
<div id="myModalViewMore" class="modal fade">
    <div class="modal-dialog">
        <div class="modal-content">
            <div class="modal-header">
                <h2 class="modal-title">View User</h2>
            </div>
            <div class="modal-body">
                <form id="viewMoreForm">
                	<div class="row">
                		<div class="col-sm-6">
                			<div class="form-group">
		                        <label class="control-label">ID</label>
		                        <div>
		                            <input id="viewMoreID" readonly type="text" class="form-control" name="id" value="">
		                        </div>
		                    </div>
		                    
		                    <div class="form-group">
		                    	<label class="control-label">Name</label>
		                        <div>
		                            <input id="viewMoreName" readonly type="text" class="form-control" name="name" value="">
		                        </div>
		                    </div>
		                    
		                    <div class="form-group">
		                    	<label class="control-label">Surname</label>
		                        <div>
		                            <input id="viewMoreSurname" readonly type="text" class="form-control" name="surname" value="">
		                        </div>
		                    </div>
                		</div>
                		
                		<div class="col-sm-6">
                			<div class="form-group">
                				<label class="control-label">Email</label>
		                        <div>
		                            <input id="viewMoreEmail" readonly  type="email" class="form-control" name="email" value=""> <!-- OVO VRSI REGEX VALIDACIJU AUTOMATSKI -->
		                        </div>
                			</div>
                			
                			<div class="form-group">
                				<label class="control-label">Phone</label>
		                        <div>
		                            <input id="viewMorePhone" readonly type="text" class="form-control" name="phone" value="">
		                        </div>
                			</div>
                			
                			<div class="form-group">
                				<label class="control-label">Address</label>
		                        <div>
		                            <input id="viewMoreAddress" readonly type="text" class="form-control" name="address" value="">
		                        </div>
                			</div>
                		</div>
                	</div>
                	
                	<div class="row">
                		<div class="col-sm-12">
                			<div class="form-group">
                				<label class="control-label">Role</label>
		                        <div>
		                            <input id="viewMoreRole" readonly type="text" class="form-control" name="role_name" value="admin">
		                        </div>
                			</div>
                		</div>
                	</div>
                    
                    <hr>
                    <div class="form-group">
                    	<div class="row">
	                    	<div class="col-sm-12">
		                        <label class="control-label">Username</label>
		                        <div>
		                            <input id="viewMoreUsername" readonly type="text" class="form-control" maxlength="100" name="username">
		                        </div>
	                        </div>
                        </div>
                        
                        <div class="row">
                        	<div class="col-sm-12">
                        		&nbsp;
                        	</div>
                        </div>
                        
                        <div class="row">
                        	<div class="col-sm-12">
                       			<label class="control-label">Job Start Date</label>
                       			<input id="viewMoreJobStart" readonly  type="date" class="form-control" name="jobStart">
                        	</div>
                        </div>
                    </div>
                </form>
            </div>
        </div><!-- /.modal-content -->
    </div><!-- /.modal-dialog -->
</div><!-- /.modal -->