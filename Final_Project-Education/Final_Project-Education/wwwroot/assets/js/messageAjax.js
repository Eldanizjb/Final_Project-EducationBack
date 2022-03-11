let ratingStars = document.querySelectorAll('.myStar')
ratingStars.forEach((rs) => {
    rs.addEventListener('click', () => {
        
        let ratingValue = rs.getAttribute('data-value')
        let teacherId = rs.getAttribute('data-teacherId')
        //fetch()  //TO-DO
        fetch(location.origin + "url", {
            method: 'POST',
            body: {
                ratingValue,
                 teacherId
            }
        })
        console.log(`${ratingValue} ${teacherId}`)
    })
})

$(document).ready(function () {

    let submit = $("#sec-btn");

    submit.click(function (e) {
        e.preventDefault();

        let email = $("#subscribies input[name='email']");
        let success = $("#subscribies .alert-success");
        let warning = $("#subscribies .alert-warning");
        success.css("display", "none");
        warning.css("display", "none");

        $.ajax({
            url: "Home/Subscribe",
            type: "get",
            dataType: "json",
            data: {
                email: email.val()
            },
            success: function (response) {
                if (response.Status == true) {
                    success.css("display", "block");
                    success.text(response.message);
                } else {
                    warning.css("display", "block");
                    warning.text(response.message);
                }
            },
            error: function (error) {
                console.log(error);
            },
            complete: function () {
                email.val("");
            }
        });
    });

});





    //Contact Us Message

   
    //let submit1 = document.querySelectorAll("#btn-message");

    //submit1.click(function (e) {
    //          e.preventDefault();

    //             let name = $("#message input[name='FullName']");
    //             let email = $("#message input[name='EmailAddress']");
    //             let phone = $("#message input[name='PhoneNo']");
    //             let text = $("#message textarea[name='Content']");

    //             let success = $("#message .alert-success");
    //             let warning = $("#message .alert-warning");
    //             success.css("display", "none");
    //             warning.css("display", "none");

    //     $.ajax({
    //             url: "Contact/Message",
    //             type: "get",
    //             dataType: "json",
    //            data: {
    //            email: name.val(),
    //            name: email.val(),
    //            phone: phone.val(),
    //            text: text.val(),
    //              },
    //             success: function (response) {
    //                if (response.status == true) {
    //            success.css("display", "block");
    //            success.text(response.message);
    //             } else {
    //            warning.css("display", "block");
    //            warning.text(response.message);
    //             }
    //         },
    //          error: function (error) {
    //        console.log(error);
    //         },
    //             complete: function () {
    //        name.val("");
    //        email.val("");
    //        phone.val("");
    //        text.val("");
    //              }
    //     });
    
    //});



   //let starReview = function (userIp, instructorDetailsId, ratingValue) {

   //    $.ajax({
   //             url: location.origin + "/Instructor/RaitingStar",
   //             type: "get",
   //             dataType: "json",
   //             data: {
   //                 userIp: userIp,
   //                 productId: String(instructorDetailsId),
   //                 ratingValue: ratingValue
   //             },
   //             success: function (response) {
   //                 if (response.success != null) {

   //                     swal("Good job!", `Thanks for taking the time to leave us a ${ratingValue} star rating `, "success");
   //                     $(".rating-wrap .rating ul li .fa-star").removeClass("fw");
   //                     for (let xs = 0; xs < response.starsCount; xs++) {

   //                         document.querySelectorAll(".rating-wrap .rating ul li .fa-star")[xs].classList.add("fw");

   //                     }
   //                     let rval2 = response.products["$values"][0].ratings["$values"];
   //                     for (let rs = 0; rs < rval2.length; rs++) {
   //                         let fiveS = 0;
   //                         let fourS = 0;
   //                         let threeS = 0;
   //                         let twoS = 0;
   //                         let oneS = 0;

   //                         for (let str = 0; str < rval2.length; str++) {
   //                             if (rval2[str].star == 5) {
   //                                 fiveS++;
   //                             }
   //                             else if (rval2[str].star == 4) {
   //                                 fourS++;
   //                             }
   //                             else if (rval2[str].star == 3) {
   //                                 threeS++;
   //                             }
   //                             else if (rval2[str].star == 2) {
   //                                 twoS++;
   //                             }
   //                             else if (rval2[str].star == 1) {
   //                                 oneS++;
   //                             }
   //                         }

   //                         let sum = (fiveS * 5) + (fourS * 4) + (threeS * 3) + (twoS * 2) + (oneS * 1);
   //                         let rSum = fiveS + fourS + threeS + twoS + oneS;
   //                         let sumRsum = sum / rSum;

   //                         if (sumRsum != 0) {

   //                             document.getElementById("rating_value").innerText = `(${sumRsum.toFixed(1)} Rating)`;
   //                         }

   //                     }

   //                 }
   //                 else if (response.changed != null) {

   //                     swal("Changed!", `Thanks for taking the time to leave us a ${ratingValue} star rating `, "success");
   //                     $(".rating-wrap .rating ul li .fa-star").removeClass("fw");
   //                     for (var xs = 0; xs < response.starsCount; xs++) {

   //                         document.querySelectorAll(".rating-wrap .rating ul li .fa-star")[xs].classList.add("fw");

   //                     }
   //                     let rval2 = response.products["$values"][0].ratings["$values"];
   //                     for (let rs = 0; rs < rval2.length; rs++) {
   //                         let fiveS = 0;
   //                         let fourS = 0;
   //                         let threeS = 0;
   //                         let twoS = 0;
   //                         let oneS = 0;

   //                         for (let str = 0; str < rval2.length; str++) {
   //                             if (rval2[str].star == 5) {
   //                                 fiveS++;
   //                             }
   //                             else if (rval2[str].star == 4) {
   //                                 fourS++;
   //                             }
   //                             else if (rval2[str].star == 3) {
   //                                 threeS++;
   //                             }
   //                             else if (rval2[str].star == 2) {
   //                                 twoS++;
   //                             }
   //                             else if (rval2[str].star == 1) {
   //                                 oneS++;
   //                             }
   //                         }

   //                         let sum = (fiveS * 5) + (fourS * 4) + (threeS * 3) + (twoS * 2) + (oneS * 1);
   //                         let rSum = fiveS + fourS + threeS + twoS + oneS;
   //                         let sumRsum = sum / rSum;

   //                         if (sumRsum != 0) {

   //                             document.getElementById("rating_value").innerText = `(${sumRsum.toFixed(1)} Rating)`;
   //                         }

   //                     }

   //                 }
   //                 else if (response.error != null) {

   //                     swal("Oops", "Something went wrong", "error");
   //                 }
   //             },
   //             error: function (error) {
   //                 console.log(error);
   //             },
   //             complete: function () {

   //             }
   //         });

   //     }

   //     if (document.querySelectorAll(".modalStarBtn") != null || document.querySelectorAll(".modalStarBtn") != undefined || document.querySelectorAll(".modalStarBtn").length > 0) {


   //         let modalStarBtn = document.querySelectorAll(".modalStarBtn");
   //         for (let r = 0; r < modalStarBtn.length; r++) {
   //             modalStarBtn[r].addEventListener("click", function () {
   //                 $.getJSON("https://api.ipify.org?format=json", function (data) {

   //                     let userIpPD = data.ip
   //                     let ratingValuePD = String(modalStarBtn[r].nextElementSibling.value)
   //                     let instructorDetailsIdPD = ratValprodId.value;


   //                     starReview(userIpPD, instructorDetailsIdPD, ratingValuePD);

   ////                 })

   ////             })
   ////         }




   ////     }

//        let eye = document.querySelectorAll(".productFullDetail");

//        for (let i = 0; i < eye.length; i++) {

//            eye[i].addEventListener("click", function () {

//                $("#quantity-left").addClass("d-none");
//                let productSwiperWrapper = $("#productmodalbody .swiper-wrapper .swiper-slide");
//                for (var q = 0; q < productSwiperWrapper.length; q++) {
//                    productSwiperWrapper[q].remove()
//                }

//                let niceSelect = $("#modalSize").siblings();
//                for (var o = 0; o < niceSelect.length; o++) {
//                    if (niceSelect[o].className != "selector-title") {
//                        niceSelect[o].remove()
//                    }

//                }

//                let sizeOptions = $("#modalSize").children();
//                for (var op = 0; op < sizeOptions.length; op++) {
//                    sizeOptions[op].remove()
//                }

//                document.getElementById("rating_value").innerText = "(0.0 Rating)";
//                $(".rating-wrap .rating ul li .fa-star").removeClass("fw");

//                let id = eye[i].firstChild.nextSibling.value;

//                $.ajax({
//                    url: "Instructor/GetInstructorInfo",
//                    type: "get",
//                    dataType: "json",
//                    data: {
//                        id: id
//                    },
//                    success: function (data) {
//                        if (data.data != null) {

//                            let noResult = $("#noResult");
//                            noResult.addClass("d-none")

//                            var Product = data.data
//                            var productImges = Product.productImages
//                            var productSizeToProduct = Product.productSizeToProducts
//                            var imagesArr = [];

//                            let ratValprodId = document.getElementById("ratValprodId");
//                            ratValprodId.value = Product.id

//                            let prodRatings = Product.ratings["$values"];

//                            for (let rs = 0; rs < prodRatings.length; rs++) {
//                                let fiveS = 0;
//                                let fourS = 0;
//                                let threeS = 0;
//                                let twoS = 0;
//                                let oneS = 0;

//                                for (let str = 0; str < prodRatings.length; str++) {
//                                    if (prodRatings[str].star == 5) {
//                                        fiveS++;
//                                    }
//                                    else if (prodRatings[str].star == 4) {
//                                        fourS++;
//                                    }
//                                    else if (prodRatings[str].star == 3) {
//                                        threeS++;
//                                    }
//                                    else if (prodRatings[str].star == 2) {
//                                        twoS++;
//                                    }
//                                    else if (prodRatings[str].star == 1) {
//                                        oneS++;
//                                    }
//                                }

//                                let sum = (fiveS * 5) + (fourS * 4) + (threeS * 3) + (twoS * 2) + (oneS * 1);
//                                let rSum = fiveS + fourS + threeS + twoS + oneS;
//                                let sumRsum = sum / rSum;

//                                if (sumRsum != 0) {

//                                    document.getElementById("rating_value").innerText = `(${sumRsum.toFixed(1)} Rating)`;
//                                }

//                            }

//                            $.getJSON("https://api.ipify.org?format=json", function (data) {

//                                let userIp2 = data.ip;


//                                for (let x = 0; x < prodRatings.length; x++) {
//                                    if (prodRatings[x].userIp == userIp2) {
//                                        for (var xs = 0; xs < prodRatings[x].star; xs++) {

//                                            document.querySelectorAll(".rating-wrap .rating ul li .fa-star")[xs].classList.add("fw");

//                                        }
//                                    }
//                                }
//                            })


//                            for (var i in productImges) {
//                                for (var t = 0; t < productImges[i].length; t++) {
//                                    if (productImges[i][t].image !== undefined) {
//                                        imagesArr[t] = productImges[i][t].image;
//                                    }
//                                }

//                            }

//                            var pricesArr = [];
//                            var pricesIdArr = [];
//                            var sizesArr = [];
//                            var quantityArr = [];
//                            var productSizeToProductHelper = [];

//                            for (var a in productSizeToProduct) {
//                                for (var b = 0; b < productSizeToProduct[a].length; b++) {
//                                    if (productSizeToProduct[a][b].price !== undefined) {

//                                        pricesArr[b] = productSizeToProduct[a][b].price
//                                        sizesArr[b] = productSizeToProduct[a][b].productSize.size
//                                        pricesIdArr[b] = productSizeToProduct[a][b].productSize.id
//                                        quantityArr[b] = productSizeToProduct[a][b].quantity
//                                        productSizeToProductHelper[b] = productSizeToProduct[a][b];

//                                    }
//                                    else if (true) {

//                                    }
//                                }
//                            }

//                            let modalSize = document.getElementById("modalSize");
//                            let modalPrice = document.getElementById("modalPrice");
//                            let modalDesc = document.getElementById("modal-product-desc");
//                            let productName = document.getElementById("product-name");
//                            modalPrice.innerText = "$" + pricesArr[0].toFixed(2);
//                            productName.innerText = Product.name
//                            modalDesc.innerText = Product.shortDesc

//                            for (var s = 0; s < sizesArr.length; s++) {
//                                let size = document.createElement("option");
//                                size.innerText = sizesArr[s];
//                                size.value = pricesIdArr[s];
//                                modalSize.appendChild(size)
//                            }
//                            $(".nice-select2").niceSelect();



//                            let selector = document.querySelectorAll("#selector-size .nice-select ul li")

//                            for (let s = 0; s < selector.length; s++) {

//                                selector[s].addEventListener("click", function () {

//                                    let sizeId = selector[s].getAttribute('data-value');

//                                    for (let i = 0; i < productSizeToProductHelper.length; i++) {

//                                        if (productSizeToProductHelper[i].productSizeId == sizeId) {

//                                            modalPrice.innerText = "$" + productSizeToProductHelper[i].price.toFixed(2)

//                                        }

//                                    }

//                                })

//                            }

//                        }
//                        else {
//                            let noResult = $("#noResult");
//                            noResult.removeClass("d-none")
//                        }

//                    },
//                    error: function (error) {
//                        console.log(error);
//                    },
//                    complete: function () {

//                    }
//                });

//            })

//        }
//        if (document.getElementById("totalRating") != null) {
//            let totalRating = document.getElementById("totalRating").value;
//        }

//        let ratingStars = document.querySelectorAll(".ratingStrars");
//        let ratingStarIcon = document.querySelectorAll(".ratingStrars .fa-star");

//        let instructorDetailsId;
//        if (document.getElementById("instructorDetailsId") != null) {
//            instructorDetailsId = document.getElementById("instructorDetailsId").value;
//        }

//        let ratingStarsValue = $(".ratingStarsValue");
//        for (let s = 0; s < ratingStars.length; s++) {

//            ratingStars[s].addEventListener("click", function (e) {
//                e.preventDefault()
//                $.getJSON("https://api.ipify.org?format=json", function (data) {


//                    let userIp = data.ip
//                    let ratingValue = String(ratingStarsValue[s].value)

//                    $.ajax({
//                        url: "../ReviewPost",
//                        type: "get",
//                        dataType: "json",
//                        data: {
//                            userIp: userIp,
//                            productId: String(instructorDetailsId),
//                            ratingValue: ratingValue
//                        },
//                        success: function (response) {
//                            if (response.success != null) {

//                                swal("Good job!", `Thanks for taking the time to leave us a ${ratingValue} star rating `, "success");
//                            }
//                            else if (response.changed != null) {

//                                swal("Good job!", `Thanks for taking the time to leave us a ${ratingValue} star rating `, "success");
//                            }
//                            else if (response.error != null) {

//                                swal("Oops", "Something went wrong", "error");
//                            }
//                        },
//                        error: function (error) {
//                            console.log(error);
//                        },
//                        complete: function () {

//                        }
//                    });






//                })




//            })

//        }

//        if (document.getElementById("totalRating") != null) {
//            for (let r = 0; r < totalRating; r++) {

//                ratingStarIcon[r].style.fontWeight = "900";
//                console.log(ratingStarIcon[r])

//            }
//        }

       
   
//});