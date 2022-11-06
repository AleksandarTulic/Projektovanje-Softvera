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

function loadAppointments(){
	patientID = document.getElementById("patientIdView").value;
	patientName = document.getElementById("patientNameView").value;
	patientSurname = document.getElementById("patientSurnameView").value;
	dentistName = document.getElementById("dentistNameView").value;
	dentistSurname = document.getElementById("dentistSurnameView").value;
	date = document.getElementById("dateView").value;
	
	$.get("Data?what=getAppointments&idPatient=" + patientID + "&patientName=" + patientName + 
	"&patientSurname=" + patientSurname + "&dentistName=" + dentistName + 
	"&dentistSurname=" + dentistSurname + "&date=" + date, function(responseJson){
		var table = document.getElementById("ViewAppointmentTableBody");
		table.innerHTML = "";
		
		for (let i=0;i<responseJson.length;i++){
			var row = table.insertRow(0);
			var cell1 = row.insertCell(0);
			var cell2 = row.insertCell(1);
			var cell3 = row.insertCell(2);
			var cell4 = row.insertCell(3);
			var cell5 = row.insertCell(4);
			cell1.innerHTML = responseJson[i].patientDTO.name + " " + responseJson[i].patientDTO.surname;
			cell2.innerHTML = responseJson[i].dentistDTO.name + " " + responseJson[i].dentistDTO.surname;
			cell3.innerHTML = responseJson[i].startDate;
			var timeEnd = new Date(new Date().toDateString() + " " + responseJson[i].startTime);
			timeEnd.setMinutes(timeEnd.getMinutes() + Number(responseJson[i].howLong));
			cell4.innerHTML = convertTime12To24(responseJson[i].startTime) + " - " + convertToRightFormat(timeEnd.getHours()) + ":" + convertToRightFormat(timeEnd.getMinutes()) + ":" + convertToRightFormat(timeEnd.getSeconds());
			cell5.innerHTML = "<button class=\"btn btn-danger\" onclick=\"areYouSureDeleteAppointment('" + responseJson[i].idDentist + "', '" + responseJson[i].startDate + "', '" + convertTime12To24(responseJson[i].startTime) + "', 'ViewAppointment_" + i + "')\">Delete</button>";
			row.id = "ViewAppointment_" + i;
		}
		
		$('#ViewAppointmentTableBody').pageMe({pagerSelector:'#myPager',showPrevNext:true,hidePageNumbers:false,perPage:8});
	});
}

var current = document.getElementsByClassName("active");
current[0].className = "";
document.getElementById("MenuAppointment").className += " active";