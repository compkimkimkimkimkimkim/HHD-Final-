<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="editmaria.aspx.cs" Inherits="HHD.UserInterfaceLayer.CMS.editmaria" MasterPageFile="~/CMS.Master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:TextBox ID="txtID" runat="server" Visible="false"></asp:TextBox>
    <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
     <asp:Label ID="lblMessage" runat="server" Visible="false"></asp:Label>
      <asp:FileUpload CssClass="Picadd" runat="server" ID="currenteventFileUploadposter" />
    <asp:Button ID="btnAction" runat="server" Text="Execute Action" OnClick="btnAction_Click" />

</asp:Content>



