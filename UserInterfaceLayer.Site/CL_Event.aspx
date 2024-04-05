<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CL_Event.aspx.cs" Inherits="HHD.UserInterfaceLayer.Site.CL_Event"%>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="../Content/SiteCss/CL_Event.css"/>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <article>
        <asp:Repeater ID="MainTitle_Containt" runat="server">
            <itemtemplate>
                <div class="content_1">
                    <asp:Image runat="server" ImageUrl='<%# "ImagesSite/" + Eval("EventPoster") %>' />
                </div>
            </itemtemplate>
            </asp:Repeater>
        <%--CURRENT EVENT LIST--%>
            <div class="content_2">
                <div class="hearder_content2"><label>CURRENT EVENT LIST</label></div>

                <div class="subcontent_content_2">

                            <asp:Repeater ID="Current_Container" runat="server">
                                <ItemTemplate>      
                                    <div class="sub_content subcontent1_content_2">            
                                        <asp:Image  runat="server" Id="MainTitle" ImageUrl='<%# "ImagesSite/" + Eval("EventPoster") %>' CssClass="image_content" />
                                    </div>
                                </ItemTemplate>
                            </asp:Repeater>
                </div>
            </div>
           
        <%--UPCOMING EVENT LIST--%>
            <div class="content_2">
                <div class="hearder_content2"><label>UPCOMING EVENT LIST</label></div>
                <div class="subcontent_content_2">
                    
                        <asp:Repeater ID="UpComing_Container" runat="server">
                            <ItemTemplate>      
                                <div class="sub_content subcontent1_content_2">            
                                    <asp:Image  runat="server" ImageUrl='<%# "ImagesSite/" + Eval("EventPoster") %>' CssClass="image_content" />
                                </div>
                            </ItemTemplate>
                        </asp:Repeater>
                    
                </div>
            </div>
        <%-- PAST EVEN LIST --%>
            <div class="content_2">
                <div class="hearder_content2"><label>LAST EVENT LIST</label></div>
                <div class="subcontent_content_2">
                    
                        <asp:Repeater ID="Past_Container" runat="server">
                            <ItemTemplate>      
                                <div class="sub_content subcontent1_content_2">            
                                    <asp:Image  runat="server" ImageUrl='<%# "ImagesSite/" + Eval("EventPoster") %>' CssClass="image_content" />
                                </div>
                            </ItemTemplate>
                        </asp:Repeater>
                    
                </div>
            </div>
    </article>
</asp:Content>
