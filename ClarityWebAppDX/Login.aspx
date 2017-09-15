<%@ Page Title="" Language="C#" MasterPageFile="~/LayoutMaster.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ClarityWebAppDX.LoginPage" %>

<%@ Register Assembly="DevExpress.Web.v17.1, Version=17.1.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="BodyContent" runat="server">
    <div class="container">
        <div class="col-sm-6 col-sm-offset-3 text-center">
            <div class="card cardShadow" id="LoginCard">
                    
                <div class="row toolbar-row text-left">
                    <div class="col-sm-12">
                        <h4 class="TitleText">Login</h4>
                    </div>
                </div>

                <div class="row imagerow">
                    <div class="col-sm-12">
                        <img src="Images/logo.png" />
                    </div>
                    <div class="col-sm-12">
                        <h4 class="TitleText darkFont">CliniLogix Administration</h4>
                    </div>
                </div>
                <hr class="divider"/>
                <div class="row FormRow">
                    <div class="col-xs-12">
                        <dx:ASPxTextBox ID="txtUserName" runat="server" Width="100%" EnableTheming="true" Theme="Material" Caption="Username" NullText="example@domain.com">
                            <ValidationSettings ErrorText="Please enter a username" ErrorTextPosition="Bottom" SetFocusOnError="True" ErrorDisplayMode="Text">
                                <RegularExpression ErrorText="Please enter a valid email address" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" />
                                <RequiredField ErrorText="Please enter a username" IsRequired="True" />
                            </ValidationSettings>
                        </dx:ASPxTextBox>
                    </div>    
                </div>

                <div class="row FormRow">
                    <div class="col-xs-12">
                        <dx:ASPxTextBox ID="txtPassword" runat="server" Width="100%" EnableTheming="true" Theme="Material" Caption="Password" Password="true">
                            <ValidationSettings ErrorText="Please enter your password" ErrorTextPosition="Bottom" SetFocusOnError="True" ErrorDisplayMode="Text">
                                <RequiredField ErrorText="Please enter your password" IsRequired="True" />
                            </ValidationSettings>
                        </dx:ASPxTextBox>
                    </div>  
                </div>

                <div class="row FormRow">
                    <div class="col-xs-12">
                        <dx:ASPxButton ID="cmdLogin" runat="server" Text="Login" Width="100%" OnClick="cmdLogin_Click"></dx:ASPxButton>
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
