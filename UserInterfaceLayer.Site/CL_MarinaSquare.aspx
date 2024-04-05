<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CL_MarinaSquare.aspx.cs" Inherits="HHD.UserInterfaceLayer.Site.CL_MarinaSquare" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="../Content/SiteCss/CL_MarinaSquare.css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <article>
        <div class="banner">
            <asp:Image ID="imgTitle" alt="Marina Square" runat="server" />
        </div>
        <div class="btnpart">
            <div class="btn_LTM">
                <div href="CL_Location.aspx" class="BTL">
                    <asp:HyperLink runat="server" NavigateUrl="~/UserInterfaceLayer.Site/CL_Location.aspx" CssClass="Bcont">SEE MAP</asp:HyperLink>
                </div>
                <div href="CL_MarinaSquare.aspx" class="BTM">
                    <asp:HyperLink runat="server" NavigateUrl="~/UserInterfaceLayer.Site/CL_MarinaSquare.aspx" CssClass="Bcont">SEE MARINA</asp:HyperLink>
                </div>
            </div>
            <div class="lbpart">
                <label class="lbl1">Stores in Marina Square</label>
            </div>
        </div>

        <div class="content">
            <hr class="Underline" />
        </div>
        <asp:Repeater ID="RptLv3" runat="server">
            <HeaderTemplate>
                <div class="content">
                    <div class="restaurant-level">
                        <label class="restaurant-list-heading">L3</label>
                    </div>
                    <div class="restaurant-list">
            </HeaderTemplate>
            <ItemTemplate>
                <div class="restaurant">
                    <div class="logo">
                        <asp:Image ID="RestaurantImage" runat="server" ImageUrl='<%# "ImagesSite/" + Eval("filepath") %>' AlternateText='<%# Eval("name") %>' />
                    </div>
                    <div class="restaurant-name">
                        <label><%# Eval("name") %></label>
                    </div>
                </div>
            </ItemTemplate>
            <FooterTemplate>
                </div>
            </FooterTemplate>
        </asp:Repeater>
        <div class="content">
            <hr class="Underline" />
        </div>
        <asp:Repeater ID="RptLv2" runat="server">
            <HeaderTemplate>
                <div class="content">
                    <div class="restaurant-level">
                        <label class="restaurant-list-heading">L2</label>
                    </div>
                    <div class="restaurant-list">
            </HeaderTemplate>
            <ItemTemplate>
                <div class="restaurant">
                    <div class="logo">
                        <asp:Image ID="RestaurantImage" runat="server" ImageUrl='<%# "ImagesSite/" + Eval("filepath") %>' AlternateText='<%# Eval("name") %>' />
                    </div>
                    <div class="restaurant-name">
                        <label><%# Eval("name") %></label>
                    </div>
                </div>
            </ItemTemplate>
            <FooterTemplate>
                </div>
            </FooterTemplate>
        </asp:Repeater>


        <div class="content">
            <hr class="Underline" />
        </div>

        <asp:Repeater ID="RptLv1" runat="server">
            <HeaderTemplate>
                <div class="content">
                    <div class="restaurant-level">
                        <label class="restaurant-list-heading">L1</label>
                    </div>
                    <div class="restaurant-list">
            </HeaderTemplate>
            <ItemTemplate>
                <div class="restaurant">
                    <div class="logo">
                        <asp:Image ID="RestaurantImage" runat="server" ImageUrl='<%# "ImagesSite/" + Eval("filepath") %>' AlternateText='<%# Eval("name") %>' />
                    </div>
                    <div class="restaurant-name">
                        <label><%# Eval("name") %></label>
                    </div>
                </div>
            </ItemTemplate>
            <FooterTemplate>
                </div>
            </FooterTemplate>
        </asp:Repeater>

        <div class="content">
            <hr class="Underline" />
        </div>

        <asp:Repeater ID="RptBase" runat="server">
            <HeaderTemplate>
                <div class="content">
                    <div class="restaurant-level">
                        <label class="restaurant-list-heading">Basement</label>
                    </div>
                    <div class="restaurant-list">
            </HeaderTemplate>
            <ItemTemplate>
                <div class="restaurant">
                    <div class="logo">
                        <asp:Image ID="RestaurantImage" runat="server" ImageUrl='<%# "ImagesSite/" + Eval("filepath") %>' AlternateText='<%# Eval("name") %>' />
                    </div>
                    <div class="restaurant-name">
                        <label><%# Eval("name") %></label>
                    </div>
                </div>
            </ItemTemplate>
            <FooterTemplate>
                </div>
            </FooterTemplate>
        </asp:Repeater>

    </article>
</asp:Content>
