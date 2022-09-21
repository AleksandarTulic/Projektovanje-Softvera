<nav class="navbar navbar-inverse">
  <div class="container-fluid">
    <div class="navbar-header">
      <button type="button" class="navbar-toggle" data-toggle="collapse" data-target="#myNavbar">
        <span class="icon-bar"></span>
        <span class="icon-bar"></span>
        <span class="icon-bar"></span>                        
      </button>
      <a class="navbar-brand" href="index.jsp">Dentil Admin</a>
    </div>
    <div class="collapse navbar-collapse" id="myNavbar">
      <ul class="nav navbar-nav">
        <li class="active"><a href="index.jsp">Home</a></li>
        <li id="MenuUsers"><a href="Navigation?what=viewUsers">Users</a></li>
        <li id="MenuSchedule"><a href="Navigation?what=schedule">Schedule</a></li>
      </ul>
      <ul class="nav navbar-nav navbar-right">
      	  <li class="dropdown"><a class="dropdown-toggle" data-toggle="dropdown" href="#">
			<%
			
				out.println(request.getRemoteUser());	
			
			%>
			<span class="caret"></span></a>
	        <ul class="dropdown-menu">
	          <li><a href="logout.jsp">Log out</a></li>
	          <!-- OVDE MOZEMO DA PROSIRIMO AKO TREBA POSEBNO DA ULOGOVANI KORISNIK VIDI SVOJE INFORMACIJE -->
	        </ul>
	      </li>
      </ul>
    </div>
  </div>
</nav>