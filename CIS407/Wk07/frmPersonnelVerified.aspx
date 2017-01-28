<%@ Page Title="Personnel Verified" Language="C#" MasterPageFile="~/CoolBizMasterPage.Master" AutoEventWireup="true" CodeBehind="frmPersonnelVerified.aspx.cs" Inherits="CIS407Project.WebForm4" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
    <div>
        <!--Label for the form submitt-->
        <asp:Label ID="lblInformationToSubmit" runat="server" Text="Information to submit"></asp:Label>
        <!--Puts a return between the label and the box-->    
        <br />
        <!--Text area box so people can view the what they submitted previous to saving it. Changed the Text box to be larger to allow for the extra message-->
        <asp:TextBox ID="txtVerifiedInfo" runat="server" Height="100px" TextMode="MultiLine" Width="400px"></asp:TextBox>
        <!--Puts the button under the textbox-->
        <br />
        <!--Button to take you to the where you can see users-->
        <asp:Button ID="btnViewPersonnel" runat="server" Text="View Personnel" 
            onclick="btnViewPersonnel_Click" />
    </div>
    </form>
</asp:Content>
