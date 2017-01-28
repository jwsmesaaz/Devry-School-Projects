<%@ Page Title="" Language="C#" MasterPageFile="~/CoolBizMasterPage.Master" AutoEventWireup="true" CodeBehind="frmSearchPersonnel.aspx.cs" Inherits="CIS407Project.WebForm6" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<form id="form1" runat="server">
    <div>
        
        <!--Label for the Last Name Search-->
        <asp:Label ID="lblSearchWhat" runat="server" Text="Search for: "></asp:Label>
        <!--Text box for user input of the last name to be searched off of-->
        <asp:TextBox ID="txtSearchName" runat="server"></asp:TextBox>
        <!--Button to actually preform the search-->
        <asp:Button ID="btnSearch" runat="server" Text="Search" onclick="btnSearch_Click" />
        <!--Break to put the button on the next line-->
        <br />
        <!--Option for what they want to search based on-->
        <asp:RadioButton ID="rbtFirstLast" runat="server" GroupName="SearchWhat" Checked="true" Text="First or Last" /><br />
        <asp:RadioButton ID="rbtFirst" runat="server" GroupName="SearchWhat" Text="First Only" /><br />
        <asp:RadioButton ID="rbtLast" runat="server" GroupName="SearchWhat" Text="Last Only" /><br />
    </div>
    </form>
</asp:Content>
