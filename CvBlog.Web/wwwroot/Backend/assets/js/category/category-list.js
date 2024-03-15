var parameters = {};
var table;
$(document).ready(function () {
    parameters['r'] = "10";
    parameters['oc'] = "Id";
    parameters['ot'] = "DESC";
    getList(parameters);
});

// #region category-list
    function getList(parameters) {
        console.log("getList - start");
        table = $('#categoriesTable').DataTable({
            "serverSide": true,
            "stateSave": true,
            "processing": true,
            "searching": true,
            "scrollY": false,
            "scrollX": false,
            "paging": true,
            "pagingType": 'full_numbers',
            ajax: {
                url: "/admin/kategori/kategori-listesi",
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
                    "data": "0",
                    "searchable": true,
                    "sortable": false,
                    render: function (data, type, row, order) {
                        if (data == null) {
                            return "-";
                        } else {
                            return data;
                        }
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
                            return data;
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
                            return data;
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
                            return data;
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
                            return data;
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
                            return data;
                        }
                    }
                },
                {
                    "data": "6",
                    "searchable": false,
                    "sortable": false,
                    render: function (data, type, row, order) {
                        var html = "";
                        var editHtml = '<button class="btn btn-xs btn-info btn-outline-info" title="Düzenlemek için tıklayınız." data-val="' + data + '"><i class="icofont icofont-edit"></i></button>';
                        var isActiveHtml = '<button class="btn btn-xs btn-warning btn-outline-success ml-1" title="Pasif yapmak için tıklayınız." data-val="' + data + '"><i class="icofont icofont-refresh"></i></button>';
                        if (row[7] == "0")
                            isActiveHtml = '<button class="btn btn-xs btn-warning btn-outline-danger ml-1"><i class="icofont icofont-refresh" title="Aktif yapmak için tıklayınız."  data-val="' + data + '"></i></button>';
                        var isDeletedHtml = '<button class="btn btn-xs btn-danger btn-outline-danger ml-1" title="Silmek için tıklayınız." data-val="' + data + '"><i class="icofont icofont-trash"></i></button>';
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
                    $('#categoryCardBlock .dataTables_filter').append(clone);
                }, 300);

            },
            drawCallback: function () {
                // $('.paginate_button', this.api().table().container())
                //     .on('click', function () {
                //         var page = $(this).find("a").text();
                //         console.log("categoriesTablePageNumber = " + categoriesTablePageNumber);
                //     });
            }
        });
        console.log("getList - end");
    }
    $(document).on('change', "input[aria-controls=categoriesTable]", function () {
        console.log("aranan kelime = " + this.value);
        table.columns().search(this.value).draw();
    });
// #endregion

// #region category-add
    $(function () {
        const placeHolderDiv = $("#modalPlaceHolder");
        $(document).on('click', '#categoryAddModalShow', function (e) {
            e.preventDefault();
            var btn = $(this);
            btn.attr("disabled", "disabled");
            $.get("/admin/kategori/kategori-ekleme-formu/").done(function (data) {
                placeHolderDiv.html(data);
                placeHolderDiv.find('.modal').modal('show');
            }).fail(function (err) {
                Swal.fire('Hata!', `${err.responseText}`, 'warning');
            });
            btn.removeAttr("disabled");
        });

        $(document).on('click', "#categoryAddButton", function (e) {
            e.preventDefault();
            var swalTitle = "Kategori Ekleme İşlemi";
            var errorMessage = "";
            var btn = $(this);
            var modal = placeHolderDiv.find("#categoryAddModal");
            $(".my-input-control").each(function () {
                var val = $(this).val();
                if (val == "") {
                    var labelText = $(this).parents(".row").find("label").html();
                    errorMessage += "<br/>" + labelText + " alanı boş geçilemez";
                }
            });
            if (errorMessage == "") {
                var list = {};
                list["Name"] = modal.find("#Name").val();
                list["Description"] = modal.find("#Description").val();
                list["Note"] = modal.find("#Note").val();
                list["IsActive"] = modal.find("#IsActive").is(':checked');
                $.ajax({
                    url: "/admin/kategori/kategori-ekle",
                    type: "post",
                    data: list,
                    beforeSend: function () {
                        btn.attr("disabled", "disabled");
                        console.log("categoryAddButton_beforeSend");
                    },
                    success: function (result) {
                        console.log("categoryAddButton_result_start");
                        console.log("result = " + result);
                        const categoryAddAjaxViewModel = jQuery.parseJSON(result);
                        const newFormBody = $('.modal-body', categoryAddAjaxViewModel.CategoryAddPartial);
                        placeHolderDiv.find('.modal-body').replaceWith(newFormBody);
                        const isValid = newFormBody.find('[name="IsValid"]').val() === 'True';
                        if (isValid) {
                            Swal.fire(swalTitle, `${categoryAddAjaxViewModel.CategoryDto.Message}`, 'success');
                            table.ajax.reload();
                            modal.modal("hide");
                        } else {
                            let summaryText = "";
                            $('#validation-summary > ul > li').each(function () {
                                let text = $(this).text();
                                summaryText += `*${text}\n`;
                            });
                            //Swal.fire(swalTitle, `${categoryAddAjaxViewModel.CategoryDto.Message}`, 'error');
                        }
                        console.log("categoryAddButton_result_end");
                    },
                    error: function (err) {
                        console.log("categoryAddButton_error");
                        Swal.fire('Hata!', `${err.responseText}`, 'warning');
                    }
                });
            } else {
                Swal.fire({
                    title: swalTitle,
                    html: `${errorMessage}`,
                    icon: "warning"
                });
            }
            btn.removeAttr("disabled");
        });
    })
// #endregion