<%@ Page Title="Clarity - New Questionnaire" Language="C#" MasterPageFile="~/ContentMaster.Master" AutoEventWireup="true" CodeBehind="NewQuestionnaire.aspx.cs" Inherits="ClarityWebAppDX.NewQuestionnaire" %>

<%@ Register Assembly="DevExpress.Web.v16.2, Version=16.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <script src="Helpers/NewQuestionnaire.js"></script>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="BodyContent" runat="server">
    <div class="row">
        <div class="col-xs-12 toolbar-row">
            <span class="toolbar-title">New Questionnaire Configurtaion</span>
        </div>
    </div>
    <br />
    <div class="row">
        <div class="col-sm-7">
            <div class="col-xs-12 card paddedCard cardShadow">
                <h3>Questionnaire Configuration</h3>
                <hr class="divider"/>
                <div class="row">
                    <div class="col-xs-12">
                        <dx:ASPxTextBox ID="txtQuestionnaireName" runat="server" Width="100%" Caption="Questionnaire Name" ClientInstanceName="txtQuestionnaireName" ClientIDMode="Static">
                            <ClientSideEvents LostFocus="NewQuestionnaireTextChanged" />
                            <ValidationSettings ErrorTextPosition="Bottom" ValidationGroup="QuestionGeneric">
                                <RequiredField IsRequired="true" ErrorText = "Questionnaire name is required" />
                            </ValidationSettings>
                        </dx:ASPxTextBox>
                    </div>
                </div>
                <div class="row">
                    <div class="col-xs-6">
                        <dx:ASPxComboBox ID="cmbRiskType" runat="server" ClientInstanceName="cmbRiskType" Caption="Risk Type" Width="100%" DataSourceID="ConfigDataSource" OnDataBinding="cmbRiskType_DataBinding" TextField="ConfigurationName" ValueField="TypeID" >
                            <ValidationSettings ValidationGroup = "Threshold" ErrorTextPosition="Bottom">
                                <RequiredField IsRequired="true" ErrorText="Select Configuration"/>
                            </ValidationSettings>
                            <ClearButton DisplayMode="OnHover" ></ClearButton>
                        </dx:ASPxComboBox>
                        <asp:SqlDataSource ID="ConfigDataSource" runat="server"></asp:SqlDataSource>
                    </div>
                    <div class="col-xs-6">
                        <dx:ASPxTextBox ID="txtRiskThreshold" runat="server" Width="100%" Caption="Risk Thresold Value" ClientInstanceName ="txtRiskThreshold">
                            <ValidationSettings ValidationGroup="Threshold" ErrorTextPosition="Bottom">
                                <RequiredField IsRequired ="true" ErrorText="Enter value"/>
                            </ValidationSettings>
                        </dx:ASPxTextBox>
                    </div>
                </div>
                <div class="row">
                    <div class="col-xs-12">
                        <dx:ASPxCallbackPanel ID="ConfigurationCallback" runat="server" Width="100%" ClientInstanceName ="ConfigurationCallback" EnableCallbackAnimation="true" EnableViewState="true">
                            <PanelCollection>
                                <dx:PanelContent ID="ConfigurationButtonPanel" runat="server">
                                    <dx:ASPxButton ID="cmdAddThreshold" runat="server" ClientInstanceName="cmdAdd" EnableClientSideAPI="True"  Text="Add Configuration" ToolTip="Add Threshold" AutoPostBack="False" Width="100%">
                                        <ClientSideEvents Click="OncmdAddThresholdClick" />
                                    </dx:ASPxButton>
                                </dx:PanelContent>
                            </PanelCollection>
                        </dx:ASPxCallbackPanel>
                        
                    </div>
                </div>
                <br />
            </div>
        </div>

        <div class="col-sm-5">
            <div id="" class="col-xs-12 card paddedCard cardShadow"><!--QuestionnaireDetails-->
                <br />
                <div class="row">
                    <div class="col-xs-12 text-center">
                        <dx:ASPxLabel ID="lblQuestionnaireName" ClientIDMode="Static" ClientInstanceName="lblQuestionnaireName" runat="server" Text="" CssClass="HeadingText"></dx:ASPxLabel>
                    </div>
                </div>
                <div class="row">
                    <hr class="divider"/> 
                </div>
                
                <div class="row">
                    <dx:ASPxGridView ID="gvConfig" runat="server" AutoGenerateColumns="False" Width="100%" ClientInstanceName="ConfigGridView" OnDataBinding="gvConfig_DataBinding" KeyFieldName="ConfigName" OnCustomCallback="gvConfig_CustomCallback"
                        OnRowDeleting="gvConfig_RowDeleting" OnRowDeleted="gvConfig_RowDeleted" EnableCallbackAnimation="True">
                        <ClientSideEvents EndCallback="gvConfigEndCallback" />
                        <SettingsDataSecurity AllowEdit="False" AllowInsert="False" />
                        <Columns>
                            <dx:GridViewCommandColumn ShowDeleteButton="True" ShowInCustomizationForm="True" VisibleIndex="0">
                            </dx:GridViewCommandColumn>
                            <dx:GridViewDataTextColumn Caption="Configuration Type" VisibleIndex="1" Width="70%" FieldName="ConfigName">
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn Caption="Value" VisibleIndex="2" FieldName="ConfigValue">
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn Caption="TypeID" VisibleIndex="3" FieldName="TypeID" Visible="false">
                            </dx:GridViewDataTextColumn>
                        </Columns>
                    </dx:ASPxGridView>    
                </div>
                
                <div class="row">
                    <hr class="divider"/> 
                </div>

                <div class="row">
                    <div class="col-xs-12 text-center">
                        <dx:ASPxButton ID="cmdSave" runat="server" Text="Save Questionnaire" Width="100%" ValidationGroup="QuestionGeneric" OnClick="cmdSave_Click"></dx:ASPxButton>
                    </div>
                </div>

                <div class="row">
                    <div class="col-xs-12 text-center">
                        <br /><dx:ASPxLabel ID="lblErr" runat="server" Text="" Font-Italic="true" Font-Size="Medium" ForeColor="#a94442" Visible="false">
                        </dx:ASPxLabel>
                    </div>
                </div>

                <br />
            </div>
        </div>

    </div>
</asp:Content>
