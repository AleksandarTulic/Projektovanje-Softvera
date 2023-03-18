<jsp:include page="../../../index.jsp"></jsp:include>

<div class="container">
	<div class="row">
		<div class="col-sm-12" id="messageRecoverPatient">
			
		</div>
	</div>
	
	<div class="row">
		<div class="col-sm-1">
		</div>
		
		<div class="col-sm-10">
			<h2>Recover Patient</h2>
			<form id="formRecoverPatient">
				<label class="control-label">Enter ID</label>
				<div class="form-group">
					<input type="text" id="idRecoverPatient" name="idRecoverPatient" class="form-control" pattern="^[0-9]{13}$" maxlength="13"/>
				</div>

				<input style="width: 50%;margin-right: 25%;margin-left: 25%;" type="button" onclick="recoverPatient()" value="Recover" class="btn btn-default"/>
			</form>
		</div>
		
		<div class="col-sm-1">
		</div>
	</div>
</div>

<script src="js/recoverPatient.js"></script>