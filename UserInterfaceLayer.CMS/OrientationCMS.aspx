<%@ Page Title="" Language="C#" MasterPageFile="~/CMS.Master" AutoEventWireup="true" CodeBehind="OrientationCMS.aspx.cs" Inherits="HHD.UserInterfaceLayer.CMS.OrientationCMS" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="../Content/CMSCss/SiteCMS.css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <article>
        <div class="cont">
            <div class="cmstitledivcover">
                <div class="cmstitlediv">
                    <label class="cmstitle">Orientation Page Welcome</label>
                </div>
            </div>
            <div class="tablemenu">
                <div class="width30 adjust">
                    <label class="tablelabel">Page Title</label></div>
                <div class="width60 adjust">
                    <label class="tablelabel">Page Text</label></div>
                <div class="width10 adjust">
                    <label class="tablelabel">Action</label></div>
            </div>
            <asp:Table ID="tbWelcome" runat="server"></asp:Table>
            <div class="divhr"></div>
        </div>
        <div class="cont">
            <div class="cmstitledivcover">
                <div class="cmstitlediv">
                    <label class="cmstitle">To-Do List</label>
                </div>
            </div>
            <div class="tablemenu">
                <div class="width10 adjust">
                    <label class="tablelabel">Image</label></div>
                <div class="width20 adjust">
                    <label class="tablelabel">Title</label></div>
                <div class="width60 adjust">
                    <label class="tablelabel">Content</label></div>
                <div class="width10 adjust">
                    <label class="tablelabel">Action</label></div>
            </div>
            <asp:Table ID="To_do_tbl" runat="server"></asp:Table>

            <div class="divhr"></div>
            <div class="Tableadd">
                <asp:FileUpload CssClass="Picadd" runat="server" ID="oriFileUploadTodo" />
                <br />
                <asp:TextBox CssClass="Tbaddnewlong" runat="server" ID="txtTodoTitle" placeholder="Title"></asp:TextBox>
                <br />
                <asp:TextBox CssClass="Tbaddnewbig" runat="server" ID="txtTodoContent" placeholder="Content"></asp:TextBox>
                <br />
                <asp:Button CssClass="Tbaddbtn" runat="server" ID="btnAddTodo" Text="Add" OnClick="btnAddTodo_Click" />
                <asp:Button CssClass="Tbaddbtn" runat="server" ID="btnCancelTodo" Text="Cancel" OnClick="btnCancelTodo_Click" />
            </div>
        </div>
        <div class="cont">
            <div class="cmstitledivcover">
                <div class="cmstitlediv">
                    <label class="cmstitle">FAQ</label>
                </div>
            </div>
            <div class="tablemenu">
                <div class="width10 adjust">
                    <label class="tablelabel">Image</label></div>
                <div class="width20 adjust">
                    <label class="tablelabel">Question</label></div>
                <div class="width60 adjust">
                    <label class="tablelabel">Content</label></div>
                <div class="width10 adjust">
                    <label class="tablelabel">Action</label></div>
            </div>
            <asp:Table ID="FAQ_tbl" runat="server"></asp:Table>

            <div class="divhr"></div>
            <div class="Tableadd">
                <asp:FileUpload CssClass="Picadd" runat="server" ID="oriFileUploadFAQ" />
                <br />
                <asp:TextBox CssClass="Tbaddnewlong" runat="server" ID="txtFAQQuestion" placeholder="Title"></asp:TextBox>
                <br />
                <asp:TextBox CssClass="Tbaddnewbig" runat="server" ID="txtFAQContent" placeholder="Content"></asp:TextBox>
                <br />
                <asp:Button CssClass="Tbaddbtn" runat="server" ID="btnAddFAQ" Text="Add" OnClick="btnAddFAQ_Click" />
                <asp:Button CssClass="Tbaddbtn" runat="server" ID="btnCancelFAQ" Text="Cancel" OnClick="btnCancelFAQ_Click" />
            </div>
        </div>
    </article>
</asp:Content>
