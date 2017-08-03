<%@ Page Title="" Language="C#" MasterPageFile="~/ContentMaster.Master" AutoEventWireup="true" CodeBehind="UserManagement.aspx.cs" Inherits="ClarityWebAppDX.UserManagement" %>

<%@ Register Assembly="DevExpress.Web.v16.2, Version=16.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="BodyContent" runat="server">
    <div class="row">
        <div class="col-xs-12 toolbar-row">
            <span class="toolbar-title">User Management</span>
        </div>
    </div>
    <br />
     <div class="row">
        <div class="col-xs-12">
            <div class="card paddedCard cardShadow fullwidth">
                <div class="col-md-12">
                    <h3>User Management</h3>
                    <hr class="divider"/>
                    <div class="row">
                        <div class="col-xs-12">
                            <dx:ASPxGridView ID="UserGridView" runat="server" AutoGenerateColumns="False" Width="100%" KeyFieldName="LoginID" 
                                OnRowDeleting="UserGridView_RowDeleting" OnDataBinding="UserGridView_DataBinding"  OnRowInserting="UserGridView_RowInserting" OnCustomButtonCallback="UserGridView_CustomButtonCallback">
                                <SettingsDataSecurity AllowEdit="False" />
                                <SettingsSearchPanel Visible="True" />
                                <SettingsCommandButton>
                                    <NewButton Text="Add User">
                                        <Image ToolTip="New" Url="Images/Icons/NewUser.png" Height="32"/>
                                    </NewButton>
                                    <DeleteButton>
                                        <Image ToolTip="Delete User" Url="Images/Icons/Delete.png" Height="32"/>
                                    </DeleteButton>
                                    <UpdateButton>
                                        <Image ToolTip="Save" Url="Images/Icons/SAve.png" Height="32"/>
                                    </UpdateButton>
                                    <CancelButton>
                                        <Image ToolTip="Cancel" Url="Images/Icons/Cancel.png" Height="32"/>
                                    </CancelButton>
                                </SettingsCommandButton>
                                <SettingsAdaptivity AdaptivityMode="HideDataCellsWindowLimit" HideDataCellsAtWindowInnerWidth="800" AllowOnlyOneAdaptiveDetailExpanded="true">
                                    <AdaptiveDetailLayoutProperties>
                                        <Styles>
                                            <LayoutGroupBox>
                                                <Caption Font-Bold="true"></Caption>
                                            </LayoutGroupBox>
                                            <LayoutItem>
                                                <Caption Font-Bold="true"></Caption>
                                                <HelpText Font-Bold="true"></HelpText>
                                            </LayoutItem>
                                        </Styles>
                                        <SettingsAdaptivity SwitchToSingleColumnAtWindowInnerWidth="600" />
                                    </AdaptiveDetailLayoutProperties>
                                </SettingsAdaptivity>
                                <Columns>
                                    <dx:GridViewCommandColumn ShowDeleteButton="True" ShowNewButtonInHeader="True" VisibleIndex="0" ButtonRenderMode="Image" Width="100">
                                        <CustomButtons>
                                            <dx:GridViewCommandColumnCustomButton ID="Reset">
                                                <Image ToolTip="Reset Password" Url="Images/Icons/Reset.png" Height="32" />
                                            </dx:GridViewCommandColumnCustomButton>
                                        </CustomButtons>
                                    </dx:GridViewCommandColumn>
                                    <dx:GridViewDataTextColumn FieldName="UserName" Name="colUserName" VisibleIndex="1">
                                    </dx:GridViewDataTextColumn>
                                    <dx:GridViewDataTextColumn FieldName="Password" Name="colPassword" VisibleIndex="2" ReadOnly="true" EditFormSettings-Visible="False">
                                    </dx:GridViewDataTextColumn>
                                    <dx:GridViewDataTextColumn FieldName="LastModified" Name="colLastModified" VisibleIndex="5" ReadOnly="True" EditFormSettings-Visible="False">
                                    </dx:GridViewDataTextColumn>
                                    <dx:GridViewDataTextColumn FieldName="FirstName" Name="colFirstName" VisibleIndex="3">
                                    </dx:GridViewDataTextColumn>
                                    <dx:GridViewDataTextColumn FieldName="LastName" Name="colLastName" VisibleIndex="4">
                                    </dx:GridViewDataTextColumn>
                                </Columns>

                            </dx:ASPxGridView>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
