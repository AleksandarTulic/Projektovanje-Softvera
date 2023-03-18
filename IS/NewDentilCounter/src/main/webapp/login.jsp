<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
    pageEncoding="ISO-8859-1"%>
    
<jsp:include page="WEB-INF/pages/common/check.jsp"></jsp:include>

<!DOCTYPE html>
<html>
	<jsp:include page="/WEB-INF/pages/common/commonOther.jsp"></jsp:include>
	
	<body>
		<div class="container">
			<div class="row">
				<div class="col-sm-2">
				</div>
				<div class="col-sm-8">
					<h2>Login Counter</h2>
					<form name="loginForm" method="POST" action="j_security_check">
						<div class="form-group">
							<p>Username: <input type="text" name="j_username" class="form-control"/></p>
						</div>
						
						<div class="form-group">
							<p>Password: <input type="password" class="form-control" name="j_password"/></p>
						</div>
						<p>  <input style="width: 50%;margin-right: 25%;margin-left: 25%;" type="submit" value="Login" class="btn btn-default"/></p>
					</form>
				</div>
				<div class="col-sm-2">
				</div>
			</div>
		</div>   
	</body>
</html>