function changePerPage(element){
	if (Number(element) >= Number(4) && Number(element) <= Number(20)){
		$('#myTableBody').pageMe({pagerSelector:'#myPager',showPrevNext:true,hidePageNumbers:false,perPage:element});
	}
}