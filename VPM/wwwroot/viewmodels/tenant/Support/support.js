$(document).ready(function () {


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
    var aid = $("#aid").val();
    fdata.append("aid", aid);
    fdata.append("file", file);
    $.busyLoadFull("show");
    $.ajax({
        url: "/Client/UploadPropertyImages",
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
                '<i class="fa fa-trash" + " title="delete" onclick=removeAssignmentImage("' + aid + '","' + res.id + '")></i>' +
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



function removeAssignmentImage(aid, id) {
    $.busyLoadFull("show");
    $.ajax({
        url: "/Client/removeAssignmentImage?aid=" + aid + "&id=" + id,
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



