$(document).ready(function (){
    var profilePasswordUpdateForm = $("#profilePasswordUpdateForm");
    profilePasswordUpdateForm.on('submit', function (event) {
        event.preventDefault();
        console.log("profilePasswordUpdateForm-start");
        var btn = $("#profilePasswordUpdateButton");
        const profilePasswordUpdateFormData = {};
        $(this).find('input').each(function () {
            profilePasswordUpdateFormData[$(this).attr("name")] = $(this).val();
            console.log($(this).attr("name") + "=" + $(this).val());
        });
        console.log(profilePasswordUpdateFormData);
        var procTitle = "Şifre Güncelleme İşlemi";
        $.ajax({
            url: '/admin/kullanici/profil-sifre-guncelle',
            type: 'post',
            data: JSON.stringify(profilePasswordUpdateFormData),
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
        console.log("profilePasswordUpdateForm-end");
    });
});