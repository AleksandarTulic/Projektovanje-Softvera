function dateChanged(value){
	document.getElementById("hoursStart").innerHTML = "";
	document.getElementById("minutesStart").innerHTML = "";
	$.get("Data?what=getDentist&value=" + value, function(responseJson){
		//console.log(responseJson);
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
	});
}

function dentistChange(value){
	$.get("Data?what=getDentist&value=" + value, function(responseJson){
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
	});
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

function convertToRightFormat(value){
	if (value < 10)
		return "0" + value;
		
	return "" + value;
}

function hoursChanged(value){
	var idDentist = document.getElementById("idDentist").value;
	var date = document.getElementById("date").value;
	
	$.get("Data?what=getAppointmentsSameDayAndDentist&date=" + date + "&idDentist=" + idDentist,function(resJson){
		const arr = [];
		for (let j=0;j<resJson.length;j++){
			var begin = new Date(resJson[j].startDate + " " + convertTime12To24(resJson[j].startTime));
			var end = new Date(begin.getTime() + resJson[j].howLong * 60000);
			arr.push({
				"begin" : begin,
				"end" : end
			});
		}
		
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
	});

}

function resetAll(){
	document.getElementById("idDentist").innerHTML = "";
	document.getElementById("hoursStart").innerHTML = "";
	document.getElementById("minutesStart").innerHTML = "";
	document.getElementById("howLong").value = 0;
	document.getElementById("checkIfPatientInputed").checked = false;
	document.getElementById("date").value = "";
	
	document.getElementById("insertEmail").value = "";
	document.getElementById("insertPhone").value = "";
	document.getElementById("insertAddress").value = "";
	document.getElementById("insertName").value = "";
	document.getElementById("insertID").value = "";
	document.getElementById("insertSurname").value = "";
}

function getAllPatients(){
	$.get("Data?what=getPatients", function(responseJson){
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
	});
}

function getWithId(value){
	$.get("Data?what=getPatient&idPatient=" + value, function(responseJson){
		setInsertPatientValeus(responseJson);
	});
}

function getWithName(value){
	$.get("Data?what=getPatient&idPatient=" + value, function(responseJson){
		setInsertPatientValeus(responseJson);
	});
}

function getWithSurname(value){
	$.get("Data?what=getPatient&idPatient=" + value, function(responseJson){
		setInsertPatientValeus(responseJson);
	});
}

function setInsertPatientValeus(responseJson){
	if (responseJson == null)
		return;
		
	document.getElementById("insertID").value = responseJson.id;
	document.getElementById("insertName").value = responseJson.name;
	document.getElementById("insertSurname").value = responseJson.surname;
	document.getElementById("insertPhone").value = responseJson.phone;
	document.getElementById("insertEmail").value = responseJson.email;
	document.getElementById("insertAddress").value = responseJson.address;
	document.getElementById("checkIfPatientInputed").checked = true;
}

var current = document.getElementsByClassName("active");
current[0].className = "";
document.getElementById("MenuAppointment").className += " active";