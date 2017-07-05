<%@ Page Title="" Language="C#" MasterPageFile="~/ContentMaster.Master" AutoEventWireup="true" CodeBehind="EditQuestionnaire.aspx.cs" Inherits="ClarityWebAppDX.EditQuestionnairePage" %>

<%@ Register Assembly="DevExpress.Web.v16.2, Version=16.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="BodyContent" runat="server">
    <div class="row">
        <div class="col-xs-12 toolbar-row">
            <span class="toolbar-title">Edit Questionnaire</span>
        </div>
    </div>

    <div class="row">
        <div class="col-xs-12 card paddedCard cardShadow">                
            <h3>Questionnaire Details</h3>
            <hr class="divider"/>
            <div class="col-md-6">
                <dx:ASPxComboBox ID="cmbQuestionnaireList" runat="server" Caption="Selected Questionnaire" Width="100%" OnDataBound="cmbQuestionnaireList_DataBound" ValueType="System.Int32"></dx:ASPxComboBox>
            </div>
            <div class="col-md-6">
                <dx:ASPxVerticalGrid ID="vgConfigList" runat="server" Width="100%"></dx:ASPxVerticalGrid>
            </div>
        </div>
    </div>

</asp:Content>
