<%@ Page Title="" Language="C#" MasterPageFile="~/CMS.Master" AutoEventWireup="true" CodeBehind="StudentClubCMS.aspx.cs" Inherits="HHD.UserInterfaceLayer.CMS.StudentClubCMS" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="../Content/CMSCss/SiteCMS.css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <article>
        <div class="cont">
            <div class="cmstitledivcover">
                <div class="cmstitlediv">
                    <label class="cmstitle">Student Club Page Title Image</label>
                </div>
            </div>
            <div class="tablemenu">
                <div class="width90 adjust">
                    <label class="tablelabel">Title Image</label></div>
                <div class="width10 adjust">
                    <label class="tablelabel">Action</label></div>
            </div>
            <asp:Table ID="TitlePageCLUB" runat="server"></asp:Table>
        </div>
        <div class="cont">
            <div class="cmstitledivcover">
                <div class="cmstitlediv">
                    <label class="cmstitle">Industry Student Chapters</label>
                </div>
            </div>
            <div class="tablemenu">
                <div class="width10 adjust">
                    <label class="tablelabel">Image</label></div>
                <div class="width15 adjust">
                    <label class="tablelabel">Name</label></div>
                <div class="width55 adjust">
                    <label class="tablelabel">Content</label></div>
                <div class="width10 adjust">
                    <label class="tablelabel">Link</label></div>
                <div class="width10 adjust">
                    <label class="tablelabel">Action</label></div>
            </div>

            <asp:Table ID="Industry_tbl" runat="server"></asp:Table>
            <div class="divhr"></div>
            <div class="Tableadd">
                <asp:FileUpload CssClass="Picadd" runat="server" ID="ClubiFileUploadIndustry" />
                <br />
                <asp:TextBox CssClass="Tbaddnew" runat="server" ID="txtIndustryName" placeholder="Name"></asp:TextBox>
                <asp:TextBox CssClass="Tbaddnew" runat="server" ID="txtIndustryLink" placeholder="link"></asp:TextBox>
                <br />
                <asp:TextBox CssClass="Tbaddnewbig" runat="server" ID="txtIndustryContent" placeholder="Content"></asp:TextBox>
                <br />
                <asp:Button CssClass="Tbaddbtn" runat="server" ID="btnAddIndustry" Text="Add" OnClick="btnAddIndustry_Click" />
                <asp:Button CssClass="Tbaddbtn" runat="server" ID="btnCancelIndustry" Text="Cancel" OnClick="btnCancelIndustry_Click" />
            </div>
        </div>
        <div class="cont">
            <div class="cmstitledivcover">
                <div class="cmstitlediv">
                    <label class="cmstitle">Interest Groups</label>
                </div>
            </div>
            <div class="tablemenu">
                <div class="width10 adjust">
                    <label class="tablelabel">Image</label></div>
                <div class="width15 adjust">
                    <label class="tablelabel">Name</label></div>
                <div class="width55 adjust">
                    <label class="tablelabel">Content</label></div>
                <div class="width10 adjust">
                    <label class="tablelabel">Link</label></div>
                <div class="width10 adjust">
                    <label class="tablelabel">Action</label></div>
            </div>
            <asp:Table ID="Interest_tbl" runat="server"></asp:Table>
            <div class="divhr"></div>
            <div class="Tableadd">
                <asp:FileUpload CssClass="Picadd" runat="server" ID="ClubiFileUploadInterest" />
                <br />
                <asp:TextBox CssClass="Tbaddnew" runat="server" ID="txtInterestName" placeholder="Name"></asp:TextBox>
                <asp:TextBox CssClass="Tbaddnew" runat="server" ID="txtInterestLink" placeholder="link"></asp:TextBox>
                <br />
                <asp:TextBox CssClass="Tbaddnewbig" runat="server" ID="txtInterestContent" placeholder="Content"></asp:TextBox>
                <br />
                <asp:Button CssClass="Tbaddbtn" runat="server" ID="btnAddInterest" Text="Add" OnClick="btnAddInterest_Click" />
                <asp:Button CssClass="Tbaddbtn" runat="server" ID="btnCancelInterest" Text="Cancel" OnClick="btnCancelInterest_Click" />
            </div>
        </div>
        <div class="cont">
            <div class="cmstitledivcover">
                <div class="cmstitlediv">
                    <label class="cmstitle">International Communities</label>
                </div>
            </div>
            <div class="tablemenu">
                <div class="width10 adjust">
                    <label class="tablelabel">Image</label></div>
                <div class="width15 adjust">
                    <label class="tablelabel">Name</label></div>
                <div class="width55 adjust">
                    <label class="tablelabel">Content</label></div>
                <div class="width10 adjust">
                    <label class="tablelabel">Link</label></div>
                <div class="width10 adjust">
                    <label class="tablelabel">Action</label></div>
            </div>

            <asp:Table ID="International_tbl" runat="server"></asp:Table>
            <div class="divhr"></div>
            <div class="Tableadd">
                <asp:FileUpload CssClass="Picadd" runat="server" ID="ClubiFileUploadInternational" />
                <br />
                <asp:TextBox CssClass="Tbaddnew" runat="server" ID="txtInternationalName" placeholder="Name"></asp:TextBox>
                <asp:TextBox CssClass="Tbaddnew" runat="server" ID="txtInternationalLink" placeholder="link"></asp:TextBox>
                <br />
                <asp:TextBox CssClass="Tbaddnewbig" runat="server" ID="txtInternationalContent" placeholder="Content"></asp:TextBox>
                <br />
                <asp:Button CssClass="Tbaddbtn" runat="server" ID="btnAddInternational" Text="Add" OnClick="btnAddInternational_Click" />
                <asp:Button CssClass="Tbaddbtn" runat="server" ID="btnCancelInternational" Text="Cancel" OnClick="btnCancelInternational_Click" />
            </div>
        </div>
    </article>
</asp:Content>
