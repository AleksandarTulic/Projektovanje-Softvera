<%@ include file="../../index.jsp" %>
<%@ page import="dto.UserDTO" %>

<link rel="stylesheet" href="css/view.css">

<div class="container">
	<h2>View Users</h2>
	
	<div class="row">
		<div class="col-sm-12" id="messageResult">
		
		</div>
	</div>

	<div class="row" style="margin-right: 0px;margin-top: 15px;">
		<div class="col-sm-6 centerThem">
			<label id="labelSearchBy" class="centerThem">Search By</label>
			<input type="text" name="searchBy" id="searchBy" onkeyup="searchBy()">
		</div>
		
		<div class="col-sm-4">
			&nbsp;
		</div>
		
		<div class="col-sm-2 centerThem" style="padding-right: 0px;text-align: right;">
			<input type="submit" class="btn normalButton" value="Add" data-toggle="modal" data-target="#myModal1">
		</div>
	</div>
		
	<div class="row">
		<div class="col-sm-12" style="margin-top: 10px;">
	    	<table id="myTable" class="table table-striped">
	    		<thead>
	    			<tr>
	    				<th class="hoverSortButton" onclick="sortTable(0)">ID</th>
	    				<th class="hoverSortButton" onclick="sortTable(1)">Name</th>
	    				<th class="hoverSortButton" onclick="sortTable(2)">Surname</th>
	    				<th class="hoverSortButton" onclick="sortTable(3)">Role</th>
	    				<th>View More</th>
	    				<th>Update</th>
	    				<th>Delete</th>
	    			</tr>
	    		</thead>
	    		
	    		<tbody id="myTableBody">
	    		</tbody>
	    	</table>
		</div>
		
		<div class="col-sm-12" style="text-align: center;" id="myPagination">
			<nav>
				<ul class="pagination">
				
					<li class="page-item disabled" id="previous"><a class="page-link" href="#" onclick="getNext(this, -1, setTableValues, 'Data?what=selectWorkers', 'Data?what=selectNumberOfWorkers', 'id', 'asc')">Previous</a></li>
					<li class="page-item active"><a id="currPage" class="page-link" href="#">1</a></li>
					<li class="page-item" id="next"><a class="page-link" href="#" onclick="getNext(this, 1, setTableValues, 'Data?what=selectWorkers', 'Data?what=selectNumberOfWorkers', 'id', 'asc')">Next</a></li>
				
				</ul>
			</nav>
		</div>
	</div>
</div>

<%@ include file="insert.jsp" %>
<%@ include file="update.jsp" %>
<%@ include file="viewMore.jsp" %>


<script src="js/global/parameterConfig.js"></script>
<script src="js/view/view.js"></script>
<script src="js/global/pagination.js"></script>
<script src="js/view/viewCall.js"></script>


<%

	UserDTO dto = (UserDTO)session.getAttribute("aaaa");
	out.println("<input type=\"text\" readonly style=\"display:none;\" value=\"" + dto.getId() + "\" id=\"IdUserLogin\">");

%>