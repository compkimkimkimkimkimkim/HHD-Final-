var btnTD_main = document.getElementById("nav_Todo");
var btnFAQ_main = document.getElementById("nav_FAQ");

btnTD_main.addEventListener("click", function () {
    btnTD_Click();
});
btnFAQ_main.addEventListener("click", function () {
    btnFAQ_Click();
});

function resetStatus() {
    var btnTD = document.getElementById("nav_Todo");
    var btnFAQ = document.getElementById("nav_FAQ");
    btnTD.classList.remove("btn_active");
    btnFAQ.classList.remove("btn_active");

    var items = document.getElementsByClassName("contents");
    for (var i = 0; i < items.length; i++) {
        items[i].style.display = 'none';
    }
};
function btnFAQ_Click() {
    resetStatus();
    var btnFAQ = document.getElementById("nav_FAQ");
    btnFAQ.classList.add("btn_active");

    var items = document.getElementsByClassName("TbFAQ");
    for (var i = 0; i < items.length; i++) {
        items[i].style.display = 'block';
    }
};
function btnTD_Click() {
    resetStatus();
    var btnTD = document.getElementById("nav_Todo");
    btnTD.classList.add("btn_active");

    var items = document.getElementsByClassName("TbTodo");
    for (var i = 0; i < items.length; i++) {
        items[i].style.display = 'block';
    }
};