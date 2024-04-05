<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Uni_Orientation.aspx.cs" Inherits="HHD.UserInterfaceLayer.Site.Uni_Orientation" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="../Content/SiteCss/Uni_Orientation.css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <article>

        <div class="title">
            <h1 runat="server" id="txt_Title" class="title_text">Welcome to Orientation Page</h1>
            <span runat="server" id="txt_Content" class="title_note">Please check and prepare your University and Singapore life</span>
        </div>
        <div class="navbar">
            <div class="nav_content btn_active" id="nav_Todo">
                <label>To-Do List</label>
            </div>
            <div class="nav_content" id="nav_FAQ">
                <label>FAQ</label>
            </div>
        </div>
        <hr class="hrr" />

        <asp:Repeater ID="rptToDo" runat="server">
            <ItemTemplate>
                <div class="contents TbTodo">
                    <div class="box">
                        <div class="boximg">
                            <asp:Image runat="server" ImageUrl='<%# "ImagesSite/" + Eval("Images") %>' />
                        </div>
                        <div class="boxinfo">
                            <h2><%# Eval("Title") %></h2>
                            <label><%# Eval("Content") %></label>
                        </div>
                    </div>
                </div>
            </ItemTemplate>
        </asp:Repeater>

        <asp:Repeater ID="rptFAQ" runat="server">
            <ItemTemplate>
                <div class="contents TbFAQ">
                    <div class="box">
                        <div class="boximg">
                            <asp:Image runat="server" ImageUrl='<%# "ImagesSite/" + Eval("Images") %>' />
                        </div>
                        <div class="boxinfo">
                            <h2><%# Eval("Title") %></h2>
                            <label><%# Eval("Content") %></label>
                        </div>
                    </div>
                </div>
            </ItemTemplate>
        </asp:Repeater>

        <script src="../Scripts/SiteJs/Uni_Orientation.js"></script>
    </article>
</asp:Content>
