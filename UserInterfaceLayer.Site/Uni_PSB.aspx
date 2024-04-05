<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Uni_PSB.aspx.cs" Inherits="HHD.UserInterfaceLayer.Site.Uni_PSB" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="../Content/SiteCss/Uni_PSB.css" type="text/css" />

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <article>
        <div class="page">
            <asp:Repeater ID="MainTitle_Contain" runat="server">
                <ItemTemplate>
                    <div class="Banner">
                        <asp:Image runat="server" ImageUrl='<%# "ImagesSite/" + Eval("Images") %>' />
                        <div class="Message">
                            <h1>
                                <%# Eval("Title") %>
                            </h1>
                            <p>
                                <%# Eval("Content") %>
                            </p>
                        </div>
                    </div>
                </ItemTemplate>
            </asp:Repeater>

            <asp:Repeater ID="OverView_Contain" runat="server">
                <HeaderTemplate>
                    <div class="title">
                        <h1>Overview</h1>
                        <div class="line"></div>
                    </div>
                </HeaderTemplate>
                <ItemTemplate>
                    <div class="content">
                        <div class="inner">
                            <div class="left">
                                <p>
                                    <%# Eval("Title") %>
                                </p>
                            </div>
                            <div class="right">
                                <asp:Image runat="server" ImageUrl='<%# "ImagesSite/" + Eval("Images") %>' />
                            </div>
                        </div>

                    </div>
                </ItemTemplate>
            </asp:Repeater>

            <div class="partners">
                <div class="title">
                    <h1>University partners</h1>
                    <div class="line"></div>
                    <div class="desc">
                        Developed as launchpads to your ideal industry, our diplomas allow you to progress to degrees offered by our
                international 
                    </div>
                </div>

                <div class="content">
                    <div class="row" id="RptPsb" runat="server"></div>
                </div>

            </div>
            <div class="effort">
                <asp:Repeater ID="RptTitle" runat="server">
                    <HeaderTemplate>
                    </HeaderTemplate>
                    <ItemTemplate>
                        <div class="title">
                            <h1><%# Eval("Title") %></h1>
                            <div class="line"></div>
                        </div>
                        <div class="desc">
                            <p>
                                <%# Eval("Content") %>
                            </p>
                        </div>
                    </ItemTemplate>
                </asp:Repeater>
                <div class="img">
                    <img src="../UserInterfacelayer.Site/ImagesSite/PSB_Effort.png">
                </div>
            </div>
        </div>
    </article>
</asp:Content>
