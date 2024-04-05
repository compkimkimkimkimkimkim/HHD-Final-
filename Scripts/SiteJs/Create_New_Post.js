function previewImage(inputId, previewId, btnId) {
    console.log(inputId);
    var fileInput = document.getElementById(inputId);
    var imagePreview = document.getElementById(previewId);
    var btn = document.getElementById(btnId);

    if (fileInput.files && fileInput.files[0]) {
        var reader = new FileReader();

        reader.onload = function (e) {
            imagePreview.src = e.target.result;
            imagePreview.parentElement.classList.add('have-image');
            imagePreview.classList.add('image_preview');
            btn.classList.add('choosebtn');
        }

        reader.readAsDataURL(fileInput.files[0]);
    }
}
