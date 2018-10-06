$(document).ready(function () {
    callApi()
    //$('#add').click(function () {
    //    ManageFood()
    //})
});
function fndelete(id){
    $.ajax({
        url: '/admin/deleteFood',
        method: 'POST',
        data: { "id": id },
        success: function (res) {
            alert(res.data)
            callApi();
        },
        error: function (err) { }
    });
}
//function ManageFood() {
//    $.ajax({
//        url: '/admin/ManageFood',
//        method: 'GET',
        
//        success: function (res) {
//            $('.container').html('')

//            $('.container').html(res)
//        },
//        error: function (err) { }
//    });
//}
function callApi() {

    var table = $('#example');
    table.DataTable().destroy();
    table.DataTable({
        ajax: {
            url: '/admin/GetFood',
            method: 'POST'
        },
        columns: [
        { data: "Name" },
        { data: "CatagoryNAme" },
        {
            data: function (data, res, c) {
                return '<img class="mycursor" src="' + data.ImageSource + '" width="55" height="52.2" />'
            }
        },
        { data: "CreatedDateS" },
        { data: "CreatedBy" },

        { data: "ModifiedDateS" },
        { data: "ModifiedBy" },
        {
            data: function (a, b, c) {
                return  '<div class ="row">' +
                            '<div class="col-md-6"><button class="btn btn-danger" onclick="fndelete(' + a.ID + ')">Delete</button>' +
                            '</div> <div class="col-md-6"><button class="btn btn-primary">Update</button></div>' +
                        '</div>'
            }
        }
        ],
        "lengthMenu": [[5, 10, 15, -1], [5, 10, 15, "All"]]
    });
}

