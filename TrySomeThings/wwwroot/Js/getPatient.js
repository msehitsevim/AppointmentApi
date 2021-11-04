

$('#SaveBtn').click(function () {
    console.log($("#IdentityNo").val());
    $.ajax({
        type: 'get',
        url: 'https://localhost:44334/api/GetPatient',
        data: { IdentityNo: $("#IdentityNo").val() },
        success: function (data) {
            alert(data);
        }
    });
});