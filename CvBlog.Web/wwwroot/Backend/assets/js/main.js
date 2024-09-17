function toastNoty(success, title, message) {
    if (success) {
        toastr.success(message, title);
    } else {
        toastr.error(message, title);
    }
}
