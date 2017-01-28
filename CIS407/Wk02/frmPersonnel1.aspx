<%@ Page Title="" Language="C#" MasterPageFile="~/CoolBizMasterPage.Master" AutoEventWireup="true" CodeBehind="frmPersonnel1.aspx.cs" Inherits="CIS407Project.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="frmPersonnelInput" runat="server">
        <!--Code to start pannel-->
        <asp:Panel ID="Panel1" runat="server" Height="250px" HorizontalAlign="Left" Width="300px">
            <!--This is the First Name Label-->
            <asp:Label ID="lblFirstName" runat="server" Text="First Name:" width="80px"></asp:Label>
            <!--This i sthe First Name Text Box-->
            <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
            <!--This is the return between First Name and Last Name-->
            <br />
            <!--This is the Last Name Label-->
            <asp:Label ID="lblLastName" runat="server" Text="Last Name:" width="80px"></asp:Label>
            <!--This i sthe Last Name Text Box-->
            <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
            <!--This is the return between Last Name and Pay Rate-->
            <br />
            <!--This is the Pay Rate Label-->
            <asp:Label ID="lblPayRate" runat="server" Text="Pay Rate:" width="80px"></asp:Label>
            <!--This i sthe Pay Rate Text Box-->
            <asp:TextBox ID="txtPayRate" runat="server"></asp:TextBox>
            <!--This is the return between Pay Rate and Start Date-->
            <br />
            <!--This is the Start Date Label-->
            <asp:Label ID="lblStartDate" runat="server" Text="Start Date:" width="80px"></asp:Label>
            <!--This i sthe Start Date Text Box-->
            <asp:TextBox ID="txtStartDate" runat="server"></asp:TextBox>
            <!--This is the return between Start Date and End Date-->
            <br />
            <!--This is the End Date Label-->
            <asp:Label ID="lblEndDate" runat="server" Text="End Date:" width="80px"></asp:Label>
            <!--This i sthe End Date Text Box-->
            <asp:TextBox ID="txtEndDate" runat="server"></asp:TextBox>
            <!--These returns are for a little extra spacing between End Date and The buttons-->
            <br /><br />
            <!--Button for submit which will take the person to a form to verify their information-->
            <asp:Button ID="btnSubmit" runat="server" Text="Submit" 
                PostBackUrl="~/frmPersonalVerified1.aspx" />
            <!--Button to Cancel will take people back to the main page-->
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" PostBackUrl="~/frmMain.aspx" />
        <!--Closes panel-->
        </asp:Panel>
    <!--Closes form-->
    </form>
</asp:Content>
