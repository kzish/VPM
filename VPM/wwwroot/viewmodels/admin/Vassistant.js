
function deleteVAssistant(vid) {
    $.busyLoadFull("show");
    $.ajax({
        type:"POST",
        url: "/Admin/deleteVAssistant",
        data: { vid: vid },
        success: function () { window.location = ""; },
        error: function () { alert("error"); $.busyLoadFull("hide");},
    });
}