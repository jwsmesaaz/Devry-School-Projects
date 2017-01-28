<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmLogin.aspx.cs" Inherits="CIS407Project.frmLogin" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
    <style type="text/css">
        .style1
        {
            width: 568px;
            height: 335px;
        }
    </style>
</head>
<body style="text-align: center">
    <!--Image for the CoolBiz Productions-->        
    <img alt="CoolBiz Productions Logo" src="Images/CoolBiz_Productions_logo.JPG" />
    <!--Three returns-->
    <br /><br /><br />
    <form id="form1" runat="server">
    <div>
        <center>
        <asp:Login ID="Login1" runat="server" DestinationPageUrl="frmMain.aspx"
            
            TitleText="Please enter your UserName and Password in order to log into the system" 
            onauthenticate="Login1_Authenticate" DisplayRememberMe="False">
        </asp:Login>
        </center>
        <br />
        <asp:LinkButton ID="linkError" runat="server" Visible="False">One Does Not Simply Log into this website <br /><img alt="New Employee" 
            src="Images/oneDoesNot.jpg" /></asp:LinkButton>
        <br />
    </form>
    <p>
        &nbsp;</p>
</body>
</html>
