$(document).ready(function () {
    loadDataTable()
});

function loadDataTable() {
    dataTable = $('#tblData').DataTable({
        "ajax": {
            url: '/admin/company/getall'
        },
        "columns": [
            { data: 'name', "width": "28%" },
            { data: 'state', "width": "20%" },
            { data: 'city', "width": "15%" },
            { data: 'phoneNumber', "width": "12%" },
            {
                data: 'id',
                "render": function (data) {
                    return `<div class="w-100 btn-group" role="group">
                                <a href="/admin/company/upsert?id=${data}" class="btn btn-primary mx-2"> <i class="bi bi-pencil-square"></i>Edit</a>
                                <a onClick=Delete('/admin/company/delete/${data}') class="btn btn-danger mx-2"><i class="bi bi-trash"></i>Delete</a>
                            </div>`
                },
                "width": "25%"
            }
        ]
    });
}

function Delete(url) {
    swal.fire({
        title: "Are you sure you want to delete?",
        text: "You will not be able to restore the data!",
        icon: "warning",
        showCancelButton: true,
        confirmButtonColor: "#DD6B55",
        cancelButtonColor: "#d33",
        confirmButtonText: "Yes, delete it!",
    }).then((result) => {
        if (result.isConfirmed) {
            $.ajax({
                type: "DELETE",
                url: url,
                success: function (data) {
                    if (data.success) {
                        toastr.success(data.message);
                        dataTable.ajax.reload();
                    } else {
                        toastr.error(data.message);
                    }
                }
            });
        }
    });
}
