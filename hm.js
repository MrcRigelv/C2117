// 屏幕自适应



function pagesize(){

    var w = $(window).width();
    var h = $(window).height();
    $("index").css("width", "width(" + w + ")");
    $("index").css("height", " + h + ");


}

function navsize(){

    var w = $(window).width();
    var h = $(window).height();
    $("index").css("width", "width(" + w + ")");
    

}
// 监听屏幕缩放，自适应
$(window).resize(function () {
    pagesize();
    navsize();

});

//  初始化调用

$(function () {
    pagesize();
    navsize();
})
