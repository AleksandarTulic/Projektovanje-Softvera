function insertAppointment(){
	if (document.getElementById("checkIfPatientInputed").checked){
		var startDate = document.getElementById("date").value;
		var idDentist = document.getElementById("idDentist").value;
		var startTime = document.getElementById("hoursStart").value + ":" + document.getElementById("minutesStart").value + ":00";
		var howLong = document.getElementById("howLong").value;
		var idPatient = document.getElementById("insertID").value;
		var idPersonal = document.getElementById("idPersonal").value;
		
		var obj = {
			"startDate": startDate,
			"startTime": startTime,
			"idPatient": idPatient,
			"idDentist": idDentist,
			"idPersonal": idPersonal,
			"howLong": howLong
		};
		
		$.ajax({
			url: "Appointment?what=insertAppointment",
			type: "POST",
			data: obj,
			success: function(res){
				var obj = JSON.parse(res);
				var elements = document.getElementById("messageAppointment");
				elements.innerHTML = "<div class=\"" + obj.alertType + "\"> " + obj.message + "</div>";
				setInterval(function(){
					document.getElementById("messageAppointment").innerHTML = "";
				}, 5000);
				
				if (obj.flag){
					document.getElementById("message").innerHTML = "";
					resetAll();
				}
			}
		});
	}
}