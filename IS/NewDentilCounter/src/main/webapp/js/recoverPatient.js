function recoverPatient(){
	var obj = {
		"id": document.getElementById("idRecoverPatient").value
	};
	
	var form = document.getElementById("formRecoverPatient");
	
	if (form.checkValidity()){
		$.ajax({
			url: "Patient?what=recoverPatient",
			type: "POST",
			data: obj,
			success: function(res){
				var obj = JSON.parse(res);
				var elements = document.getElementById("messageRecoverPatient");
				elements.innerHTML = "<div class=\"" + obj.alertType + "\"> " + obj.message + "</div>";
				
				setTimeout(function(){
					document.getElementById("messageRecoverPatient").innerHTML = "";
				}, 3000);
				
				if (obj.flag){
					form.reset();
				}
			}
		});
	}else{
		var elements = document.getElementById("messageRecoverPatient");
		elements.innerHTML = "<div class=\"" + "alert alert-danger" + "\"> " + "Inserted value is not of the correct form. Look up the correct form value on Help tab." + "</div>";
		
		setTimeout(function(){
			document.getElementById("messageRecoverPatient").innerHTML = "";
		}, 3000);
	}
}

var current = document.getElementsByClassName("active");
current[0].className = "";
document.getElementById("MenuRecoverPatient").className += " active";