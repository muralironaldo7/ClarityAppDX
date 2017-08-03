<%@ Page Title="" Language="C#" MasterPageFile="~/ContentMaster.Master" AutoEventWireup="true" CodeBehind="Physicians.aspx.cs" Inherits="ClarityWebAppDX.PhysicianManagement" %>
<%@ Register Assembly="DevExpress.Web.v16.2, Version=16.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="BodyContent" runat="server">
    <div class="row">
        <div class="col-xs-12 toolbar-row">
            <span class="toolbar-title">Physician Management</span>
        </div>
    </div>
    <br />
    <div class="row">
        <div class="col-xs-12">
            <div class="card paddedCard cardShadow fullwidth">
                <div class="col-md-12">
                    <h3>Physician List</h3>
                    <hr class="divider"/>
                    <div class="row">
                        <div class="col-xs-12">
                            <dx:ASPxGridView ID="PhysicianGridView" runat="server" AutoGenerateColumns="False" Width="100%" KeyFieldName="PhysicianID" 
                                OnRowDeleting="PhysicianGridView_RowDeleting" OnDataBinding="PhysicianGridView_DataBinding"  OnRowInserting="PhysicianGridView_RowInserting" OnCellEditorInitialize="PhysicianGridView_CellEditorInitialize">
                                <SettingsDataSecurity AllowEdit="False" />
                                <SettingsSearchPanel Visible="True" />
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
                                <SettingsAdaptivity AdaptivityMode="HideDataCellsWindowLimit" HideDataCellsAtWindowInnerWidth="800">
                                    <AdaptiveDetailLayoutProperties>
                                        <SettingsAdaptivity SwitchToSingleColumnAtWindowInnerWidth="800" />
                                    </AdaptiveDetailLayoutProperties>
                                </SettingsAdaptivity>
                                <Columns>
                                    <dx:GridViewCommandColumn ShowDeleteButton="True" ShowNewButtonInHeader="True" VisibleIndex="0" ButtonRenderMode="Image" Width="50">
                                    </dx:GridViewCommandColumn>
                                    <dx:GridViewDataTextColumn FieldName="PhysicianFirstName" Name="colFirstName" VisibleIndex="3" Caption="First Name">
                                    </dx:GridViewDataTextColumn>
                                    <dx:GridViewDataTextColumn FieldName="PhysicianLastName" Name="colLastName" VisibleIndex="4" Caption="Last Name">
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
