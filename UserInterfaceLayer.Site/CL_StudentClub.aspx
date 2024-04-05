<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="~/UserInterfaceLayer.Site/CL_StudentClub.aspx.cs" Inherits="HHD.UserInterfaceLayer.Site.CL_StudentClub" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="../Content/SiteCss/CL_StudentClub.css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <article>
        <asp:Repeater ID="MainTitle_Contain" runat="server">
            <ItemTemplate>
                <div class="content_1">
                    <asp:Image runat="server" ImageUrl='<%# "ImagesSite/" + Eval("Images") %>' />
                </div>
            </ItemTemplate>
        </asp:Repeater>

        <div class="nav_content_2">
            <div class="nav_content_2_item_active nav_content_2_item" id="nav_content_2_ISC">
                <div>Industry Student Chapters</div>
            </div>
            <div class="nav_content_2_item" id="nav_content_2_IG">
                <div>Interest Groups</div>
            </div>
            <div class="nav_content_2_item" id="nav_content_2_IC">
                <div>International Communities</div>
            </div>
        </div>
        <%-- Industry Club --%>
        <asp:Repeater ID="rptIndustryClub" runat="server">
            <ItemTemplate>
                <div class="content_2_item content_2_item_ISC">
                    <div class="content_2_item_title"><%# Eval("Name") %></div>
                    <div class="content_2_item_detail">
                        <asp:Image CssClass="content_2_item_detail_img" runat="server" ImageUrl='<%# "ImagesSite/" + Eval("Images") %>' />
                        <div class="content_2_item_detail_des">
                            <span class="content_2_item_detail_text"><%# Eval("Content") %></span>
                            <div class="content_2_item_detail_instagram">
                                <i class="fab fa-instagram"></i>
                                <a href='<%# Eval("Link") %>' target="_blank"><span class="text_instagram"><%# Eval("Link") %></span></a>

                            </div>
                        </div>
                    </div>
                </div>
            </ItemTemplate>
        </asp:Repeater>
        <%-- Interest Club --%>
        <asp:Repeater ID="rptInterestClub" runat="server">
            <ItemTemplate>
                <div class="content_2_item content_2_item_IG">
                    <div class="content_2_item_title"><%# Eval("Name") %></div>
                    <div class="content_2_item_detail">
                        <asp:Image CssClass="content_2_item_detail_img" runat="server" ImageUrl='<%# "ImagesSite/" + Eval("Images") %>' />
                        <div class="content_2_item_detail_des">
                            <span class="content_2_item_detail_text"><%# Eval("Content") %></span>
                            <div class="content_2_item_detail_instagram">
                                <i class="fab fa-instagram"></i>
                                <a href='<%# Eval("Link") %>' target="_blank"><span class="text_instagram"><%# Eval("Link") %></span></a>

                            </div>
                        </div>
                    </div>
                </div>
            </ItemTemplate>
        </asp:Repeater>
        <%-- International Club --%>
        <asp:Repeater ID="rptInternationalClub" runat="server">
            <ItemTemplate>
                <div class="content_2_item content_2_item_IC">
                    <div class="content_2_item_title"><%# Eval("Name") %></div>
                    <div class="content_2_item_detail">
                        <asp:Image CssClass="content_2_item_detail_img" runat="server" ImageUrl='<%# "ImagesSite/" + Eval("Images") %>' />
                        <div class="content_2_item_detail_des">
                            <span class="content_2_item_detail_text"><%# Eval("Content") %></span>
                            <div class="content_2_item_detail_instagram">
                                <i class="fab fa-instagram"></i>
                                <a href='<%# Eval("Link") %>' target="_blank"><span class="text_instagram"><%# Eval("Link") %></span></a>

                            </div>
                        </div>
                    </div>
                </div>
            </ItemTemplate>
        </asp:Repeater>
        <script src="../Scripts/SiteJs/CL_StudentClub.js"></script>
    </article>
</asp:Content>
