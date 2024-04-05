function ChangeTab(id) {
    if (id == 0) {
        var Manage_Page = document.getElementById('Manage_Page');
        var Manage_Post = document.getElementById('Manage_Post');
        var Create_Post = document.getElementById('Create_Post');

        Manage_Page.style.display = 'block';
        Manage_Post.style.display = 'none';
        Create_Post.style.display = 'none';
    } else if (id == 1) {
        var Manage_Page = document.getElementById('Manage_Page');
        var Manage_Post = document.getElementById('Manage_Post');
        var Create_Post = document.getElementById('Create_Post');

        Manage_Page.style.display = 'none';
        Manage_Post.style.display = 'block';
        Create_Post.style.display = 'none';
    } else if (id == 2) {
        var Manage_Page = document.getElementById('Manage_Page');
        var Manage_Post = document.getElementById('Manage_Post');
        var Create_Post = document.getElementById('Create_Post');

        Manage_Page.style.display = 'none';
        Manage_Post.style.display = 'none';
        Create_Post.style.display = 'block';
    }
}