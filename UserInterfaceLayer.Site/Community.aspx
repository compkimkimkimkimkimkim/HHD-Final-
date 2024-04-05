<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Community.aspx.cs" Inherits="HHD.UserInterfaceLayer.Site.Community" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="../Content/SiteCss/Community.css" />
    <script src="../Scripts/SiteJs/Community.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <article>
        <div class="welcome">
            <h1 runat="server" ID="txt_Title">Welcome to Community Page</h1>
            <p runat="server" ID="txt_Content">Please share your thoughts and opinions about life in Singapore or school!</p>
        </div>
        <div class="category">
            <asp:Button CssClass="category_item selected" ID="btnCategoryAll" runat="server" Text='All' CommandArgument='0' OnClick="btnCategory_Click" />
            <asp:Repeater ID="rptCategories" runat="server">
                <ItemTemplate>
                    <asp:Button CssClass="category_item" ID="btnCategory" runat="server" Text='<%# Eval("Name") %>' CommandArgument='<%# Eval("Id") %>' OnClick="btnCategory_Click" />
                </ItemTemplate>
            </asp:Repeater>
        </div>
        <div class="line"></div>
        <div class="community">
            <div class="community_left">
                <div class="community_top">
                    <asp:Button CssClass="community_top_button" runat="server" Text="Create Post" ID="btnCreatePost" OnClick="btnCreatePost_Click" />
                </div>
                <div runat="server" ID="arrItem">
                     <div class='item'>
                        <h4>Submission Guidelines</h4>
                        <p>Articles And Discussions Should Be Directly Related To Campus Life InSingapore.</p>
                    </div>
                    <div class="item">
                        <h4>Copyright And Responsibility For Posts</h4>
                        <p>The Copyright Of The Posts (Including Comments) Posted In The Gallery Belongs To The Publisher Himself And Should Not Infringe On The Rights Of Others.</p>
                    </div>
                    <div class="item">
                        <h4>Post Deletion Criteria</h4>
                        <p>If You Post A Post That Corresponds To Wallpapers, Advertisements, Pornography, Abusive Language, Copyright Infringement, Or Personal Information Infringement, You Will Be Deleted Or Blocked, And You May Be Liable For Civil Or Criminal Charges.</p>
                    </div>
                </div>
            </div>
            <div class="community_center">
                <div class="community_top">
                    <div class="community_top_tip">
                        <p>Create the post or comment function that you want!</p>
                    </div>
                </div>



                <div class="community_list">
                    <asp:Repeater ID="rptCommunities" runat="server">
                        <ItemTemplate>
                            <div class="community_item" style='<%# Eval("Name").ToString() == "MR.ADMIN" ? "border: 2px solid red;" : "" %>'>
                                <div class="community_item_close">
                                    <div class="community_item_close_btn">X</div>
                                </div>
                                <div class="community_item_top">
                                    <div class="community_item_top_left" onclick="confirmEditDelete(<%# Eval("Id") %>, event)">
                                        <asp:Image runat="server" ImageUrl="~/UserInterfaceLayer.Site/ImagesSite/Community User.png" />
                                    </div>
                                    <div class="community_item_top_right">
                                        <div class="community_item_top_right_nametime">
                                           <div class="community_item_top_right_name" style='<%# Eval("Name").ToString() == "MR.ADMIN" ? "color: red;" : "" %>'><%# Eval("Name") %></div>

                                            <div class="community_item_top_right_time"><%# DataBinder.Eval(Container.DataItem, "CreationTime", "{0:dd/MM/yyyy}") %></div>
                                        </div>
                                        <div class="community_item_top_right_title">
                                            <h3><%# Eval("Title") %></h3>
                                        </div>
                                    </div>
                                </div>
                                <div class="community_content">
                                    <p><%# Eval("Content") %></p>
                                </div>
                                <div class="community_picture">
                                    <asp:Repeater ID="Repeater1" runat="server" DataSource='<%# Eval("Pictures") %>'>
                                        <ItemTemplate>
                                            <asp:Image runat="server" ImageUrl='<%# Eval("Path") %>' />
                                        </ItemTemplate>
                                    </asp:Repeater>
                                </div>
                                <div class="community_item_bottom">
                                    <div class="community_item_category">
                                        <asp:Repeater ID="rptItemCategorys" runat="server" DataSource='<%# Eval("Categories") %>'>
                                            <ItemTemplate>
                                                <p>#<%# Eval("CategoryName") %></p>
                                            </ItemTemplate>
                                        </asp:Repeater>
                                    </div>
                                    <div class="community_item_likecomment">
                                        <div class="community_item_comment">
                                            <asp:Image runat="server" ImageUrl="~/UserInterfaceLayer.Site/ImagesSite/Community Comment.png" />
                                            <h3><%# Eval("CommentCount") %></h3>
                                        </div>
                                    </div>
                                </div>
                                <div class="community_comment">
                                    <table>
                                        <asp:UpdatePanel ID="UpdatePanel" runat="server" UpdateMode="Conditional">
                                            <ContentTemplate>
                                                <asp:Repeater ID="rptItemComments" runat="server" DataSource='<%# Eval("Comments") %>'>
                                                    <ItemTemplate>
                                                        <tr onclick="confirmDelete(<%# Eval("Id") %>, event)">
                                                            <td class="first-column">
                                                                <div class="name_avatar">
                                                                    <div class="name_avatar_name"><%# Eval("Username") %></div>
                                                                    <asp:Image runat="server" ImageUrl="~/UserInterfaceLayer.Site/ImagesSite/Community User.png" />
                                                                </div>
                                                            </td>
                                                            <td class="second-column">
                                                                <%# Eval("Content") %>
                                                            </td>
                                                        </tr>
                                                    </ItemTemplate>
                                                </asp:Repeater>
                                            </ContentTemplate>
                                        </asp:UpdatePanel>
                                    </table>









                                    <div class="post_comment">
                                        <div class="post_comment_left">
                                            <input id="txbName" runat="server" placeholder="Name" />
                                            <input id="txbPassword" type="password" runat="server" placeholder="PASSWORD" />
                                        </div>
                                        <div class="post_comment_right">
                                            <textarea placeholder="Please Leave a Comment Here" id="txContent" runat="server"></textarea>
                                        </div>
                                    </div>
                                    <div class="bottom_button">
                                        <asp:Button CssClass="btn_post" ID="btnPost" runat="server" CommandArgument='<%# Eval("Id") %>' Text='Registration' OnClientClick="return handleButtonClick(event);" OnClick="btnPost_Click" />
                                    </div>
                                </div>
                            </div>
                        </ItemTemplate>
                    </asp:Repeater>
                    <div class="community_page">
                        <asp:LinkButton ID="lnkFirst" runat="server" OnClick="lnkFirst_Click"><<</asp:LinkButton>
                        <asp:LinkButton ID="lnkPrevious" runat="server" OnClick="lnkPrevious_Click"><</asp:LinkButton>
                        <asp:Repeater ID="rptPages" runat="server" OnItemCommand="rptPages_ItemCommand">
                            <ItemTemplate>
                                <asp:LinkButton ID="lnkPage" runat="server" CommandName="Page" CommandArgument='<%# Eval("PageIndex") %>' CssClass='<%# GetPageCssClass(Convert.ToInt32(Eval("PageIndex"))) %>'><%# Eval("PageIndex") %></asp:LinkButton>
                            </ItemTemplate>
                        </asp:Repeater>
                        <asp:LinkButton ID="lnkNext" runat="server" OnClick="lnkNext_Click">></asp:LinkButton>
                        <asp:LinkButton ID="lnkLast" runat="server" OnClick="lnkLast_Click">>></asp:LinkButton>
                    </div>
                </div>
            </div>









            <div class="community_right">
                <div class="community_top"></div>
                <a href="CL_Event.aspx">
                    <asp:Image runat="server" ImageUrl="~/UserInterfaceLayer.Site/ImagesSite/Community Ad1.png" />
                </a>
                <a href="CL_StudentClub.aspx" class="CL_StudentClub">
                    <asp:Image runat="server" ImageUrl="~/UserInterfaceLayer.Site/ImagesSite/Community Ad2.png" />
                </a>
            </div>
        </div>
        <div class="line"></div>
        <div id="passwordPrompt" class="password-prompt" runat="server">
            <div class="password-prompt-content">
                <input id="txtID" runat="server" type="hidden" />
                Password：<asp:TextBox ID="txtPassword" runat="server" TextMode="Password" /><br />
                <asp:Button ID="btnConfirm" runat="server" Text="Confirm" OnClick="btnConfirm_Click" />
                <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" />
            </div>
        </div>
        <div id="edit_delete" class="password-prompt" runat="server">
            <div class="password-prompt-content">
                <input id="txtCommunityID" runat="server" type="hidden" />
                Password：<asp:TextBox ID="txtCommunityPassword" runat="server" TextMode="Password" /><br />
                <asp:Button ID="btnCommunityEdit" runat="server" Text="Edit" OnClick="btnCommunityEdit_Click" />
                <asp:Button ID="btnCommunityDelete" runat="server" Text="Delete" OnClick="btnCommunityDelete_Click" />
                <asp:Button ID="btnCommunityCancel" runat="server" Text="Cancel" OnClick="btnCommunityCancel_Click" />
            </div>
        </div>
    </article>
</asp:Content>
