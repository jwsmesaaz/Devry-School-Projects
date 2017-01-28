<%@ Page Title="View Personnel" Language="C#" MasterPageFile="~/CoolBizMasterPage.Master" AutoEventWireup="true" CodeBehind="frmViewPersonnel.aspx.cs" Inherits="CIS407Project.WebForm5" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
    <div>
        <!--Label for the view personnel Grid-->    
        <asp:Label ID="lblViewPersonnel" runat="server" Text="View Personnel"></asp:Label>
        <!--A Return to make it a standard format with the User Activity Page-->
        <br />
        <!--Grid with the information about the people that you have entered into the database-->
        <asp:GridView ID="grdViewPersonnel" runat="server"></asp:GridView>
    </div>
    </form>
</asp:Content>
