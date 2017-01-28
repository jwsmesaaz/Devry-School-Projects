<%@ Page Title="" Language="C#" MasterPageFile="~/CoolBizMasterPage.Master" AutoEventWireup="true" Codefile="frmPersonalVerified1.aspx.cs" Inherits="CIS407Project.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="frmVerifiedInput" runat="server">
    <!--Label for the form submitt-->
    <asp:Label ID="lblInformationToSubmit" runat="server" Text="Information to submit"></asp:Label>    
    <!--Text area box so people can view the what they submitted previous to saving it.-->
    <asp:TextBox ID="txtVerifiedInfo" runat="server" Height="80px" TextMode="MultiLine" Width="400px"></asp:TextBox>
    </form>
</asp:Content>
