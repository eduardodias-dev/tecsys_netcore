// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
window.onload = function () {
    new Glider(document.querySelector('.glider'), {
        slidesToShow: 1,
        dots: '#dots',
        draggable: true,
        scrollLock: true,
        arrows: {
            prev: '.glider-prev',
            next: '.glider-next'
        }
    })

//    list.map(x => x.classList.remove('in'))
};