<%@ Page Title="User Activity" Language="C#" MasterPageFile="~/CoolBizMasterPage.Master" AutoEventWireup="true" CodeBehind="frmUserActivity.aspx.cs" Inherits="CIS407Project.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="lblUserActivity" runat="server" Text="User Activity"></asp:Label>
        <br />
        <asp:GridView ID="grdUserActivity" runat="server">
        </asp:GridView>
    </div>
    </form>
</asp:Content>
