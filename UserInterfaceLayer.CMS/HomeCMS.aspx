<%@ Page Title="" Language="C#" MasterPageFile="~/CMS.Master" AutoEventWireup="true" CodeBehind="HomeCMS.aspx.cs" Inherits="HHD.UserInterfaceLayer.CMS.HomeCMS" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="../Content/CMSCss/SiteCMS.css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <article>
        <div class="cont">
            <div class="cmstitledivcover">
                <div class="cmstitlediv">
                    <label class="cmstitle">Current Event List</label>
                </div>
            </div>
            <div class="tablemenu">
                <div class="width90 adjust">
                    <label class="tablelabel">Event Poster</label>
                </div>
                <div class="width10 adjust">
                    <label class="tablelabel">Action</label>
                </div>
            </div>
            <asp:Table ID="TitlePage_tbl" runat="server"></asp:Table>
            <div class="divhr"></div>

            <div class="Tableadd">
                <asp:FileUpload CssClass="Picadd" runat="server" ID="TitlePageFileUploadposter" />
                <br />
                <asp:Button CssClass="Tbaddbtn" runat="server" ID="Button1" Text="Add" OnClick="btnAddEVENTPoster_Click" />

            </div>
        </div>
        <div class="cont">
            <div class="cmstitledivcover">
                <div class="cmstitlediv">
                    <label class="cmstitle">Campus Life Section</label>
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
            <asp:Table ID="tbCampus" runat="server"></asp:Table>
        </div>
        <div class="cont">
            <div class="cmstitledivcover">
                <div class="cmstitlediv">
                    <label class="cmstitle">Uni Info Section</label>
                </div>
            </div>
            <div class="tablemenu">
                <div class="width90 adjust">
                    <label class="tablelabel">Description</label>
                </div>
                <div class="width10 adjust">
                    <label class="tablelabel">Action</label>
                </div>
            </div>
            <asp:Table ID="tbUniInfo" runat="server"></asp:Table>

        </div>
        <div class="cont">
            <div class="cmstitledivcover">
                <div class="cmstitlediv">
                    <label class="cmstitle">Community Section</label>
                </div>
            </div>
            <div class="tablemenu">
                <div class="width45 adjust">
                    <label class="tablelabel">Image</label>
                </div>
                <div class="width45 adjust">
                    <label class="tablelabel">Description</label>
                </div>
                <div class="width10 adjust">
                    <label class="tablelabel">Action</label>
                </div>
            </div>
            <asp:Table ID="tbCommunity" runat="server"></asp:Table>

        </div>

        <div class="cont">
            <div class="cmstitledivcover">
                <div class="cmstitlediv">
                    <label class="cmstitle">Testimonial</label>
                </div>
            </div>
            <div class="tablemenu">
                <div class="width90 adjust">
                    <label class="tablelabel">Video Link</label>
                </div>
                <div class="width10 adjust">
                    <label class="tablelabel">Action</label>
                </div>
            </div>
            <asp:Table ID="Testimonial" runat="server"></asp:Table>

            <div class="divhr"></div>
            <div class="Tableadd">
                <asp:TextBox CssClass="Tbaddnewlong" runat="server" ID="txtlink" placeholder="VideoLink"></asp:TextBox>
                <br />
                <asp:Button CssClass="Tbaddbtn" runat="server" ID="btnAddTestimonial" OnClick="btnAddTestimonial_Click" Text="Add" />
                <asp:Button CssClass="Tbaddbtn" runat="server" ID="btnCancelcureventPoster" OnClick="btnCancelTestimonial_Click" Text="Cancel" />
            </div>
        </div>
    </article>
</asp:Content>
