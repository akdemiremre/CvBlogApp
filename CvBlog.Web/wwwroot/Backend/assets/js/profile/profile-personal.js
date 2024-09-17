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
                /*
                if (response.success) {
                    toastr.success(`${response.message}`, procTitle);
                } else {
                    toastr.error(`${response.message}`, procTitle);
                }
                */
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
});