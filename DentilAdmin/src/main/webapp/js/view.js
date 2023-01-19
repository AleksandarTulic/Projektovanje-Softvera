function searchByInputValue(value){
	
	var table = document.getElementsByTagName("table");
	var tbody = table[0].children[1];
	var tr = tbody.children;
	
	for (let i=0;i<tr.length;i++){
		if (tr[i].className == "paintInGrey" || tr[i].className.includes("paintInGrey")){
			var tds = tr[i].children;
			
			var id = tds[0].outerText;
			var name = tds[1].outerText;
			var surname = tds[2].outerText;
			var role = tds[3].outerText;
			
			if (id.toUpperCase().includes(value.toUpperCase()) || name.toUpperCase().includes(value.toUpperCase()) ||
			surname.toUpperCase().includes(value.toUpperCase()) || role.toUpperCase().includes(value.toUpperCase())){
				tr[i].removeAttribute("hidden");
			}else{
				tr[i].setAttribute("hidden", "");
			}
		}else{
			tr[i].setAttribute("hidden", "");
		}
	}
	
	//console.log(document.getElementById("perPageIDView").value);
	if (value + "" === ""){
		//console.log("Proslo ...");
		$('#myTableBody').pageMe({pagerSelector:'#myPager',showPrevNext:true,hidePageNumbers:false,perPage:Number(document.getElementById("perPageIDView").value)});
	}
}

function updateUserDefaultInput(someClassName){
	var tr = document.getElementById("element_" + someClassName);
	var tds = tr.children;
	
	var id = tds[0].outerText;
	var name = tds[1].outerText;
	var surname = tds[2].outerText;
	var role = tds[3].outerText;
	
	var elements = document.getElementsByClassName("child_" + someClassName);
	
	var email = elements[0].children[2].innerText;
	var phone = elements[1].children[2].innerText;
	var address = elements[2].children[2].innerText;
	var usernamee = elements[3].children[2].innerText;
	var jobStart = '';
	var jobEnd = '';
	
	if (!(role === "admin")){
		jobStart = elements[4].children[2].innerText;
		jobEnd = elements[5].children[2].innerText;
	}
	
	document.getElementById("updateID").setAttribute("value", id);
	document.getElementById("updateName").setAttribute("value", name);
	document.getElementById("updateSurname").setAttribute("value", surname);
	document.getElementById("updateEmail").setAttribute("value", email);
	document.getElementById("updatePhone").setAttribute("value", phone);
	document.getElementById("updateAddress").setAttribute("value", address);
	document.getElementById("updateUsername").setAttribute("value", usernamee);
	
	document.getElementById("updateRole").setAttribute("value", role);
	document.getElementById("updateOldID").setAttribute("value", id);
	
	if (role === "admin"){
		document.getElementById("dateOfStartEndWork").style.display = "none";
		document.getElementById("updateJobStart").removeAttribute("required");
	}else{
		document.getElementById("updateJobStart").setAttribute("value", jobStart);
		if (jobEnd !== ""){
			document.getElementById("updateJobEnd").setAttribute("value", jobEnd);
		}
		
		document.getElementById("dateOfStartEndWork").style.display = "block";
		document.getElementById("updateJobStart").setAttribute("required", "");
	}
}

var current = document.getElementsByClassName("active");
current[0].className = "";
document.getElementById("MenuUsers").className += " active";