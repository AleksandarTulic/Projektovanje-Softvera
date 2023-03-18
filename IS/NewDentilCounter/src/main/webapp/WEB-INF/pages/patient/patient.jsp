<jsp:include page="../../../index.jsp"></jsp:include>

<div class="container">

	<div class="row">
		<div class="col-sm-12" id="messagePatient">
			
		</div>
	</div>

	<div class="row" style="margin-right: 0px;margin-top: 15px;">
		<div class="col-sm-6 centerThem">
			<label id="labelSearchBy" class="centerThem">Search By</label>
			<input type="text" name="searchBy" id="searchBy" onkeyup="searchByInputValue()">
		</div>
		
		<div class="col-sm-4">
			&nbsp;
		</div>
		
		<div class="col-sm-2 centerThem" style="padding-right: 0px;text-align: right;">
			<input type="submit" class="btn normalButton" value="Add" data-toggle="modal" data-target="#myModal1">
		</div>
	</div>
	
	<div class="row">
	
		<div class="col-sm-12">
			<div class="table-responsive" style="margin-top: 10px;">
		    	<table id="myTable" class="table table-striped">
		    		<thead>
		    			<tr>
		    				<th class="hoverSortButton" onclick="sortTable(0)">ID</th>
		    				<th class="hoverSortButton" onclick="sortTable(1)">Name</th>
		    				<th class="hoverSortButton" onclick="sortTable(2)">Surname</th>
		    				<th>View More</th>
		    				<th>Update</th>
		    				<th>Delete</th>
		    			</tr>
		    		</thead>
		    		
		    		<tbody id="myTableBody">
		    		</tbody>
		    	</table>
		    </div>
		</div>
		
		<div class="col-sm-12" style="text-align: center;" id="myPagination">
			<nav>
				<ul class="pagination">
				
					<li class="page-item disabled" id="previous"><a class="page-link" href="#" onclick="getNext(this, -1, setTableValues, 'Data?what=getPatients', 'Data?what=getNumberOfPatients', 'id', 'asc')">Previous</a></li>
					<li class="page-item active"><a id="currPage" class="page-link" href="#">1</a></li>
					<li class="page-item" id="next"><a class="page-link" href="#" onclick="getNext(this, 1, setTableValues, 'Data?what=getPatients', 'Data?what=getNumberOfPatients', 'id', 'asc')">Next</a></li>
				
				</ul>
			</nav>
		</div>
	
	</div>
	
</div>

<%@ include file="update.jsp" %>
<%@ include file="insert.jsp" %>
<%@ include file="view.jsp" %>

<script src="js/parameterConfig.js"></script>
<script src="js/patient.js"></script>
<script src="js/pagination.js"></script>
<script src="js/patientCall.js"></script>