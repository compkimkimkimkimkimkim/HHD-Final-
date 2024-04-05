<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CL_Location.aspx.cs" Inherits="HHD.UserInterfaceLayer.Site.CL_Location" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="../Content/SiteCss/CL_Location.css" type="text/css" />

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <article>
        <div class="location-top">
            <asp:Image runat="server" ID="imgTitle" ImageUrl="~/UserInterfaceLayer.Site/ImagesSite/vos.png" />
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
                <label class="lbl1">University of Newcastle’s Singapore Campus at Marina Square</label>
            </div>
        </div>

        <div class="location-map">
            <p>Campus Location</p>
            <div id="map">
                <iframe src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d1994.4026921592576!2d103.85802303846779!3d1.2911041208111407!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x31da197f38ae8cad%3A0xf0cc7e9c37d34d23!2sPSB%20Academy%20City%20Campus%3A%20Main%20Wing!5e0!3m2!1szh-EN!2sjp!4v1705332742931!5m2!1szh-EN!2sjp"
                    allowfullscreen="" loading="lazy" referrerpolicy="no-referrer-when-downgrade"></iframe>
            </div>
        </div>

        <div class="city-campus">
            <div class="city-campus-main">
                <asp:Repeater ID="RptCity" runat="server">
                    <ItemTemplate>
                        <p>
                            <%# Eval("LocaltionName") %><br />
                            <%# SplitAddress(Eval("LocaltionAddress").ToString()) %><br />

                        </p>
                    </ItemTemplate>
                </asp:Repeater>
            </div>
        </div>


        <div class="msn">
            <p>Mrt Stations nearby</p>
            <div class="msn-mrt">
                <div class="msn-mrt-item">
                    <asp:Repeater ID="rptstation1" runat="server">

                        <ItemTemplate>
                            <div class="msn-mrt-item-top">
                                <div class="msn-mrt-item-icon">
                                    <div class="msn-mrt-item-icon-left"></div>
                                    <div class="msn-mrt-item-icon-right"></div>
                                </div>
                                <p><%# Eval("LocaltionName") %></p>
                            </div>
                            <div class="msn-mrt-item-bottom">
                                <asp:Image runat="server" ImageUrl="~/UserInterfaceLayer.Site/ImagesSite/MRT.png" />
                                <p><%# Eval("Distance") %>m </p>
                                <p>(<%# Eval("Minutes") %>mins)</p>
                            </div>
                        </ItemTemplate>

                    </asp:Repeater>

                </div>
                <div class="msn-mrt-item">
                    <asp:Repeater ID="Repeater1" runat="server">
                        <ItemTemplate>
                            <div class="msn-mrt-item-top">

                                <div class="msn-mrt-item-icon2">
                                </div>
                                <p><%# Eval("LocaltionName") %></p>
                            </div>
                            <div class="msn-mrt-item-bottom">
                                <asp:Image runat="server" ImageUrl="~/UserInterfaceLayer.Site/ImagesSite/MRT.png" />
                                <p><%# Eval("Distance") %>m  </p>
                                <p>(<%# Eval("Minutes") %>mins)</p>
                            </div>
                        </ItemTemplate>

                    </asp:Repeater>

                </div>
                <div class="msn-mrt-item">
                    <asp:Repeater ID="Repeater2" runat="server">
                        <ItemTemplate>
                            <div class="msn-mrt-item-top">
                                <div class="msn-mrt-item-icon">
                                    <div class="msn-mrt-item-icon-left3"></div>
                                    <div class="msn-mrt-item-icon-right3"></div>
                                </div>
                                <p><%# Eval("LocaltionName") %></p>
                            </div>
                            <div class="msn-mrt-item-bottom">
                                <asp:Image runat="server" ImageUrl="~/UserInterfaceLayer.Site/ImagesSite/MRT.png" />
                                <p><%# Eval("Distance") %>m  </p>
                                <p>(<%# Eval("Minutes") %>mins)</p>
                            </div>
                        </ItemTemplate>
                    </asp:Repeater>

                </div>
            </div>
        </div>



        <div class="bus">
            <p class="bsn">Bus Stations nearby</p>
            <asp:Repeater ID="RptBus1" runat="server">

                <ItemTemplate>
                    <div class="bus-plpp">
                        <p><%# Eval("LocaltionName") %></p>
                        <div class="bus-plpp-card">
                            <div class="bus-plpp-card-left">
                                <asp:Image runat="server" ImageUrl="~/UserInterfaceLayer.Site/ImagesSite/bus.png" />
                            </div>
                            <div class="bus-plpp-card-right">
                                <div class="bus-plpp-card-right">
                                    <%# RenderBusNumbers(Eval("BusNumbers").ToString()) %>
                                </div>
                            </div>
                        </div>
                    </div>

                </ItemTemplate>
            </asp:Repeater>
        </div>


    </article>
</asp:Content>
