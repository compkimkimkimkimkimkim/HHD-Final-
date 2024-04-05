<%@ Page Title="About Us" Language="C#" MasterPageFile="~/CMS.Master" AutoEventWireup="true" CodeBehind="AboutUsCMS.aspx.cs" Inherits="HHD.UserInterfaceLayer.CMS.AboutUsCMS" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="../Content/CMSCss/SiteCMS.css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <article>
        <div class="cont">
            <div class="cmstitledivcover">
                <div class="cmstitlediv">
                    <label class="cmstitle">About Us Page Title Image</label>
                </div>
            </div>
            <div class="tablemenu">
                <div class="width90 adjust">
                    <label class="tablelabel">Title Image</label>
                </div>
                <div class="width10 adjust">
                    <label class="tablelabel">Action</label>
                </div>
            </div>
            <asp:Table ID="tbTitle" runat="server"></asp:Table>
            <div class="divhr"></div>
        </div>
        <div class="cont">
            <div class="cmstitledivcover">
                <div class="cmstitlediv">
                    <label class="cmstitle">Project Members</label>
                </div>
            </div>
            <div class="tablemenu">
                <div class="width10 adjust">
                    <label class="tablelabel">Image</label>
                </div>
                <div class="width15 adjust">
                    <label class="tablelabel">Name</label>
                </div>
                <div class="width20 adjust">
                    <label class="tablelabel">Major</label>
                </div>
                <div class="width45 adjust">
                    <label class="tablelabel">Ambitions</label>
                </div>
                <div class="width10 adjust">
                    <label class="tablelabel">Action</label>
                </div>
            </div>

            <asp:Table ID="Project_tbl" runat="server"></asp:Table>
            <div class="divhr"></div>
            <div class="Tableadd">
                <asp:FileUpload CssClass="Picadd" runat="server" ID="aboutusFileUploadmember" />
                <br />
                <asp:TextBox CssClass="Tbaddnew" runat="server" ID="txtMemebrName" placeholder="Name"></asp:TextBox>
                <br />
                <asp:TextBox CssClass="Tbaddnewlong" runat="server" ID="txtMemebrMajor" placeholder="Major"></asp:TextBox>
                <br />
                <asp:TextBox CssClass="Tbaddnewbig" runat="server" ID="txtMemebrAmbition" placeholder="Ambition"></asp:TextBox>
                <br />
                <asp:Button CssClass="Tbaddbtn" runat="server" ID="btnAddMemebr" Text="Add" OnClick="btnAddMemebr_Click" />
                <asp:Button CssClass="Tbaddbtn" runat="server" ID="btnCancelMemebr" Text="Cancel" OnClick="btnCancelMemebr_Click" />
            </div>
        </div>
        <div class="cont">
            <div class="cmstitledivcover">
                <div class="cmstitlediv">
                    <label class="cmstitle">Tools</label>
                </div>
            </div>
            <div class="tablemenu">
                <div class="width45 adjust">
                    <label class="tablelabel">Image</label>
                </div>
                <div class="width45 adjust">
                    <label class="tablelabel">Name</label>
                </div>
                <div class="width10 adjust">
                    <label class="tablelabel">Action</label>
                </div>
            </div>
            <asp:Table ID="Toolst_tbl" runat="server"></asp:Table>
            <div class="divhr"></div>
            <div class="Tableadd">
                <asp:FileUpload CssClass="Picadd" runat="server" ID="aboutusFileUploadtool" />
                <br />
                <asp:TextBox CssClass="Tbaddnew" runat="server" ID="txtToolName" placeholder="Name"></asp:TextBox>
                <br />
                <asp:Button CssClass="Tbaddbtn" runat="server" ID="btnAddTool" Text="Add" OnClick="btnAddTool_Click" />
                <asp:Button CssClass="Tbaddbtn" runat="server" ID="btnCancelTool" Text="Cancel" OnClick="btnCancelTool_Click" />
            </div>
        </div>
    </article>
</asp:Content>
