$(document).ready(function () {
    var profilePersonalUpdateForm = $("#profilePersonalUpdateForm");
    profilePersonalUpdateForm.on('submit', function (event) {
        event.preventDefault();
        console.log("profilePersonalUpdateForm-start");
        var btn = $("#profilePersonalUpdateButton");
        const profilePersonalUpdateFormData = {};
        $(this).find('input').each(function () {
            profilePersonalUpdateFormData[$(this).attr('name')] = $(this).val();
        });
        console.log(profilePersonalUpdateFormData);
        var procTitle = "Profil Güncelleme İşlemi";
        $.ajax({
            url: '/admin/kullanici/profil-kisisel-bilgiler-guncelle',
            type: 'post',
            contentType: 'application/json',
            data: JSON.stringify(profilePersonalUpdateFormData),
            contentType: "application/json",
            beforeSend: function () {
                btn.attr("disabled", "disabled");
            },
            success: function (response) {
                toastNoty(response.success, procTitle, response.message);
                btn.removeAttr("disabled");
            },
            error: function (jqXHR) {
                toastr.error(`${jqXHR.responseText}`, procTitle);
                btn.removeAttr("disabled");
            }
        });
        console.log("profilePersonalUpdateForm-end");
    });
    $(document).on('click', '#userProfileImageUpload', function () {
        $("#userProfileImageUploadFile").trigger('click');
    });
    $(document).on('change', '#userProfileImageUploadFile', function () {
        var procTitle = "Profil Fotoğrafı Güncelleme İşlemi";
        var formData = new FormData();
        var file = $(this)[0].files[0];
        if (!file) {
            toastNoty(true, procTitle, "Lütfen fotoğraf seçiniz!");
        } else {
            var allowedExtensions = ['.jpg', '.jpeg', '.png', '.gif'];
            var fileExtension = file.name.split('.').pop().toLowerCase();
            if ($.inArray('.' + fileExtension, allowedExtensions) === -1) {
                toastNoty(false, procTitle, "Geçersiz dosya uzantısı. Sadece .jpg, .jpeg, .png, .gif dosyaları kabul edilir.");
            } else {
                var maxSize = 1 * 1024 * 1024; // 1MB
                if (file.size > maxSize) {
                    toastNoty(false, procTitle, "Dosya boyutu 1MB'ı geçemez.");
                } else {
                    formData.append("file", file);
                    $.ajax({
                        url: '/admin/kullanici/profil-fotografi-guncelle',
                        type: 'post',
                        data: formData,
                        processData: false,
                        contentType: false,
                        success: function (response) {
                            toastNoty(response.success, procTitle, response.message);
                            $("#userProfileImageUpload").attr("src", response.src);
                        },
                        error: function (jqXHR) {
                            toastNoty(false, procTitle, `${jqXHR.responseText}`);
                        }
                    });
                }
            }
        }
    });
});