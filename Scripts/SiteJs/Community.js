window.addEventListener("DOMContentLoaded", function () {

    var items = document.querySelectorAll(".community_item");
    for (var i = 0; i < items.length; i++) {

        //var top = items[i].querySelector(".community_item_top");
        //top.addEventListener("click", function () {
        //    var parent = this.parentNode;
        //    var close = parent.querySelector(".community_item_close");
        //    var content = parent.querySelector(".community_content");
        //    var comment = parent.querySelector(".community_comment");
        //    var picture = parent.querySelector(".community_picture");

        //    if (close.style.display === "none") {
        //        close.style.display = "flex";
        //        content.style.display = "block";
        //        //comment.style.display = "block";
        //        picture.style.display = "flex";
        //    } else {
        //        close.style.display = "none";
        //        content.style.display = "none";
        //        //comment.style.display = "none";
        //        picture.style.display = "none";
        //    }
        //});

        var parent = items[i];
        console.log(items[i]);
        items[i].addEventListener("click", function () {
            var close = this.querySelector(".community_item_close");
            var content = this.querySelector(".community_content");
            var comment = this.querySelector(".community_comment");
            var picture = this.querySelector(".community_picture");
            console.log(close);
            console.log(close.style.display);
            console.log(close.style.display === "none");
            
            if (close.style.display ==='' || close.style.display === "none") {
                close.style.display = "flex";
                content.style.display = "block";
                //comment.style.display = "block";
                picture.style.display = "flex";
            } else {
                close.style.display = "none";
                content.style.display = "none";
                comment.style.display = "none";
                picture.style.display = "none";
            }
        });

        var comment = items[i].querySelector(".community_item_comment");
        comment.addEventListener("click", function (event) {
            var parent = this.parentNode.parentNode.parentNode;
            var comment = parent.querySelector(".community_comment");
            var content = parent.querySelector(".community_content");

            if (content.style.display !== "none" && content.style.display !== "") {

                event.stopPropagation();
                if (comment.style.display === "none") {
                    comment.style.display = "block";
                } else {
                    comment.style.display = "none";
                }
            } else {

            }
        });

        var closeBtn = items[i].querySelector(".community_item_close_btn");
        closeBtn.addEventListener("click", function (event) {

            event.stopPropagation();
            var close = this.parentNode;
            close.style.display = "none";
            close.parentNode.querySelector(".community_content").style.display = "none";
            close.parentNode.querySelector(".community_comment").style.display = "none";
            close.parentNode.querySelector(".community_picture").style.display = "none";
        });
    }
});

function confirmDelete(id, event) {
    var passwordPrompt = document.getElementById('MainContent_passwordPrompt');
    var idInput = document.getElementById('MainContent_txtID');
    idInput.value = id;
    passwordPrompt.style.display = 'block';

    event.stopPropagation();

    return false; 
}

function confirmEditDelete(id, event) {
    var edit_delete = document.getElementById('MainContent_edit_delete');
    var idInput = document.getElementById('MainContent_txtCommunityID');
    idInput.value = id;
    edit_delete.style.display = 'block';

    event.stopPropagation();

    return false;
}