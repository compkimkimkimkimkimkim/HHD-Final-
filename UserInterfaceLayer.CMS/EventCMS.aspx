<%@ Page Title="Event" Language="C#" MasterPageFile="~/CMS.Master" AutoEventWireup="true" CodeBehind="EventCMS.aspx.cs" Inherits="HHD.UserInterfaceLayer.CMS.EventCMS" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="../Content/CMSCss/SiteCMS.css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <article>
        <div class="cont">
            <div class="cmstitledivcover">
                <div class="cmstitlediv">
                    <label class="cmstitle">Event Page Title Image</label>
                </div>
            </div>
            <div class="tablemenu">
                <div class="width90 adjust">
                    <label class="tablelabel">Title Image</label></div>
                <div class="width10 adjust">
                    <label class="tablelabel">Action</label></div>
            </div>
            <asp:Table ID="TitlePage_tbl" runat="server"></asp:Table>
        </div>
        <div class="cont">
            <div class="cmstitledivcover">
                <div class="cmstitlediv">
                    <label class="cmstitle">Current Event List</label>
                </div>
            </div>
            <div class="tablemenu">
                <div class="width90 adjust">
                    <label class="tablelabel">Event Poster</label></div>
                <div class="width10 adjust">
                    <label class="tablelabel">Action</label></div>
            </div>

            <asp:Table ID="Current_tbl" runat="server"></asp:Table>
            <div class="divhr"></div>
            <div class="Tableadd">
                <asp:FileUpload CssClass="Picadd" runat="server" ID="currenteventFileUploadposter" />
                <br />
                <asp:Button CssClass="Tbaddbtn" runat="server" ID="btnAddcureventPoster" Text="Add" OnClick="btnAddcureventPoster_Click" />
                <asp:Button CssClass="Tbaddbtn" runat="server" ID="btnCancelcureventPoster" Text="Cancel" OnClick="btnCancelcureventPoster_Click" />
            </div>
        </div>
        <div class="cont">
            <div class="cmstitledivcover">
                <div class="cmstitlediv">
                    <label class="cmstitle">Upcoming Event List</label>
                </div>
            </div>

            <div class="tablemenu">
                <div class="width90 adjust">
                    <label class="tablelabel">Event Poster</label></div>
                <div class="width10 adjust">
                    <label class="tablelabel">Action</label></div>
            </div>
            <asp:Table ID="Upcoming_tbl" runat="server"></asp:Table>

            <div class="divhr"></div>
            <div class="Tableadd">
                <asp:FileUpload CssClass="Picadd" runat="server" ID="upeventFileUploadposter" />
                <br />
                <asp:Button CssClass="Tbaddbtn" runat="server" ID="btnAddupeventPoster" Text="Add" OnClick="btnAddupeventPoster_Click" />
                <asp:Button CssClass="Tbaddbtn" runat="server" ID="btnCancelupeventPoster" Text="Cancel" OnClick="btnCancelupeventPoster_Click" />
            </div>
        </div>
        <div class="cont">
            <div class="cmstitledivcover">
                <div class="cmstitlediv">
                    <label class="cmstitle">Past Event List</label>
                </div>
            </div>
            <div class="tablemenu">
                <div class="width90 adjust">
                    <label class="tablelabel">Event Poster</label></div>
                <div class="width10 adjust">
                    <label class="tablelabel">Action</label></div>
            </div>
            <asp:Table ID="Past_tbl" runat="server"></asp:Table>
            <div class="divhr"></div>
            <div class="Tableadd">
                <asp:FileUpload CssClass="Picadd" runat="server" ID="pasteventFileUploadposter" />
                <br />
                <asp:Button CssClass="Tbaddbtn" runat="server" ID="btnAddpasteventPoster" Text="Add" OnClick="btnAddpasteventPoster_Click" />
                <asp:Button CssClass="Tbaddbtn" runat="server" ID="btnCancelpasteventPoster" Text="Cancel" OnClick="btnCancelpasteventPoster_Click" />
            </div>
        </div>
    </article>
</asp:Content>
