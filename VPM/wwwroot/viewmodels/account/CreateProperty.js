

function openFimages() {
    $("#fimages").click();
}

function openTFiles() {
    $("#tfiles").click();
}

$(document).ready(function () {

    $('#stateOrPorvince').selectize();
    $('#propertyCountry').selectize();
    $('#propertyType').selectize();
    $('#billingRate').selectize();
    $('#PropertyStatus').selectize();

    $("#fcp").validate();


    $("#fimages").on("change", function () {
        var f = $("#fimages")[0].files;
        for (var i = 0; i < f.length; i++) {
            UploadPropertyImages("fimages", f[i]);
        }
        $("#fimages").val("");
    });

    $("#tfiles").on("change", function () {
        var f = $("#tfiles")[0].files;
        for (var i = 0; i < f.length; i++) {
            UploadPropertyTitleDeeds("fimages", f[i]);
        }
        $("#tfiles").val("");
    });

});


function UploadPropertyImages(par, file) {
    var fdata = new FormData();
    var pid = $("#pid").val();
    fdata.append("pid", pid);
    fdata.append("file", file);
    $.busyLoadFull("show");
    $.ajax({
        url: "/Account/UploadPropertyImages",
        data: fdata,
        type: "POST",
        processData: false,
        contentType: false,
        success: function (res) {
            console.log(res);
            $.busyLoadFull("hide");
            $("#pimages").append(

                /*'<div class="col-md-3" id="' + res.id + '">' +
                '<div class="divImageHolder">' +
                '<a href="javascript:void(0);">' +
                '<div class="divImageItem firstProduct">' +
                '<img src="/uploads/' + res.msg + '" style="object-fit:cover" />' +
                '<span class="text-content">' +
                '<span>' +
                '<i class="fa fa-trash" title="delete" onclick=removePropertyImage("' + pid + '","' + res.id + '")></i>' +
                '</span>' +
                '</span>' +
                '</div>' +
                '</a>' +
                '</div>' +
                '</div>'*/


                
                '<div class="col-md-4" id="' + res.id + '">' +
                '<div class="divImageHolder">' +
                '<a href="javascript:void(0);">' +
                '<div class="divImageItem firstProduct">' +
                '<img src="/uploads/' + res.msg + '" style="object-fit:cover" />' +
                '<span class="text-content">' +
                '<span>' +
                '<i class="fa fa-trash" + " title="delete" onclick=removePropertyImage("' + pid + '","' + res.id + '")></i>' +
                '</span>' +
                '</span>' +
                '</div>' +
                '</a>' +
                '</div>' +
                '</div>'


            );

        },
        error: function () {
            alert("Eror uploading files");
            $.busyLoadFull("hide");

        },
    });
}

function UploadPropertyTitleDeeds(par, file) {
    var fdata = new FormData();
    var pid = $("#pid").val();
    fdata.append("pid", pid);
    fdata.append("file", file);
    $.busyLoadFull("show");
    $.ajax({
        url: "/Account/UploadPropertyTitleDeeds",
        data: fdata,
        type: "POST",
        processData: false,
        contentType: false,
        success: function (res) {
            console.log(res);
            $.busyLoadFull("hide");
            $("#tdfiles").append(

                /*'<div class="col-md-4" id="' + res.id + '">' +
                '<div class="divImageHolder">' +
                '<a href="javascript:void(0);">' +
                '<div class="divImageItem firstProduct">' +
                '<img src="/uploads/' + res.msg + '" style="object-fit:cover" />' +
                '<span class="text-content">' +
                '<span>' +
                '<i class="fa fa-trash" title="delete" onclick=removeTitleDeed("' + pid + '","' + res.id + '")></i>' +
                '</span>' +
                '</span>' +
                '</div>' +
                '</a>' +
                '</div>' +
                '</div>'*/


                '<div class="col-md-4" id="'+res.id+'">'+
                '<div class="divImageHolder">'+
                        '<a href="javascript:void(0);">'+
                            '<div class="divImageItem firstProduct">'+
                                '<img src="/uploads/' + res.msg+'" style="object-fit:cover" />'+
                                '<span class="text-content">'+
                                    '<span>'+
                                        '<i class="fa fa-trash" + " title="delete" onclick=removeTitleDeed("' + pid + '","' + res.id + '")></i>'+
                                    '</span>'+
                                '</span>'+
                            '</div>'+
                        '</a>'+
                    '</div>'+
                '</div>'



            );

        },
        error: function () {
            alert("Eror uploading files");
            $.busyLoadFull("hide");

        },
    });
}


function removePropertyImage(pid, id) {
    $.busyLoadFull("show");
    $.ajax({
        url: "/Account/removePropertyImage?pid=" + pid + "&id=" + id,
        type: "get",
        success: function (res) {
            $.busyLoadFull("hide");
            console.log(res);
            $("#" + id).remove();
        },
        error: function () {
            alert("error");
            $.busyLoadFull("hide");
            // window.location = "";
        }
    })
}



function removeTitleDeed(pid, id) {
    $.busyLoadFull("show");
    $.ajax({
        url: "/Account/removeTitleDeed?pid=" + pid + "&id=" + id,
        type: "get",
        success: function (res) {
            $.busyLoadFull("hide");
            console.log(res);
            $("#" + id).remove();
        },
        error: function () {
            alert("error");
            $.busyLoadFull("hide");
            // window.location = "";
        }
    })
}

function deleteProperty() {
    var pid = $("#pid").val();
    $.confirm({
        title: "Information",
        content: "Delete this property?",
        type: "orange",
        buttons: {
            yes: function () {
                execDeleteProrperty(pid);
            },
            no: function () {

            }
        }

    });
}


function execDeleteProrperty(pid) {
    $.busyLoadFull("show");
    $.ajax({
        url: "/Account/deleteProperty?pid=" + pid,
        data: null,
        type: "get",
        success: function (res) {
            console.log(res);
            if (res.res == "ok") {
                window.location = "/Account/Properties";
            }
        },
        error: function () {
            alert("error");
            $.busyLoadFull("hide");
        }

    });

}


function openGoogleForm() {

    

    $.MessageBox({
        input: true,
        message: "Copy And Paste Your Google Form Link here"
    }).done(function (data) {
        if ($.trim(data)) {
            ref = data;//get the reference or caption
            execSaveGoogleFormLink(ref);
        } else {

        }
        });

    var win = window.open("https://docs.google.com/forms/u/0/", '_blank');
    win.focus();

}


function execSaveGoogleFormLink(_ref) {
    $.busyLoadFull("show");
    var pid = $("#pid").val();
    $.ajax({
        url: "/Account/SaveGoogleFormLink",
        method: "POST",
        data: { _ref: _ref, pid: pid },
        success: function (res) {
            console.log(res);
            $.busyLoadFull("hide");
            if (res.res == "ok") {
                $.alert({
                    title: "Information",
                    content: "saved",
                    type: "green"
                });

                $("#eligibilityFormLink").val(_ref);
            }
            else if (res.res != "ok") {
                $.alert({
                    title: "Error",
                    content: "error",
                    type: "orange"
                });
            }
        },
        error: function () {
            alert("error");
        }
    });

}



//get the cities on drop down select
function getcities() {
    $.getJSON("/Account/getcities", function (data) {
        //var items = [];
        var cityOrTown = $("#cityOrTown");
        $.each(data, function (key,val) {
           // cityOrTown.append("<option value='" + val + "'>" + val + "</option>");
        });


    });
}
getcities();

function deleteEligibilityForm(pid) {
    $.busyLoadFull("show");
    $.ajax({
        url: "/Account/deleteEligibilityForm",
        data: {pid:pid},
        method: 'POST',
        success: function (res) {
            console.log(res);
            $.busyLoadFull("hide");
            $("#eligibilityFormLink").val("");
        },
        error: function () {
            $.busyLoadFull("hide");
            alert("error");
        }
    });
}