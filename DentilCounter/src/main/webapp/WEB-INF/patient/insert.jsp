<!-- Modal HTML Markup -->
<div id="myModal1" class="modal fade">
    <div class="modal-dialog">
        <div class="modal-content">
            <div class="modal-header">
                <div class="col-sm-4" style="padding-left: 0px;">
                	<h2 class="modal-title">Add Patient</h2>
                </div>
                
                <div class="col-sm-1">
                	&nbsp;
                </div>
                
                <div class="col-sm-7" id="insertMessage">
                </div>
            </div>
            <div class="modal-body">
                <form action="Patient?what=insertPatientWithReload" method="POST">
                	<div class="row">
                		<div class="col-sm-6">
                			<div class="form-group">
		                        <label class="control-label">ID</label>
		                        <div>
		                            <input required pattern="[0-9]{13}"  type="text" class="form-control" name="insertID" id="insertID" value="" maxlength="13">
		                        </div>
		                    </div>
		                    
		                    <div class="form-group">
		                    	<label class="control-label">Name</label>
		                        <div>
		                            <input required pattern="[a-zA-Z]{2,}[\s]*[a-zA-Z]*"  type="text" class="form-control" name="insertName" id="insertName" maxlength="100" value="">
		                        </div>
		                    </div>
		                    
		                    <div class="form-group">
		                    	<label class="control-label">Surname</label>
		                        <div>
		                            <input required pattern="[a-zA-Z]{2,}"  type="text" class="form-control" name="insertSurname" id="insertSurname" maxlength="100" value="">
		                        </div>
		                    </div>
                		</div>
                		
                		<div class="col-sm-6">
                			<div class="form-group">
                				<label class="control-label">Email</label>
		                        <div>
		                            <input type="email" class="form-control" name="insertEmail" id="insertEmail" maxlength="200"> <!-- OVO VRSI REGEX VALIDACIJU AUTOMATSKI -->
		                        </div>
                			</div>
                			
                			<div class="form-group">
                				<label class="control-label">Phone</label>
		                        <div>
		                            <input pattern="[0-9]{2,}"  type="text" class="form-control" maxlength="30" name="insertPhone" id="insertPhone">
		                        </div>
                			</div>
                			
                			<div class="form-group">
                				<label class="control-label">Address</label>
		                        <div>
		                            <input pattern="^[a-zA-Z]{2,}[0-9a-zA-Z\s]*"  type="text" maxlength="250" class="form-control" name="insertAddress" id="insertAddress">
		                        </div>
                			</div>
                		</div>
                	</div>
                    
                    <hr>
                    
                    <div class="form-group">
                    	<div class="row">
                    		<div class="col-sm-4">
                    			&nbsp;
                    		</div>
                    		
	                        <div class="col-sm-4" style="text-align: center">
	                            <input onclick="insertPatient()" type="button" class="btn normalButton" value="Add">
	                        </div>
	                        
	                        <div class="col-sm-4">
                    			&nbsp;
                    		</div>
                        </div>
                    </div>
                </form>
            </div>
        </div><!-- /.modal-content -->
    </div><!-- /.modal-dialog -->
</div><!-- /.modal -->

<script>
	function insertPatient(){
		var id = document.getElementById("insertID").value;
		var name = document.getElementById("insertName").value;
		var surname = document.getElementById("insertSurname").value;
		var email = document.getElementById("insertEmail").value;
		var phone = document.getElementById("insertPhone").value;
		var address = document.getElementById("insertAddress").value;
		
		if (email === "")
			email = null;
		
		if (phone === "")
			phone = null;
		
		if (address === "")
			address = null;
		
		var obj = {
				"id": id,
				"name": name,
				"surname": surname,
				"email": email,
				"phone": phone,
				"address": address
		};
		
		$.ajax({
			url: "Patient?what=insertPatient",
			type: "POST",
			data: obj,
			success: function(res){
				var obj = JSON.parse(res);
				var elements = document.getElementById("insertMessage");
				elements.innerHTML = "<div class=\"" + obj.alertType + "\"> " + obj.message + "</div>";
				
				setInterval(function(){
					document.getElementById("insertMessage").innerHTML = "";
				}, 5000);
				
				if (obj.flag == "true"){
					document.getElementById("insertID").value = "";
					document.getElementById("insertName").value = "";
					document.getElementById("insertSurname").value = "";
					document.getElementById("insertEmail").value = "";
					document.getElementById("insertPhone").value = "";
					document.getElementById("insertAddress").value = "";
					
					var table = document.getElementById("myTable");
					var row = table.insertRow();
					const cells = [];
					for (let i=0;i<5;i++){
						cells.push(row.insertCell());
					}
					
					var counter = findMaxCounterValue();
					
					cells[0].innerHTML = id;
					cells[1].innerHTML = name;
					cells[2].innerHTML = surname;
					cells[3].innerHTML = "<td><a onclick=\"updateUserDefaultInput(" + counter + ")\" data-toggle=\"modal\" data-target=\"#myModal2\" href=\"#\" class=\"btn btn-warning\">Update</a></td>";
					cells[4].innerHTML = "<td><button onclick=\"areYouSureDeletePatient(" + id + ", " + counter + ")\" class=\"btn btn-danger\">Delete</button></td>";
				
					row.id = "element_" + counter;
					row.addEventListener("click", showMore(counter));
					row.classList.add("paintInGrey");
					
					var row1 = table.insertRow();
					var row2 = table.insertRow();
					var row3 = table.insertRow();
					
					row1.classList.add("paintInWhite");
					row1.classList.add("child_" + counter);
					const cells1 = [];
					for (let i=0;i<5;i++){
						cells1.push(row1.insertCell());
					}
					
					cells1[0].innerHTML = "&nbsp;";
					cells1[1].innerHTML = "Email:";
					cells1[2].innerHTML = email;
					cells1[3].innerHTML = "&nbsp;";
					cells1[4].innerHTML = "&nbsp;";
					
					row2.classList.add("paintInWhite");
					row2.classList.add("child_" + counter);
					const cells2 = [];
					for (let i=0;i<5;i++){
						cells2.push(row2.insertCell());
					}
					
					cells2[0].innerHTML = "&nbsp;";
					cells2[1].innerHTML = "Phone:";
					cells2[2].innerHTML = phone;
					cells2[3].innerHTML = "&nbsp;";
					cells2[4].innerHTML = "&nbsp;";
					
					row3.classList.add("paintInWhite");
					row3.classList.add("child_" + counter);
					const cells3 = [];
					for (let i=0;i<5;i++){
						cells3.push(row3.insertCell());
					}
					
					cells3[0].innerHTML = "&nbsp;";
					cells3[1].innerHTML = "Address:";
					cells3[2].innerHTML = address;
					cells3[3].innerHTML = "&nbsp;";
					cells3[4].innerHTML = "&nbsp;";
				
					paintWhite();
					paintGrey();
					
					var createClickHandler = function(countValue) {
				      return function() {
				        showMore(countValue);
				      };
				    };
					    
					row.onclick = createClickHandler(counter);
					$('#myTableBody').pageMe({pagerSelector:'#myPager',showPrevNext:true,hidePageNumbers:false,perPage:8});
				}
			}
		});
	}
	
	function findMaxCounterValue(){
		var table = document.getElementById("myTable");
		var row = table.insertRow();
		
		var counter = 0;
		for (let i=0;i<table.rows.length;i++){
			if (table.rows[i].classList.contains("paintInGrey")){
				var counterValue = parseInt(table.rows[i].id.split("_")[1]);
				if (counterValue > counter){
					counter = counterValue;
				}
			}
		}
		
		return counter + 1;
	}
</script>