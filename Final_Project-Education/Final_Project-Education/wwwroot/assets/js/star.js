////$(document).ready(function () {

////    if (document.getElementById("totalRating") != null) {
////        let totalRating = document.getElementById("totalRating").value;
////    }

////    let ratingStars = document.querySelectorAll(".ratingStrars");
////    let ratingStarIcon = document.querySelectorAll(".ratingStrars .fa-star");

////    let singleProductId;
////    if (document.getElementById("singleProductId") != null) {
////        singleProductId = document.getElementById("singleProductId").value;
////    }

////    let ratingStarsValue = $(".ratingStarsValue");
////    for (let s = 0; s < ratingStars.length; s++) {

////        ratingStars[s].addEventListener("click", function (e) {
////            e.preventDefault()
////            $.getJSON("https://api.ipify.org?format=json", function (data) {


////                let userIp = data.ip
////                let ratingValue = String(ratingStarsValue[s].value)

////                $.ajax({
////                    url: "../RaitingStar",
////                    type: "get",
////                    dataType: "json",
////                    data: {
////                        userIp: userIp,
////                        productId: String(singleProductId),
////                        ratingValue: ratingValue
////                    },
////                    success: function (response) {
////                        if (response.success != null) {

////                            swal("Good job!", `Thanks for taking the time to leave us a ${ratingValue} star rating `, "success");
////                        }
////                        else if (response.changed != null) {

////                            swal("Good job!", `Thanks for taking the time to leave us a ${ratingValue} star rating `, "success");
////                        }
////                        else if (response.error != null) {

////                            swal("Oops", "Something went wrong", "error");
////                        }
////                    },
////                    error: function (error) {
////                        console.log(error);
////                    },
////                    complete: function () {

////                    }
////                });
////            })
////        })
////    }

////    if (document.getElementById("totalRating") != null) {
////        for (let r = 0; r < totalRating; r++) {

////            ratingStarIcon[r].style.fontWeight = "900";
////            console.log(ratingStarIcon[r])

////        }
////    }










////    // #region Modal-slider \\
////    new Swiper(".modal-slider", {
////        autoplay: false,
////        delay: 5e3,
////        slidesPerView: 1,
////        slidesPerGroup: 1,
////        observer: true,
////        observeParents: true,
////        loop: false,
////        navigation: {
////            nextEl: ".thumbs-button-next",
////            prevEl: ".thumbs-button-prev"
////        }
////    });
////    // #endregion Modal-slider end \\

  


 
////    let StarFunc = function (AllTheStars) {

////        let allStr = AllTheStars;
////        if (allStr != null) {
////            for (let astr = 0; astr < allStr.length; astr++) {

////                allStr[astr].addEventListener("mouseover", function () {

////                    if (astr == 0) {
////                        for (let astr2 = 0; astr2 <= astr; astr2++) {
////                            allStr[astr2].children[0].style.fontWeight = "900";

////                        }
////                    }
////                    else if (astr == 1) {
////                        for (let astr2 = 0; astr2 <= astr; astr2++) {
////                            allStr[astr2].children[0].style.fontWeight = "900";

////                        }
////                    }
////                    else if (astr == 2) {
////                        for (let astr2 = 0; astr2 <= astr; astr2++) {
////                            allStr[astr2].children[0].style.fontWeight = "900";

////                        }
////                    }
////                    else if (astr == 3) {
////                        for (let astr2 = 0; astr2 <= astr; astr2++) {
////                            allStr[astr2].children[0].style.fontWeight = "900";

////                        }
////                    }
////                    else if (astr == 4) {
////                        for (let astr2 = 0; astr2 <= astr; astr2++) {
////                            allStr[astr2].children[0].style.fontWeight = "900";

////                        }
////                    }

////                })

////            }

////            for (let astre = allStr.length - 1; astre >= 0; astre--) {

////                allStr[astre].addEventListener("mouseleave", function () {

////                    if (astre == 0) {
////                        for (let astr2 = astre; astr2 >= 0; astr2--) {
////                            allStr[astr2].children[0].style.fontWeight = "100";

////                        }
////                    }
////                    else if (astre == 1) {
////                        for (let astr2 = astre; astr2 >= 0; astr2--) {
////                            allStr[astr2].children[0].style.fontWeight = "100";

////                        }
////                    }
////                    else if (astre == 2) {
////                        for (let astr2 = astre; astr2 >= 0; astr2--) {
////                            allStr[astr2].children[0].style.fontWeight = "100";

////                        }
////                    }
////                    else if (astre == 3) {
////                        for (let astr2 = astre; astr2 >= 0; astr2--) {
////                            allStr[astr2].children[0].style.fontWeight = "100";

////                        }
////                    }
////                    else if (astre == 4) {
////                        for (let astr2 = astre; astr2 >= 0; astr2--) {
////                            allStr[astr2].children[0].style.fontWeight = "100";

////                        }

////                    }

////                })
////            }
////        }
////    }

////    let starReviews = function (userEmail, userSurname, userName, singleProductId, ratingValue) {
////        $.ajax({
////            url: location.origin + "/Instructor/RaitingStar",
////            type: "get",
////            dataType: "json",
////            data: {
////                userName: userName,
////                userSurname: userSurname,
////                userEmail: userEmail,
////                productId: String(singleProductId),
////                ratingValue: ratingValue
////            },
////            success: function (response) {
////                if (response.success != null) {

////                    swal("Good job!", `Thanks for taking the time to leave us a ${ratingValue} star rating `, "success");
////                    //GetAllStars();
////                    let rval2 = response.products["$values"][0].ratings["$values"];
////                    for (let rs = 0; rs < rval2.length; rs++) {
////                        let fiveS = 0;
////                        let fourS = 0;
////                        let threeS = 0;
////                        let twoS = 0;
////                        let oneS = 0;

////                        for (let str = 0; str < rval2.length; str++) {
////                            if (rval2[str].star == 5) {
////                                fiveS++;
////                            }
////                            else if (rval2[str].star == 4) {
////                                fourS++;
////                            }
////                            else if (rval2[str].star == 3) {
////                                threeS++;
////                            }
////                            else if (rval2[str].star == 2) {
////                                twoS++;
////                            }
////                            else if (rval2[str].star == 1) {
////                                oneS++;
////                            }
////                        }

////                        let sum = (fiveS * 5) + (fourS * 4) + (threeS * 3) + (twoS * 2) + (oneS * 1);
////                        let rSum = fiveS + fourS + threeS + twoS + oneS;
////                        let sumRsum = sum / rSum;

////                        if (sumRsum != 0) {

////                            document.getElementById("rating_value").innerText = `(${sumRsum.toFixed(1)} Rating)`;
////                        }
////                    }
////                }
////                else if (response.changed != null)

////                    console.log(ratingValue);


////                    swal("Changed!", `Thanks for taking the time to leave us a ${ratingValue} star rating `, "success");
////                    //GetAllStars()
////                    let rval2 = response.products["$values"][0].ratings["$values"];
////                    for (let rs = 0; rs < rval2.length; rs++) {
////                        let fiveS = 0;
////                        let fourS = 0;
////                        let threeS = 0;
////                        let twoS = 0;
////                        let oneS = 0;

////                        for (let str = 0; str < rval2.length; str++) {
////                            if (rval2[str].star == 5) {
////                                fiveS++;
////                            }
////                            else if (rval2[str].star == 4) {
////                                fourS++;
////                            }
////                            else if (rval2[str].star == 3) {
////                                threeS++;
////                            }
////                            else if (rval2[str].star == 2) {
////                                twoS++;
////                            }
////                            else if (rval2[str].star == 1) {
////                                oneS++;
////                            }
////                        }

////                        let sum = (fiveS * 5) + (fourS * 4) + (threeS * 3) + (twoS * 2) + (oneS * 1);
////                        let rSum = fiveS + fourS + threeS + twoS + oneS;
////                        let sumRsum = sum / rSum;

////                        if (sumRsum != 0) {

////                            document.getElementById("rating_value").innerText = `(${sumRsum.toFixed(1)} Rating)`;
////                        }

////                    }

////                }
////                else if (response.error != null) {

////                    swal("Oops", "Something went wrong", "error");
////                }
////            }
////            error: function (error) {
////                console.log(error);
////            },
////            complete: function () {

////            }
////        });

////    }

////var instSI = $(`.rating-box ul li .fastar`);

////if ($(".instructor-detail").length > 0) {

////    instSI = $(".instructor-detail .instructor-admin .rating-box1 .fastar");
////    }

////    let isEmailTrue = function isEmail(email) {
////        return /^((([a-z]|\d|[!#\$%&'\*\+\-\/=\?\^_`{\|}~]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])+(\.([a-z]|\d|[!#\$%&'\*\+\-\/=\?\^_`{\|}~]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])+)*)|((\x22)((((\x20|\x09)*(\x0d\x0a))?(\x20|\x09)+)?(([\x01-\x08\x0b\x0c\x0e-\x1f\x7f]|\x21|[\x23-\x5b]|[\x5d-\x7e]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(\\([\x01-\x09\x0b\x0c\x0d-\x7f]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF]))))*(((\x20|\x09)*(\x0d\x0a))?(\x20|\x09)+)?(\x22)))@((([a-z]|\d|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(([a-z]|\d|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])([a-z]|\d|-|\.|_|~|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])*([a-z]|\d|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])))\.)+(([a-z]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(([a-z]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])([a-z]|\d|-|\.|_|~|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])*([a-z]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])))$/i.test(email);
////    }

////    var b;
////    var a;

////    instSI.click(function () {

////        let ratingValuePD = $(this).data().rv;
////        let singleInstructorIdPD = $(this).data().pd;

////        b = ratingValuePD;
////        a = singleInstructorIdPD;


////    })

////    instSI.mouseover(function () {

////        StarFunc($(this).parentsUntil(".rating-box")[1].children);

////    })

////    $("#mdoalrat1").click(function (e) {

////        e.preventDefault();

////        var userName = $("#recipient-name").val();
////        var userSurname = $("#recipient-surname").val();
////        var userEmail = $("#message-email").val();

////        if (isEmailTrue(userEmail)) {

////            starReviews(userEmail, userSurname, userName, a, b);

////            console.log(userEmail, userSurname, userName, a, b)

////        }
////        else {

////            swal("Oops", "Please enter valid Email adress", "error");
////        }

////        $("#exampleModal2 .btn-close").click()

////    })

////    if ($(".user-enable").length > 0) {

////        $(".user-enable").click(function () {

////            starReviews("user", "user", "user", a, b);

////        })

////    }

////    if ($("#profileIsCreated").length > 0) {

////        swal("Perfect!", `Thank you for Signing Up!`, "success");

////    }

////    if ($("#UpdateUserSuccess").length > 0) {

////        swal("Updated!", `Your profile was updated successfully!`, "success");

////    }

////    if ($("#PaymentSuccessAlert").length > 0) {

////        swal("Perfect!!", `Thank you for choosing us! Please check your Email`, "success");

////    }

////    if ($("#ResetSuccess").length > 0) {

////        swal("Success!", `Your password has been changed successfully!`, "success");

////    }

////    if ($("#ResetError2").length > 0) {

////        swal("Oops!", `Something went wrong. Try it again!`, "error");

////    }

////    if ($("#LoginRoleError").length > 0) {

////        swal("Oops!", `You dont have permission to use this account like End User!`, "error");

////    }

   




















////});


//success: function (response) {
//    if (response.success != null) {

//        swal("Good job!", `Thanks for taking the time to leave us a ${ratingValue} star rating `, "success");
//        //GetAllStars();
//        let rval2 = response.products["$values"][0].ratings["$values"];
//        for (let rs = 0; rs < rval2.length; rs++) {
//            let fiveS = 0;
//            let fourS = 0;
//            let threeS = 0;
//            let twoS = 0;
//            let oneS = 0;

//            for (let str = 0; str < rval2.length; str++) {
//                if (rval2[str].star == 5) {
//                    fiveS++;
//                }
//                else if (rval2[str].star == 4) {
//                    fourS++;
//                }
//                else if (rval2[str].star == 3) {
//                    threeS++;
//                }
//                else if (rval2[str].star == 2) {
//                    twoS++;
//                }
//                else if (rval2[str].star == 1) {
//                    oneS++;
//                }
//            }

//            let sum = (fiveS * 5) + (fourS * 4) + (threeS * 3) + (twoS * 2) + (oneS * 1);
//            let rSum = fiveS + fourS + threeS + twoS + oneS;
//            let sumRsum = sum / rSum;

//            if (sumRsum != 0) {

//                document.getElementById("rating_value").innerText = `(${sumRsum.toFixed(1)} Rating)`;
//            }

//        }

//    }
//    else if (response.changed != null) {



//        console.log(ratingValue);


//        swal("Changed!", `Thanks for taking the time to leave us a ${ratingValue} star rating `, "success");
//        //GetAllStars()
//        let rval2 = response.products["$values"][0].ratings["$values"];
//        for (let rs = 0; rs < rval2.length; rs++) {
//            let fiveS = 0;
//            let fourS = 0;
//            let threeS = 0;
//            let twoS = 0;
//            let oneS = 0;

//            for (let str = 0; str < rval2.length; str++) {
//                if (rval2[str].star == 5) {
//                    fiveS++;
//                }
//                else if (rval2[str].star == 4) {
//                    fourS++;
//                }
//                else if (rval2[str].star == 3) {
//                    threeS++;
//                }
//                else if (rval2[str].star == 2) {
//                    twoS++;
//                }
//                else if (rval2[str].star == 1) {
//                    oneS++;
//                }
//            }

//            let sum = (fiveS * 5) + (fourS * 4) + (threeS * 3) + (twoS * 2) + (oneS * 1);
//            let rSum = fiveS + fourS + threeS + twoS + oneS;
//            let sumRsum = sum / rSum;

//            if (sumRsum != 0) {

//                document.getElementById("rating_value").innerText = `(${sumRsum.toFixed(1)} Rating)`;
//            }

//        }

//    }
//    else if (response.error != null) {

//        swal("Oops", "Something went wrong", "error");
//    }
//},
//error: function (error) {
//    console.log(error);
//},
//complete: function () {

//}