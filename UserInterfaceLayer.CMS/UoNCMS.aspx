<%@ Page Title="" Language="C#" MasterPageFile="~/CMS.Master" AutoEventWireup="true" CodeBehind="UoNCMS.aspx.cs" Inherits="HHD.UserInterfaceLayer.CMS.UoNCMS" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="../Content/CMSCss/SiteCMS.css" />
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <article>
        <div class="cont">
            <div class="cmstitledivcover">
                <div class="cmstitlediv">
                    <label class="cmstitle">UoN Page Title Image</label>
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
            <asp:Table ID="titlene" runat="server"></asp:Table>
        </div>
        <div class="cont">
            <div class="cmstitledivcover">
                <div class="cmstitlediv">
                    <label class="cmstitle">UoN Page Overviews</label>
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

            <asp:Table ID="Overview_tbl" runat="server"></asp:Table>
        </div>
        <div class="cont">
            <div class="cmstitledivcover">
                <div class="cmstitlediv">
                    <label class="cmstitle">UoN Ranking</label>
                </div>
            </div>
            <div class="tablemenu">
                <div class="width20 adjust">
                    <label class="tablelabel">Image</label></div>
                <div class="width30 adjust">
                    <label class="tablelabel">Rank</label></div>
                <div class="width40 adjust">
                    <label class="tablelabel">Description</label></div>
                <div class="width10 adjust">
                    <label class="tablelabel">Action</label></div>
            </div>

            <asp:Table ID="UoN_Ranking" runat="server"></asp:Table>
            <div class="divhr"></div>
            <div class="Tableadd">
                <asp:FileUpload CssClass="Picadd" runat="server" ID="UoNFileUploadRank" />
                <br />
                <asp:TextBox CssClass="Tbaddnew" runat="server" ID="txtRank" placeholder="Rank"></asp:TextBox>
                <asp:TextBox CssClass="Tbaddnew" runat="server" ID="txtRankDescription" placeholder="Description"></asp:TextBox>
                <br />
                <asp:Button CssClass="Tbaddbtn" runat="server" ID="btnAddRank" Text="Add" OnClick="btnAddRank_Click" />
                <asp:Button CssClass="Tbaddbtn" runat="server" ID="btnCancelRank" Text="Cancel" OnClick="btnCancelRank_Click" />
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
                <div class="width30 adjust">
                    <label class="tablelabel">Contents</label></div>
                <div class="width30 adjust">
                    <label class="tablelabel">Description</label></div>
                <div class="width20 adjust">
                    <label class="tablelabel">Image</label></div>
                <div class="width10 adjust">
                    <label class="tablelabel">Action</label></div>
            </div>
            <asp:Table ID="Other_tbl" runat="server"></asp:Table>

            <div class="divhr"></div>
            <div class="Tableadd">
                <asp:TextBox CssClass="Tbaddnewlong" runat="server" ID="txtTitle" placeholder="Title"></asp:TextBox>
                <br />
                <asp:TextBox CssClass="Tbaddnewbig" runat="server" ID="txtContent" placeholder="Content"></asp:TextBox>
                <br />
                <asp:TextBox CssClass="Tbaddnewbig" runat="server" ID="txtDescription" placeholder="Description"></asp:TextBox>
                <br />
                <asp:FileUpload CssClass="Picadd" runat="server" ID="UoNFileUploadNew" />
                <br />
                <asp:Button CssClass="Tbaddbtn" runat="server" ID="btnAdd" Text="Add" OnClick="btnAdd_Click" />
                <asp:Button CssClass="Tbaddbtn" runat="server" ID="btnCancel" Text="Cancel" OnClick="btnCancel_Click" />
            </div>
        </div>
    </article>
</asp:Content>
