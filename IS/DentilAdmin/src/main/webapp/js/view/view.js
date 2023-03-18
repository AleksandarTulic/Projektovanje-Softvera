var arr = [];
var orderByType = ["asc", "asc", "asc", "asc"];
var currentOrderBy = "id";
var currentOrderByType = "asc";

function setTableValues(){
	arr = [];
	var table = document.getElementById("myTableBody");
	table.innerHTML = "";
	
	//console.log(this);
	
	for (let i=0;i<this.length;i++){
		var row = table.insertRow(table.rows.length);
	
		var cell1 = row.insertCell(0);
		var cell2 = row.insertCell(1);
		var cell3 = row.insertCell(2);
		var cell4 = row.insertCell(3);
		var cell5 = row.insertCell(4);
		var cell6 = row.insertCell(5);
		var cell7 = row.insertCell(6);
	
		cell1.innerHTML = this[i].id;
		cell2.innerHTML = this[i].name;
		cell3.innerHTML = this[i].surname;
		cell4.innerHTML = this[i].role_name;
		cell5.innerHTML = "<button class=\"btn btn-info\" data-toggle=\"modal\" data-target=\"#myModalViewMore\" onclick=\"return setViewMore('viewMore', " + i + ")\">View more</button>";
		cell6.innerHTML = "<button class=\"btn btn-warning\" data-toggle=\"modal\" data-target=\"#myModalUpdate\" onclick=\"return setUpdateWorker(" + i + ")\">Update</button>";
		
		//console.log(document.getElementById("IdUserLogin").value + " " + this[i].id);
		if (document.getElementById("IdUserLogin").value + "" !== this[i].id)
			cell7.innerHTML = "<button class=\"btn btn-danger\" onclick=\"deleteWorker(" + i + ")\">Delete</button>";
		
		var objPush = {
			"id": this[i].id,
			"role": this[i].role_name
		};
		
		arr.push(objPush);
	}
}

function sortTable(id){
	var table = document.getElementById("myTable");
	
	currentOrderBy = table.rows[0].cells[id].innerHTML.toLowerCase();
	currentOrderByType = orderByType[id];
	
	loadElements(setTableValues, GET_WORKERS, GET_NUMBER_OF_WORKERS);
	
	orderByType[id] = orderByType[id] === "asc" ? "desc" : "asc";
}

function setViewMore(prefix, i){
	resetValuesViewMore(prefix);
	
	var obj = {
		"id": arr[i].id,
		"role": arr[i].role
	};
	
	$.ajax({
		url: "Data?what=selectWorkerWithId",
		type: "POST",
		data: obj,
		success: function(res){
			document.getElementById(prefix + "ID").value = res.id;
			document.getElementById(prefix + "Name").value = res.name;
			document.getElementById(prefix + "Surname").value = res.surname;
			document.getElementById(prefix + "Email").value = res.email;
			document.getElementById(prefix + "Phone").value = res.phone;
			document.getElementById(prefix + "Address").value = res.address;
			document.getElementById(prefix + "Username").value = res.username;
			document.getElementById(prefix + "Role").value = res.role_name;
			
			if (res.jobStart + "" !== "undefined"){
				var jobStart = new Date(res.jobStart);
				//console.log(jobStart.getFullYear() + "-" + (jobStart.getMonth() + 1 < 10 ? "0" + (jobStart.getMonth() + 1) : (jobStart.getMonth() + 1)) + "-" + (jobStart.getDate() < 10 ? "0" + jobStart.getDate() : jobStart.getDate()));
				document.getElementById(prefix + "JobStart").value = jobStart.getFullYear() + "-" + (jobStart.getMonth() + 1 < 10 ? "0" + (jobStart.getMonth() + 1) : (jobStart.getMonth() + 1)) + "-" + (jobStart.getDate() < 10 ? "0" + jobStart.getDate() : jobStart.getDate());
			}
		}
	});
}

function resetValuesViewMore(prefix){
	document.getElementById(prefix + "Form").reset();
}

function setUpdateWorker(i){
	setViewMore("update", i);
	document.getElementById("updateOldID").value = arr[i].id;
}

function deleteWorker(i){
	if (confirm("Are you sure?") === true){
		var obj = {
			"id": arr[i].id,
			"role": arr[i].role
		};
		
		$.ajax({
		url: "Delete",
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
				loadElements(setTableValues, GET_WORKERS, GET_NUMBER_OF_WORKERS);
			}
		}
	});
	}
}

var current = document.getElementsByClassName("active");
current[0].className = "";
document.getElementById("MenuUsers").className += " active";