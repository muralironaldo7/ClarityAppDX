﻿<%@ Page Title="Clarity - New Questionnaire" Language="C#" MasterPageFile="~/ContentMaster.Master" AutoEventWireup="true" CodeBehind="NewQuestionnaire.aspx.cs" Inherits="ClarityWebAppDX.NewQuestionnaire" %>

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
                        <dx:ASPxComboBox ID="cmdRiskType" runat="server" Caption="Risk Type" Width="100%"></dx:ASPxComboBox>
                    </div>
                    <div class="col-xs-5">
                        <dx:ASPxTextBox ID="txtRiskThreshold" runat="server" Width="100%" Caption="Risk Thresold Value">
                            <ValidationSettings ValidationGroup="Threshold">
                            </ValidationSettings>
                        </dx:ASPxTextBox>
                    </div>
                    <div class="col-xs-1">
                        <dx:ASPxButton ID="cmdAddThreshold" runat="server" ClientInstanceName="cmdAdd" EnableClientSideAPI="True" RenderMode="Link" ValidationGroup="Threshold" ToolTip="Add Threshold">
                            <Image Height="30px" Url="~/Images/Icons/add.png">
                            </Image>
                        </dx:ASPxButton>
                    </div>
                </div>
            </div>
        </div>

        <div class="col-sm-5">
            <div class="col-xs-12 card paddedCard">
                <div class="row">
                    <div class="col-xs-12 text-center">
                        <dx:ASPxLabel ID="lblQuestionnaireName" ClientIDMode="Static" ClientInstanceName="lblQuestionnaireName" runat="server" Text=""></dx:ASPxLabel>
                    </div>
                </div>
                
            </div>
        </div>

    </div>
</asp:Content>