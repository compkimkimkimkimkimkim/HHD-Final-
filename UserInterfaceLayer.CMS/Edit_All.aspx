<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Edit_All.aspx.cs" MasterPageFile="~/CMS.Master"  Inherits="HHD.UserInterfaceLayer.CMS.Edit_All" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  <style>
      .ItemText, .ItemInput { display:table-cell; padding:7px 0; vertical-align:middle; height:38px; }
.ItemText.lblDESC{vertical-align: top;}
.ItemInput>.ItemInput{ padding:0; height:auto; }
.q-content .ItemRow label{ padding-right:10px; }
.ItemText { width:150px; padding-right:5px; word-break:break-word; }
.TextR { padding-left: 20px; }
.ItemText:empty, .ItemInput:empty{ display:none; }
.ItemInput span { display:inline-block; }
.DetailForm .ItemInput > span { border:1px #ccc solid; padding:6px; width:97.3%; background:#f2f2f2; border-radius:3px; }
.DetailForm .ItemInput > span.aspNetDisabled { padding:0; border:0; background: transparent; }
.DetailForm .four-col .ItemInput span { width:94%; min-height:28px; }
.ItemText label { color: #f00; }
div.icright {position: relative;}
div.icright .ic-search{ position:absolute; right:13px; top:17px; cursor:pointer; }
.ItemInput { width:auto; font-weight:600; word-break:break-word; }
.ItemInput>div{display:inline-block}
.ItemInput>div:empty{ display:none; }
.ItemInput>div.Buttons{ float:right; padding:0; margin-bottom:10px; }
.ItemInput>div.Buttons input{ height:auto; margin-left:0; }
.ItemInput>div.ClientPeoplePicker{display: block;}
.ItemInput:first-child { padding-left:0; }
.ItemInput label{font-weight:600;}
#FormContent_rdbGender>tbody tr{display:inline-block; vertical-align:middle; margin-right: 30px;}
.ItemInput #FormContent_rdbGender input[type=radio]{margin:0 6px 2px 0}
#Right_PanelImages img { width:auto!important; max-height:150px; }
div.k-multiselect .k-input{ font-family:"roboto", sans-serif; }
.ItemInput input { width:100%; height:32px; border-radius:3px; box-sizing:border-box; }
.ItemInput input[type=checkbox],.ItemInput input[type=radio],.ItemInput input[type=file],.ItemInput input[type=image]{width:auto; height:auto;}
.ItemInput input[type=file]{width:auto!important; display:block}
.ItemInput.fill-width input[type=text] { width:100%; }
.six-col .ItemInput input[type=text] { width:100%; }
.six-col .TextC, .six-col .TextR { padding-left:15px; }
.ItemInput input { border:1px #c5c5c5 solid; font-size:13px;padding-left:5px }
.ItemInput input[type=image] { border:0; }
.ItemInput select { width:100%; border:1px #c5c5c5 solid; min-height:32px; border-radius:3px; box-sizing:border-box; }
.ItemInput textarea { width: 86%; height: 120px; border: 1px #c5c5c5 solid; resize: vertical;}
.ItemInput input.btnUpload{ width:auto; padding:7px 20px; cursor:pointer; height:auto; }
.AdminThemeForm .img-preview{ width:auto!important; }
.AdminThemeForm .img-preview img{ max-width:50%; width:auto!important; }
.ItemInput.icsearch{ position:relative; }
.Buttons { padding:8px 0 10px; text-align:right; transition:all 0.3s ease 0s; position:relative; }
.container-body{margin-left: 222px;padding-top: 54px;}
  </style>
 <div class="col-group col-one">
            <div class="col-md col-md-12" visible="false"  runat="server" id="divName">
                <div class="ItemRow">
                    <div class="ItemText">
                        <span class="spLabel">Name</span>
                    </div>
                    <div class="ItemInput" style=" width: 86%">
                            <input type="text" runat="server" id="txtName" placeholder="Name"/>
                    </div>
                </div>
            </div>
            <div class="col-md col-md-12" visible="false"  runat="server" id="divLinkVideo">
                <div class="ItemRow">
                    <div class="ItemText">
                        <span class="spLabel">Video</span>
                    </div>
                    <div class="ItemInput" style=" width: 86%">
                            <input type="text" runat="server" id="txtLink" placeholder="Link"/>
                    </div>
                </div>
            </div>
            <div class="col-md col-md-12" visible="false"  runat="server" id="divTitle">
                <div class="ItemRow">
                    <div class="ItemText">
                        <span class="spLabel">Title</span>
                    </div>
                    <div class="ItemInput" style=" width: 86%">
                        <textarea runat="server" id="txtTitle" placeholder="Title"></textarea>
                    </div>
                </div>
            </div>
            <div class="col-md col-md-12"  visible="false"  runat="server" id="divContent">
                <div class="ItemRow">
                    <div class="ItemText">
                        <span class="spLabel">Content</span>
                    </div>
                    <div class="ItemInput" style=" width: 86%">
                        <textarea runat="server" id="txtContent" placeholder="Content"></textarea>
                    </div>
                </div>
            </div>
            <div class="col-md col-md-12"  visible="false"  runat="server" id="divDescription">
                <div class="ItemRow">
                    <div class="ItemText">
                        <span class="spLabel">Description</span>
                    </div>
                    <div class="ItemInput" style=" width: 86%">
                            <textarea runat="server" id="txtDescription" placeholder="Description"></textarea>
                    </div>
                </div>
            </div>
            <div class="col-md col-md-12" runat="server"  visible="false"  id="divImage">
                <div class="ItemRow">
                    <div class="ItemText lblImageThumb">
                        <span class="spLabel">Image</span>
                    </div>
                    <div class="ItemInput cntImageThumb">
                        <label id="lbClick" class="showImageFiles" data-value="" data-id="ImageThumb">Choose Image</label>
                        <asp:FileUpload CssClass="Picadd"  runat="server" ID="PSBFileUploadUni" />
                    </div>
                </div>
            </div>
        </div>
      <div class="Buttons" style="padding-right: 40px; border-bottom-color: transparent">
            <asp:Button CssClass="Tbaddbtn" runat="server" ID="btnSave" Text="Save" OnClick="btnSave_Click" />
        </div>
   </asp:Content>


