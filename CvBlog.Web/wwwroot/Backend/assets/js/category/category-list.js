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
                    "data": null,
                    "searchable": false,
                    "sortable": false,
                    "render": function (data, type, row, order) {
                        return `<div class="text-center">${order.row + 1}</div>`;
                    }
                },
                {
                    "data": "0",
                    "searchable": true,
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
                            return `<div class="text-center">${data}</div>`;
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
                        var editHtml = '<button class="btn btn-xs btn-info btn-outline-info categoryUpdateModalShow" title="Düzenlemek için tıklayınız." data-val="' + data + '"><i class="icofont icofont-edit"></i></button>';
                        var isActiveHtml = '<button class="btn btn-xs btn-warning btn-outline-success ml-1 categoryIsActiveButton"  data-val="' + data + '" title="Pasif yapmak için tıklayınız."><i class="icofont icofont-refresh"></i></button>';
                        if (row[7] == "False")
                            isActiveHtml = '<button class="btn btn-xs btn-warning btn-outline-danger ml-1 categoryIsActiveButton" data-val="' + data + '"><i class="icofont icofont-refresh" title="Aktif yapmak için tıklayınız."></i></button>';
                        var isDeletedHtml = '<button class="btn btn-xs btn-danger btn-outline-danger ml-1 categoryIsDeletedButton" title="Silmek için tıklayınız." data-val="' + data + '"><i class="icofont icofont-trash"></i></button>';
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
                        const categoryAddAjaxModel = jQuery.parseJSON(result);
                        const newFormBody = $('.modal-body', categoryAddAjaxModel.CategoryAddPartial);
                        placeHolderDiv.find('.modal-body').replaceWith(newFormBody);
                        const isValid = newFormBody.find('[name="IsValid"]').val() === 'True';
                        if (isValid) {
                            Swal.fire(swalTitle, `${categoryAddAjaxModel.CategoryDto.Message}`, 'success');
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

// #region category-update
    $(function () {
        const placeHolderDiv = $("#modalPlaceHolder");
        $(document).on('click', '.categoryUpdateModalShow', function (e) {
            e.preventDefault();
            var btn = $(this);
            var data_val = btn.attr("data-val");
            btn.attr("disabled", "disabled");
            $.get("/admin/kategori/kategori-guncelleme-formu", { val: data_val }).done(function (data) {
                placeHolderDiv.html(data);
                placeHolderDiv.find('.modal').modal('show');
            }).fail(function (err) {
                Swal.fire('Hata!', `${err.responseText}`, 'warning');
                btn.removeAttr("disabled");
            });
        });
        $(document).on('click', '#categoryUpdateButton', function (e) {
            console.log("categoryUpdateButton_start");
            e.preventDefault();
            var swalTitle = "Kategori Güncelleme İşlemi";
            var errorMessage = "";
            var btn = $(this);
            var modal = $("#categoryUpdateModal");
            $(".my-input-control").each(function () {
                var val = $(this).val();
                if (val == "") {
                    var labelText = $(this).parents(".row").find("label").html();
                    errorMessage += "<br/>" + labelText + " alanı boş geçilemez";
                }
            });
            console.log("errorMessage = " + errorMessage);
            if (errorMessage == "") {
                var list = {};
                list["Id"] = modal.find("#Id").val();
                list["Name"] = modal.find("#Name").val();
                list["Description"] = modal.find("#Description").val();
                list["Note"] = modal.find("#Note").val();
                list["IsActive"] = modal.find("#IsActive").is(':checked');
                list["IsDeleted"] = modal.find("#IsDeleted").is(':checked');
                    $.ajax({
                        url: "/admin/kategori/kategori-guncelle",
                        type: "post",
                        data: list,
                        beforeSend: function () {
                            console.log("categoryUpdateButton_beforeSend");
                            btn.attr("disabled", "disabled");
                        },
                        success: function (result) {
                            console.log("categoryUpdateButton_success_start");
                            console.log("result = " + result);
                            const categoryUpdateAjaxModel = jQuery.parseJSON(result);
                            const newFormBody = $('.modal-body', categoryUpdateAjaxModel.CategoryUpdatePartial);
                            placeHolderDiv.find(".modal-body").replaceWith(newFormBody);
                            const isValid = placeHolderDiv.find('[name="IsValid"]').val() === 'True';
                            if (isValid) {
                                Swal.fire(swalTitle, `${categoryUpdateAjaxModel.CategoryDto.Message}`, 'success');
                                table.ajax.reload();
                                modal.modal("hide");
                            } else {
                                let summaryText = "";
                                $("#validation-summary > ul > li").each(function () {
                                    let text = $(this).text();
                                    summaryText += `*${text}\n`;
                                });
                            }
                            console.log("categoryUpdateButton_success_end");
                        },
                        error: function (err) {
                            console.log("categoryUpdateButton_error");
                            Swal.fire('Hata!', `${err.responseText}`, 'warning');
                        }
                });
            } else {
                Swal.fire({
                    title: swalTitle,
                    html: `${errorMessage}`,
                    icon:"warning"
                });
            }
            btn.removeAttr("disabled");
            console.log("categoryUpdateButton_end");
        });
    })
// #endregion

// #region category-isActive
$(document).on('click', '.categoryIsActiveButton', function (e) {
    console.log("categoryIsActiveButton_start");
    e.preventDefault();
    var btn = $(this);
    btn.attr("disabled", "disabled");
    Swal.fire({
        icon: `question`,
        title: "Durumu güncellemek istediğinize emin misiniz?",
        showCancelButton: true,
        confirmButtonText: "Evet, Sil",
        cancelButtonText: `Vazgeç`,
    }).then((result) => {
        if (result.value) {
            var swalTitle = "Aktif Durumunu Güncelleme İşlemi";
            var data_val = btn.attr("data-val");
            $.ajax({
                url: "/admin/kategori/kategori-aktif-durumunu-degistir",
                type: "post",
                data: { val: data_val },
                beforeSend: function () {
                    console.log("categoryIsActiveButton_beforeSend");
                },
                success: function (result) {
                    console.log("categoryIsActiveButton_success");
                    console.log("result = " + result);
                    if (result.resultStatus == "0") {
                        Swal.fire({
                            title: swalTitle,
                            html: result.message,
                            icon: "success"
                        }).then(function () {
                            table.ajax.reload();
                        });
                    } else {
                        Swal.fire({
                            title: swalTitle,
                            html: result.message,
                            icon: "warning"
                        });
                    }
                },
                error: function (err) {
                    console.log("categoryIsActiveButton_error");
                    Swal.fire('Hata!', `${err.responseText}`, 'warning');
                }
            });
        }
    });
    btn.removeAttr("disabled");
    console.log("categoryIsActiveButton_end");
});
// #endregion

// #region category-isActive
$(document).on('click', '.categoryIsDeletedButton', function (e) {
    console.log("categoryIsDeletedButton_start");
    e.preventDefault();
    var btn = $(this);
    btn.attr("disabled", "disabled");
    Swal.fire({
        icon: `question`,
        title: "Silmek istediğinize emin misiniz?",
        showCancelButton: true,
        confirmButtonText: "Evet, Sil",
        cancelButtonText: `Vazgeç`,
    }).then((result) => {
        if (result.value) {
            var swalTitle = "Silme İşlemi";
            var data_val = btn.attr("data-val");
            $.ajax({
                url: "/admin/kategori/kategori-sil",
                type: "post",
                data: { val: data_val },
                beforeSend: function () {
                    console.log("categoryIsDeletedButton_beforeSend");
                },
                success: function (result) {
                    console.log("categoryIsDeletedButton_success");
                    console.log("result = " + result);
                    if (result.resultStatus == "0") {
                        Swal.fire({
                            title: swalTitle,
                            html: result.message,
                            icon: "success"
                        }).then(function () {
                            table.ajax.reload();
                        });
                    } else {
                        Swal.fire({
                            title: swalTitle,
                            html: result.message,
                            icon: "warning"
                        });
                    }
                },
                error: function (err) {
                    console.log("categoryIsDeletedButton_error");
                    Swal.fire('Hata!', `${err.responseText}`, 'warning');
                }
            });
        }
    });
    btn.removeAttr("disabled");    
    console.log("categoryIsDeletedButton_end");
});
// #endregion    