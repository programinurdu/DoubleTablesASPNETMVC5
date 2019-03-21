// On Clicking Student Logo Image, then change the image
function ChangePicture() {
    $('#upload').click();
}

function ReadURL(input) {
    if (input.files && input.files[0]) {
        var reader = new FileReader();
        reader.onload = function (e) {
            $('#image').attr('src', e.target.result);
        };
        reader.readAsDataURL(input.files[0]);
    }
}

$(document).ready(function () {
    $('#myTable2').dataTable();
});

$(document).ready(function () {
    $('#myTable').dataTable({
        "scrollY": '50vh',
        "scrollCollapse": true,
        "paging": false,
        "ajax": {
            "url": "/Student/StudentsList",
            "type": "GET",
            "datatype": "json"
        },
        "columns": [
            { "data": "StudentId" },
            { "data": "FullName" },
            { "data": "Email" },
            { "data": "GenderDesc" },
            { "data": "Mobile" },
            { "data": "Telephone" }
        ]
    });
});