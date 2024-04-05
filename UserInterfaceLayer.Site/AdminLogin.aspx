<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AdminLogin.aspx.cs" Inherits="HHD.UserInterfaceLayer.Site.AdminLogin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="../Content/SiteCss/AdminLogin.css"/>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <article>
        <div class="logincont">
            <div class="loginstyle1">
                <h2 class="H2login">Admin Login</h2>
            </div>
            <div class="loginstyle2">
                <div class="tooltip">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" ControlToValidate="LidCMS"
                    ErrorMessage="Email address is required!" ValidationGroup="grpCMSlogin" Display="Dynamic"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator11" runat="server" ControlToValidate="LidCMS"
                    ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
                    ErrorMessage="Input value is an invalid email address!" ValidationGroup="grpCMSlogin"></asp:RegularExpressionValidator>
                </div>
                <asp:TextBox ID="LidCMS" Cssclass="Tblogin" runat="server" placeholder="XXXX@ADMIN.XX" ValidationGroup="grpCMSlogin"></asp:TextBox>
            </div>
            <div class="loginstyle3">
                <div class="tooltip">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator22" runat="server" ControlToValidate="LpdCMS"
                    ErrorMessage="password is required!" ValidationGroup="grpCMSlogin" Display="Dynamic"></asp:RequiredFieldValidator>
                </div>
                <asp:TextBox ID="LpdCMS"  CssClass="Tblogin" runat="server" placeholder="PASSWORD" TextMode="Password" ValidationGroup="grpCMSlogin"></asp:TextBox>
            </div>
            <div class="loginstyle4">
                <asp:Button CssClass="BtnBlue" runat="server" Text="Log in" ValidationGroup="grpCMSlogin" OnClick="BtnLogIn_Click" />
                <div class="fcont">
                    <asp:Label ID="loginfail" runat="server" CssClass="Lfail" Text=""></asp:Label>
                </div>
            </div>
        </div>
    </article>
</asp:Content>
