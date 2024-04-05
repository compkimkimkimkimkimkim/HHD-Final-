<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EditHome4.aspx.cs" Inherits="HHD.UserInterfaceLayer.CMS.EditHome4" MasterPageFile="~/CMS.Master"%>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 

     <div class="Tableadd">
               
                <asp:TextBox CssClass="Tbaddnew" runat="server" ID="txtIndustryLink" placeholder="link"></asp:TextBox>
               
                <br />
                 <asp:Button CssClass="Tbaddbtn" runat="server" ID="btnAddRank" Text="Add" OnClick="btnAddRank_Click" />
            </div>

    </asp:Content>