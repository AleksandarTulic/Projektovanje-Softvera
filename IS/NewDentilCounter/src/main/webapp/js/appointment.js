var arr = [];
var orderByType = ["asc", "asc", "asc"];
var currentOrderBy = "patient";
var currentOrderByType = "asc";

function setTableValues(){
	arr = [];
	var table = document.getElementById("myTableBody");
	table.innerHTML = "";
	
	for (let i=0;i<this.length;i++){
		var row = table.insertRow(table.rows.length);
	
		var cell1 = row.insertCell(0);
		var cell2 = row.insertCell(1);
		var cell3 = row.insertCell(2);
		var cell4 = row.insertCell(3);
		var cell5 = row.insertCell(4);
		
		cell1.innerHTML = this[i].patientDTO.name + " " + this[i].patientDTO.surname;
		cell2.innerHTML = this[i].dentistDTO.name + " " + this[i].dentistDTO.surname;
		cell3.innerHTML = this[i].startDate;
		
		var timeEnd = new Date(new Date().toDateString() + " " + this[i].startTime);
		timeEnd.setMinutes(timeEnd.getMinutes() + Number(this[i].howLong));
		cell4.innerHTML = convertTime12To24(this[i].startTime) + " - " + 
		convertToRightFormat(timeEnd.getHours()) + ":" + 
		convertToRightFormat(timeEnd.getMinutes()) + ":" + 
		convertToRightFormat(timeEnd.getSeconds());
		
		cell5.innerHTML = "<button class=\"btn btn-danger\" onclick=\"deleteAppointment(" + i + ")\">Delete</button>";
	
		var aDate = new Date(this[i].startDate);
		var objPush = {
			"patientName": this[i].patientDTO.name,
			"patientSurname": this[i].patientDTO.surname,
			"dentistName": this[i].dentistDTO.name,	
			"dentistSurname": this[i].dentistDTO.surname,
			"idDentist": this[i].idDentist,
			"startDate": aDate.getFullYear() + "-" + (aDate.getMonth() + 1) + "-" + aDate.getDate(),
			"startTime": convertTime12To24(this[i].startTime),
			"howLong": this[i].howLong,
			
		};
		
		arr.push(objPush);
	}
}

function convertToRightFormat(value){
	if (value < 10)
		return "0" + value;
		
	return "" + value;
}

function convertTime12To24(time) {
    var hours   = Number(time.match(/^(\d+)/)[1]);
    var minutes = Number(time.match(/:(\d+)/)[1]);
    var AMPM    = time.match(/\s(.*)$/)[1];
    if (AMPM === "PM" && hours < 12) hours = hours + 12;
    if (AMPM === "AM" && hours === 12) hours = hours - 12;
    var sHours   = hours.toString();
    var sMinutes = minutes.toString();
    if (hours < 10) sHours = "0" + sHours;
    if (minutes < 10) sMinutes = "0" + sMinutes;
    return (sHours + ":" + sMinutes + ":00");
}

function deleteAppointment(index){
	if (confirm("Are You Sure?") === true){
		$.ajax({
			url: "Appointment?what=deleteAppointment",
			type: "POST",
			data: arr[index],
			success: function(res){
				console.log(res);
				var obj = JSON.parse(res);
				var elements = document.getElementById("messageDeleteAppointment");
				elements.innerHTML = "<div class=\"" + obj.alertType + "\"> " + obj.message + "</div>";
				
				setInterval(function(){
						document.getElementById("messageDeleteAppointment").innerHTML = "";
				}, 3000);
				
				if (obj.message === "Operation Successful"){
					resetPagination();
					loadElements(setTableValues, GET_APPOINTMENTS, 
					GET_NUMBER_APPOINTMENTS);
				}
			}
		});
	}
}

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
				
				setTimeout(function(){
					document.getElementById("messageAppointment").innerHTML = "";
				}, 3000);
				
				if (obj.flag){
					resetAll();
				}
			}
		});
	}
}

function insertPatient(){
	console.log(document.getElementById("insertAppointmentPatient").checkValidity());
	
	if (document.getElementById("insertAppointmentPatient").checkValidity()){
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
				console.log(res);
				var obj = JSON.parse(res);
				var elements = document.getElementById("messageInsertPatient");
				elements.innerHTML = "<div class=\"" + obj.alertType + "\"> " + obj.message + "</div>";
				
				setInterval(function(){
						document.getElementById("messageInsertPatient").innerHTML = "";
				}, 3000);
				
				if (obj.flag){
					document.getElementById("checkIfPatientInputed").checked = true;
				}
			}
		});
	}else{
		var elements = document.getElementById("messageInsertPatient");
		elements.innerHTML = "<div class=\"" + "alert alert-danger" + "\"> " + "Operation Failed" + "</div>";
		
		setInterval(function(){
			document.getElementById("messageInsertPatient").innerHTML = "";
		}, 3000);
	}
}

function getWithId(value){
	$.ajax({
		url: "Data?what=getPatient&idPatient=" + value,
		type: "POST",
		data: null,
		success: function(res){
			setInsertPatientValeus(res);
		}
	});
}

function getWithName(value){
	$.ajax({
		url: "Data?what=getPatient&idPatient=" + value,
		type: "POST",
		data: null,
		success: function(res){
			setInsertPatientValeus(res);
		}
	});
}

function getWithSurname(value){
	$.ajax({
		url: "Data?what=getPatient&idPatient=" + value,
		type: "POST",
		data: null,
		success: function(res){
			setInsertPatientValeus(res);
		}
	});
}

function setInsertPatientValeus(responseJson){
	if (responseJson == null)
		return;
		
	document.getElementById("insertID").value = responseJson.id;
	document.getElementById("insertName").value = responseJson.name;
	document.getElementById("insertSurname").value = responseJson.surname;
	document.getElementById("insertPhone").value = responseJson.phone + "" === "undefined" ? "" : responseJson.phone;
	document.getElementById("insertEmail").value = responseJson.email + "" === "undefined" ? "" : responseJson.email;
	document.getElementById("insertAddress").value = responseJson.address + "" === "undefined" ? "" : responseJson.address;
	document.getElementById("checkIfPatientInputed").checked = true;
}

function getAllPatients(){
	var obj = {
		"orderBy": "name",
		"orderByType": "asc"
	};
	
	$.ajax({
		url: "Data?what=getPatients",
		type: "POST",
		data: obj,
		success: function(responseJson){
			var datalistID = document.getElementById("datalistID");
			var datalistName = document.getElementById("datalistName");
			var datalistSurname = document.getElementById("datalistSurname");
			datalistID.innerHTML = "";
			datalistName.innerHTML = "";
			datalistSurname.innerHTML = "";
	
			for (let i=0;i<responseJson.length;i++){
				var option1 = document.createElement("option");
				option1.value = responseJson[i].id;
				option1.text =  responseJson[i].name + " " + responseJson[i].surname;
				datalistID.appendChild(option1);
				
				var option2 = document.createElement("option");
				option2.value = responseJson[i].id;
				option2.text = responseJson[i].name + " " + responseJson[i].surname;
				datalistName.appendChild(option2);
				
				var option3 = document.createElement("option");
				option3.value = responseJson[i].id;
				option3.text = responseJson[i].name + " " + responseJson[i].surname;
				datalistSurname.appendChild(option3);
			}
			}
		});
}

function sortTable(id){
	var table = document.getElementById("myTable");
	
	currentOrderBy = table.rows[0].cells[id].innerHTML.toLowerCase();
	currentOrderByType = orderByType[id];
	
	loadElements(setTableValues, GET_APPOINTMENTS, GET_NUMBER_APPOINTMENTS);
	
	orderByType[id] = orderByType[id] === "asc" ? "desc" : "asc";
}

function resetSelectPatient(){
	document.getElementById("insertID").value = "";
	document.getElementById("insertName").value = "";
	document.getElementById("insertSurname").value = "";
	document.getElementById("insertPhone").value = "";
	document.getElementById("insertEmail").value = "";
	document.getElementById("insertAddress").value = "";
	document.getElementById("checkIfPatientInputed").checked = false;
}

function resetAll(){
	document.getElementById("idDentist").innerHTML = "";
	document.getElementById("hoursStart").innerHTML = "";
	document.getElementById("minutesStart").innerHTML = "";
	document.getElementById("howLong").value = 0;
	document.getElementById("date").value = "";
	
	resetSelectPatient();
}

function selectPatient(){
	if (document.getElementById("checkIfPatientInputed").checked === true){
		$('#myModal1').modal('hide');
	}else{
		var elements = document.getElementById("messageInsertPatient");
		elements.innerHTML = "<div class=\"alert alert-danger\">Patient needs to be selected.</div>";
			
		setInterval(function(){
				document.getElementById("messageInsertPatient").innerHTML = "";
		}, 3000);
	}
}

function dateChanged(value){
	document.getElementById("hoursStart").innerHTML = "";
	document.getElementById("minutesStart").innerHTML = "";
	
	$.ajax({
		url: "Data?what=getDentist&value=" + value,
		type: "POST",
		data: null,
		success: function(responseJson){
			var nodeSelect = document.getElementById("idDentist");
			nodeSelect.innerHTML = "";
			for (let i=0;i<responseJson.length;i++){
				var option = document.createElement("option");
				option.value = responseJson[i].id;
				option.text = responseJson[i].name + " " + responseJson[i].surname;
				nodeSelect.add(option);
				
				if (i === 0){
					var node = document.getElementById("hoursStart");
					var elementsBegin = responseJson[i].shift.begin.split(":");
					var elementsEnd = responseJson[i].shift.end.split(":");
					var hoursStart = parseInt(elementsBegin[0]);
					var hoursEnd = parseInt(elementsEnd[0]);
					
					if (responseJson[i].shift.begin.includes("PM"))
						hoursStart = (hoursStart + 12) % 24;
					if (responseJson[i].shift.end.includes("PM"))
						hoursEnd = (hoursEnd + 12) % 24;
	
					for (let j=hoursStart;j<=hoursEnd;j++){
						var hoursStartOption = document.createElement("option");
						hoursStartOption.value = convertToRightFormat(j);
						hoursStartOption.text = j;
						node.add(hoursStartOption);
					}
					
					hoursChanged(hoursStart);
				}
			}
		}
	});
}

function dentistChange(value){
	$.ajax({
		url: "Data?what=getDentist&value=" + value,
		type: "POST",
		data: null,
		success: function(responseJson){
			for (let i=0;i<responseJson.length;i++){
				if (i === value){
					var node = document.getElementById("hoursStart");
					node.innerHTML = "";
					var elementsBegin = responseJson[i].shift.begin.split(":");
					var elementsEnd = responseJson[i].shift.end.split(":");
					var hoursStart = parseInt(elementsBegin[0]);
					var hoursEnd = parseInt(elementsEnd[0]);
					
					if (responseJson[i].shift.begin.includes("PM"))
						hoursStart = (hoursStart + 12) % 24;
					if (responseJson[i].shift.end.includes("PM"))
						hoursEnd = (hoursEnd + 12) % 24;
	
					for (let j=hoursStart;j<=hoursEnd;j++){
						var hoursStartOption = document.createElement("option");
						hoursStartOption.value = convertToRightFormat(j);
						hoursStartOption.text = j;
						node.add(hoursStartOption);
					}
					
					hoursChanged(hoursStart);
				}
			}
		}
	});
}

function hoursChanged(value){
	var idDentist = document.getElementById("idDentist").value;
	var date = document.getElementById("date").value;
	
	$.ajax({
		url: "Data?what=getAppointmentsSameDayAndDentist&date=" + date + "&idDentist=" + idDentist,
		type: "POST",
		data: null,
		success: function(resJson){
			console.log(resJson);
			const arr = [];
			for (let j=0;j<resJson.length;j++){
				var begin = new Date(resJson[j].startDate + " " + convertTime12To24(resJson[j].startTime));
				var end = new Date(begin.getTime() + resJson[j].howLong * 60000);
				arr.push({
					"begin" : begin,
					"end" : end
				});
			}
			
			console.log(arr);
			
			var minutes = document.getElementById("minutesStart");
			minutes.innerHTML = "";
			var optionElements = document.getElementById("hoursStart").children;
			var maks = optionElements[optionElements.length - 1].value;
			for (let i=0;i<=59;i++){
				if (i != 0 && maks == value)
					break;
	
				var flag = true;
				for (let j=0;j<arr.length;j++){
					var current = new Date(date + " " + value + ":" + convertToRightFormat(i) + ":00");
					if (arr[j].begin <= current && current <= arr[j].end){
						flag = false;
						break;
					}
				}
				
				if (flag){
					var minutesStartOption = document.createElement("option");
					minutesStartOption.value = convertToRightFormat(i);
					minutesStartOption.text = i;
					minutes.add(minutesStartOption);
				}
			}
		}
	});

}

var current = document.getElementsByClassName("active");
current[0].className = "";
document.getElementById("MenuAppointment").className += " active";