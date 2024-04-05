<%@ Page Title="" Language="C#" MasterPageFile="~/CMS.Master" AutoEventWireup="true" CodeBehind="MarinaSquareCMS.aspx.cs" Inherits="HHD.UserInterfaceLayer.CMS.MarinaSquareCMS" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="../Content/CMSCss/SiteCMS.css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager2" runat="server"></asp:ScriptManager>

    <article>
        <div class="cont">
            <div class="cmstitledivcover">
                <div class="cmstitlediv">
                    <label class="cmstitle">Marina Square Page Title Image</label>
                </div>
            </div>
            <div class="tablemenu">
                <div class="width90 adjust">
                    <label class="tablelabel">Title Image</label></div>
                <div class="width10 adjust">
                    <label class="tablelabel">Action</label></div>
            </div>
            <asp:Table ID="tbTitle" runat="server"></asp:Table>

        </div>
        <div class="cont">
            <div class="cmstitledivcover">
                <div class="cmstitlediv">
                    <label class="cmstitle">Level 3</label>
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

            <asp:Table ID="level3_tbl" runat="server"></asp:Table>
            <div class="divhr"></div>
            <div class="Tableadd">
                <asp:FileUpload CssClass="Picadd" runat="server" ID="MSFileUploadL3" />
                <br />
                <asp:TextBox CssClass="Tbaddnew" runat="server" ID="txtL3Name" placeholder="Name"></asp:TextBox>
                <br />
                <asp:Button CssClass="Tbaddbtn" runat="server" ID="btnAddL3" Text="Add" OnClick="btnAddL3_Click" />
                <asp:Button CssClass="Tbaddbtn" runat="server" ID="btnCancelL3" Text="Cancel" OnClick="btnCancelL3_Click" />
            </div>
        </div>
        <div class="cont">
            <div class="cmstitledivcover">
                <div class="cmstitlediv">
                    <label class="cmstitle">Level 2</label>
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


            <asp:Table ID="level2_tbl" runat="server"></asp:Table>

            <div class="divhr"></div>
            <div class="Tableadd">
                <asp:FileUpload CssClass="Picadd" runat="server" ID="MSFileUploadL2" />
                <br />
                <asp:TextBox CssClass="Tbaddnew" runat="server" ID="txtL2Name" placeholder="Name"></asp:TextBox>
                <br />
                <asp:Button CssClass="Tbaddbtn" runat="server" ID="btnAddL2" Text="Add" OnClick="btnAddL2_Click" />
                <asp:Button CssClass="Tbaddbtn" runat="server" ID="btnCancelL2" Text="Cancel" OnClick="btnCancelL2_Click" />
            </div>
        </div>
        <div class="cont">
            <div class="cmstitledivcover">
                <div class="cmstitlediv">
                    <label class="cmstitle">Level 1</label>
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

            <asp:Table ID="level1_tbl" runat="server"></asp:Table>

            <div class="divhr"></div>
            <div class="Tableadd">
                <asp:FileUpload CssClass="Picadd" runat="server" ID="MSFileUploadL1" />
                <br />
                <asp:TextBox CssClass="Tbaddnew" runat="server" ID="txtL1Name" placeholder="Name"></asp:TextBox>
                <br />
                <asp:Button CssClass="Tbaddbtn" runat="server" ID="btnAddL1" Text="Add" OnClick="btnAddL1_Click" />
                <asp:Button CssClass="Tbaddbtn" runat="server" ID="btnCancelL1" Text="Cancel" OnClick="btnCancelL1_Click" />
            </div>
        </div>
        <div class="cont">
            <div class="cmstitledivcover">
                <div class="cmstitlediv">
                    <label class="cmstitle">Basement 1</label>
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

            <asp:Table ID="levelb1_tbl" runat="server"></asp:Table>


            <div class="divhr"></div>
            <div class="Tableadd">
                <asp:FileUpload CssClass="Picadd" runat="server" ID="MSFileUploadB1" />
                <br />
                <asp:TextBox CssClass="Tbaddnew" runat="server" ID="txtB1Name" placeholder="Name"></asp:TextBox>
                <br />
                <asp:Button CssClass="Tbaddbtn" runat="server" ID="btnAddB1" Text="Add" OnClick="btnAddB1_Click" />
                <asp:Button CssClass="Tbaddbtn" runat="server" ID="btnCancelB1" Text="Cancel" OnClick="btnCancelB1_Click" />
            </div>
        </div>
    </article>


</asp:Content>
