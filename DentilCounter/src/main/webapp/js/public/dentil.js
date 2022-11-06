isLeapYear = (year) => {
  return (
    (year % 4 === 0 && year % 100 !== 0 && year % 400 !== 0) ||
    (year % 100 === 0 && year % 400 === 0)
  );
};

getFebDays = (year) => {
  return isLeapYear(year) ? 29 : 28;
};

let calendar = document.querySelector(".calendar");

const monthNames = [
  "Januar",
  "Februar",
  "Mart",
  "April",
  "Maj",
  "Jun",
  "Jul",
  "Avgust",
  "Septembar",
  "Oktobar",
  "Novembar",
  "Decembar",
];

let monthPicker = document.querySelector("#month-picker");

monthPicker.onclick = () => {
  monthList.classList.add("show");
};

//GENERATE CALENDAR
generateCalendar = (month, year) => {
  let calendarDays = document.querySelector(".calendar-days");
  calendarDays.innerHTML = "";
  let calendarHeaderYear = document.querySelector("#year");
  let daysOfMonth = [
    31,
    getFebDays(year),
    31,
    30,
    31,
    30,
    31,
    31,
    30,
    31,
    30,
    31,
  ];

  let currentDate = new Date();
  monthPicker.innerHTML = monthNames[month];

  calendarHeaderYear.innerHTML = year;

  let firstDay = new Date(year, month, 1);

  for (let i = 0; i <= daysOfMonth[month] + firstDay.getDay() - 1; i++) {
    let day = document.createElement("div");
    if (i >= firstDay.getDay()) {
      day.classList.add("calendar-days-hover");
      day.classList.add("calendar-days-point");
      day.innerHTML = i - firstDay.getDay() + 1;
      day.innerHTML += "<span></span><span></span><span></span><span></span>";
      if (
        i - firstDay.getDay() + 1 === currentDate.getDate() &&
        year === currentDate.getFullYear() &&
        month === currentDate.getMonth()
      ) {
        day.classList.add("curr-date");
      }
    }
    calendarDays.appendChild(day);
  }
};

let currentDate = new Date();
let currentMonth = currentDate.getMonth();
let monthList = calendar.querySelector(".month-list");
monthNames.forEach((e, index) => {
  let month = document.createElement("div");
  if (index < currentMonth) {
    month.innerHTML = `<div class="month-passed">${e}</div>`;
  } else {
    month.innerHTML = `<div>${e}</div>`;
    month.classList.add("month-list-point");
    month.onclick = () => {
      monthList.classList.remove("show");
      currMonth.value = index;
      generateCalendar(currMonth.value, currYear.value);
    };
  }
  monthList.appendChild(month);
});

let currDate = new Date();
let currMonth = { value: currDate.getMonth() };

let currYear = { value: currDate.getFullYear() };

generateCalendar(currMonth.value, currYear.value);

//NAVIGATION
const allLinks = document.querySelectorAll("a:link");
allLinks.forEach(function (link) {
  link.addEventListener("click", function (e) {
    e.preventDefault();
    const href = link.getAttribute("href");
    const sectionElement = document.querySelector(href);
    sectionElement.scrollIntoView({ behavior: "smooth" });
  });
});

//MOBILE NAVIGATION

const btnNav = document.querySelector(".mobile-nav-buttin");
const btnNavX = document.querySelector(".btnX");
const headerEl = document.querySelector(".header");

btnNav.addEventListener("click", function (e) {
  headerEl.classList.add("nav-open");
});

btnNavX.addEventListener("click", function (e) {
  headerEl.classList.remove("nav-open");
});

// ORDER

const tableDate = document.querySelector(".table-date");
tableDate.textContent = `${currDate.getDay() - 1}. ${
  monthNames[currMonth.value]
} ${currYear.value}.`;

let globalDay = document.createElement("div");
globalDay.classList.add("calendar-days-hover");
globalDay.classList.add("calendar-days-point");
globalDay.classList.add("clicked-day");
globalDay.textContent = 0;
//'<div class="day">0<span></span><span></span><span></span></div>'

const selectedDay = document.querySelector(".calendar-days");

var selectedDate;
selectedDay.addEventListener("click", function (e) {
  const tableDay = e.target.textContent;
  const targetDay = e.target;

  if (tableDay > 0 && tableDay < 32) {
    if (globalDay.textContent !== tableDay.textContent)
      globalDay.classList.remove("clicked-day");
    const tableMonth = document.querySelector(".month-picker");
    targetDay.classList.add("clicked-day");
    tableDate.textContent = `${tableDay}. ${tableMonth.textContent} ${currYear.value}.`;
    globalDay = targetDay;

    //Ovo ti je objekat, odnosno kljucevi za fatch
    currentDate = {
      day: tableDay,
      month: tableMonth.textContent,
      year: currYear.value,
    };
    
    selectedDate = {
		day: tableDay,
      	month: tableMonth.textContent,
      	year: currYear.value,
	};
	
	updateListOfAppointments();
  }
});

function updateListOfAppointments(){
	var id = document.getElementById("dentistID");

	const table = document.querySelector(".table-body");
	table.innerHTML = "";
	$.get("Data?what=getAppointmentsSameDayAndDentist&date=" + selectedDate.year + "-" + convertToRightFormat(getMonthFromText(selectedDate.month)) + "-" + convertToRightFormat(selectedDate.day) + "&idDentist=" + id.value, function(responseJson){
		responseJson = responseJson.reverse();
		for (let i=0;i<responseJson.length;i++){
			var row = table.insertRow(0);
			var cell1 = row.insertCell(0);
			cell1.innerHTML = "<ion-icon name=\"person-outline\"></ion-icon>";
			var cell2 = row.insertCell(1);
			cell2.innerHTML = convertTime12To24(responseJson[i].startTime);
			var cell3 = row.insertCell(2);
			var timeEnd = new Date(new Date().toDateString() + " " + responseJson[i].startTime);
			timeEnd.setDate(selectedDate.day);
			timeEnd.setMonth(getMonthFromText(selectedDate.month));
			timeEnd.setFullYear(selectedDate.year);
			timeEnd.setMinutes(timeEnd.getMinutes() + Number(responseJson[i].howLong));
			cell3.innerHTML = convertToRightFormat(timeEnd.getHours()) + ":" + convertToRightFormat(timeEnd.getMinutes()) + ":" + convertToRightFormat(timeEnd.getSeconds());
		}
		
		$('#myTableBody').pageMe({pagerSelector:'#myPager',showPrevNext:true,hidePageNumbers:false,perPage:4});
	});
}

function getDentist(){
	var selectTag = document.getElementById("dentistID");
	selectTag.innerHTML = "";
	$.get("Data?what=getDentists", function(responseJson){
		for (let i=0;i<responseJson.length;i++){
			var opt = document.createElement('option');
			opt.value = responseJson[i].id;
			opt.innerHTML = responseJson[i].name + " " + responseJson[i].surname;
			selectTag.appendChild(opt);
		}
	});
}

function getMonthFromText(text){
	var returnValue = 1;
	if("Februar" === text){
		returnValue = 2;
	}else if("Mart" === text){
		returnValue = 3;
	}else if("April" === text){
		returnValue = 4;
	}else if("Maj" === text){
		returnValue = 5;
	}else if("Jun" === text){
		returnValue = 6;
	}else if("Jul" === text){
		returnValue = 7;
	}else if("Avgust" === text){
		returnValue = 8;
	}else if("Septembar" === text){
		returnValue = 9;
	}else if("Oktobar" === text){
		returnValue = 10;
	}else if("Novembar" === text){
		returnValue = 11;
	}else if("Decembar" === text){
		returnValue = 12;
	}
	
	return returnValue;
}

getDentist();
