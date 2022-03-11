$(document).ready(function () {
    "use strict";
    //preloader
    window.onload = function () {
        $("#onload").fadeOut();
        $("body").removeClass("hidden");
    };

    //sticky
    function stickyMenu() {
        var sticky = document.getElementById("sticky");
        if (window.pageYOffset > 300) {
            sticky.classList.add("stickyStyle");
        } else {
            sticky.classList.remove("stickyStyle");
        }
    }
    window.onscroll = function () {
        stickyMenu();
    };


    $(".sliderInstructors").owlCarousel({
        loop: true,
        margin: 20,
        dots: true,
        autoplay: true,
        autoplayTimeout: 2000,
        responsive: {
            0: {
                items: 1,
            },
            600: {
                items: 2,
            },
            1000: {
                items: 4,
            },
        },

    });


    $(".slideTestimonial").owlCarousel({
        loop: true,
        dots: true,
        autoplay: true,
        autoplayTimeout: 2000,
        responsive: {
            0: {
                items: 1,
            },
            600: {
                items: 1,
            },
            1000: {
                items: 1,
            },
        },
    });



    $(".sliderCompanies").owlCarousel({
        loop: true,
        margin: 20,
        dots: false,
        autoplay: true,
        nav: false,
        autoplayTimeout: 2000,
        responsive: {
            0: {
                items: 2,
            },
            600: {
                items: 3,
            },
            1000: {
                items: 5,
            },
        },
    });

    $("#open-reply").on('click', function () {

        $('#reply-hidden').addClass("show-form");
    });





    //Accordion Box
    var faqOpenBtn = document.querySelectorAll(".accordion-button");
    var faqBody = document.querySelectorAll(".accordion-collapse");
    for (let i = 0; i < faqOpenBtn.length; i++) {
        faqOpenBtn[i].addEventListener("click", function (e) {
            e.preventDefault();
            for (let j = 0; j < faqBody.length; j++) {
                if (j != i) {
                    faqBody[j].classList.remove("show");
                }
            }
            faqBody[i].classList.add("show");
            faqOpenBtn[i].classList.add("collapsed");
        });
    }

    let ratingStars = document.querySelectorAll('.myStar')
    ratingStars.forEach((rs) => {
        rs.addEventListener('click', () => {

            let ratingValue = rs.getAttribute('data-value')
            let teacherId = rs.getAttribute('data-teacherId')
            $.ajax({
                url: "/Instructor/RaitingStar",
                type: "get",
                dataType: "json",
                data: {

                    ratingValue,
                    teacherId
                },
            });
            console.log(`${ratingValue} ${teacherId}`)
        })
    })


    let submit = $("#sec-btn");

    submit.click(function (e) {
        e.preventDefault();

        let email = $("#subscribies input[name='email']");
        $.ajax({
            url: "/Home/Subscribe",
            type: "get",
            dataType: "json",
            data: {
                email: email.val()
            },
            success: function (response) {
                console.log(response)
                if (response.status) {

                    Swal.fire({
                        position: 'top-end',
                        icon: 'success',
                        title: 'You subscribe successfully!',
                        showConfirmButton: false,
                        timer: 1500
                    });
                }
                else if (!response.status && !response.status2) {
                    Swal.fire({
                        position: 'top-end',
                        icon: 'success',
                        title: 'Subscribtion faild! You must enter your email',
                        showConfirmButton: false,
                        timer: 1500
                    });
                }

                if (response.status2) {
                    Swal.fire({
                        position: 'top-end',
                        icon: 'success',
                        title: 'Your have already subscribed!',
                        showConfirmButton: false,
                        timer: 1500
                    });
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

    let submit2 = $("#btn-message");
    submit2.click(function (e) {
        e.preventDefault();
        let name = $("#message input[name='FullName']");
        let email1 = $("#message input[name='EmailAddress']");
        let phone = $("#message input[name='PhoneNo']");
        let text = $("#message textarea[name='Content']");


        $.ajax({
            url: "/Contact/Message",
            type: "get",
            dataType: "json",
            data: {
                name: name.val(),
                email1: email1.val(),
                phone: phone.val(),
                text: text.val()
            },
            success: function (response) {
                console.log(response)
                if (response.message) {

                    Swal.fire({
                        position: 'top-end',
                        icon: 'success',
                        title: 'You subscribe successfully!',
                        showConfirmButton: false,
                        timer: 1500
                    });
                }
                else if (!response.message && !response.message2) {
                    Swal.fire({
                        position: 'top-end',
                        icon: 'success',
                        title: 'Subscribtion faild! You must enter your email',
                        showConfirmButton: false,
                        timer: 1500
                    });
                }

                if (response.message2) {
                    Swal.fire({
                        position: 'top-end',
                        icon: 'success',
                        title: 'Your have already subscribed!',
                        showConfirmButton: false,
                        timer: 1500
                    });
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




    var searchConfig = {
        facets: {},
        sort: {
            field: undefined,
            direction: undefined,
        },
        price: {
            from: undefined,
            to: undefined,
        },
    };
    var resultTemplate = Hogan.compile(
        [
            "<div class='product'>",
            "<h2>{{title}}</h2>",
            "<div>Quantity: {{quantity}}</div>",
            "<div>Category: {{category}}</div>",
            "<div>Price: ${{price}}</div>",
            "<div>Tags: {{tags}}</div>",
            "<div>Published: {{published_on}}</div>",
            "</div>",
        ].join("")
    );
    var customRenderFunction = function (document_type, item) {
        var date = new Date(item["published_on"]),
            data = {
                title: item["title"],
                quantity: item["quantity"],
                price: item["price"],
                category: item["category"],
                tags: item["tags"],
                published_on: [date.getMonth(), date.getDate(), date.getFullYear()].join(
                    "/"
                ),
            };
        return resultTemplate.render(data);
    };
    var $facetContainer = $(".st-dynamic-facets");
    var reloadResults = function () {
        window.location.hash = window.location.hash.replace(/stp=[^&]*/i, "stp=1"); // Reset to page 1
        $(window).hashchange();
    };
    var bindControls = function (data) {
        var resultInfo = data["info"],
            facets = "";
        $.each(resultInfo, function (documentType, typeInfo) {
            $.each(typeInfo.facets, function (field, facetCounts) {
                facets += ['<div class="facet"><h3>', field, "</h3></div>"].join("");
                $.each(facetCounts, function (label, count) {
                    var status = "",
                        id = encodeURIComponent(label).toLowerCase();
                    if (
                        window.searchConfig.facets[field] &&
                        window.searchConfig.facets[field].indexOf(label) > -1
                    ) {
                        status = 'checked="checked"';
                    }
                    facets +=
                        '<input type="checkbox"' +
                        status +
                        ' name="' +
                        field +
                        '" value="' +
                        label +
                        '" id="' +
                        id +
                        '"> <label for="' +
                        id +
                        '">' +
                        label +
                        " (" +
                        count +
                        ")</label><br/>";
                });
                facets +=
                    '<a href="#" class="clear-selection" data-name="' +
                    field +
                    '">Clear all</a>';
            });
            $facetContainer.html(facets);
        });
    };
    var readSortField = function () {
        return { products: window.searchConfig.sort.field };
    };
    var readSortDirection = function () {
        return { products: window.searchConfig.sort.direction };
    };
    $(".sort").on("click", function (e) {
        e.preventDefault();
        // Visually change the selected sorting order
        $(".sort").removeClass("active");
        $(this).addClass("active");
        // Update sorting settings
        window.searchConfig.sort.field = $(this).data("field");
        window.searchConfig.sort.direction = $(this).data("direction");
        reloadResults();
    });
    $facetContainer.on("click", "input", function (e) {
        window.searchConfig.facets = {}; // Set the hash to empty
        $('.st-dynamic-facets input[type="checkbox"]').each(function (idx, obj) {
            var $checkbox = $(obj),
                facet = $checkbox.prop("name");
            if (!window.searchConfig.facets[facet]) {
                window.searchConfig.facets[facet] = [];
            }
            if ($checkbox.prop("checked")) {
                window.searchConfig.facets[facet].push($checkbox.prop("value"));
            }
        });
        reloadResults();
    });
    $facetContainer.on("click", "a.clear-selection", function (e) {
        e.preventDefault();
        var name = $(this).data("name");
        $("input[name=" + name + "]").prop("checked", false);
        window.searchConfig.facets[name] = [];
        reloadResults();
    });
    $(".price-filter").on("click", function (e) {
        if ($(this).prop("checked")) {
            // Visually update the checkboxes
            $(".price-filter").prop("checked", false);
            $(this).prop("checked", true);
            // Update the search parameters
            window.searchConfig.price.from = $(this).data("from");
            window.searchConfig.price.to = $(this).data("to");
        } else {
            window.searchConfig.price.from = undefined;
            window.searchConfig.price.to = undefined;
        }
        reloadResults();
    });
    var readFilters = function () {
        return {
            products: {
                category: window.searchConfig.facets["category"],
                tags: window.searchConfig.facets["tags"],
                price: {
                    type: "range",
                    from: window.searchConfig.price.from,
                    to: window.searchConfig.price.to,
                },
            },
        };
    };
    $("#st-search-input").swiftypeSearch({
        resultContainingElement: "#st-results-container",
        engineKey: "t2s8T3sUKx4jJoebs73L",
        renderFunction: customRenderFunction,
        sortField: readSortField,
        sortDirection: readSortDirection,
        facets: { products: ["category", "tags"] },
        filters: readFilters,
        postRenderFunction: bindControls,
        perPage: 12,
    });
    $("#st-search-input").swiftype({
        engineKey: "t2s8T3sUKx4jJoebs73L",
    });
    // Start the demo out with products loaded on the page
    $(window).on("load", function () {
        var hasSearchTerm = window.location.hash.indexOf("stq=") >= 0;
        if (!hasSearchTerm) {
            window.location.hash = "stq=product&stp=1";
            reloadResults();
        }
    });

});

