<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentClubEdit.aspx.cs" MasterPageFile="~/CMS.Master" Inherits="HHD.UserInterfaceLayer.CMS.StudentClubEdit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


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

</asp:Content>
