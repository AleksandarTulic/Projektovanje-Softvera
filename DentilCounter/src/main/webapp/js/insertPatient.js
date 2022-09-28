function insertPatient(){
	var id = document.getElementById("insertID").value;
	var name = document.getElementById("insertName").value;
	var surname = document.getElementById("insertSurname").value;
	var email = document.getElementById("insertEmail").value;
	var phone = document.getElementById("insertPhone").value;
	var address = document.getElementById("insertAddress").value;
	
	if (email === "")
		email = null;
	
	if (phone === "")
		phone = null;
	
	if (address === "")
		address = null;
	
	var obj = {
			"id": id,
			"name": name,
			"surname": surname,
			"email": email,
			"phone": phone,
			"address": address
	};
	
	$.ajax({
		url: "Patient?what=insertPatient",
		type: "POST",
		data: obj,
		success: function(res){
			var obj = JSON.parse(res);
			var elements = document.getElementById("message");
			elements.innerHTML = "<div class=\"" + obj.alertType + "\"> " + obj.message + "</div>";
			
			if (obj.flag){
				document.getElementById("checkIfPatientInputed").checked = true;
			}
		}
	});
}