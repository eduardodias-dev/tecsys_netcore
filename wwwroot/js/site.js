$(document).ready(function(){
    var index = 0;
    var length = $('.hero-content').length;
    setInterval(function(){
        index++;
        if(index < length){
            $($('.hero-content')[index-1]).hide();
            $($('.hero-content')[index]).fadeIn(1000);
        }else{
            $($('.hero-content')[length - 1]).hide();
            index = 0;
            $($('.hero-content')[index]).fadeIn(1000);
        }
    },5000)
});