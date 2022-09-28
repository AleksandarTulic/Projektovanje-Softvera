function updateUserDefaultInput(someClassName){
	var tr = document.getElementById("element_" + someClassName);
	var tds = tr.children;
	
	var id = tds[0].outerText;
	var name = tds[1].outerText;
	var surname = tds[2].outerText;
	
	var elements = document.getElementsByClassName("child_" + someClassName);
	
	var email = elements[0].children[2].innerText;
	var phone = elements[1].children[2].innerText;
	var address = elements[2].children[2].innerText;
	
	document.getElementById("updateID").setAttribute("value", id);
	document.getElementById("updateName").setAttribute("value", name);
	document.getElementById("updateSurname").setAttribute("value", surname);
	document.getElementById("updateEmail").setAttribute("value", email);
	document.getElementById("updatePhone").setAttribute("value", phone);
	document.getElementById("updateAddress").setAttribute("value", address);
	document.getElementById("updateOldID").setAttribute("value", id);
}

function updatePatient(){
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
			}, 5000);
			
			if (obj.flag == "true"){
				reset();
				
				var table = document.getElementById("myTable");
				var rows = table.rows;
				for (let i=0;i<rows.length;i++){
					var cells = rows[i].cells;
					if (cells[0].innerHTML == oldId){
						var counter = parseInt(rows[i].id.split("_")[1]);
						cells[0].innerHTML = id;
						cells[1].innerHTML = name;
						cells[2].innerHTML = surname;
						cells[4].innerHTML = "<button onclick=\"areYouSureDeletePatient(" + id + ", " + counter + ")\" class=\"btn btn-danger\">Delete</button>";
						
						var cells1 = rows[i + 1].cells;
						cells1[2].innerHTML = email;
						var cells2 = rows[i + 2].cells;
						cells2[2].innerHTML = phone;
						var cells3 = rows[i + 3].cells;
						cells3[2].innerHTML = address;
						break;
					}
				}
			}
		}
	});
}

var current = document.getElementsByClassName("active");
current[0].className = "";
document.getElementById("MenuPatient").className += " active";