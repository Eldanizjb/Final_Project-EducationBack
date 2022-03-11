$(document).ready(function () {
    "use strict";



    $('.select2').select2();
    $('#Content').summernote({
        height: 300,
        minHeight: null,
        maxHeight: null,
        focus: true
    });


    ////Accordion Box
    //var OpenBtn = document.querySelectorAll(".nav-item");
    //var Body = document.querySelectorAll(".collapses");
    //for (let i = 0; i < OpenBtn.length; i++) {
    //    OpenBtn[i].addEventListener("click", function (e) {
    //        e.preventDefault();
    //        for (let j = 0; j < Body.length; j++) {
    //            if (j != i) {
    //                Body[j].classList.remove("show");
    //            }
    //        }
    //        Body[i].classList.add("show");
    //        OpenBtn[i].classList.add("collapsed");
    //    });
    //}
});
