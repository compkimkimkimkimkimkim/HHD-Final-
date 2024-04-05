<%@ Page Title="Community" Language="C#" MasterPageFile="~/CMS.Master" AutoEventWireup="true" CodeBehind="CommunityCMS.aspx.cs" Inherits="HHD.UserInterfaceLayer.CMS.CommunityCMS" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="../Content/CMSCss/SiteCMS.css" />
    <link rel="stylesheet" href="../Content/CMSCss/CommunityCMS.css" />
    <link rel="stylesheet" href="../Content/CMSCss/Create_New_Post.css" />
    <script src="../Scripts/CMSJs/Create_New_Post.js"></script>
    <script src="../Scripts/CMSJs/CommunityCMS.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <article>
        <div class="main">

            <div class="nav">
                <div class="nav_item nav_item_bb">
                    <a onclick="ChangeTab(0)">Manage Page</a>
                </div>
                <div class="nav_item nav_item_bb">
                    <a onclick="ChangeTab(1)">Manage Post</a>
                </div>
                <div class="nav_item">

                    <a onclick="ChangeTab(2)">Create Post</a>


                </div>
            </div>

            <div class="body">
                <div class="Manage_Page" id="Manage_Page">
                    <div class="body">
                        <div class="cont">
                            <div class="cmstitledivcover">
                                <div class="cmstitlediv">
                                    <label class="cmstitle">Community Page Welcome</label>
                                </div>
                            </div>
                            <div class="tablemenu">
                                <div class="width30 adjust">
                                    <label class="tablelabel">Page Title</label>
                                </div>
                                <div class="width60 adjust">
                                    <label class="tablelabel">Page Text</label>
                                </div>
                                <div class="width10 adjust">
                                    <label class="tablelabel">Action</label>
                                </div>
                            </div>
                            <div runat="server" id="TBWelcome_Page">
                            </div>
                            <div class="divhr"></div>
                        </div>
                        <div class="cont">
                            <div class="cmstitledivcover">
                                <div class="cmstitlediv">
                                    <label class="cmstitle">Community Page Rules</label>
                                </div>
                            </div>
                            <div class="tablemenu">
                                <div class="width30 adjust">
                                    <label class="tablelabel">Rule Title</label>
                                </div>
                                <div class="width60 adjust">
                                    <label class="tablelabel">Rule Text</label>
                                </div>
                                <div class="width10 adjust">
                                    <label class="tablelabel">Action</label>
                                </div>
                            </div>
                            <div runat="server" id="TBRules_Page"></div>
                            <div class="divhr"></div>
                            <div class="Tableadd">
                                <input type="text" id="txtTitle" placeholder="Title" style="width: 60%" />
                                <br />
                                <input type="text" id="txtText" placeholder="Text" style="width: 90%" />
                                <br />
                                <input type='button' class='Tbaddbtn' onclick='saveRules("Add")' value='Add' />
                                <input type='button' class='Tbaddbtn' onclick='saveRules("Cancel")' value='Cancel' />
                            </div>
                        </div>

                    </div>
                </div>
            </div>

            <div class="Manage_Post" id="Manage_Post">
                <asp:Repeater ID="listne" runat="server">
                    <ItemTemplate>

                        <div class="community_post">
                            <div class="width90">
                                <div class="community_item" style='<%# Eval("Name").ToString() == "MR.ADMIN" ? "border: 2px solid red;": "" %>'>
                                    <div class="community_item_top">
                                        <div class="community_item_top_left">
                                            <asp:Image runat="server" ImageUrl="~/UserInterfaceLayer.Site/ImagesSite/Community User.png" />
                                        </div>
                                        <div class="community_item_top_right">
                                            <div class="community_item_top_right_nametime">

                                                <div class="community_item_top_right_name" style='<%# Eval("Name").ToString() == "MR.ADMIN" ? "color: red;": "" %>'><%# Eval("Name") %></div>
                                                <div class="community_item_top_right_time"><%# DataBinder.Eval(Container.DataItem, "CreationTime", "{0:dd/MM/yyyy}") %></div>

                                            </div>
                                            <div class="community_item_top_right_title">
                                                <h3><%# Eval("Title") %></h3>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="community_item_bottom">
                                        <asp:Repeater ID="rptItemCategorys" runat="server" DataSource='<%# Eval("Categories") %>'>
                                            <ItemTemplate>
                                                <div class="community_item_category">
                                                    <p>#<%# Eval("CategoryName") %></p>
                                                </div>
                                            </ItemTemplate>
                                        </asp:Repeater>
                                        <div class="community_item_likecomment">
                                            <div class="community_item_comment">
                                                <asp:Image runat="server" ImageUrl="~/UserInterfaceLayer.Site/ImagesSite/Community Comment.png" />
                                                <h3><%# Eval("CommentCount") %></h3>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class="width10 delete">
                                <asp:Button ID="btnDelete" runat="server" CssClass="tablebtn" CommandName="Delete" CommandArgument='<%# Eval("ID") %>' OnCommand="Deletecomuni_Click" Text="Delete" />
                            </div>

                        </div>
                    </ItemTemplate>
                </asp:Repeater>

            </div>

            <div class="Create_Post" id="Create_Post">
                <div class="content">
                    <div class="title">
                        <h3>CREATE Admin POST</h3>
                    </div>
                    <div>
                        <input class="noeror" id="txbName" runat="server" placeholder="Full Name or Nick Name" value="MR.ADMIN" disabled />
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

                        <textarea placeholder="content" id="txContent" runat="server"> <%# Eval("Content") %></textarea>
                    </div>

                    <div class="pictures">
                        <div class="pictures_left">Pictures</div>
                        <div class="pictures_right">
                            <div class="choose" id="choose1" runat="server">
                                <label id="choosebtn1" class="btn" runat="server">
                                    <span>Choose file 1</span>
                                    <input class="input_file" type="file" accept="image/*" id="fileInput1" runat="server" onchange="previewImage('ContentPlaceHolder1_fileInput1', 'ContentPlaceHolder1_image_preview1', 'ContentPlaceHolder1_choosebtn1')" />
                                </label>
                                <img src="" class="" id="image_preview1" runat="server" />
                            </div>
                            <div class="choose" id="choose2" runat="server">
                                <label id="choosebtn2" class="btn" runat="server">
                                    <span>Choose file 2</span>
                                    <input class="input_file" type="file" accept="image/*" id="fileInput2" runat="server" onchange="previewImage('ContentPlaceHolder1_fileInput2', 'ContentPlaceHolder1_image_preview2', 'ContentPlaceHolder1_choosebtn2')" />
                                </label>
                                <img src="" class="" id="image_preview2" runat="server" />
                            </div>
                            <div class="choose" id="choose3" runat="server">
                                <label id="choosebtn3" class="btn" runat="server">
                                    <span>Choose file 3</span>
                                    <input class="input_file" type="file" accept="image/*" id="fileInput3" runat="server" onchange="previewImage('ContentPlaceHolder1_fileInput3', 'ContentPlaceHolder1_image_preview3', 'ContentPlaceHolder1_choosebtn3')" />
                                </label>
                                <img src="" class="" id="image_preview3" runat="server" />
                            </div>
                            <div class="choose" id="choose4" runat="server">
                                <label id="choosebtn4" class="btn" runat="server">
                                    <span>Choose file 4</span>
                                    <input class="input_file" type="file" accept="image/*" id="fileInput4" runat="server" onchange="previewImage('ContentPlaceHolder1_fileInput4', 'ContentPlaceHolder1_image_preview4', 'ContentPlaceHolder1_choosebtn4')" />
                                </label>
                                <img src="" class="" id="image_preview4" runat="server" />
                            </div>
                            <div class="choose" id="choose5" runat="server">
                                <label id="choosebtn5" class="btn" runat="server">
                                    <span>Choose file 5</span>
                                    <input class="input_file" type="file" accept="image/*" id="fileInput5" runat="server" onchange="previewImage('ContentPlaceHolder1_fileInput5', 'ContentPlaceHolder1_image_preview5', 'ContentPlaceHolder1_choosebtn5')" />
                                </label>
                                <img src="" class="" id="image_preview5" runat="server" />
                            </div>
                            <div class="choose" id="choose6" runat="server">
                                <label id="choosebtn6" class="btn" runat="server">
                                    <span>Choose file 6</span>
                                    <input class="input_file" type="file" accept="image/*" id="fileInput6" runat="server" onchange="previewImage('ContentPlaceHolder1_fileInput6', 'ContentPlaceHolder1_image_preview6', 'ContentPlaceHolder1_choosebtn6')" />
                                </label>
                                <img src="" class="" id="image_preview6" runat="server" />
                            </div>
                        </div>
                    </div>

                    <div class="password_tip">
                        <p>* This is an administrator account, so please do not use it except when writing a notification.</p>
                    </div>
                    <div class="bottom_button">
                        <asp:Button CssClass="btn_cancel" ID="Button1" runat="server" Text='CANCEL' OnClick="btnCancel_Click" />
                        <asp:Button CssClass="btn_post" ID="btnPost" runat="server" Text='POST' OnClick="btnPost_Click" />
                    </div>
                </div>
            </div>
        </div>


    </article>
    <script>
        function linkto(link) {
            document.location.href = link;
        }
        function ReceiverDiagram(value) {
            document.location.reload();
        }
        function saveRules(active, id) {
            if (active == "Cancel") {
                document.getElementById('txtTitle').value = "";
                document.getElementById('txtText').value = "";
            }
            else {
                CallDiagram(active + "$$" + id + "$$" + document.getElementById('txtTitle').value + "$$" + document.getElementById('txtText').value);
            }

        }
    </script>
</asp:Content>
