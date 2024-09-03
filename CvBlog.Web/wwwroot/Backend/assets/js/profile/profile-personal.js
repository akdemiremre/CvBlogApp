$(document).ready(function () {
    var form = $("#profileUpdateForm");
    form.on('submit', function (event) {
        event.preventDefault();
        var btn = $("#profilePersonalUpdateButton");
        const formData = {};
        $(this).find('input').each(function () {
            formData[$(this).attr('name')] = $(this).val();
        });
        console.log(formData);
        var procTitle = "Profil Güncelleme İşlemi";
        $.ajax({
            url: '/admin/kullanici/profil-kisisel-bilgiler-guncelle',
            type: 'post',
            contentType: 'application/json',
            data: JSON.stringify(formData),
            contentType: "application/json",
            beforeSend: function () {
                btn.attr("disabled", "disabled");
            },
            success: function (response) {
                if (response.success) {
                    toastr.success(`${response.message}`, procTitle);
                } else {
                    toastr.error(`${response.message}`, procTitle);
                }
                btn.removeAttr("disabled");
            },
            error: function (jqXHR) {
                toastr.error(`${jqXHR.responseText}`, procTitle);
                btn.removeAttr("disabled");
            }
        });
    });
    
    $(document).on('click', '#userProfileImageUpload', function () {
        $("#userProfileImageUploadFile").trigger('click');
    });
});