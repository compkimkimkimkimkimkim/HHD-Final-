<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Editlocation2.aspx.cs"  MasterPageFile="~/CMS.Master" Inherits="HHD.UserInterfaceLayer.CMS.Editlocation2" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="dynamicControlsPanel" runat="server"></asp:Panel>
    <asp:Panel ID="dynamicControlsPanel2" runat="server"></asp:Panel>
    <asp:TextBox ID="txtID" runat="server"></asp:TextBox>
    <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    <asp:Button ID="btnAction" runat="server" Text="Execute Action" OnClick="btnAction_Click" />
     <asp:Label ID="lblMessage" runat="server" Visible="false"></asp:Label>
</asp:Content>
