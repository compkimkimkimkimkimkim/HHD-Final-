<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EditRulerComunity.aspx.cs" MasterPageFile="~/CMS.Master" Inherits="HHD.UserInterfaceLayer.CMS.EditRulerComunity" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

   <div class="Tableadd">
                
                <asp:TextBox CssClass="Tbaddnewlong" runat="server" ID="txtTitleRuler" placeholder="Name"></asp:TextBox>
                <asp:TextBox CssClass="Tbaddnewlong" runat="server" ID="ContentRuler" placeholder="Content"></asp:TextBox>
                <br />
                <asp:Button CssClass="Tbaddbtn" runat="server" ID="btnAddUni" Text="Add" OnClick="btnAddRuler_Click" />
               
            </div>
    </asp:Content>