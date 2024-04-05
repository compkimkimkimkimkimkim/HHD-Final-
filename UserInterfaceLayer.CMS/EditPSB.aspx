<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EditPSB.aspx.cs" MasterPageFile="~/CMS.Master" Inherits="HHD.UserInterfaceLayer.CMS.EditPSB" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

   <div class="Tableadd">
                <asp:FileUpload CssClass="Picadd" runat="server" ID="PSBFileUploadUni" />
                <br />
                <asp:TextBox CssClass="Tbaddnewlong" runat="server" ID="txtUniName" placeholder="Name"></asp:TextBox>
                <asp:TextBox CssClass="Tbaddnewlong" runat="server" ID="Contentne" placeholder="Content"></asp:TextBox>
                <br />
                <asp:Button CssClass="Tbaddbtn" runat="server" ID="btnAddUni" Text="Add" OnClick="btnAddUni_Click" />
               
            </div>
    </asp:Content>