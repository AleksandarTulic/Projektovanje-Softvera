var arr = [];
var orderByType = ["asc", "asc", "asc"];
var currentOrderBy = "id";
var currentOrderByType = "asc";

function update(){
	console.log(document.getElementById("formUpdatePatient").checkValidity());
	if (document.getElementById("formUpdatePatient").checkValidity()){
		var id = document.getElementById("updateID").value;
		var name = document.getElementById("updateName").value;
		var surname = document.getElementById("updateSurname").value;
		var email = document.getElementById("updateEmail").value;
		var phone = document.getElementById("updatePhone").value;
		var address = document.getElementById("updateAddress").value;
		var oldId = document.getElementById("updateOldID").value;
		
		var obj = {
			"id": id,
			"name": name,
			"surname": surname,
			"phone": phone,
			"email": email,
			"address": address,
			"oldID": oldId
		};
		
		$.ajax({
			url: "Patient?what=updatePatient",
			type: "POST",
			data: obj,
			success: function(res){
				var obj = JSON.parse(res);
				var elements = document.getElementById("updateMessage");
				elements.innerHTML = "<div class=\"" + obj.alertType + "\"> " + obj.message + "</div>";
				
				setInterval(function(){
						document.getElementById("updateMessage").innerHTML = "";
				}, 3000);
				
				if (obj.flag == "true"){
					resetPagination();
					loadElements(setTableValues, GET_PATIENTS, GET_NUMBER_PATIENTS);
				}
			}
		});
	}else{
		var elements = document.getElementById("updateMessage");
		elements.innerHTML = "<div class=\"" + "alert alert-danger" + "\"> " + "Operation Failed" + "</div>";
		
		setInterval(function(){
			document.getElementById("updateMessage").innerHTML = "";
		}, 3000);
	}
}

function deletePatient(id){
	var flag = confirm("Are you sure?");
	
	if (flag === true){
		var obj = {
			"id": id	
		};
		
		$.ajax({
			url: "Patient?what=deletePatient",
			type: "POST",
			data: obj,
			success: function(res){
				var obj = JSON.parse(res);
				var elements = document.getElementById("messagePatient");
				elements.innerHTML = "<div class=\"" + obj.alertType + "\"> " + obj.message + "</div>";
				
				setInterval(function(){
						document.getElementById("messagePatient").innerHTML = "";
				}, 3000);
				
				if (obj.flag == "true"){
					resetPagination();
					loadElements(setTableValues, GET_PATIENTS, GET_NUMBER_PATIENTS);
				}
			}
		});
	}
}

function setUpdatePatient(i){
	document.getElementById("updateID").value = arr[i].id;
	document.getElementById("updateName").value = arr[i].name;
	document.getElementById("updateSurname").value = arr[i].surname;
	document.getElementById("updateEmail").value = arr[i].email + "" === "undefined" ? "" : arr[i].email;
	document.getElementById("updatePhone").value = arr[i].phone + "" === "undefined" ? "" : arr[i].phone;
	document.getElementById("updateAddress").value = arr[i].address + "" === "undefined" ? "" : arr[i].address;
	document.getElementById("updateOldID").value = arr[i].id;
}

function setViewMore(i){
	document.getElementById("viewID").value = arr[i].id;
	document.getElementById("viewName").value = arr[i].name;
	document.getElementById("viewSurname").value = arr[i].surname;
	document.getElementById("viewEmail").value = arr[i].email + "" === "undefined" ? "" : arr[i].email;
	document.getElementById("viewPhone").value = arr[i].phone + "" === "undefined" ? "" : arr[i].phone;
	document.getElementById("viewAddress").value = arr[i].address + "" === "undefined" ? "" : arr[i].address;
}

function setTableValues(){
	arr = [];
	var table = document.getElementById("myTableBody");
	
	for (let i=0;i<this.length;i++){
		var row = table.insertRow(table.rows.length);
	
		var cell1 = row.insertCell(0);
		var cell2 = row.insertCell(1);
		var cell3 = row.insertCell(2);
		var cell4 = row.insertCell(3);
		var cell5 = row.insertCell(4);
		var cell6 = row.insertCell(5);
	
		cell1.innerHTML = this[i].id;
		cell2.innerHTML = this[i].name;
		cell3.innerHTML = this[i].surname;
		cell4.innerHTML = "<button class=\"btn btn-info\" data-toggle=\"modal\" data-target=\"#myModal3\" onclick=\"return setViewMore(" + i + ")\">View more</button>";
		cell5.innerHTML = "<button class=\"btn btn-warning\" data-toggle=\"modal\" data-target=\"#myModal2\" onclick=\"return setUpdatePatient(" + i + ")\">Update</button>";
		cell6.innerHTML = "<button class=\"btn btn-danger\" onclick=\"return deletePatient(" + this[i].id + ")\">Delete</button>";
		
		var objPush = {
			"id": this[i].id,
			"name": this[i].name,
			"surname": this[i].surname,
			"email": this[i].email,
			"address": this[i].address,
			"phone": this[i].phone
		};
		
		arr.push(objPush);
	}
}

function sortTable(id){
	var table = document.getElementById("myTable");
	
	currentOrderBy = table.rows[0].cells[id].innerHTML.toLowerCase();
	currentOrderByType = orderByType[id];
	
	loadElements(setTableValues, GET_PATIENTS, GET_NUMBER_PATIENTS);
	
	orderByType[id] = orderByType[id] === "asc" ? "desc" : "asc";
}

var current = document.getElementsByClassName("active");
current[0].className = "";
document.getElementById("MenuPatient").className += " active";