<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UONEdit.aspx.cs" MasterPageFile="~/CMS.Master" Inherits="HHD.UserInterfaceLayer.CMS.UONEdit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="Tableadd">
        <asp:FileUpload CssClass="Picadd" runat="server" ID="UoNFileUploadRank" />
        <br />
        <asp:TextBox CssClass="Tbaddnew" runat="server" ID="txtRank" placeholder="Rank"></asp:TextBox>
        <asp:TextBox CssClass="Tbaddnew" runat="server" ID="txtRankDescription" placeholder="Description"></asp:TextBox>
        <br />
        <asp:Button CssClass="Tbaddbtn" runat="server" ID="btnAddRank" Text="Add" OnClick="btnAddRank_Click" />

    </div>
</asp:Content>
