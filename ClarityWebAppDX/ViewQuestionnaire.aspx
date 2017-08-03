<%@ Page Title="" Language="C#" MasterPageFile="~/ContentMaster.Master" AutoEventWireup="true" CodeBehind="ViewQuestionnaire.aspx.cs" Inherits="ClarityWebAppDX.ViewQuestionnaire" %>
<%@ Register Assembly="DevExpress.Web.v16.2, Version=16.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="BodyContent" runat="server">
    <div class="row">
        <div class="col-xs-12 toolbar-row">
            <span class="toolbar-title">View Questionnaire</span>
        </div>
    </div>
    <br />
    <div class="row">
        <div class="col-xs-12">
            <div class="card paddedCard cardShadow fullwidth">
                <div class="col-md-12">
                    <dx:ASPxComboBox ID="cmbQuestionnaireList" runat="server" Caption="Selected Questionnaire" Width="100%" OnDataBound="cmbQuestionnaireList_DataBound" ValueType="System.Int32" AutoPostBack="true" OnSelectedIndexChanged="cmbQuestionnaireList_SelectedIndexChanged">
                       
                    </dx:ASPxComboBox>
                    <hr class="divider"/>

                    <dx:ASPxGridView ID="QuestionsGridView" runat="server" Width="100%" AutoGenerateColumns="False" OnDataBinding ="QuestionsGridView_DataBinding" KeyFieldName="QID">
                        <Settings ShowColumnHeaders="false" />
                        <SettingsDetail ShowDetailRow="true" ShowDetailButtons="true"  AllowOnlyOneMasterRowExpanded="true"/>
                        <SettingsPager PageSize="15"></SettingsPager>
                        <SettingsBehavior AllowGroup="False" AllowSort="False" />
                        <SettingsDataSecurity AllowDelete="False" AllowEdit="False" AllowInsert="False" />
                        <Columns>
                            <dx:GridViewDataTextColumn Caption="QAID" FieldName="QID" Visible="False" VisibleIndex="0">
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn Caption="Question Text" FieldName="QuestionText" VisibleIndex="1" Width="100%">
                            </dx:GridViewDataTextColumn>
                        </Columns>
                        <Templates>
                            <DetailRow>
                                <dx:ASPxGridView ID="AnswersGridView" runat="server" Width="100%" OnInit="AnswersGridView_Init">
                                    <Settings ShowColumnHeaders="false" />
                                    <SettingsBehavior AllowGroup="False" AllowSort="False" />
                                    <SettingsDataSecurity AllowDelete="False" AllowEdit="False" AllowInsert="False" />
                                    <Columns>
                                        <dx:GridViewDataTextColumn Caption="AnswerID" FieldName="AnswerID" Visible="False" VisibleIndex="0">
                                        </dx:GridViewDataTextColumn>
                                        <dx:GridViewDataTextColumn Caption="Answer Text" FieldName="AnswerText" VisibleIndex="1" Width="100%">
                                        </dx:GridViewDataTextColumn>
                                    </Columns>
                                </dx:ASPxGridView>
                            </DetailRow>
                        </Templates>
                    </dx:ASPxGridView>
                    <br /><br />

                </div>
            </div>
        </div>
    </div>
</asp:Content>
