<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AboutUs.aspx.cs" Inherits="HHD.UserInterfaceLayer.Site.AboutUs" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="../Content/SiteCss/AboutUs.css"/>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <article>
        <div class="imgcont">
            <asp:Image runat="server" ID="imgTitle"  ImageUrl="~/UserInterfaceLayer.Site/ImagesSite/aboutustitle.png" />
        </div>

        <div class="membercont">
            <div class="conttitle">
                <label>Meet the Project Members.</label>
            </div>
            <asp:Repeater ID="rptAboutUs" runat="server">
                <ItemTemplate>
                    <div class="memberbox">
                        <div class="memberimg">
                            <asp:Image runat="server" ImageUrl='<%# "ImagesSite/" + Eval("Images") %>' />
                        </div>
                        <div class="memberinfo">
                            <h2><%# Eval("Name") %></h2>
                            <h4><%# Eval("Major") %><br /></h4>
                            <label><%# Eval("Ambitions") %></label>
                        </div>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </div>

        <div class="toolcont">
            <div class="conttitle">
                <label>Tools Used During the Project.</label>
            </div>
            <div class="toolbox">    
                <asp:Repeater ID="AbouUsType2" runat="server">
                    <ItemTemplate>
                        <div class="toolinfo">
                            <div class="toolimg">
                                <asp:Image runat="server" ImageUrl='<%# "ImagesSite/" + Eval("Images") %>' />
                            </div>
                            <div class="toolname">
                                <label><%# Eval("Name") %></label>
                            </div>
                        </div>
                    </ItemTemplate>
                </asp:Repeater>
            </div>
        </div>

    </article>
</asp:Content>