<%@ Page Title="" Language="C#" MasterPageFile="~/ContentMaster.Master" AutoEventWireup="true" CodeBehind="PatientList.aspx.cs" Inherits="ClarityWebAppDX.PatientList" %>
<%@ Register Assembly="DevExpress.Web.v17.1, Version=17.1.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <script src="Helpers/PatientList.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="BodyContent" runat="server">
    <div class="row">
        <div class="col-xs-12 toolbar-row">
            <span class="toolbar-title">Patient Management</span>
        </div>
    </div>
    <br />
    <div class="row">
        <div class="col-xs-12">
            <div class="card paddedCard cardShadow fullwidth">
                <div class="col-md-12">
                    <h3>Patient List</h3>
                    <hr class="divider"/>
                    <div class="row">
                        <div class="col-xs-12">
                            <dx:ASPxGridView ID="PatientListGridView" ClientIDMod="Static" ClientInstanceName="PatientListGridView" runat="server" AutoGenerateColumns="False" Width="100%" KeyFieldName="PatientID"
                                OnDataBinding="PatientListGridView_DataBinding" OnCellEditorInitialize="PatientListGridView_CellEditorInitialize" OnRowInserting="PatientListGridView_RowInserting" OnRowUpdating="PatientListGridView_RowUpdating" OnCustomButtonCallback="PatientListGridView_CustomButtonCallback">
                                <SettingsSearchPanel Visible="True" />
                                <SettingsBehavior AllowSelectByRowClick="true" AllowSelectSingleRowOnly = "true" />
                                <SettingsCommandButton>
                                    <NewButton>
                                        <Image ToolTip="New" Url="Images/Icons/NewUser.png" Height="32"/>
                                    </NewButton>
                                    <DeleteButton>
                                        <Image ToolTip="Delete" Url="Images/Icons/Delete.png" Height="32"/>
                                    </DeleteButton>
                                    <UpdateButton>
                                        <Image ToolTip="Save" Url="Images/Icons/SAve.png" Height="32"/>
                                    </UpdateButton>
                                    <CancelButton>
                                        <Image ToolTip="Cancel" Url="Images/Icons/Cancel.png" Height="32"/>
                                    </CancelButton>
                                    <EditButton>
                                        <Image ToolTip="Edit" Url="Images/Icons/EditRow.png" Height="32"/>
                                    </EditButton>
                                </SettingsCommandButton>
                                <SettingsAdaptivity AdaptivityMode="HideDataCellsWindowLimit" HideDataCellsAtWindowInnerWidth="800">
                                    <AdaptiveDetailLayoutProperties>
                                        <SettingsAdaptivity SwitchToSingleColumnAtWindowInnerWidth="800" />
                                    </AdaptiveDetailLayoutProperties>
                                </SettingsAdaptivity>
                                <Columns>
                                    <dx:GridViewCommandColumn ShowEditButton="true" ShowDeleteButton="True" ShowNewButtonInHeader="True" VisibleIndex="0" ButtonRenderMode="Image" Width="70">
                                        <CustomButtons>
                                            <dx:GridViewCommandColumnCustomButton ID="ConsolidatedReport">
                                                <Image ToolTip="Consolidated REport" Url="Images/Icons/Report.png" Height="32" />
                                            </dx:GridViewCommandColumnCustomButton>
                                        </CustomButtons>
                                    </dx:GridViewCommandColumn>
                                    <dx:GridViewDataTextColumn FieldName="PatientFirstName" Name="colFirstName" VisibleIndex="1" Caption="First Name">
                                        <PropertiesTextEdit>
                                            <ValidationSettings ErrorDisplayMode="ImageWithText">
                                                <RequiredField IsRequired="true" />
                                            </ValidationSettings>
                                        </PropertiesTextEdit>
                                    </dx:GridViewDataTextColumn>
                                    <dx:GridViewDataTextColumn FieldName="PatientLastName" Name="colLastName" VisibleIndex="2" Caption="Last Name">
                                        <PropertiesTextEdit>
                                            <ValidationSettings ErrorDisplayMode="ImageWithText">
                                                <RequiredField IsRequired="true" />
                                            </ValidationSettings>
                                        </PropertiesTextEdit>
                                    </dx:GridViewDataTextColumn>
                                    <dx:GridViewDataTextColumn FieldName="PatientAccountNumber" Name="colPAN" VisibleIndex="3" Caption="Account Number">
                                        <PropertiesTextEdit>
                                            <ValidationSettings ErrorDisplayMode="ImageWithText">
                                                <RequiredField IsRequired="true" />
                                            </ValidationSettings>
                                        </PropertiesTextEdit>
                                    </dx:GridViewDataTextColumn>
                                    <dx:GridViewDataDateColumn FieldName="PatientDOB" Name="colDOB" VisibleIndex="4" Caption="Date of Birth">
                                        <PropertiesDateEdit>
                                            <ValidationSettings ErrorDisplayMode="ImageWithText">
                                                <RequiredField IsRequired="true" />
                                            </ValidationSettings>
                                        </PropertiesDateEdit>
                                    </dx:GridViewDataDateColumn>
                                    <dx:GridViewDataComboBoxColumn FieldName="PhysicianName" Name="colPrimaryPhysician" VisibleIndex="5" Caption="Primary Physician">
                                        <PropertiesComboBox TextField="PhysicianName" ValueField="PhysicianID" ValueType="System.String" IncrementalFilteringMode="Contains"></PropertiesComboBox>
                                    </dx:GridViewDataComboBoxColumn>
                                </Columns>
                                <ClientSideEvents RowDblClick="OnPatientDblClick" EndCallback="OnPatientListGridViewEndCallback" />
                            </dx:ASPxGridView>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <br />
     <div class="row">
        <div class="col-xs-12">
            <div class="card paddedCard cardShadow fullwidth">
                <dx:ASPxCallbackPanel ID="PatientDetailsPanel" ClientInstanceName="PatientDetailsPanel" ClientIDMode="Static" runat="server" Width="100%" OnCallback="PatientDetailsPanel_Callback" >
                    <PanelCollection>
                        <dx:PanelContent>
                            <div class="col-md-12">
                                <h3>Patient Details</h3>
                                <hr class="divider"/>
                                <div class="row">
                                    <div class="col-sm-6">
                                        <dx:ASPxTextBox ID="txtPatientAccount" runat="server" Width="100%" Caption="Patient Account Number" ReadOnly ="true" Border-BorderStyle="None" ForeColor="#4bb34a" Font-Bold="true" Font-Size="Medium">
                                            <CaptionStyle ForeColor="#333333"></CaptionStyle>
                                        </dx:ASPxTextBox>
                                    </div>
                                    <div class="col-sm-6">
                                        <dx:ASPxTextBox ID="txtPatientName" runat="server" Width="100%" Caption="Patient Name" ReadOnly ="true" Border-BorderStyle="None" ForeColor="#4bb34a" Font-Bold="true" Font-Size="Medium">
                                            <CaptionStyle ForeColor="#333333"></CaptionStyle>
                                        </dx:ASPxTextBox>
                                    </div>

                                </div><br />

                                <div class="row">
                                    <div class="col-lg-6">
                                        <h4>Questionnaire History</h4>
                                        <hr class="divider"/>
                                        <dx:ASPxGridView ID="gvQuestionnaireHistory" runat="server" Width="100%" AutoGenerateColumns="False" KeyFieldName="PQID" 
                                            OnDataBinding="gvQuestionnaireHistory_DataBinding" OnHtmlRowPrepared="gvQuestionnaireHistory_HtmlRowPrepared" OnCustomButtonCallback="gvQuestionnaireHistory_CustomButtonCallback">
                                            <SettingsBehavior AllowSelectByRowClick="true" AllowSelectSingleRowOnly="true"/>
                                            <SettingsPager PageSize ="5"></SettingsPager>
                                            <SettingsDataSecurity AllowEdit="False" AllowInsert="False" AllowDelete="False"></SettingsDataSecurity>
                                            <SettingsSearchPanel Visible="True"></SettingsSearchPanel>
                                            <Columns>
                                                <dx:GridViewDataTextColumn FieldName="PQID" Name="colPatientQuestionanireID" Caption="PQID" Visible="false" VisibleIndex="0"></dx:GridViewDataTextColumn>
                                                <dx:GridViewDataTextColumn FieldName="QuestionnaireName" Name="colQuestionnaireName" Caption="Questionnaire Name" VisibleIndex="1"></dx:GridViewDataTextColumn>
                                                <dx:GridViewDataTextColumn FieldName="CompletedDate" Name="colCompletedDate" Caption="Completed Date" VisibleIndex="2"></dx:GridViewDataTextColumn>
                                                <dx:GridViewDataTextColumn FieldName="Score" Name="colScore" Caption="Score" VisibleIndex="3"></dx:GridViewDataTextColumn>
                                                <dx:GridViewDataTextColumn FieldName="RiskCategory" Name="colRiskCategory" Caption="Risk Category" VisibleIndex="4"></dx:GridViewDataTextColumn>
                                                <dx:GridViewCommandColumn ButtonRenderMode="Image" VisibleIndex="5" Caption="Report" Width="40">
                                                    <CustomButtons>
                                                        <dx:GridViewCommandColumnCustomButton ID="ViewResponse">
                                                            <Image ToolTip="View Responses" Url="Images/Icons/PatientResponse.png" Height="32"/>
                                                        </dx:GridViewCommandColumnCustomButton>
                                                    </CustomButtons>
                                                </dx:GridViewCommandColumn>
                                            </Columns>
                                            <ClientSideEvents EndCallback="gvQuestionnaireHistoryEndCallback" />
                                        </dx:ASPxGridView>
                                        <br /><br />
                                    </div>
                                    <div class="col-lg-6">
                                        <h4>Assigned Questionnaire</h4>
                                        <hr class="divider"/>
                                        <dx:ASPxGridView ID="gvAssignedQuestionnaire" runat="server" Width="100%" AutoGenerateColumns="False" KeyFieldName="PQID"   
                                            OnDataBinding="gvAssignedQuestionnaire_DataBinding" OnCellEditorInitialize="gvAssignedQuestionnaire_CellEditorInitialize" OnRowInserting="gvAssignedQuestionnaire_RowInserting" OnRowDeleting="gvAssignedQuestionnaire_RowDeleting">
                                            <SettingsBehavior AllowSort ="false" AllowSelectByRowClick="false" />
                                            <SettingsPager PageSize ="5"></SettingsPager>
                                            <SettingsDataSecurity AllowEdit="False"></SettingsDataSecurity>
                                            <SettingsEditing EditFormColumnCount ="1"></SettingsEditing>
                                            <SettingsCommandButton>
                                                <NewButton>
                                                    <Image ToolTip="New" Url="Images/Icons/NewUser.png" Height="32"/>
                                                </NewButton>
                                                <DeleteButton>
                                                    <Image ToolTip="Delete" Url="Images/Icons/Delete.png" Height="32"/>
                                                </DeleteButton>
                                                <UpdateButton>
                                                    <Image ToolTip="Save" Url="Images/Icons/SAve.png" Height="32"/>
                                                </UpdateButton>
                                                <CancelButton>
                                                    <Image ToolTip="Cancel" Url="Images/Icons/Cancel.png" Height="32"/>
                                                </CancelButton>
                                            </SettingsCommandButton>
                                            <Columns>
                                                <dx:GridViewCommandColumn ShowDeleteButton="True" VisibleIndex="0" ButtonRenderMode="Image" Width="50" ShowNewButtonInHeader="True">
                                                </dx:GridViewCommandColumn>
                                                <dx:GridViewDataTextColumn FieldName="PQID" Name="colPatientQuestionanireID" Caption="PQID" Visible="false" VisibleIndex="1"></dx:GridViewDataTextColumn>
                                                <dx:GridViewDataComboBoxColumn FieldName="QuestionnaireName" Name="colQuestionnaireName" VisibleIndex="2" Caption="Questionnaire Name">
                                                    <PropertiesComboBox TextField="QuestionnaireName" ValueField="QuestionnaireID" ValueType="System.String">
                                                        <ValidationSettings ErrorDisplayMode="ImageWithText">
                                                            <RequiredField IsRequired="true" />
                                                        </ValidationSettings>
                                                    </PropertiesComboBox>
                                                </dx:GridViewDataComboBoxColumn>
                                                <dx:GridViewDataDateColumn FieldName="ScheduledDate" Name="colScheduleDate" Caption="Schedule Date" VisibleIndex="3">
                                                    <PropertiesDateEdit>
                                                        <ValidationSettings ErrorDisplayMode="ImageWithText">
                                                            <RequiredField IsRequired="true" />
                                                        </ValidationSettings>
                                                    </PropertiesDateEdit>
                                                </dx:GridViewDataDateColumn>
                                            </Columns>
                                        </dx:ASPxGridView>
                                    </div>
                                </div><br />

                            </div>
                        </dx:PanelContent>
                    </PanelCollection>
                </dx:ASPxCallbackPanel>

                

            </div>
        </div>
    </div>
</asp:Content>
