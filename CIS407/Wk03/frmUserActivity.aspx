<%@ Page Language="C#" AutoEventWireup="true" Codefile="frmUserActivity.aspx.cs" Inherits="CIS407Project.frmUserActivity" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
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
    <div>
        <asp:Label ID="lblUserActivity" runat="server" Text="User Activity"></asp:Label>
        <br />
        <asp:GridView ID="grdUserActivity" runat="server">
        </asp:GridView>
    </div>
    </form>
</body>
</html>
