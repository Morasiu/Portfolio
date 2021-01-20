function downloadPdfJs(element) {
    var element = document.getElementById(element);
    
    $('.skill_icon').css('filter', 'invert(0%) sepia(96%) saturate(16%) hue-rotate(282deg) brightness(89%) contrast(104%)');

    element.classList.add("text-dark");
    for (let el of document.querySelectorAll('.hide_print')) el.style.visibility = 'hidden';

    window.print();
    
    element.classList.remove("text-dark"); 
    $('.skill_icon').css('filter', 'invert(100%) sepia(11%) saturate(2%) hue-rotate(329deg) brightness(108%) contrast(101%)');

    $('.hide-print').css("visibility", "visible !important");
    for (let el of document.querySelectorAll('.hide_print')) el.style.visibility = 'visible';
}