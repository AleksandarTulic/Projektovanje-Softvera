$.fn.pageMe = function(opts){
	document.getElementById("myPager").innerHTML = "";
	
    var $this = this,
        defaults = {
            perPage: 8,
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

    var numItems = children.length;
    var numPages = 0;
	var paintInGreyNum = 0;
	
	const elements = [];
    for (let i=0;i<children.length;i++){
		if (children[i].className.includes("paintInGrey")){
			numPages++;
			paintInGreyNum++;
			elements.push(i);
		}
	}

	numPages = Math.ceil(numPages/perPage);
	
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

	/*
    children.hide();
    children.slice(0, perPage).show();
	*/
	
	for (let i=0;i<children.length;i++){
		children[i].setAttribute("hidden", "");
	}
	
	//Math.min(numItems, perPage);
	for (let i=0;i<Math.min(perPage, elements.length);i++){
		children[elements[i]].removeAttribute("hidden");
	}
	
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
        var startAt = page * perPage,
            endOn = Math.min(startAt + perPage, paintInGreyNum);

		for (let i=0;i<startAt;i++){
			children[elements[i]].setAttribute("hidden", "");
			for (let j=elements[i] + 1;j<elements[i + 1];j++){
				children[j].setAttribute("hidden", "");
			}
		}
		
		for (let i=endOn;i<paintInGreyNum;i++){
			children[elements[i]].setAttribute("hidden", "");
			
			for (let j=elements[i] + 1;j<elements[i + 1];j++){
				children[j].setAttribute("hidden", "");
			}
		}
		
		for (let i=startAt;i<endOn;i++){
			children[elements[i]].removeAttribute("hidden");
		}

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