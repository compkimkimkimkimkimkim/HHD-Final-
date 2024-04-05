<%@ Page Language="C#" MasterPageFile="~/CMS.Master" AutoEventWireup="true" CodeBehind="LocationCMS.aspx.cs" Inherits="HHD.UserInterfaceLayer.CMS.LocationCMS" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="../Content/CMSCss/SiteCMS.css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <article>
        <div class="cont">
            <div class="cmstitledivcover">
                <div class="cmstitlediv">
                    <label class="cmstitle">Location Page Title Image</label>
                </div>
            </div>
            <div class="tablemenu">
                <div class="width90 adjust">
                    <label class="tablelabel">Title Image</label>
                </div>
                <div class="width10 adjust">
                    <label class="tablelabel">Action</label>
                </div>
            </div>
            <asp:Table ID="tbTitle" runat="server"></asp:Table>
        </div>
        <div class="cont">
            <div class="cmstitledivcover">
                <div class="cmstitlediv">
                    <label class="cmstitle">Campus Location</label>
                </div>
            </div>
            <div class="tablemenu">
                <div class="width45 adjust">
                    <label class="tablelabel">Campus Name</label>
                </div>
                <div class="width45 adjust">
                    <label class="tablelabel">Campus Location</label>
                </div>
                <div class="width10 adjust">
                    <label class="tablelabel">Action</label>
                </div>
            </div>

            <asp:Table ID="campus_tbl" class="tbl" runat="server"></asp:Table>
            <div class="divhr"></div>
            <div class="Tableadd">
                <asp:TextBox CssClass="Tbaddnew" runat="server" ID="txtCampusName" placeholder="Name"></asp:TextBox>
                <asp:TextBox CssClass="Tbaddnew" runat="server" ID="txtCampusLocation" placeholder="Location"></asp:TextBox>
                <br />
                <asp:Button CssClass="Tbaddbtn" runat="server" ID="btnAddCampus" Text="Add" OnClick="btnAddCampus_Click" />
              <asp:Button CssClass="Tbaddbtn" runat="server" ID="btnCancelCampus" Text="Cancel" OnClick="btnCancelCampus_Click" />
            </div>
        </div>
        <div class="cont">
            <div class="cmstitledivcover">
                <div class="cmstitlediv">
                    <label class="cmstitle">Mrt Stations nearby</label>
                </div>
            </div>
            <div class="tablemenu">
                <div class="width30 adjust">
                    <label class="tablelabel">MRT Line Colour</label>
                </div>
                <div class="width40 adjust">
                    <label class="tablelabel">MRT Station Name</label>
                </div>
                <div class="width10 adjust">
                    <label class="tablelabel">Distance</label>
                </div>
                <div class="width10 adjust">
                    <label class="tablelabel">Minutes</label>
                </div>
                <div class="width10 adjust">
                    <label class="tablelabel">Action</label>
                </div>
            </div>
            <asp:Table ID="cmstitledivcover_tbl" class="tbl" runat="server"></asp:Table>
            <div class="divhr"></div>
            <div class="Tableadd">
                <asp:TextBox CssClass="Tbaddnew" runat="server" ID="txtMrtColour" placeholder="MRT Line Colour"></asp:TextBox>
                <asp:TextBox CssClass="Tbaddnew" runat="server" ID="txtMrtName" placeholder="MRT Station Name"></asp:TextBox>
                <br />
                <asp:TextBox CssClass="Tbaddnew" runat="server" ID="txtMrtLong" placeholder="Distance from MRT to Campus"></asp:TextBox>
                <asp:TextBox CssClass="Tbaddnew" runat="server" ID="txtMrtMins" placeholder="Minutes from MRT to Campus"></asp:TextBox>
                <br />
                <asp:Button CssClass="Tbaddbtn" runat="server" ID="btnAddMrt" Text="Add" OnClick="btnAddMrt_Click" />
                <asp:Button CssClass="Tbaddbtn" runat="server" ID="btnCancelMrt" Text="Cancel" OnClick="btnCancelMrt_Click" />
            </div>
        </div>
        <div class="cont">
            <div class="cmstitledivcover">
                <div class="cmstitlediv">
                    <label class="cmstitle">Bus Stations nearby</label>
                </div>
            </div>
            <div class="tablemenu">
                <div class="width20 adjust">
                    <label class="tablelabel">Name of Bus Stop</label>
                </div>
                <div class="width70 adjust">
                    <label class="tablelabel">Bus Numbers</label>
                </div>
                <div class="width10 adjust">
                    <label class="tablelabel">Action</label>
                </div>
            </div>


            <asp:Table ID="bus_tbl" class="tbl" runat="server"></asp:Table>
            <div class="divhr"></div>
            <div class="Tableadd">
                <asp:TextBox CssClass="Tbaddnewlong" runat="server" ID="txtBusName" placeholder="Name of Bus Stops"></asp:TextBox>
                <br />
                <asp:TextBox CssClass="Tbaddnewbig" runat="server" ID="txtBusNumber" placeholder="Bus Numbers"></asp:TextBox>
                <br />
                <asp:Button CssClass="Tbaddbtn" runat="server" ID="btnAddBus" Text="Add" OnClick="btnAddBus_Click" />
                <asp:Button CssClass="Tbaddbtn" runat="server" ID="btnCancelBus" Text="Cancel" OnClick="btnCancelBus_Click" />
            </div>
        </div>
    </article>
</asp:Content>
