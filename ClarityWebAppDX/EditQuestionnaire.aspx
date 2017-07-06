﻿<%@ Page Title="" Language="C#" MasterPageFile="~/ContentMaster.Master" AutoEventWireup="true" CodeBehind="EditQuestionnaire.aspx.cs" Inherits="ClarityWebAppDX.EditQuestionnairePage" %>

<%@ Register Assembly="DevExpress.Web.v16.2, Version=16.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <script src="Helpers/EditQuestionnaire.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="BodyContent" runat="server">
    <div class="row">
        <div class="col-xs-12 toolbar-row">
            <span class="toolbar-title">Edit Questionnaire</span>
        </div>
    </div>

    <div class="row">
        <div class="col-xs-12">
            <div class="card paddedCard cardShadow">
                <h3>Questionnaire Details</h3>
                <hr class="divider"/>
                <div class="col-md-6">
                    <dx:ASPxComboBox ID="cmbQuestionnaireList" runat="server" Caption="Selected Questionnaire" Width="100%" OnDataBound="cmbQuestionnaireList_DataBound" ValueType="System.Int32"></dx:ASPxComboBox>
                    <br />
                    <div class="row">
                        <div class="col-xs-6 text-center">
                            <dx:ASPxButton ID="cmdEditQuestionnaireName" runat="server" Text="Edit Questionnaire Name" RenderMode="Link" AutoPostBack="false" ClientInstanceName="cmdEditQuestionnaireName"></dx:ASPxButton>
                        </div>
                        <div class="col-xs-6 text-center">
                            <dx:ASPxButton ID="cmdEditConfiguration" runat="server" Text="Edit Configuration" RenderMode="Link" AutoPostBack="False" ClientInstanceName="cmdEditConfiguration">
                                <ClientSideEvents Click="OncmdEditConfigurationClick" />
                            </dx:ASPxButton>
                        </div>
                    </div>
                </div>
                <div class="col-md-6">
                    <dx:ASPxGridView ID="ConfigGridView" runat="server" ClientInstanceName="ConfigGridView" AutoGenerateColumns="False" KeyFieldName="ConfigID" Width="100%" CssClass="text-center"
                        OnCustomCallback="ConfigGridView_CustomCallback" OnDataBinding="ConfigGridView_DataBinding" OnRowUpdating="ConfigGridView_RowUpdating" OnRowUpdated="ConfigGridView_RowUpdated">
                        <SettingsPager Visible="False">
                        </SettingsPager>
                        <SettingsDataSecurity AllowDelete="False" AllowInsert="False" />

                        <Columns>
                            <dx:GridViewCommandColumn ShowEditButton="True" Visible="False" VisibleIndex="0" Name="ConfigEditColumn">
                            </dx:GridViewCommandColumn>
                            <dx:GridViewDataTextColumn Caption="Configuration Name" Name="ConfigurationName" VisibleIndex="2" FieldName="ConfigurationName" ReadOnly="True">
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn Caption="Configuration Value" Name="ConfigurationValue" VisibleIndex="3" FieldName="ConfigurationValue">
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn Caption="ConfigurationID" Name="ConfigurationID" Visible="False" VisibleIndex="1" FieldName="ConfigID">
                            </dx:GridViewDataTextColumn>
                        </Columns>

                    </dx:ASPxGridView>
                </div>
            </div>
        </div>
    </div>

</asp:Content>
