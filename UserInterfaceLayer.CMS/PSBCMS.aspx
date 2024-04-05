<%@ Page Title="" Language="C#" MasterPageFile="~/CMS.Master" AutoEventWireup="true" CodeBehind="PSBCMS.aspx.cs" Inherits="HHD.UserInterfaceLayer.CMS.PSBCMS" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="../Content/CMSCss/SiteCMS.css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <article>
        <div class="cont">
            <div class="cmstitledivcover">
                <div class="cmstitlediv">
                    <label class="cmstitle">PSB Page Title Image</label>
                </div>
            </div>
            <div class="tablemenu">
                <div class="width20 adjust">
                    <label class="tablelabel">Title Image</label></div>
                <div class="width20 adjust">
                    <label class="tablelabel">Title</label></div>
                <div class="width50 adjust">
                    <label class="tablelabel">Content</label></div>
                <div class="width10 adjust">
                    <label class="tablelabel">Action</label></div>
            </div>
            <asp:Table ID="TitlePSB_pln" runat="server"></asp:Table>

        </div>
        <div class="cont">
            <div class="cmstitledivcover">
                <div class="cmstitlediv">
                    <label class="cmstitle">PSB Page Overview</label>
                </div>
            </div>
            <div class="tablemenu">
                <div class="width20 adjust">
                    <label class="tablelabel">Image</label></div>
                <div class="width70 adjust">
                    <label class="tablelabel">Title</label></div>
                <div class="width10 adjust">
                    <label class="tablelabel">Action</label></div>
            </div>
            <asp:Table ID="Overview_pln" runat="server"></asp:Table>
        </div>
        <div class="cont">
            <div class="cmstitledivcover">
                <div class="cmstitlediv">
                    <label class="cmstitle">University partners</label>
                </div>
            </div>
            <div class="tablemenu">
                <div class="width45 adjust">
                    <label class="tablelabel">Image</label></div>
                <div class="width45 adjust">
                    <label class="tablelabel">Name</label></div>
                <div class="width10 adjust">
                    <label class="tablelabel">Action</label></div>
            </div>

            <asp:Table ID="University_tbl" runat="server"></asp:Table>

            <div class="divhr"></div>
            <div class="Tableadd">
                <asp:FileUpload CssClass="Picadd" runat="server" ID="PSBFileUploadUni" />
                <br />
                <asp:TextBox CssClass="Tbaddnewlong" runat="server" ID="txtUniName" placeholder="Name"></asp:TextBox>
                <br />
                <asp:Button CssClass="Tbaddbtn" runat="server" ID="btnAddUni" Text="Add" OnClick="btnAddUni_Click" />
                <asp:Button CssClass="Tbaddbtn" runat="server" ID="btnCancelUni" Text="Cancel" OnClick="btnCancelUni_Click" />
            </div>
        </div>
        <div class="cont">
            <div class="cmstitledivcover">
                <div class="cmstitlediv">
                    <label class="cmstitle">Other Contents</label>
                </div>
            </div>
            <div class="tablemenu">
                <div class="width10 adjust">
                    <label class="tablelabel">Title</label></div>
                <div class="width50 adjust">
                    <label class="tablelabel">Contents</label></div>
                <div class="width30 adjust">
                    <label class="tablelabel">Image</label></div>
                <div class="width10 adjust">
                    <label class="tablelabel">Action</label></div>
            </div>
            <asp:Table ID="Other_tbl" runat="server"></asp:Table>

            <div class="divhr"></div>
            <div class="Tableadd">
                <asp:TextBox CssClass="Tbaddnewlong" runat="server" ID="txtContentTitle" placeholder="Title"></asp:TextBox>
                <br />
                <asp:TextBox CssClass="Tbaddnewbig" runat="server" ID="txtContentContent" placeholder="Content"></asp:TextBox>
                <br />
                <asp:FileUpload CssClass="Picadd" runat="server" ID="PSBFileUploadNew" />
                <br />
                <asp:Button CssClass="Tbaddbtn" runat="server" ID="btnAddContent" Text="Add" OnClick="btnAddContent_Click" />
                <asp:Button CssClass="Tbaddbtn" runat="server" ID="btnCancelContent" Text="Cancel" OnClick="btnCancelContent_Click" />
            </div>
        </div>
    </article>
</asp:Content>
