<%@ include file="../../index.jsp" %>

<div class="container">
	<div class="row">
		<div class="col-sm-12" id="messageResult">
			
		</div>
	</div>
	
	<div class="row">
		<div class="col-sm-1">
		</div>
		
		<div class="col-sm-10">
			<h2>Recover Worker</h2>
			<form id="formRecoverWorker">
				<label class="control-label">Enter ID</label>
				<div class="form-group">
					<input required type="text" id="idRecoverWorker" name="idRecoverWorker" class="form-control" pattern="^[0-9]{13}$" maxlength="13"/>
				</div>

				<input style="width: 50%;margin-right: 25%;margin-left: 25%;" type="button" onclick="recoverWorker()" value="Recover" class="btn btn-default"/>
			</form>
		</div>
		
		<div class="col-sm-1">
		</div>
	</div>
</div>

<script>

	function recoverWorker(){
		if (document.getElementById("formRecoverWorker").checkValidity()){
			var obj = {
				"id": document.getElementById("idRecoverWorker").value
			};
			
			$.ajax({
				url: "Update?what=recoverWorker",
				type: "POST",
				data: obj,
				success: function(res){
					var obj = JSON.parse(res);
					var elements = document.getElementById("messageResult");
					elements.innerHTML = "<div class=\"" + obj.alertType + "\"> " + obj.message + "</div>";
					
					setTimeout(function(){
						document.getElementById("messageResult").innerHTML = "";
					}, 3000);
					
					if (obj.flag){
						document.getElementById("formRecoverWorker").reset();
					}
				}
			});
		}else{
			var elements = document.getElementById("messageResult");
			elements.innerHTML = "<div class=\"" + "alert alert-danger" + "\"> " + "Inserted value is not of the correct form. Look up the correct form value on Help tab." + "</div>";
			
			setTimeout(function(){
				document.getElementById("messageResult").innerHTML = "";
			}, 3000);
		}
	}


	var current = document.getElementsByClassName("active");
	current[0].className = "";
	document.getElementById("MenuRecover").className += "active";
</script>