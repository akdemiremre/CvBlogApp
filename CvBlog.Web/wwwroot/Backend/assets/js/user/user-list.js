$(document).ready(function () {
    const placeHolderDiv = $('#modalPlaceHolder');

    // #region user-list
    const dataTable = $('#usersTable').DataTable({
        dom:
            "<'row'<'col-sm-3'l><'col-sm-7'f><'col-sm-2'B>>" +
            "<'row'<'col-sm-12'tr>>" +
            "<'row'<'col-sm-5'i><'col-sm-7'p>>",
        buttons: [
            {
                text: '<i class="icofont icofont-plus"></i>Ekle',
                attr: {
                    id: "btnAdd",
                    title: "Yeni kullanıcı eklemek için tıklayınız."
                },
                className: 'btn btn-success btn-outline-success',
                action: function (e, dt, node, config) {
                    const url = '/admin/kullanici/kullanici-ekleme-formu';
                    const placeHolderDiv = $('#modalPlaceHolder');
                    $.get(url).done(function (data) {
                        placeHolderDiv.html(data);
                        placeHolderDiv.find(".modal").modal('show');
                    });
                }
            },
            {
                text: '<i class="icofont icofont-refresh"></i>Yenile',
                className: 'btn btn-danger btn-outline-danger',
                action: function (e, dt, node, config) {
                    $.ajax({
                        type: 'GET',
                        url: '/admin/kullanici/liste-yinele/',
                        contentType: "application/json",
                        beforeSend: function () {
                            $('#usersTable').hide();
                            $('.spinner-border').show();
                        },
                        success: function (data) {
                            //const userListDto = jQuery.parseJSON(data);
                            const userListDto = data;
                            dataTable.clear();
                            console.log("userListDto = "+userListDto);
                            console.log("userListDto.resultStatus = " + userListDto.resultStatus);
                            if (userListDto.resultStatus === 0) {
                                console.log("userListDto.users = " + userListDto.users);
                                userListDto.users.forEach(user => {
                                    console.log("userListDto.users = " + user);
                                    const newTableRow = dataTable.row.add([
                                        user.id,
                                        user.firstName + " " + user.lastName,
                                        user.userName,
                                        user.email,
                                        user.phoneNumber,
                                        `<img src="/img/${user.picture}" alt="${user.userName}" class="my-image-table" />`,
                                        `
                                                <button class="btn btn-xs btn-info btn-outline-info userUpdateModalShow" title="Düzenlemek için tıklayınız." data-id="${user.id}"> <i class="icofont icofont-edit"></i></button>
                                                <button class="btn btn-xs btn-danger btn-outline-danger ml-1 userIsDeletedButton" title="Silmek için tıklayınız." data-id="${user.id}"><i class="icofont icofont-trash"></i></button>
                                            `
                                    ]).node();
                                    const jqueryTableRow = $(newTableRow);
                                    jqueryTableRow.attr("name", `${user.id}`);
                                });
                                dataTable.draw();
                                $('.spinner-border').hide();
                                $('#usersTable').fadeIn(1400);
                            } else {
                                toastr.error(`${userListDto.Message}`, 'İşlem Başarısız!');
                            }
                        },
                        error: function (err) {
                            console.log(err);
                            $('.spinner-border').hide();
                            $('#usersTable').fadeIn(1000);
                            toastr.error(`${err.responseText}`, 'Hata!');
                        }
                    });
                }
            }
        ],
        language: {
            "sDecimal": ",",
            "sEmptyTable": "Tabloda herhangi bir veri mevcut değil",
            "sInfo": "_TOTAL_ kayıttan _START_ - _END_ arasındaki kayıtlar gösteriliyor",
            "sInfoEmpty": "Kayıt yok",
            "sInfoFiltered": "(_MAX_ kayıt içerisinden bulunan)",
            "sInfoPostFix": "",
            "sInfoThousands": ".",
            "sLengthMenu": "Sayfada _MENU_ kayıt göster",
            "sLoadingRecords": "Yükleniyor...",
            "sProcessing": "İşleniyor...",
            "sSearch": "Ara:",
            "sZeroRecords": "Eşleşen kayıt bulunamadı",
            "oPaginate": {
                "sFirst": "İlk",
                "sLast": "Son",
                "sNext": "Sonraki",
                "sPrevious": "Önceki"
            },
            "oAria": {
                "sSortAscending": ": artan sütun sıralamasını aktifleştir",
                "sSortDescending": ": azalan sütun sıralamasını aktifleştir"
            },
            "select": {
                "rows": {
                    "_": "%d kayıt seçildi",
                    "0": "",
                    "1": "1 kayıt seçildi"
                }
            }
        }
    });
    // #endregion

    // #region user-add
    $(function () {
        placeHolderDiv.on('click', '#userAddButton', function (event) {
            event.preventDefault();
            const form = $('#form-user-add');
            const actionUrl = form.attr('action');
            const dataToSend = new FormData(form.get(0));
            $.ajax({
                url: actionUrl,
                type: "post",
                data: dataToSend,
                processData: false,
                contentType: false,
                success: function (data) {
                    //console.log(data);
                    const userAddAjaxModel = jQuery.parseJSON(data);
                    //console.log(userAddAjaxModel);
                    const newFormBody = $('.modal-body', userAddAjaxModel.UserAddPartial);
                    placeHolderDiv.find('.modal-body').replaceWith(newFormBody);
                    console.log("newFormBody.IsValid = " + newFormBody.find('[name="IsValid"]').val());
                    const isValid = newFormBody.find('[name="IsValid"]').val() === 'True';
                    console.log("isValid = " + isValid);
                    if (isValid) {
                        console.log("modalstate_isvalid = true");
                        placeHolderDiv.find('.modal').modal('hide');
                        const newTableRow = dataTable.row.add([
                            userAddAjaxModel.UserDto.User.Id,
                            userAddAjaxModel.UserDto.User.FirstName + " " + userAddAjaxModel.UserDto.User.LastName,
                            userAddAjaxModel.UserDto.User.UserName,
                            userAddAjaxModel.UserDto.User.Email,
                            userAddAjaxModel.UserDto.User.PhoneNumber,
                            `<img src="/img/${userAddAjaxModel.UserDto.User.Picture}" alt="${userAddAjaxModel.UserDto.User.UserName}" class="my-image-table" />`,
                            `
                             <button class="btn btn-xs btn-info btn-outline-info userUpdateModalShow" title="Düzenlemek için tıklayınız." data-id="${userAddAjaxModel.UserDto.User.Id}"> <i class="icofont icofont-edit"></i></button>
                             <button class="btn btn-xs btn-danger btn-outline-danger ml-1 userIsDeletedButton" title="Silmek için tıklayınız." data-id="${userAddAjaxModel.UserDto.User.Id}"><i class="icofont icofont-trash"></i></button>
                                            `
                        ]).node();
                        const jqueryTableRow = $(newTableRow);
                        jqueryTableRow.attr("name", `${userAddAjaxModel.UserDto.User.Id}`);
                        dataTable.row(newTableRow).draw();
                        toastr.success(`${userAddAjaxModel.UserDto.Message}`, "Başarılı İşlem");
                    } else {
                        console.log("modalstate_isvalid = false");
                        let summaryText = "";
                        $('#validation-summary > ul > li').each(function () {
                            let text = $(this).text();
                            summaryText += `*${text}<br/>`;
                        });
                        toastr.warning(summaryText);
                    }
                },
                error: function (err) {
                    console.log("error:" + err);
                }
            });
        });
    })
    // #endregion

    // #region user-delete
    $(document).on('click', '.userIsDeletedButton', function (event) {
        event.preventDefault();
        const id = $(this).attr("data-id");
        const tableRow = $(`[name="${id}"]`);
        const userName = tableRow.find('td:eq(1)').text();
        console.log("id = " + id);
        console.log("tableRow = " + tableRow);
        console.log("userName = " + userName);
        Swal.fire({
            title: 'Silmek istediğinize emin misiniz?',
            text: `${userName} adlı kullanıcı silinecektir!`,
            icon: 'warning',
            showCancelButton: true,
            confirmButtonColor: '#3085d6',
            cancelButtonColor: '#d33',
            confirmButtonText: 'Evet, silmek istiyorum.',
            cancelButtonText:'Hayır, silmek istiyorum.'
        }).then((result) => {
            if (result.isConfirmed) {
                $.ajax({
                    type: 'POST',
                    dataType: 'json',
                    data: { userId: id },
                    url: '/admin/kullanici/kullanici-sil',
                    success: function (data) {
                        const userDto = jQuery.parseJSON(data);
                        if (userDto.ResultStatus === 0) {
                            Swal.fire('Silindi', `${userDto.User.UserName} adlı kullanıcı başarıyla silinmiştir.`, 'success');
                            dataTable.row(tableRow).remove().draw();
                        } else {
                            Swal.fire({
                                icon: 'error',
                                title: 'Başarısız işlem!',
                                text: `${userDto.Message}`
                            });
                        }
                    },
                    error: function (err) {
                        console.log(err);
                        toastr.error(`${err.responseText}`,"Hata!")
                    }
                });
            }
        })
    });
    // #endregion

    // #region user-update
    $(function () {
        $(document).on('click', '.userUpdateModalShow', function (event) {
            event.preventDefault();
            const id = $(this).attr("data-id");
            console.log("id = " + id);
            $.get('/admin/kullanici/kullanici-guncelleme-formu/', { userId: id }).done(function (data) {
                placeHolderDiv.html(data);
                placeHolderDiv.find('.modal').modal('show');
            }).fail(function () {
                toastr.error("Bir hata oluştu");
            });
        });

        placeHolderDiv.on('click', '#userUpdateButton', function (event) {
            event.preventDefault();
            const form = $('#form-user-update');
            const actionUrl = form.attr('action');
            const dataToSend = new FormData(form.get(0));
            $.ajax({
                url: actionUrl,
                type: "post",
                data: dataToSend,
                processData: false,
                contentType: false,
                success: function (data) {
                    console.log(data);
                    const userUpdateAjaxModel = jQuery.parseJSON(data);
                    console.log(userUpdateAjaxModel);
                    const id = userUpdateAjaxModel.UserUpdateDto.Id;
                    const tableRow = $(`[name="${id}"]`);
                    const newFormBody = $('.modal-body', userUpdateAjaxModel.UserUpdatePartial);
                    placeHolderDiv.find('.modal-body').replaceWith(newFormBody);
                    const isValid = newFormBody.find('[name="IsValid"]').val() === 'True';
                    if (isValid) {
                        placeHolderDiv.find('.modal').modal('hide');
                        dataTable.row(tableRow).data([
                            userUpdateAjaxModel.UserDto.User.Id,
                            userUpdateAjaxModel.UserDto.User.FirstName + " " + userUpdateAjaxModel.UserDto.User.LastName,
                            userUpdateAjaxModel.UserDto.User.UserName,
                            userUpdateAjaxModel.UserDto.User.Email,
                            userUpdateAjaxModel.UserDto.User.PhoneNumber,
                            `<img src="/img/${userUpdateAjaxModel.UserDto.User.Picture}" alt="${userUpdateAjaxModel.UserDto.User.UserName}" class="my-image-table" />`,
                            `
                             <button class="btn btn-xs btn-info btn-outline-info userUpdateModalShow" title="Düzenlemek için tıklayınız." data-id="${userUpdateAjaxModel.UserDto.User.Id}"> <i class="icofont icofont-edit"></i></button>
                             <button class="btn btn-xs btn-danger btn-outline-danger ml-1 userIsDeletedButton" title="Silmek için tıklayınız." data-id="${userUpdateAjaxModel.UserDto.User.Id}"><i class="icofont icofont-trash"></i></button>
                                            `
                        ]);
                        tableRow.attr("name", `${id}`);
                        dataTable.row(tableRow).invalidate();
                        toastr.success(`${userUpdateAjaxModel.UserDto.Message}`, "Başarılı İşlem");
                    } else {
                        let summaryText = "";
                        $('#validation-summary > ul > li').each(function () {
                            let text = $(this).text();
                            summaryText += `*${text}<br/>`;
                        });
                        toastr.warning(summaryText);
                    }
                },
                error: function (err) {
                    console.log("error:" + err);
                }
            });
        });
    })
    // #endregion
});

