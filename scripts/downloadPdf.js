function downloadPdfJs(element) {
    var element = document.getElementById(element);
    
    $('.skill_icon').css('filter', 'invert(0%) sepia(96%) saturate(16%) hue-rotate(282deg) brightness(89%) contrast(104%)');

    element.classList.add("text-dark");
    for (let el of document.querySelectorAll('.hide_print')) el.style.visibility = 'hidden';

    window.print();
    
    element.classList.remove("text-dark"); 
    $('.hide-print').css("visibility", "visible !important");
    for (let el of document.querySelectorAll('.hide_print')) el.style.visibility = 'visible';
}