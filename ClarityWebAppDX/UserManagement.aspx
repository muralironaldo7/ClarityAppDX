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
                    <h3>Current Users</h3>
                    <hr class="divider"/>
                    <div class="row">
                        <div class="col-xs-12">
                            <dx:ASPxGridView ID="UserGridView" runat="server" AutoGenerateColumns="False" Width="100%" KeyFieldName="LoginID" 
                                OnRowDeleting="UserGridView_RowDeleting" OnDataBinding="UserGridView_DataBinding"  OnRowInserting="UserGridView_RowInserting">
                                <SettingsDataSecurity AllowEdit="False" />
                                <SettingsSearchPanel Visible="True" />
                                <Columns>
                                    <dx:GridViewCommandColumn ShowDeleteButton="True" ShowNewButtonInHeader="True" VisibleIndex="0">
                                    </dx:GridViewCommandColumn>
                                    <dx:GridViewDataTextColumn FieldName="UserName" Name="colUserName" VisibleIndex="1">
                                    </dx:GridViewDataTextColumn>
                                    <dx:GridViewDataTextColumn FieldName="LastModified" Name="colLastModified" VisibleIndex="4" ReadOnly="True">
                                    </dx:GridViewDataTextColumn>
                                    <dx:GridViewDataTextColumn FieldName="FirstName" Name="colFirstName" VisibleIndex="2">
                                    </dx:GridViewDataTextColumn>
                                    <dx:GridViewDataTextColumn FieldName="LastName" Name="colLastName" VisibleIndex="3">
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
