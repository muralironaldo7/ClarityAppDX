<%@ Page Title="" Language="C#" MasterPageFile="~/LayoutMaster.Master" AutoEventWireup="true" CodeBehind="ResetPassword.aspx.cs" Inherits="ClarityWebAppDX.ResetPasswordPage" %>
<%@ Register Assembly="DevExpress.Web.v16.2, Version=16.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="BodyContent" runat="server">
    <div class="container">
        <div class="col-sm-6 col-sm-offset-3 text-center">
            <div class="card cardShadow" id="LoginCard">
                    
                <div class="row toolbar-row text-left">
                    <div class="col-sm-12">
                        <h4 class="TitleText">Reset Password</h4>
                    </div>
                </div>

                <div class="row FormRow">
                    <div class="col-xs-12">
                        <dx:ASPxTextBox ID="txtUserName" runat="server" Width="100%" EnableTheming="true" Theme="Material" Caption="Username" NullText="example@domain.com" Enabled="false">
                        </dx:ASPxTextBox>
                    </div>    
                </div>

                <div class="row FormRow">
                    <div class="col-xs-12">
                        <dx:ASPxTextBox ID="txtPassword" runat="server" Width="100%" EnableTheming="true" Theme="Material" Caption="Current Password" Password="true">
                            <ValidationSettings ErrorText="Please enter your password" ErrorTextPosition="Bottom" SetFocusOnError="True" ErrorDisplayMode="Text">
                                <RequiredField ErrorText="Please enter your password" IsRequired="True" />
                            </ValidationSettings>
                        </dx:ASPxTextBox>
                    </div>  
                </div>
                <div class="row FormRow">
                    <div class="col-xs-12">
                        <dx:ASPxTextBox ID="txtNewPassword" runat="server" Width="100%" EnableTheming="true" Theme="Material" Caption="New Password" Password="true" ClientInstanceName="txtNewPassword">
                            <ValidationSettings ErrorText="New Password is required" ErrorTextPosition="Bottom" SetFocusOnError="True" ErrorDisplayMode="Text">
                                <RequiredField ErrorText="New Password is required" IsRequired="True" />
                            </ValidationSettings>
                        </dx:ASPxTextBox>
                    </div>  
                </div>
                <div class="row FormRow">
                    <div class="col-xs-12">
                        <dx:ASPxTextBox ID="txtConfirm" runat="server" Width="100%" EnableTheming="true" Theme="Material" Caption="Confirm New Password" Password="true" ClientInstanceName="txtConfirm">
                            <ClientSideEvents Validation="function(s, e) {e.isValid = (s.GetText() == txtNewPassword.GetText());}" />
                            <ValidationSettings ErrorText="Password should match" ErrorTextPosition="Bottom" SetFocusOnError="True" ErrorDisplayMode="Text">
                                <RequiredField ErrorText="Password should match" IsRequired="True" />
                            </ValidationSettings>
                        </dx:ASPxTextBox>
                    </div>  
                </div>

                <div class="row FormRow">
                    <div class="col-xs-12">
                        <dx:ASPxButton ID="cmdSubmit" runat="server" Text="Change Password" Width="100%" OnClick="cmdSubmit_Click"></dx:ASPxButton>
                    </div>
                </div>

                <div class="row FormRow">
                    <div class="col-xs-12">
                        <dx:ASPxLabel ID="lblErr" runat="server" Text="" Width="100%" CssClass="has-error" ForeColor="Red" Font-Size="Medium" Font-Italic="true">
                        </dx:ASPxLabel>
                    </div>
                </div>

            </div>
        </div>
    </div>
</asp:Content>
