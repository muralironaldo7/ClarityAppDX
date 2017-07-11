<%@ Page Title="" Language="C#" MasterPageFile="~/ContentMaster.Master" AutoEventWireup="true" CodeBehind="EditQuestionnaire.aspx.cs" Inherits="ClarityWebAppDX.EditQuestionnairePage" %>

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
    <br />
    <div class="row">
        <div class="col-xs-12">
            <div class="card paddedCard cardShadow">
                <h3>Questionnaire Details</h3>
                <hr class="divider"/>
                <div class="col-md-6">
                    <dx:ASPxComboBox ID="cmbQuestionnaireList" runat="server" Caption="Selected Questionnaire" Width="100%" OnDataBound="cmbQuestionnaireList_DataBound" ValueType="System.Int32" AutoPostBack="true" OnSelectedIndexChanged="cmbQuestionnaireList_SelectedIndexChanged">
                        
                    </dx:ASPxComboBox>
                    <br />
                    <div class="row">
                         <div class="col-xs-10 text-center">
                             <dx:ASPxTextBox ID="txtQuestionnaireName" runat="server" Width="100%" Caption="Questionnaire Name" ClientInstanceName="txtQuestionnaireName" Enabled="False" ClientIDMode="Static" Visible="false"></dx:ASPxTextBox>
                        </div>
                        <div class="col-xs-2 text-center">
                            <dx:ASPxButton ID="cmdEditQuestionnaireName" runat="server" Text="Edit Name" RenderMode="Link" AutoPostBack="false" ClientInstanceName="cmdEditQuestionnaireName" Visible="false">
                                <ClientSideEvents Click="OncmdEditQuestionnaireNameClick" />
                            </dx:ASPxButton>
                        </div>
                    </div>
                </div>
                <div class="col-md-6">
                    <dx:ASPxGridView ID="ConfigGridView" runat="server" ClientInstanceName="ConfigGridView" AutoGenerateColumns="False" KeyFieldName="ConfigID" Width="100%" CssClass="text-center"
                        OnCustomCallback="ConfigGridView_CustomCallback" OnDataBinding="ConfigGridView_DataBinding" OnRowUpdating="ConfigGridView_RowUpdating">
                        <SettingsPager Visible="False">
                        </SettingsPager>
                        <SettingsDataSecurity AllowDelete="False" AllowInsert="False" />

                        <Columns>
                            <dx:GridViewCommandColumn ShowEditButton="True" VisibleIndex="0" Name="ConfigEditColumn">
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
    <br />
    <div class="row">
        <div class="col-xs-12">
            <div class="col-md-6">
                <div class="card cardShadow col-xs-12 nomargin">
                    <h3>Add Question</h3>
                    <hr class="divider"/>
                    <dx:ASPxMemo ID="txtQuestion" runat="server" Height="80px" Width="100%" ClientInstanceName="txtQuestion" Caption="Question Text">
                        <CaptionSettings Position="Top"  />
                        <ValidationSettings ErrorTextPosition="Bottom">
                            <RequiredField IsRequired="true" ErrorText="Please enter the question" />
                        </ValidationSettings>
                    </dx:ASPxMemo>
                    <h4>Select Answers</h4>

                    <dx:ASPxGridView ID="AnswerListGridView" ClientInstanceName="AnswerListGridView" runat="server" Width="100%" AutoGenerateColumns="False" OnDataBinding="AnswerListGridView_DataBinding" KeyFieldName="AnswerID" 
                        OnRowInserting="AnswerListGridView_RowInserting" OnRowInserted="AnswerListGridView_RowInserted">
                        <SettingsDataSecurity AllowDelete="False" AllowEdit="False" />
                        <SettingsSearchPanel Visible="True" />
                        <ClientSideEvents SelectionChanged="OnAnswerListGridViewSelectionChanged" />
                        <Columns>
                            <dx:GridViewCommandColumn SelectAllCheckboxMode="None" ShowSelectCheckbox="True" VisibleIndex="0" Width="35px" ShowNewButtonInHeader="True">
                            </dx:GridViewCommandColumn>
                            <dx:GridViewDataTextColumn Caption="AnswerID" FieldName="AnswerID" Visible="False" VisibleIndex="1">
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn Caption="Answer Text" FieldName="AnswerText" VisibleIndex="2">
                            </dx:GridViewDataTextColumn>
                        </Columns>
                    </dx:ASPxGridView>

                    <br />

                    <dx:ASPxListBox ID="lbSelectedAnswers" ClientInstanceName="lbSelectedAnswers" runat="server" ValueType="System.String" ValueField="AnswerID" TextField="AnswerText" Width="100%" Height="175px"></dx:ASPxListBox>
                    <br />
                    <dx:ASPxButton ID="cmdSaveQuestion" runat="server" Text="Save Question" Width="100%" OnClick="cmdSaveQuestion_Click"></dx:ASPxButton>
                    <br />
                    <br />
                </div>
                
            </div>
            <div class="col-md-6">
                <div class="card cardShadow col-xs-12 nomargin">
                    <h3>Current Questions</h3>
                    <hr class="divider"/>
                    <dx:ASPxGridView ID="QuestionsGridView" runat="server" Width="100%" AutoGenerateColumns="False" OnDataBinding ="QuestionsGridView_DataBinding">
                        <Settings ShowColumnHeaders="false" />
                        <SettingsPager PageSize="15">
                        </SettingsPager>
                        <SettingsBehavior AllowGroup="False" AllowSort="False" />
                        <SettingsDataSecurity AllowDelete="False" AllowEdit="False" AllowInsert="False" />
                        <Columns>
                            <dx:GridViewDataTextColumn Caption="QAID" FieldName="QID" Visible="False" VisibleIndex="0">
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn Caption="Question Text" FieldName="QuestionText" VisibleIndex="1" Width="100%">
                            </dx:GridViewDataTextColumn>
                        </Columns>
                    </dx:ASPxGridView>
                    <br /><br />
                </div>
            </div>
        </div>
    </div>

    <br />
    <br />
</asp:Content>
