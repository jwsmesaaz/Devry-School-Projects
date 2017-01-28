<%@ Page Title="Personnel" Language="C#" MasterPageFile="~/CoolBizMasterPage.Master" AutoEventWireup="true" CodeBehind="frmPersonnel.aspx.cs" Inherits="CIS407Project.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
        <!--Code to start pannel-->
        <asp:Panel ID="Panel1" runat="server" Height="250px" HorizontalAlign="Left" Width="600px">
            <!--This is the First Name Label-->
            <asp:Label ID="lblFirstName" runat="server" Text="First Name:" width="80px"></asp:Label>
            <!--This i sthe First Name Text Box-->
            <asp:TextBox ID="txtFirstName" runat="server" TabIndex="1"></asp:TextBox>
            <!--This is validation for the first name-->
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="First Name may not be empty" ControlToValidate="txtFirstName"></asp:RequiredFieldValidator>
            <!--This is the return between First Name and Last Name-->
            <br />
            <!--This is the Last Name Label-->
            <asp:Label ID="lblLastName" runat="server" Text="Last Name:" width="80px"></asp:Label>
            <!--This i sthe Last Name Text Box-->
            <asp:TextBox ID="txtLastName" runat="server" TabIndex="2"></asp:TextBox>
            <!--This is validation for the Last name-->
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Last Name may not be empty" ControlToValidate="txtLastName"></asp:RequiredFieldValidator>
            <!--This is the return between Last Name and Pay Rate-->
            <br />
            <!--This is the Pay Rate Label-->
            <asp:Label ID="lblPayRate" runat="server" Text="Pay Rate:" width="80px"></asp:Label>
            <!--This i sthe Pay Rate Text Box-->
            <asp:TextBox ID="txtPayRate" runat="server" TabIndex="3"></asp:TextBox>
            <!--These is validation for the Pay Rate-->
            <!--This is the return between Pay Rate and Start Date-->
            <br />
            <!--This is the Start Date Label-->
            <asp:Label ID="lblStartDate" runat="server" Text="Start Date:" width="80px"></asp:Label>
            <!--This i sthe Start Date Text Box-->
            <asp:TextBox ID="txtStartDate" runat="server" TabIndex="4"></asp:TextBox>
            <!--This is validation for the Start Date-->
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                ControlToValidate="txtStartDate" ErrorMessage="Date must be in mm/dd/yy format"                 
                ValidationExpression="^(0[1-9]|1[012])[- /.](0[1-9]|[12][0-9]|3[01])[- /.](19|20)\d\d$"></asp:RegularExpressionValidator>
            <!--This is the return between Start Date and End Date-->
            <br />
            <!--This is the End Date Label-->
            <asp:Label ID="lblEndDate" runat="server" Text="End Date:" width="80px"></asp:Label>
            <!--This i sthe End Date Text Box-->
            <asp:TextBox ID="txtEndDate" runat="server" TabIndex="5"></asp:TextBox>
            <!--This is validation for the End Date-->
            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" 
                ControlToValidate="txtEndDate" ErrorMessage="Date must be in mm/dd/yy format" 
                ValidationExpression="^(0[1-9]|1[012])[- /.](0[1-9]|[12][0-9]|3[01])[- /.](19|20)\d\d$"></asp:RegularExpressionValidator>
            <!--These returns are for a little extra spacing between End Date and The buttons-->
            <br /><br />
            <!--Button for submit which will take the person to a form to verify their information-->
            <asp:Button ID="btnSubmit" runat="server" Text="Submit" onclick="btnSubmit_Click" />
            <!--Return to put the error message on the next line-->
            <br /><br />
            <!--This is for the error labels-->
            <asp:Label ID="lblError" runat="server" ForeColor="Red" ></asp:Label>
        <!--Closes panel-->
        </asp:Panel>
    </form>
</asp:Content>
