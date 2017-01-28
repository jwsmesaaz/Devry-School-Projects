<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmPersonnel.aspx.cs" Inherits="CIS407Project.frmPersonnel" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Personnel</title>
    <div style="text-align:center">
        <!--Unable to use the following Code to proform the function that the iLab asked for. If I move this code out of the header area then it does function.
        <asp:HyperLink runat="server" NavigateURL="~/frmMain.aspx" imageUrl="~/Images/CoolBiz_Productions_logo.JPG"></asp:HyperLink>
        <!--Starts hyperlink using an a tag-->
        <a href="frmMain.aspx">
        <!--Image for the CoolBiz Productions-->        
        <img alt="CoolBiz Productions Logo" src="Images/CoolBiz_Productions_logo.JPG" />
        <!--Ends the hyperlink for the image-->
        </a>
        <!--Three returns-->
        <br /><br /><br />
    </div>
</head>
<body>
    <form id="form1" runat="server">
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
                PostBackUrl="~/frmPersonnelVerified.aspx" />
            <!--Button to Cancel will take people back to the main page-->
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" PostBackUrl="~/frmMain.aspx" />
        <!--Closes panel-->
        </asp:Panel>
    </form>
</body>
</html>
