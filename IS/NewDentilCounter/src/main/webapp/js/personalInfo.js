var orderByType = ["asc", "asc"];
var currentOrderBy = "date";
var currentOrderByType = "asc";

function setTableValues(){
	var table = document.getElementById("myTableBody");
	table.innerHTML = "";
	
	for (let i=0;i<this.a.length;i++){
		var row = table.insertRow(table.rows.length);
	
		var cell1 = row.insertCell(0);
		var cell2 = row.insertCell(1);
		
		cell1.innerHTML = this.a[i].date;
		cell2.innerHTML = convertTime12To24(this.b[i].begin) + " - " + convertTime12To24(this.b[i].end);
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
	var table = document.getElementById("myTable2");
	
	currentOrderBy = table.rows[0].cells[id].innerHTML.toLowerCase();
	currentOrderByType = orderByType[id];
	
	loadElements(setTableValues, 
	GET_PERSONAL_SCHEDULE + "&id=" + document.getElementById("idOfPersonalLogedIn").innerHTML, 
	GET_NUMBER_PERSONAL_SCHEDULE + "&id=" + document.getElementById("idOfPersonalLogedIn").innerHTML);
	
	orderByType[id] = orderByType[id] === "asc" ? "desc" : "asc";
}

var current = document.getElementsByClassName("active");
current[0].className = "";
document.getElementById("MenuHome").className += " active";