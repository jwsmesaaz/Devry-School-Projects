<%@ Page Title="" Language="C#" MasterPageFile="~/CoolBizMasterPage.Master" AutoEventWireup="true" CodeBehind="frmSalaryCalculator.aspx.cs" Inherits="CIS407Project.frmSalaryCalculator" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <!--This is the label for the Annual Hours-->
        <asp:Label ID="lblAnnualHours" runat="server" Text="Annual Hours" width="95px"></asp:Label>
        <!--This is the Text box for the Annual Hours-->
        <asp:TextBox ID="txtAnnualHours" runat="server"></asp:TextBox>
        <!--This will add a return between the Annual Hours and the Rate-->
        <br />
        <!--This is the label for the Rate-->
        <asp:Label ID="lblRate" runat="server" Text="Rate" width="95px"></asp:Label>
        <!--This is the Text box for the Rate-->
        <asp:TextBox ID="txtRate" runat="server"></asp:TextBox>
        <!--This will add a return between the button and the Rate-->
        <br />
        <!--This is the Button for Calculating the Salary Leaving it as button1 didn't seem correct to my coding knowledge so I changed it to btnCalculateSalary-->
        <asp:Button ID="btnCalculateSalary" runat="server" Text="Calculate Salary" onclick="btnCalculateSalary_Click" />
        <!--This will add a return between the button and the Salary-->
        <br />
        <!--This is the label for the Salary output-->
        <asp:Label ID="lblSalary" runat="server" Text="$"></asp:Label>
    </div>
</asp:Content>
