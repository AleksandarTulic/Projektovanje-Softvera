<!-- Modal HTML Markup -->
<div id="myModal1" class="modal fade">
    <div class="modal-dialog">
        <div class="modal-content">
            <div class="modal-header">
                <div class="col-sm-4" style="padding-left: 0px;">
                	<h2 class="modal-title">Add Patient</h2>
                </div>
                
                <div class="col-sm-1">
                	&nbsp;
                </div>
                
                <div class="col-sm-7" id="message">
                </div>
            </div>
            <div class="modal-body">
                <form action="Insert" method="POST">
                	<div class="row">
                		<div class="col-sm-6">
                			<div class="form-group">
		                        <label class="control-label">ID</label>
		                        <div>
		                            <input onchange="getWithId(this.value)" list="datalistID" required pattern="[0-9]{13}"  type="text" class="form-control" name="insertID" id="insertID" value="" maxlength="13">
		                        	<datalist id="datalistID">
		                        	</datalist>
		                        </div>
		                    </div>
		                    
		                    <div class="form-group">
		                    	<label class="control-label">Name</label>
		                        <div>
		                            <input onchange="getWithName(this.value)" list="datalistName" required pattern="[a-zA-Z]{2,}[\s]*[a-zA-Z]*"  type="text" class="form-control" name="insertName" id="insertName" maxlength="100" value="">
		                        	<datalist id="datalistName">
		                        	</datalist>
		                        </div>
		                    </div>
		                    
		                    <div class="form-group">
		                    	<label class="control-label">Surname</label>
		                        <div>
		                            <input onchange="getWithSurname(this.value)" list="datalistSurname" required pattern="[a-zA-Z]{2,}"  type="text" class="form-control" name="insertSurname" id="insertSurname" maxlength="100" value="">
		                        	<datalist id="datalistSurname">
		                        	</datalist>
		                        </div>
		                    </div>
                		</div>
                		
                		<div class="col-sm-6">
                			<div class="form-group">
                				<label class="control-label">Email</label>
		                        <div>
		                            <input type="email" class="form-control" name="insertEmail" id="insertEmail" maxlength="200"> <!-- OVO VRSI REGEX VALIDACIJU AUTOMATSKI -->
		                        </div>
                			</div>
                			
                			<div class="form-group">
                				<label class="control-label">Phone</label>
		                        <div>
		                            <input pattern="[0-9]{2,}"  type="text" class="form-control" maxlength="30" name="insertPhone" id="insertPhone">
		                        </div>
                			</div>
                			
                			<div class="form-group">
                				<label class="control-label">Address</label>
		                        <div>
		                            <input pattern="^[a-zA-Z]{2,}[0-9a-zA-Z\s]*"  type="text" maxlength="250" class="form-control" name="insertAddress" id="insertAddress">
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
	                            <input onclick="insertPatient()" type="button" class="btn normalButton" value="Add">
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

<script src="js/insertPatient.js"></script>