<%@ Page Title="" Language="C#" MasterPageFile="~/CoolBizMasterPage.Master" AutoEventWireup="true" CodeBehind="frmMain.aspx.cs" Inherits="CIS407Project.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="text-align: center">
        <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="~/frmSalaryCalculator.aspx"><img alt="Calculator" src="Images/calculator.PNG" style="height: 44px; width: 52px" />Annual Salary Calculator </asp:LinkButton> ||
        <asp:LinkButton ID="LinkButton2" runat="server" PostBackUrl="~/frmPersonnel.aspx">Add New Employee <img alt="New Employee" src="Images/New Employee.PNG" style="height: 44px; width: 52px" /></asp:LinkButton>
    </div>
</asp:Content>
