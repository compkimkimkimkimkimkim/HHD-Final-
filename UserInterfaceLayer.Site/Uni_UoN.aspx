<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Uni_UoN.aspx.cs" Inherits="HHD.UserInterfaceLayer.Site.Uni_UoN" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="../../Content/SiteCss/Uni_UoN.css">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <article>
        <div class="page">
            <asp:Repeater ID="MainTitle_Contain" runat="server">
                <ItemTemplate>
                    <div class="banner">
                        <asp:Image runat="server" ImageUrl='<%# "ImagesSite/" + Eval("Images") %>' />
                        <div class="message">
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
            <asp:Repeater ID="rptview" runat="server">
                <ItemTemplate>
                    <div class="overview">
                        <div class="title">
                            <h1><%# Eval("Title") %></h1>
                            <div class="line"></div>
                        </div>

                        <div class="content">
                            <div class="inner">
                                <div class="left">
                                    <img src="<%# "ImagesSite/" + Eval("Images") %>">
                                </div>
                                <div class="right">
                                    <p>
                                        <%# Eval("Content") %>
                                    </p>
                                </div>
                            </div>
                        </div>
                    </div>
                </ItemTemplate>
            </asp:Repeater>


            <div class="performance">
                <div class="top">
                    <h2>Performance on the world stage</h2>
                    <div class="line"></div>
                    <div class="content">
                        The University of Newcastle continues to build its global reputation for being one of the world's most prestigious universities.
                   
                    </div>
                </div>
                <div class="bottom">
                    <asp:Repeater ID="rptTop" runat="server">
                        <ItemTemplate>
                            <div class="item">
                                <img src="<%# "ImagesSite/" + Eval("Images") %>">
                                <h3><%# "Top "+ Eval("Rank") %></h3>
                                <div class="content"><%# Eval("Description") %></div>
                            </div>
                        </ItemTemplate>
                    </asp:Repeater>


                </div>
            </div>

            <div class="school-logo">
                <img src="../UserInterfacelayer.Site/ImagesSite/Logo.png">
            </div>

            <div runat="server" id="arrItemOtherContents" class="chancellor-message">
                <div class='itemOtherContent'>
                    <h1></h1>
                    <div class='line-wrap'>
                        <div class='line'></div>
                    </div>
                    <div class='light'></div>
                    <p class='message-cont'>
                    </p>
                    <div class='sign'>
                        <img src='ImagesSite/'>
                    </div>
                </div>
            </div>
        </div>
    </article>
</asp:Content>
