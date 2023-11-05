// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

//скролл до блока с популярными курсами.
function scrollToBlock() {
    const targetBlock = document.getElementById("divPopularCourses");

    // Используем smooth scrolling для плавного перехода
    targetBlock.scrollIntoView({ block: "center", behavior: 'smooth' });
}


// блок скрыть/показать header.
var prevScrollPos = window.scrollY;
var scrollThreshold = 20;  // Порог для скрытия/показа header

window.onscroll = function () {
    var currentScrollPos = window.scrollY;
    var header = document.getElementById("header");

    if (header) {
        // это условие нужно для проверки порога
        if (Math.abs(prevScrollPos - currentScrollPos) >= scrollThreshold) {
            if (prevScrollPos > currentScrollPos) {
                header.classList.remove("hidden"); // Плавно показываем header при скролле вверх
            } else {
                header.classList.add("hidden"); // Плавно скрываем header при скролле вниз
            }
        }

        prevScrollPos = currentScrollPos;
    }
}
