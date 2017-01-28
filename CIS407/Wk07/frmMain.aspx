<%@ Page Title="Payroll System" Language="C#" MasterPageFile="~/CoolBizMasterPage.Master" AutoEventWireup="true" CodeBehind="frmMain.aspx.cs" Inherits="CIS407Project.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="text-align: center">
        <form id="frmMainButton" runat="server">

        <!--Link that will take us to Adding new Emeployees-->
        <asp:LinkButton ID="linkbtnNewEmployee" runat="server" PostBackUrl="frmPersonnel.aspx"><img alt="New Employee" src="Images/New Employee.PNG" style="height: 44px; width: 52px" /> Add New Employee   </asp:LinkButton> 
        <!--Adds breaks between the different items-->
        <strong><span style="font-size: xx-large"><asp:Label ID="DoubleLine01" runat="server" Text="||"></asp:Label></span></strong>
        <!--Link that will take us to Adding new Emeployees-->
        <asp:LinkButton ID="linkbtnEditEmployees" runat="server" PostBackUrl="frmEditPersonnel.aspx"> Edit Employees <img alt="New Employee" src="Images/Edit Employee.png" style="height: 44px; width: 52px" /></asp:LinkButton> 

        <!--Creates breaks for the next items-->
        <br /><br />

        <!--Link to view the Personnel-->
        <asp:LinkButton ID="linkbtnViewPersonnel" runat="server" PostBackUrl="frmViewPersonnel.aspx"><img alt="View Personnel" src="Images/Personnel.PNG" style="height: 44px; width: 52px" /> View Personnel   </asp:LinkButton>
        <!--Adds breaks between the different items-->
        <strong><span style="font-size: xx-large"><asp:Label ID="DoubleLine02" runat="server" Text="||"></asp:Label></span></strong>
        <!--Link to search the Personnel-->
        <asp:LinkButton ID="linkbtnSearch" runat="server" PostBackUrl="frmSearchPersonnel.aspx"> Search Personnel <img alt="View Personnel" src="Images/SearchUsers.PNG" style="height: 44px; width: 52px" /></asp:LinkButton>
        
        <!--Creates breaks for the next items-->
        <br /><br />

        <!--Link that will take us to the Salary Calculator-->
        <asp:LinkButton ID="linkbtnCalculator" runat="server" PostBackUrl="frmSalaryCalculator.aspx"><img alt="Calculator" src="Images/calculator.PNG" style="height: 44px; width: 52px" /> Annual Salary Calculator   </asp:LinkButton>
        
        <!--Creates breaks for the next items-->
        <br /><br />
        
        <!--Adds a button for the User activity-->
        <asp:LinkButton ID="linkbtnManageUser" runat="server" PostBackUrl="frmManageUsers.aspx"><img alt="Manage User" src="Images/AddUser.png" style="height: 44px; width: 52px" /> Manage User</asp:LinkButton>
        <!--Adds breaks between the different items-->
        <strong><span style="font-size: xx-large"><asp:Label ID="DoubleLine03" runat="server" Text="||"></asp:Label></span></strong>
        <!--Adds a button for the User activity-->
        <asp:LinkButton ID="linkbtnViewUserActivity" runat="server" PostBackUrl="frmUserActivity.aspx">User Activity <img alt="User Activity" src="Images/Monitoring-user-activity.jpg" style="height: 44px; width: 52px" /></asp:LinkButton>
        </form>
    </div>
</asp:Content>
