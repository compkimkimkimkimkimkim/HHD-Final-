<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Editaboutus2.aspx.cs" Inherits="HHD.UserInterfaceLayer.CMS.Editaboutus2" MasterPageFile="~/CMS.Master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
      <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
     <asp:Label ID="lblMessage" runat="server" Visible="false"></asp:Label>
      <asp:FileUpload CssClass="Picadd" runat="server" ID="currenteventFileUploadposter" />
    <asp:Button ID="btnAction" runat="server" Text="Execute Action" OnClick="btnAction_Click" />

</asp:Content>


