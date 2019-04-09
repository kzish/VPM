$(document).ready(function () {

    $("#flog0").validate();
    $("#flog1").validate();
    $("#freg").validate({
        rules: {
            password: {
                minlength: 5
            },
            password_confirm: {
                minlength: 5,
                equalTo: "#password"
            }
        }
    });

    $("#flog0").on("submit", function (e) {
        var valid = $("#flog0").valid();
        if (valid) {
            $.busyLoadFull("show");
        }
    });

    $("#flog1").on("submit", function (e) {
        var valid = $("#flog1").valid();
        if (valid) {
            $.busyLoadFull("show");
        }
    });

    $("#freg").on("submit", function (e) {
        var valid = $("#freg").valid();
        if (valid) {
            $.busyLoadFull("show");
        }
    });


});