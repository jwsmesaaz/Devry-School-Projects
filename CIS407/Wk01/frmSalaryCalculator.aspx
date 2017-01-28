<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmSalaryCalculator.aspx.cs" Inherits="CIS407Project.frmSalaryCalculator" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <!--This is the label for the Annual Hours-->
        <asp:Label ID="lblAnnualHours" runat="server" Text="Annual Hours"></asp:Label>
        <!--This is the Text box for the Annual Hours-->
        <asp:TextBox ID="txtAnnualHours" runat="server"></asp:TextBox>
        <!--This will add a return between the Annual Hours and the Rate-->
        <br />
        <!--This is the label for the Rate-->
        <asp:Label ID="lblRate" runat="server" Text="Rate"></asp:Label>
        <!--This is the Text box for the Rate-->
        <asp:TextBox ID="txtRate" runat="server"></asp:TextBox>
        <!--This will add a return between the button and the Rate-->
        <br />
        <!--This is the Button for Calculating the Salary Leaving it as button1 didn't seem correct to my coding knowledge so I changed it to btnCalculateSalary-->
        <asp:Button ID="btnCalculateSalary" runat="server" Text="Calculate Salary" 
            onclick="btnCalculateSalary_Click" />
        <!--This will add a return between the button and the Salary-->
        <br />
        <!--This is the label for the Salary output-->
        <asp:Label ID="lblSalary" runat="server" Text="$"></asp:Label>
    </div>
    
    </form>
</body>
</html>
