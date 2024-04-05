var btnIC_main = document.getElementById("nav_content_2_IC");
var btnISC_main = document.getElementById("nav_content_2_ISC");
var btnIG_main = document.getElementById("nav_content_2_IG");
btnIC_main.addEventListener("click", function () {
    btnIC_Click();
});
btnISC_main.addEventListener("click", function () {
    btnISC_Click();
});
btnIG_main.addEventListener("click", function () {
    btnIG_Click();
});
function resetStatus() {
    var btnTC = document.getElementById("nav_content_2_IC");
    var btnISC = document.getElementById("nav_content_2_ISC");
    var btnIG = document.getElementById("nav_content_2_IG");
    btnTC.classList.remove("nav_content_2_item_active");
    btnISC.classList.remove("nav_content_2_item_active");
    btnIG.classList.remove("nav_content_2_item_active");

    var items = document.getElementsByClassName("content_2_item");
    for (var i = 0; i < items.length; i++) {
        items[i].style.display = 'none';
    }
};
function btnIG_Click() {
    resetStatus();
    var btnIG = document.getElementById("nav_content_2_IG");
    btnIG.classList.add("nav_content_2_item_active");

    var items = document.getElementsByClassName("content_2_item_IG");
    for (var i = 0; i < items.length; i++) {
        items[i].style.display = 'block';
    }
};
function btnISC_Click() {
    resetStatus();
    var btnISC = document.getElementById("nav_content_2_ISC");
    btnISC.classList.add("nav_content_2_item_active");

    var items = document.getElementsByClassName("content_2_item_ISC");
    for (var i = 0; i < items.length; i++) {
        items[i].style.display = 'block';
    }
};
function btnIC_Click() {
    resetStatus();
    var btnTC = document.getElementById("nav_content_2_IC");
    btnTC.classList.add("nav_content_2_item_active");

    var items = document.getElementsByClassName("content_2_item_IC");
    for (var i = 0; i < items.length; i++) {
        items[i].style.display = 'block';
    }
};