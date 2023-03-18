var arr = [];
var arrWorkers = [];
var orderByType = ["asc", "asc", "asc", "asc"];
var currentOrderBy = "name";
var currentOrderByType = "asc";

var arrDelete = [];
var arrAddSchedule = [];

function setTableValues(){
	arr = [];
	arrDelete = [];
	var table = document.getElementById("myTableBody");
	table.innerHTML = "";
	
	for (let i=0;i<this.length;i++){
		var row = table.insertRow(table.rows.length);
		
		var cell1 = row.insertCell(0);
		var cell2 = row.insertCell(1);
		var cell3 = row.insertCell(2);
		var cell4 = row.insertCell(3);
		var cell5 = row.insertCell(4);
		
		var showDate = new Date(this[i].schedule.date);
		cell1.innerHTML = this[i].name + " " + this[i].surname;
		cell2.innerHTML = this[i].role_name;
		cell3.innerHTML = showDate.getFullYear() + "-" + (showDate.getMonth() + 1) + "-" + showDate.getDate();
		cell4.innerHTML = convertTime12To24(this[i].shift.begin) + " - " + convertTime12To24(this[i].shift.end);
		cell5.innerHTML = "<input class=\"checkThemAll\" type=\"checkbox\" name=\"check_" + i +"\" onclick=\"selectedForDelete(this, " + i + ")\">";
	
		var objPush = {
			"idPersonal": this[i].id,
			"date": showDate.getFullYear() + "-" + (showDate.getMonth() + 1) + "-" + showDate.getDate(),
			"idShift": this[i].shift.id
		};
		
		arr.push(objPush);	
	}
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

function sortTable(id){
	var table = document.getElementById("myTable");
	
	currentOrderBy = table.rows[0].cells[id].innerHTML.toLowerCase();
	currentOrderByType = orderByType[id];
	
	loadElements(setTableValues, GET_SCHEDULES, GET_NUMBER_OF_SCHEDULES);
	
	orderByType[id] = orderByType[id] === "asc" ? "desc" : "asc";
}

function selectedForDelete(element, i){
	if (element.checked + "" === "true")
		arrDelete.push(i);
	else{
		const index = arrDelete.indexOf(i);
		arrDelete.splice(index, 1);
		document.getElementById("checkThemAllID").checked = false;
	}
	
	console.log(arrDelete);
}

function deleteSchedule(){
	if (confirm("Are you sure?")){
		var arrDate = [];
		var arrIdPersonal = [];
		var arrIdShift = [];
		
		for (let i=0;i<arrDelete.length;i++){
			arrDate.push(arr[arrDelete[i]].date);
			arrIdPersonal.push(arr[arrDelete[i]].idPersonal);
			arrIdShift.push(arr[arrDelete[i]].idShift);
		}
		
		var obj = {
			"idPersonal": arrIdPersonal,
			"idShift": arrIdShift,
			"date": arrDate
		};
		
		console.log(obj);
		
		$.ajax({
			url: "Schedule?what=deleteSchedule",
			type: "POST",
			data: obj,
			success: function(res){
				var resObj = JSON.parse(res);
				var elements = document.getElementById("messageResult");
				elements.innerHTML = "<div class=\"" + resObj.alertType + "\"> " + resObj.message + "</div>";
				
				setInterval(function(){
					document.getElementById("messageResult").innerHTML = "";
				}, 3000);
				
				if (resObj.flag + "" === "true"){
					resetPagination();
					loadElements(setTableValues, GET_SCHEDULES, GET_NUMBER_OF_SCHEDULES);
				}
			}
		});
		
		arrDelete = [];
		document.getElementById("checkThemAllID").checked = false;
	}
}

function selectShiftsAndWorkers(){
	arrWorkers = [];
    arrAddSchedule = [];
	
	loadShifts("idShift1");
	
	var obj = {
		"orderBy": "name",
		"orderByType": "asc"
	};
	
	$.ajax({
		url: "Data?what=selectWorkersWithoutAdmins",
		type: "POST",
		data: obj,
		success: function(res){
			arrWorkers = [];
			var table = document.getElementById("workersSchedulesSelect");
			table.innerHTML = "";
			
			for (let i=0;i<res.length;i++){
				var row = table.insertRow(table.rows.length);
		
				var cell1 = row.insertCell(0);
				var cell2 = row.insertCell(1);
				
				cell1.innerHTML = res[i].name + " " + res[i].surname;
				cell2.innerHTML = "<input type=\"checkbox\" name=\"check_worker_" + i +"\" onclick=\"selectedForAddingSchedule(this, " + i + ")\">";
				arrWorkers.push(res[i].id);
			}
		}
	});
}

function selectedForAddingSchedule(element, i){
	if (element.checked + "" === "true")
		arrAddSchedule.push(i);
	else{
		const index = arrAddSchedule.indexOf(i);
		arrAddSchedule.splice(index, 1);
	}
}

function addSchedule(){
	var arrSendPersonal = [];
	for (let i=0;i<arrAddSchedule.length;i++){
		arrSendPersonal.push(arrWorkers[arrAddSchedule[i]]);
	}
	
	var obj = {
		"idPersonal": arrSendPersonal,
		"idShift": document.getElementById("idShift1").value,
		"date": document.getElementById("date").value
	};
	
	$.ajax({
		url: "Schedule?what=addSchedule",
		type: "POST",
		data: obj,
		success: function(res){
			var resObj = JSON.parse(res);
			var elements = document.getElementById("messageResult");
			elements.innerHTML = "<div class=\"" + resObj.alertType + "\"> " + resObj.message + "</div>";
			
			setInterval(function(){
				document.getElementById("messageResult").innerHTML = "";
			}, 3000);
			
			if (resObj.flag + "" === "true"){
				selectShiftsAndWorkers();
			}
		}
	});
}

function deleteShift(){
	var obj = {
		"idShift": document.getElementById("idShift2").value
	};
	
	$.ajax({
		url: "Shift?what=deleteShift",
		type: "POST",
		data: obj,
		success: function(res){
			var resObj = JSON.parse(res);
			var elements = document.getElementById("messageResult");
			elements.innerHTML = "<div class=\"" + resObj.alertType + "\"> " + resObj.message + "</div>";
			
			setInterval(function(){
				document.getElementById("messageResult").innerHTML = "";
			}, 3000);
			
			if (resObj.flag + "" === "true"){
				loadShifts("idShift2");
			}
		}
	});
}

function addShift(){
	var obj = {
		"begin": document.getElementById("begin").value,
		"end": document.getElementById("end").value
	};
	
	$.ajax({
		url: "Shift?what=addShift",
		type: "POST",
		data: obj,
		success: function(res){
			var resObj = JSON.parse(res);
			var elements = document.getElementById("messageResult");
			elements.innerHTML = "<div class=\"" + resObj.alertType + "\"> " + resObj.message + "</div>";
			
			setInterval(function(){
				document.getElementById("messageResult").innerHTML = "";
			}, 3000);
			
			if (resObj.flag + "" === "true"){
				loadShifts("idShift2");
			}
		}
	});
}

function loadShifts(whatElement){
	$.ajax({
		url: "Data?what=selectShifts",
		type: "POST",
		data: null,
		success: function(res){
			arrSchedules = [];
			document.getElementById(whatElement).innerHTML = "";
			for (let i=0;i<res.length;i++){
				document.getElementById(whatElement).innerHTML += "<option value=\"" + res[i].id + "\">" + convertTime12To24(res[i].begin) + " - " + convertTime12To24(res[i].end) + "</option>";
			}
		}
	});
}

var current = document.getElementsByClassName("active");
current[0].className = "";
document.getElementById("MenuSchedule").className += "active";