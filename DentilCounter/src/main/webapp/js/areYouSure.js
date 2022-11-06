function areYouSure(){
	return confirm("Are you sure?");
}

function areYouSureDeletePatient(idPatient, idCounter){
	if (confirm("Are you sure?") == true){
		var obj = {
			"idPatient": idPatient
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
				}, 5000);
				
				if (obj.flag == "true"){
					var table = document.getElementById("myTable");
					var row = table.rows;
					const pos = [];
					for (let i=0;i<row.length;i++){
						if (row[i].id == "element_" + idCounter){
							pos.push(i);
						}else if (row[i].classList.contains("child_" + idCounter)){
							pos.push(i);
						}
					}
					
					for (let i=0;i<pos.length;i++){
						table.deleteRow(pos[i] - i);
					}
					
					$('#myTableBody').pageMe({pagerSelector:'#myPager',showPrevNext:true,hidePageNumbers:false,perPage:8});
				}
			}
		});
	}
}

function areYouSureDeleteAppointment(idDentist, startDate, startTime, viewAppointment){
	if (areYouSure()){
		var currDate = new Date(startDate);
		var obj = {
			"idDentist": idDentist,
			"startDate": currDate.getFullYear() + "-" + convertToRightFormat(currDate.getMonth() + 1) + "-" + convertToRightFormat(currDate.getDate()),
			"startTime": startTime,
			"howLong": 1 //it does not matter, just to pass AppointmentFactory
		};
		
		$.ajax({
			url: "Appointment?what=deleteAppointment",
			type: "POST",
			data: obj,
			success: function(res){
				console.log(res);
				var obj = JSON.parse(res);
				var message = document.getElementById("messageDeleteAppointment");
				message.innerHTML = "<div class=\"" + obj.alertType + "\"> " + obj.message + "</div>";
				
				if (obj.flag == "true"){
					var row = document.getElementById(viewAppointment);
					row.parentNode.removeChild(row);
					
					$('#ViewAppointmentTableBody').pageMe({pagerSelector:'#myPager',showPrevNext:true,hidePageNumbers:false,perPage:8});
				}
			}
		});
	}
}