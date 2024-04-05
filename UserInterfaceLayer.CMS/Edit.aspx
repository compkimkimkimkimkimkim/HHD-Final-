<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Edit.aspx.cs" MasterPageFile="~/CMS.Master"  Inherits="HHD.UserInterfaceLayer.CMS.Edit" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:TextBox ID="txtID" runat="server"></asp:TextBox>
    <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
    <asp:Button ID="btnAction" runat="server" Text="Execute Action" OnClick="btnAction_Click" />
     <asp:Label ID="lblMessage" runat="server" Visible="false"></asp:Label>
</asp:Content>

