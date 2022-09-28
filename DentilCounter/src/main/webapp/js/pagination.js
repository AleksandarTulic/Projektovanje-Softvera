$.fn.pageMe = function(opts){
	document.getElementById("myPager").innerHTML = "";
	
    var $this = this,
        defaults = {
            perPage: 7,
            showPrevNext: false,
            hidePageNumbers: false
        },
        settings = $.extend(defaults, opts);

    var listElement = $this;
    var perPage = settings.perPage; 
    var children = listElement.children();
    var pager = $('.pager');

    if (typeof settings.childSelector!="undefined") {
        children = listElement.find(settings.childSelector);
    }

    if (typeof settings.pagerSelector!="undefined") {
        pager = $(settings.pagerSelector);
    }

	var numItems = 0;
	if (children.length % 4 === 0){
		numItems = children.length / 4;
	}else{
		numItems = (children.length - 1) / 4;
	}
    var numPages = Math.ceil(numItems/perPage);

	//console.log(children.length + " " + numItems + " " + numPages);
    pager.data("curr",0);

    if (settings.showPrevNext){
        $('<li><a href="#" class="prev_link">&laquo;</a></li>').appendTo(pager);
    }

    var curr = 0;
    while(numPages > curr && (settings.hidePageNumbers==false)){
        $('<li><a href="#" class="page_link">'+(curr+1)+'</a></li>').appendTo(pager);
        curr++;
    }

    if (settings.showPrevNext){
        $('<li><a href="#" class="next_link">&raquo;</a></li>').appendTo(pager);
    }

    pager.find('.page_link:first').addClass('active');
    pager.find('.prev_link').hide();
    if (numPages<=1) {
        pager.find('.next_link').hide();
    }
    pager.children().eq(1).addClass("active");

    //children.hide();
    for (let i=0;i<children.length;i++){
		children[i].setAttribute("hidden", "");
	}
	
	for (let i=0;i<perPage * 4;i++){
		if (typeof children[i] != "undefined"){
			var arrClass = children[i].classList;
			var flagSet = 1;
			for (let j=0;j<arrClass.length;j++){
				if (arrClass[j].includes("child_")){
					flagSet = 2;
					break;
				}
			}
			
			if (flagSet === 1){
				children[i].removeAttribute("hidden");
			}
		}
	}
    //children.slice(0, perPage * 4).show();

    pager.find('li .page_link').click(function(){
        var clickedPage = $(this).html().valueOf()-1;
        goTo(clickedPage,perPage);
        return false;
    });
    pager.find('li .prev_link').click(function(){
        previous();
        return false;
    });
    pager.find('li .next_link').click(function(){
        next();
        return false;
    });

    function previous(){
        var goToPage = parseInt(pager.data("curr")) - 1;
        goTo(goToPage);
    }

    function next(){
        goToPage = parseInt(pager.data("curr")) + 1;
        goTo(goToPage);
    }

    function goTo(page){
        var startAt = page * perPage * 4,
            endOn = startAt + perPage * 4;

		for (let i=0;i<startAt;i++)
			children[i].setAttribute("hidden", "");

		for (let i=endOn;i<children.length;i++)
			if (typeof children[i] != "undefined")
				children[i].setAttribute("hidden", "");
		
		for (let i=startAt;i<endOn;i++){
			if (typeof children[i] != "undefined"){
				var arrClass = children[i].classList;
				var flagSet = 1;
				for (let j=0;j<arrClass.length;j++){
					if (arrClass[j].includes("child_")){
						flagSet = 2;
						break;
					}
				}
				
				if (flagSet === 1){
					children[i].removeAttribute("hidden");
				}
			}
		}
		
        //children.css('display','none').slice(startAt, endOn).style.dispay = "block";

        if (page>=1) {
            pager.find('.prev_link').show();
        }
        else {
            pager.find('.prev_link').hide();
        }

        if (page<(numPages-1)) {
            pager.find('.next_link').show();
        }
        else {
            pager.find('.next_link').hide();
        }

        pager.data("curr",page);
        pager.children().removeClass("active");
        pager.children().eq(page+1).addClass("active");

    }
};