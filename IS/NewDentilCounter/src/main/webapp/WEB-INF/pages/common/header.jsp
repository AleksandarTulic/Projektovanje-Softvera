<nav class="navbar navbar-inverse" style="border-radius: 0px !important;">
  <div class="container-fluid">
    <div class="navbar-header">
      <button type="button" class="navbar-toggle" data-toggle="collapse" data-target="#myNavbar">
        <span class="icon-bar"></span>
        <span class="icon-bar"></span>
        <span class="icon-bar"></span>                        
      </button>
      <a class="navbar-brand" href="index.jsp">Dentil</a>
    </div>
    <div class="collapse navbar-collapse" id="myNavbar">
      <ul class="nav navbar-nav">
        <li class="active" id="MenuHome"><a href="index.jsp">Home</a></li>
        <li id="MenuAppointment"><a href="Navigation?what=viewAppointments">Appointment</a></li>
        <li id="MenuPatient"><a href="Navigation?what=viewPatients">Patient</a></li>
        <li id="MenuRecoverPatient"><a href="Navigation?what=recoverPatient">Recover Patient</a></li>
        <li id="MenuHelp"><a href="Navigation?what=help">Help</a></li>
      </ul>
      <ul class="nav navbar-nav navbar-right">
      	  <li class="dropdown"><a class="dropdown-toggle" data-toggle="dropdown" href="#">
			<%
			
				out.println(request.getRemoteUser());
			
			%>
			<span class="caret"></span></a>
	        <ul class="dropdown-menu">
	          <li><a href="Navigation?what=personalInfo">View</a></li>
	          <li><a href="logout.jsp">Log out</a></li>
	          <!-- OVDE MOZEMO DA PROSIRIMO AKO TREBA POSEBNO DA ULOGOVANI KORISNIK VIDI SVOJE INFORMACIJE -->
	        </ul>
	      </li>
      </ul>
    </div>
  </div>
</nav>