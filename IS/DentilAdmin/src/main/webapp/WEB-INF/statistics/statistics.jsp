<%@ include file="../../index.jsp" %>

<div class="container">
	<div class="row">
		<div class="col-sm-12">
			<div class="panel panel-default">
			  	<div class="panel-heading">
				  	<div class="row">
				  		<div class="col-sm-6">General Values</div>
				  		<div class="col-sm-5"></div>
				  		<div class="col-sm-1" style="text-align: right;"><b data-toggle="collapse" data-target="#demo1" style="cursor: grab;">&plus;</b></div>
					</div>
				</div>
			
				<div class="panel-body collapse" id="demo1">
					<h3>General Information</h3>
					<p>Here you can observe some general information that can help you manage your dentist organization.</p>
					
					<div class="panel panel-default">
					  <div class="panel-heading">Number Of Dentists</div>
					  <div class="panel-body" id="numberOfDentists">4</div>
					</div>
					
					<div class="panel panel-default">
					  <div class="panel-heading">Number Of Personal</div>
					  <div class="panel-body" id="numberOfPersonal">20</div>
					</div>
					
					<div class="panel panel-default">
					  <div class="panel-heading">Number Of Patients</div>
					  <div class="panel-body" id="numberOfPatients">120</div>
					</div>
				</div>
			</div>
		</div>
		
		<div class="col-sm-12">
			<div class="panel panel-default">
			  	<div class="panel-heading">
				  	<div class="row">
				  		<div class="col-sm-6">Dentist Earnings</div>
				  		<div class="col-sm-5"></div>
				  		<div class="col-sm-1" style="text-align: right;"><b data-toggle="collapse" data-target="#demo2" style="cursor: grab;">&plus;</b></div>
					</div>
				</div>
			
				<div class="panel-body collapse" id="demo2">
					<canvas id="myChart1" style="width:100%;max-width:600px"></canvas>
				</div>
			</div>
		</div>
		
		<div class="col-sm-12">
			<div class="panel panel-default">
			  	<div class="panel-heading">
				  	<div class="row">
				  		<div class="col-sm-6">Dentist Type Problems Encountered</div>
				  		<div class="col-sm-5"></div>
				  		<div class="col-sm-1" style="text-align: right;"><b data-toggle="collapse" data-target="#demo3" style="cursor: grab;">&plus;</b></div>
					</div>
				</div>
			
				<div class="panel-body collapse" id="demo3">
					<label>Select Problem Type</label>
					<select name="typeProblem" id="typeProblem" class="form-control" onchange="selectTypeProblemsEncountered(this.value)">
						
					</select>
					<canvas id="myChart2" style="width:100%;max-width:600px"></canvas>
				</div>
			</div>
		</div>
		
		<div class="col-sm-12">
			<div class="panel panel-default">
			  	<div class="panel-heading">
				  	<div class="row">
				  		<div class="col-sm-6">Dentist Usage of certain Service</div>
				  		<div class="col-sm-5"></div>
				  		<div class="col-sm-1" style="text-align: right;"><b data-toggle="collapse" data-target="#demo4" style="cursor: grab;">&plus;</b></div>
					</div>
				</div>
			
				<div class="panel-body collapse" id="demo4">
					<label>Select Service</label>
					<select name="typeProblem" id="typeService" class="form-control" onchange="selectService(this.value)">
						
					</select>
					<canvas id="myChart3" style="width:100%;max-width:600px"></canvas>
				</div>
			</div>
		</div>
		
		<div class="col-sm-12">
			<div class="panel panel-default">
			  	<div class="panel-heading">
				  	<div class="row">
				  		<div class="col-sm-6">Dentist Employment</div>
				  		<div class="col-sm-5"></div>
				  		<div class="col-sm-1" style="text-align: right;"><b data-toggle="collapse" data-target="#demo5" style="cursor: grab;">&plus;</b></div>
					</div>
				</div>
			
				<div class="panel-body collapse" id="demo5">
					<canvas id="myChart4" style="width:100%;max-width:600px"></canvas>
				</div>
			</div>
		</div>
		
		<div class="col-sm-12">
			<div class="panel panel-default">
			  	<div class="panel-heading">
				  	<div class="row">
				  		<div class="col-sm-6">Dentist Unemployment</div>
				  		<div class="col-sm-5"></div>
				  		<div class="col-sm-1" style="text-align: right;"><b data-toggle="collapse" data-target="#demo6" style="cursor: grab;">&plus;</b></div>
					</div>
				</div>
			
				<div class="panel-body collapse" id="demo6">
					<canvas id="myChart5" style="width:100%;max-width:600px"></canvas>
				</div>
			</div>
		</div>
		
		<div class="col-sm-12" style="height: 200px;">
		</div>

	</div>
</div>

<script>

function getNumberOfPersonal(){
	$.ajax({
		url: "Statistics?what=getNumberOfPersonal",
		type: "POST",
		data: null,
		success: function(res){
			document.getElementById("numberOfPersonal").innerHTML = res;
		}
	});
}

function getNumberOfDentists(){
	$.ajax({
		url: "Statistics?what=getNumberOfDentists",
		type: "POST",
		data: null,
		success: function(res){
			document.getElementById("numberOfDentists").innerHTML = res;
		}
	});
}

function getNumberOfPatients(){
	$.ajax({
		url: "Statistics?what=getNumberOfPatients",
		type: "POST",
		data: null,
		success: function(res){
			document.getElementById("numberOfPatients").innerHTML = res;
		}
	});
}

function selectDentistEarned(){
	$.ajax({
		url: "Statistics?what=selectDentistEarned",
		type: "POST",
		data: null,
		success: function(res){
			var xValues = [];
			var yValues = [];
			var barColors = [];
			
			for (let i=0;i<res.length;i++){
				xValues.push(res[i].a);
				yValues.push(res[i].b);
				barColors.push("green");
			}
			
			new Chart("myChart1", {
			  type: "bar",
			  data: {
			    labels: xValues,
			    datasets: [{
			      backgroundColor: barColors,
			      data: yValues
			    }]
			  },
			  options: {
			    legend: {display: false},
			    title: {
			      display: true,
			      text: "Dentist Earnings"
			    }
			  }
			});
		}
	});
}

function selectTypeProblemsEncountered(value){
	var obj = {
		"id": value	
	};
	
	$.ajax({
		url: "Statistics?what=selectTypeProblemsEncountered",
		type: "POST",
		data: obj,
		success: function(res){
			var xValues = [];
			var yValues = [];
			var barColors = [];
			
			for (let i=0;i<res.length;i++){
				xValues.push(res[i].a);
				yValues.push(res[i].b);
				barColors.push("green");
			}
			
			new Chart("myChart2", {
			  type: "bar",
			  data: {
			    labels: xValues,
			    datasets: [{
			      backgroundColor: barColors,
			      data: yValues
			    }]
			  },
			  options: {
			    legend: {display: false},
			    title: {
			      display: true,
			      text: "Number Of Times Problem Occured"
			    }
			  }
			});
		}
	});
}

function selectService(value){
	var obj = {
		"id": value	
	};
	
	$.ajax({
		url: "Statistics?what=selectVisitServicesEncountered",
		type: "POST",
		data: obj,
		success: function(res){
			var xValues = [];
			var yValues = [];
			var barColors = [];
			
			for (let i=0;i<res.length;i++){
				xValues.push(res[i].a);
				yValues.push(res[i].b);
				barColors.push("green");
			}
			
			new Chart("myChart3", {
			  type: "bar",
			  data: {
			    labels: xValues,
			    datasets: [{
			      backgroundColor: barColors,
			      data: yValues
			    }]
			  },
			  options: {
			    legend: {display: false},
			    title: {
			      display: true,
			      text: "Number Of Times Dentist Used a Service"
			    }
			  }
			});
		}
	});
}

function selectEmployment(){
	$.ajax({
		url: "Statistics?what=selectEmployed",
		type: "POST",
		data: null,
		success: function(res){
			var xValues = [];
			var yValues = [];
			var barColors = [];
			
			for (let i=0;i<res.length;i++){
				xValues.push(res[i].b);
				yValues.push(res[i].a);
				barColors.push("green");
			}
			
			new Chart("myChart4", {
			  type: "bar",
			  data: {
			    labels: xValues,
			    datasets: [{
			      backgroundColor: barColors,
			      data: yValues
			    }]
			  },
			  options: {
			    legend: {display: false},
			    title: {
			      display: true,
			      text: "Employment by years"
			    }
			  }
			});
		}
	});
}

function selectUnemployment(){
	$.ajax({
		url: "Statistics?what=selectUnemployed",
		type: "POST",
		data: null,
		success: function(res){
			var xValues = [];
			var yValues = [];
			var barColors = [];
			
			for (let i=0;i<res.length;i++){
				xValues.push(res[i].b);
				yValues.push(res[i].a);
				barColors.push("green");
			}
			
			new Chart("myChart5", {
			  type: "bar",
			  data: {
			    labels: xValues,
			    datasets: [{
			      backgroundColor: barColors,
			      data: yValues
			    }]
			  },
			  options: {
			    legend: {display: false},
			    title: {
			      display: true,
			      text: "Unemployment by years"
			    }
			  }
			});
		}
	});
}

function selectTypeProblems(){
	$.ajax({
		url: "Data?what=selectTypeProblems",
		type: "POST",
		data: null,
		success: function(res){
			var typeProblemSelect = document.getElementById("typeProblem");
			for (let i=0;i<res.length;i++){
				typeProblemSelect.innerHTML += "<option value=\"" + res[i].id + "\">" + res[i].name + "</option>";
			}
			
			if (res.length >= 1)
				selectTypeProblemsEncountered(res[0].id);
		}
	});
}

function selectServices(){
	$.ajax({
		url: "Data?what=selectServices",
		type: "POST",
		data: null,
		success: function(res){
			var typeService = document.getElementById("typeService");

			for (let i=0;i<res.length;i++){
				typeService.innerHTML += "<option value=\"" + res[i].a + "\">" + res[i].b + "</option>";
			}
			
			if (res.length >= 1)
				selectService(res[0].a);
		}
	});
}

getNumberOfPatients();
getNumberOfDentists();
getNumberOfPersonal();
selectDentistEarned();
selectTypeProblems();
selectServices();
selectEmployment();
selectUnemployment();

var current = document.getElementsByClassName("active");
current[0].className = "";
document.getElementById("MenuStatistics").className += "active";
</script>