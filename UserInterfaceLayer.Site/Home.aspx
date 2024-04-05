<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="HHD.UserInterfaceLayer.Site.Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="../Content/SiteCss/Home.css" type="text/css" />
    <script src="Scripts/SiteJs/Home.js"></script>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.7.1/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js"></script>
    <style>
        .navcont {
            cursor: pointer;
        }

        .navlink {
            text-decoration: none !important;
            font-size: 20px;
            color: whitesmoke;
            text-decoration-line: none;
        }

        nav {
            height: 70px;
            background-color: #202124;
            overflow: hidden;
            white-space: nowrap;
            display: flex !important;
            justify-content: space-between;
            position: fixed;
            top: 0;
            left: 0;
            right: 0;
            z-index: 10;
        }

        .dropdown {
            position: fixed !important;
            display: none;
        }

            .dropdown a {
                display: grid;
                text-decoration-line: none;
                color: black;
                font-size: 15px;
                padding-top: 5px;
                border-bottom: 1px solid #ccc;
            }

        .sublink {
            padding: 10px;
        }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <article>
        <div class="cel">
            Current Event List
        </div>

        <div id="rptCurrent" runat="server">
        </div>
        <div class="wsc">
            <h3>Welcome to Singapore Campus</h3>
            <div class="image-gallery">
                <div class="image-item">
                    <a href="CL_Location.aspx">
                        <asp:Image runat="server" ID="imgCL_Location" ImageUrl="ImagesSite/ntc.png" />
                    </a>
                    <div class="image-caption" runat="server" id="txt_CL_Location">Navigate to Campus</div>
                </div>
                <div class="image-item">
                    <a href="CL_MarinaSquare.aspx">
                        <asp:Image runat="server" ID="imgCL_MarinaSquare" ImageUrl="~/UserInterfaceLayer.Site/ImagesSite/about_ms.png" />
                    </a>
                    <div runat="server" id="txt_CL_MarinaSquare" class="image-caption">About Marina Square</div>
                </div>
                <div class="image-item">
                    <a href="CL_StudentClub.aspx">
                        <asp:Image runat="server" ID="imgCL_StudentClub" ImageUrl="~/UserInterfaceLayer.Site/ImagesSite/student_club.png" />
                    </a>
                    <div class="image-caption" runat="server" id="txt_CL_StudentClub">Student Club</div>
                </div>
            </div>
        </div>
        <div class="ou">
            <div class="ou-left">
                <h3>Our University</h3>
                <p runat="server" id="txt_OurUni">
                    The University of Newcastle Singapore
                    campus exists within the PSB Academy as a 
                    partnership with the PSB Academy.
                </p>
                <div class="ou-left-mtop">
                    <p>*Are you first-year student?</p>
                    <div class="mtopbtn">
                        <a href="Uni_Orientation.aspx">Step into new Beginning</a>
                    </div>
                </div>
            </div>
            <div class="ou-right">
                <div class="ou-right-left">
                    <div class="unicont">
                        <div class="uniname">
                            <label>The University of</label>
                            <h3>Newcastle</h3>
                        </div>
                        <p runat="server" id="txt_University_of_NewCastle">Our university is ranked in the top 175 of the world's universities and stands as a global leader distinquished by our commitment to equity and excellence.</p>
                    </div>
                    <asp:Button CssClass="learn_more" runat="server" OnClick="uonbtn" Text="Learn more" />
                </div>
                <div class="ou-right-right">
                    <div class="unicont">
                        <div class="uniname">
                            <h3>PSB Academy</h3>
                        </div>
                        <p runat="server" id="txt_PSB_Academy">PSB Academy is one of Singapore's leading private educational institutions, producing more than 200,000 learners for nearly 60 years.</p>
                    </div>
                    <asp:Button CssClass="learn_more" runat="server" OnClick="psbbtn" Text="Learn more" />
                </div>
            </div>
        </div>
        <div class="cwf">
            <div class="cwf-left">
                <div class="cwf-left-main">
                    <h3>Communicate With Friends</h3>
                    <p runat="server" id="txt_Communicate">
                        Share Your Experiences About UoN Singapore Campus On The
                        Community! Post Freely And show Support With A Simple Click Of The
                        Heart Button.
                    </p>
                    <div class="mtopbtn2">
                        <a href="Community.aspx">View Community</a>
                    </div>
                </div>
            </div>
            <div class="cwf-right">
                <asp:Image runat="server" ID="imgCommunicate" ImageUrl="~/UserInterfaceLayer.Site/ImagesSite/home2.png" />
            </div>
        </div>

        <div class="reviewcon">
            <div class="reviewh1">
                <a class="reviewtext">Testimonials on Our Website</a>
            </div>
            <div class="image-gallery">
                <asp:Repeater ID="rptVideo" runat="server">
                    <ItemTemplate>
                        <div class="reviewvideo">
                            <iframe class="review" src="<%# Eval("Link") %>" title="rose" frameborder="0" allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share" referrerpolicy="strict-origin-when-cross-origin" allowfullscreen></iframe>
                        </div>
                    </ItemTemplate>
                </asp:Repeater>
            </div>
        </div>

    </article>
    <script type="text/javascript" src="/Scripts/SiteJs/Home.js"></script>
</asp:Content>
