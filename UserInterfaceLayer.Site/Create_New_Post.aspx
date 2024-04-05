<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Create_New_Post.aspx.cs" Inherits="HHD.UserInterfaceLayer.Site.Create_New_Post" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="../Content/SiteCss/Create_New_Post.css" />
    <script src="../Scripts/SiteJs/Create_New_Post.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <article>
        <div class="content">
            <div class="title">
                <h3>CREATE NEW POST</h3>
            </div>
            <div>
                <input id="txbName" runat="server" placeholder="Full Name or Nick Name" />
            </div>
            <div>
                <input class="txbtitle" id="txbTitle" runat="server" placeholder="Title" />
            </div>
            <h3>Categories</h3>
            <div class="category">
                <asp:Repeater ID="rptCategories" runat="server" OnItemDataBound="rptCategories_ItemDataBound">
                    <ItemTemplate>
                        <asp:Button CssClass="category_item" ID="btnCategory" runat="server" Text='<%# Eval("Name") %>' CommandArgument='<%# Eval("Id") %>' OnClick="btnCategory_Click" />
                    </ItemTemplate>
                </asp:Repeater>
            </div>
            <div>
                <textarea placeholder="content" id="txContent" runat="server"></textarea>
            </div>
            <div class="pictures">
                <div class="pictures_left">Pictures</div>
                <div class="pictures_right">
                    <div class="choose" id="choose1" runat="server">
                        <label id="choosebtn1" class="btn" runat="server">
                            <span>Choose file 1</span>
                            <input class="input_file" type="file" accept="image/*" id="fileInput1" runat="server" onchange="previewImage('MainContent_fileInput1', 'MainContent_image_preview1', 'MainContent_choosebtn1')" />
                        </label>
                        <img src="" class="" id="image_preview1" runat="server" />
                    </div>
                    <div class="choose" id="choose2" runat="server">
                        <label id="choosebtn2" class="btn" runat="server">
                            <span>Choose file 2</span>
                            <input class="input_file" type="file" accept="image/*" id="fileInput2" runat="server" onchange="previewImage('MainContent_fileInput2', 'MainContent_image_preview2', 'MainContent_choosebtn2')" />
                        </label>
                        <img src="" class="" id="image_preview2" runat="server" />
                    </div>
                    <div class="choose" id="choose3" runat="server">
                        <label id="choosebtn3" class="btn" runat="server">
                            <span>Choose file 3</span>
                            <input class="input_file" type="file" accept="image/*" id="fileInput3" runat="server" onchange="previewImage('MainContent_fileInput3', 'MainContent_image_preview3', 'MainContent_choosebtn3')" />
                        </label>
                        <img src="" class="" id="image_preview3" runat="server" />
                    </div>
                    <div class="choose" id="choose4" runat="server">
                        <label id="choosebtn4" class="btn" runat="server">
                            <span>Choose file 4</span>
                            <input class="input_file" type="file" accept="image/*" id="fileInput4" runat="server" onchange="previewImage('MainContent_fileInput4', 'MainContent_image_preview4', 'MainContent_choosebtn4')" />
                        </label>
                        <img src="" class="" id="image_preview4" runat="server" />
                    </div>
                    <div class="choose" id="choose5" runat="server">
                        <label id="choosebtn5" class="btn" runat="server">
                            <span>Choose file 5</span>
                            <input class="input_file" type="file" accept="image/*" id="fileInput5" runat="server" onchange="previewImage('MainContent_fileInput5', 'MainContent_image_preview5', 'MainContent_choosebtn5')" />
                        </label>
                        <img src="" class="" id="image_preview5" runat="server" />
                    </div>
                    <div class="choose" id="choose6" runat="server">
                        <label id="choosebtn6" class="btn" runat="server">
                            <span>Choose file 6</span>
                            <input class="input_file" type="file" accept="image/*" id="fileInput6" runat="server" onchange="previewImage('MainContent_fileInput6', 'MainContent_image_preview6', 'MainContent_choosebtn6')" />
                        </label>
                        <img src="" class="" id="image_preview6" runat="server" />
                    </div>
                </div>
            </div>
            <div class="password">
                <div>
                    <input type="password" id="txbPassword" runat="server" placeholder="Password" />
                </div>
                <div>
                    <input type="password" id="txbCPassword" runat="server" placeholder="Confirm Password" />
                </div>
            </div>
            <div class="password_tip">
                <p>* If you enter an easy password, it's easy for others to modify and delete the post.</p>
            </div>
            <div class="bottom_button">
                <asp:Button CssClass="btn_cancel" ID="btnCancel" runat="server" Text='CANCEL' OnClick="btnCancel_Click" />
                <asp:Button CssClass="btn_post" ID="btnPost" runat="server" Text='POST' OnClick="btnPost_Click" />
            </div>
        </div>
    </article>
</asp:Content>
