$(document).ready(function(){
	/* This code is executed after the DOM has been completely loaded */

	/* Changing thedefault easing effect - will affect the slideUp/slideDown methods: */
	$.easing.def = "easeOutBounce";

	/* Binding a click event handler to the links: */
    $('li.button a').click(function (e) {

        /* Finding the drop down list that corresponds to the current section: */
        var dropDown = $(this).parent().next();

        /* Closing all other drop down sections, except the current one */
        $('.dropdown').not(dropDown).slideUp('slow');
        dropDown.slideToggle('slow');

        /* Preventing the default event (which would be to navigate the browser to the link's address) */
        e.preventDefault();
    });
    $("span.menu").click(function () {
        $("ul.nav1").slideToggle(300, function () {
            // Animation complete.
        });
    });
    $(function () {
        $("#datepicker,#datepicker1").datepicker();
    });
    $('.marquee').marquee({ pauseOnHover: true });
    $(document).ready(function () {
        $('#horizontalTab').easyResponsiveTabs({
            type: 'default', //Types: default, vertical, accordion           
            width: 'auto', //auto or any width like 600px
            fit: true   // 100% fit in a container
        });
    });    $(window).load(function () {
        $("#flexiselDemo1").flexisel({
            visibleItems: 4,
            animationSpeed: 1000,
            autoPlay: true,
            autoPlaySpeed: 3000,
            pauseOnHover: true,
            enableResponsiveBreakpoints: true,
            responsiveBreakpoints: {
                portrait: {
                    changePoint: 480,
                    visibleItems: 1
                },
                landscape: {
                    changePoint: 640,
                    visibleItems: 2
                },
                tablet: {
                    changePoint: 768,
                    visibleItems: 3
                }
            }
        });
    });
});