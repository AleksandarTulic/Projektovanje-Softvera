function searchByInputValue(value){
	document.getElementById("myPager").innerHTML = "";
	
	var table = document.getElementsByTagName("table");
	var tbody = table[0].children[1];
	var tr = tbody.children;
	
	for (let i=0;i<tr.length;i++){
		if (tr[i].className == "paintInGrey" || tr[i].className.includes("paintInGrey")){
			var tds = tr[i].children;
			
			var id = tds[0].outerText;
			var name = tds[1].outerText;
			var surname = tds[2].outerText;
			
			if (id.toUpperCase().includes(value.toUpperCase()) || name.toUpperCase().includes(value.toUpperCase()) ||
			surname.toUpperCase().includes(value.toUpperCase())){
				tr[i].removeAttribute("hidden");
			}else{
				tr[i].setAttribute("hidden", "");
			}
		}else{
			tr[i].setAttribute("hidden", "");
		}
	}
	
	if (value == ""){
		$('#myTableBody').pageMe({pagerSelector:'#myPager',showPrevNext:true,hidePageNumbers:false,perPage:8});
	}
	
	//$('#myTableBody').pageMe({pagerSelector:'#myPager',showPrevNext:true,hidePageNumbers:false,perPage:8});
}