function areYouSure(){
	if (confirm("Are you sure?") == true){
		return true;
	}else{
		return false;
	}
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