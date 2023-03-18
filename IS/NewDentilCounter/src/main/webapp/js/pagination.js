var left = 0;
var right = 3;

var increase = 3;
var numberOfPages = 0;

function loadElements(someFunction, myUrl, myNumberUrl){
	document.getElementById("myTableBody").innerHTML = "";
	checkPagination(myNumberUrl);
	
	var obj = {
		"value": document.getElementById("searchBy") == null ? 
		"" : document.getElementById("searchBy").value,
		"idPatient": document.getElementById("patientIdView") == null ? 
		"" : document.getElementById("patientIdView").value,
		"patientName": document.getElementById("patientNameView") == null ? 
		"" : document.getElementById("patientNameView").value,
		"patientSurname": document.getElementById("patientSurnameView") == null ?
		"" : document.getElementById("patientSurnameView").value,
		"dentistName": document.getElementById("dentistNameView") == null ? 
		"" : document.getElementById("dentistNameView").value,
		"dentistSurname": document.getElementById("dentistSurnameView") == null ?
		"" : document.getElementById("dentistSurnameView").value,
		"date": document.getElementById("dateView") == null ?
		"" : document.getElementById("dateView").value,
		"left": left,
		"right": increase,
		"orderBy": currentOrderBy,
		"orderByType": currentOrderByType
	};

	$.ajax({
		url: myUrl,
		type: "POST",
		data: obj,
		success: function(res){
			someFunction.call(res);
		}
	});
}

function checkPagination(myNumberUrl){
	var myPagination = document.getElementById("myPagination");
	
	var obj = {
		"value": document.getElementById("searchBy") == null ? 
		"" : document.getElementById("searchBy").value,
		"idPatient": document.getElementById("patientIdView") == null ? 
		"" : document.getElementById("patientIdView").value,
		"patientName": document.getElementById("patientNameView") == null ? 
		"" : document.getElementById("patientNameView").value,
		"patientSurname": document.getElementById("patientSurnameView") == null ?
		"" : document.getElementById("patientSurnameView").value,
		"dentistName": document.getElementById("dentistNameView") == null ? 
		"" : document.getElementById("dentistNameView").value,
		"dentistSurname": document.getElementById("dentistSurnameView") == null ?
		"" : document.getElementById("dentistSurnameView").value,
		"date": document.getElementById("dateView") == null ?
		"" : document.getElementById("dateView").value
	};
	
	$.ajax({
		url: myNumberUrl,
		type: "POST",
		data: obj,
		success: function(res){
			numberOfPages = Math.round(res / increase) + (res % increase === 0 ? 0 : 1);
			
			if (isNaN(numberOfPages) === false){
				if (numberOfPages === 0){
					myPagination.style.display = "none";
				}else{
					myPagination.style.display = "block";
					
					if (numberOfPages === 1){
						document.getElementById("previous").className = "page-item disabled";
						document.getElementById("next").className = "page-item disabled";
					}else{
						document.getElementById("previous").className = left === 0 ? "page-item disabled" : "page-item";
						document.getElementById("next").className = right >= res ? "page-item disabled" : "page-item";
						
						document.getElementById("currPage").innerHTML = ((left / increase) + 1) + "";
					}
				}
			}
		}
	});
}

function getNext(a, value, someFunction, myUrl, myNumberUrl){
	if (!a.parentElement.className.includes("disabled")){
		left += Number(value) * increase;
		right = left + increase;
		
		loadElements(someFunction, myUrl, myNumberUrl);
	}
	
	return false;
}

function resetPagination(){
	left = 0;
	right = 3;
	increase = 3;
	numberOfPages = 0;
	document.getElementById("currPage").innerHTML = "1";
}
