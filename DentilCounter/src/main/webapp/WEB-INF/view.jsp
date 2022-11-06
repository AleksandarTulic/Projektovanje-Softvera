<%@ include file="../index.jsp" %>
<%@ page import="dto.*" %>
<jsp:useBean id='personalService' class='service.PersonalService' scope='application'></jsp:useBean>  
<script src="js/paginationView.js"></script>
<script src="js/sortView.js"></script>

<%

	PersonalDTO dto = (PersonalDTO)request.getSession().getAttribute("aaaa");	
	PairDTO<List<ScheduleDTO>, List<ShiftDTO>> pairDTO = personalService.selectWithIdPersonal(dto.getId());
	List<ScheduleDTO> arrSchedule = (List<ScheduleDTO>)pairDTO.getA();
	List<ShiftDTO> arrShift = (List<ShiftDTO>)pairDTO.getB();
%>

<div class="container">
	<div class="row">
		<div class="col-sm-4">
			<h3>View Personal Info</h3>
		</div>
		
		<div class="col-sm-8">
			&nbsp;
		</div>
	</div>
	<div class="row">
		<div class="col-sm-12">
			<div class="table-responsive" style="margin-top: 10px;">
		    	<table id="myTable1" class="table table-striped" style="text-align: center;">
		    		<tbody>
		    			<tr>
		    				<th style="text-align: center;">ID:</th>
		    				<%
		    				
		    					if (dto != null){
		    						out.println("<td>" + dto.getId() + "</td>");
		    					}
		    				
		    				%>
		    			</tr>
		    			
		    			<tr>
		    				<th style="text-align: center;">Name:</th>
		    				<%
		    				
		    					if (dto != null){
		    						out.println("<td>" + dto.getName() + "</td>");
		    					}
		    				
		    				%>
		    			</tr>
		    			
		    			<tr>
		    				<th style="text-align: center;">Surname:</th>
		    				<%
		    				
		    					if (dto != null){
		    						out.println("<td>" + dto.getSurname() + "</td>");
		    					}
		    				
		    				%>
		    			</tr>
		    			
		    			<tr>
		    				<th style="text-align: center;">Email:</th>
		    				<%
		    				
		    					if (dto != null){
		    						out.println("<td>" + dto.getEmail() + "</td>");
		    					}
		    				
		    				%>
		    			</tr>
		    			
		    			<tr>
		    				<th style="text-align: center;">Phone:</th>
		    				<%
		    				
		    					if (dto != null){
		    						out.println("<td>" + dto.getPhone() + "</td>");
		    					}
		    				
		    				%>
		    			</tr>
		    			
		    			<tr>
		    				<th style="text-align: center;">Address:</th>
		    				<%
		    				
		    					if (dto != null){
		    						out.println("<td>" + dto.getAddress() + "</td>");
		    					}
		    				
		    				%>
		    			</tr>
		    			
		    			<tr>
		    				<th style="text-align: center;">Username:</th>
		    				<%
		    				
		    					if (dto != null){
		    						out.println("<td>" + dto.getUsername() + "</td>");
		    					}
		    				
		    				%>
		    			</tr>
		    			
		    			<tr>
		    				<th style="text-align: center;">JobStart:</th>
		    				<%
		    				
		    					if (dto != null){
		    						out.println("<td>" + dto.getJobStart() + "</td>");
		    					}
		    				
		    				%>
		    			</tr>
		    		</tbody>
	   			</table>
			</div>
		</div>
	</div>
	
	<div class="row">
		<div class="col-sm-4">
			<h3>View Schedule</h3>
		</div>
		
		<div class="col-sm-8">
			&nbsp;
		</div>
	</div>
	<div class="row">
		<div class="col-sm-12">
			<table id="myTable2" class="table table-striped" style="text-align: center;">
				<thead>
					<tr>
						<th class="hoverSortButton" onclick="sortTable(0, 'myTable2')" style="text-align: center;">Date</th>
						<th class="hoverSortButton" onclick="sortTable(1, 'myTable2')" style="text-align: center;">Shift</th>
					</tr>
				</thead>
	    		<tbody id="myTableBody">
	    			<%
	    			
	    				for (int i=0;i<arrSchedule.size();i++){
	    					out.println("<tr>");
	    					out.println("<td>" + arrSchedule.get(i).getDate() + "</td>");
	    					out.println("<td>" + arrShift.get(i).getBegin() + " - " + arrShift.get(i).getEnd() + "</td>");
	    					out.println("</tr>");
	    				}
	    			
	    			%>
	    		</tbody>
   			</table>
		</div>
		
		<div class="col-sm-12" style="text-align: center;">
    		<ul class="pagination pagination-lg pager" id="myPager"></ul>
    	</div>
    	
    	<script>
       		$('#myTableBody').pageMe({pagerSelector:'#myPager',showPrevNext:true,hidePageNumbers:false,perPage:8});
       	</script>
	</div>
</div>