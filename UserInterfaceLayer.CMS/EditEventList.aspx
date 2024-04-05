<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EditEventList.aspx.cs" MasterPageFile="~/CMS.Master" Inherits="HHD.UserInterfaceLayer.CMS.EditEventList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="Panel1" runat="server"></asp:Panel>
    <asp:Panel ID="dynamicControlsPanel2" runat="server"></asp:Panel>

    
     <asp:Label ID="lblMessage" runat="server" Visible="false"></asp:Label>
      <asp:FileUpload CssClass="Picadd" runat="server" ID="currenteventFileUploadposter" />
    <asp:Button ID="btnAction" runat="server" Text="Execute Action" OnClick="btnAction_Click" />

    
</asp:Content>