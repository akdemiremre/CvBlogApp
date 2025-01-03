var parameters = {};
var table;
$(document).ready(function () {
    parameters["r"] = 10;
    parameters["oc"] = "Id";
    parameters["ot"] = "DESC";
    getList(parameters);
});
// #region education-list
function getList(parameters) {
    console.log("getList - start");
    table = $('#educationsTable').DataTable({
        "serverSide": true,
        "stateSave": true,
        "processing": true,
        "searching": true,
        "scrollY": false,
        "scrollX": false,
        "paging": true,
        "pagingType": 'full_numbers',
        ajax: {
            url: "/admin/egitim/egitim-listesi",
            type: "post",
            data: { val: JSON.stringify(parameters) },
            dataType: "json",
            async: true,
            dataFilter: function (data) {
                var json = jQuery.parseJSON(data);
                return JSON.stringify(json); // return JSON string
            }
        },
        columns: [
            {
                "data": null, 
                "searchable": false,
                "sortable": false,
                "render": function (data, type, row, order) {
                    return `<div class="text-center">${order.row + 1}</div>`;
                }
            },
            {
                "data": "1",
                "searchable": true,
                "sortable": false,
                render: function (data, type, row, order) {
                    if (data == null) {
                        return "-";
                    } else {
                        const maxLength = 20;
                        if (data.length > maxLength) {
                            const truncated = data.substring(0, maxLength) + "...";
                            return `<span title="${data}">${truncated}</span>`;
                        } else {
                            return data;
                        }
                    }
                }
            },
            {
                "data": "2",
                "searchable": false,
                "sortable": false,
                render: function (data, type, row, order) {
                    if (data == null) {
                        return "-";
                    } else {
                        return `<div class="text-center">${data}</div>`;
                    }
                }
            },
            {
                "data": "3",
                "searchable": false,
                "sortable": false,
                render: function (data, type, row, order) {
                    if (data == null) {
                        return "-";
                    } else {
                        const maxLength = 20;
                        if (data.length > maxLength) {
                            const truncated = data.substring(0, maxLength) + "...";
                            return `<span title="${data}">${truncated}</span>`;
                        } else {
                            return data;
                        }
                    }
                }
            },
            {
                "data": "4",
                "searchable": false,
                "sortable": false,
                render: function (data, type, row, order) {
                    if (data == null) {
                        return "-";
                    } else {
                        return `<div class="text-center">${data}</div>`;
                    }
                }
            },
            {
                "data": "5",
                "searchable": false,
                "sortable": false,
                render: function (data, type, row, order) {
                    if (data == null) {
                        return "-";
                    } else {
                        return `<div class="text-center">${data}</div>`;
                    }
                }
            },
            {
                "data": "6",
                "searchable": false,
                "sortable": false,
                render: function (data, type, row, order) {
                    var html = "";
                    var editHtml = '<button class="btn btn-xs btn-info btn-outline-info educationUpdateModalShow" title="Düzenlemek için tıklayınız." data-val="' + data + '"><i class="icofont icofont-edit"></i></button>';
                    var isActiveHtml = '<button class="btn btn-xs btn-warning btn-outline-success ml-1 educationIsActiveButton"  data-val="' + data + '" title="Pasif yapmak için tıklayınız."><i class="icofont icofont-refresh"></i></button>';
                    if (row[7] == "False")
                        isActiveHtml = '<button class="btn btn-xs btn-warning btn-outline-danger ml-1 educationIsActiveButton" data-val="' + data + '"><i class="icofont icofont-refresh" title="Aktif yapmak için tıklayınız."></i></button>';
                    var isDeletedHtml = '<button class="btn btn-xs btn-danger btn-outline-danger ml-1 educationIsDeletedButton" title="Silmek için tıklayınız." data-val="' + data + '"><i class="icofont icofont-trash"></i></button>';
                    html += editHtml + isActiveHtml + isDeletedHtml;
                    return html;
                }
            }
        ],
        language: {
            url: '//cdn.datatables.net/plug-ins/1.13.7/i18n/tr.json',
        },
        initComplete: function () {
            setTimeout(function () {
                table.page(0).draw('page');
                var clone = $('#procButtons').clone().removeClass("hidden");
                $('#educationCardBlock .dataTables_filter').append(clone);
            }, 300);

        },
        drawCallback: function () {
            // $('.paginate_button', this.api().table().container())
            //     .on('click', function () {
            //         var page = $(this).find("a").text();
            //         console.log("educationsTablePageNumber = " + educationsTablePageNumber);
            //     });
        }
    });
    console.log("getList - end");
}
// #endregion