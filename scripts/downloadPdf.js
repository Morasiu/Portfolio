function downloadPdfJs(element) {
    var element = document.getElementById(element);
    
    $('.skill_icon').css('filter', 'invert(0%) sepia(96%) saturate(16%) hue-rotate(282deg) brightness(89%) contrast(104%)');

    element.classList.add("text-dark");
    for (let el of document.querySelectorAll('.hide_print')) el.style.visibility = 'hidden';
    for (let el of document.querySelectorAll('.show_print')) el.style.visibility = 'visible';

    window.print();
    
    element.classList.remove("text-dark"); 
    $('.skill_icon').css('filter', 'invert(100%) sepia(11%) saturate(2%) hue-rotate(329deg) brightness(108%) contrast(101%)');
    for (let el of document.querySelectorAll('.hide_print')) el.style.visibility = 'visible';
    for (let el of document.querySelectorAll('.show_print')) el.style.visibility = 'hidden';
}