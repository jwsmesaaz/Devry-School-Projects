<%@ Page Title="Manage User" Language="C#" MasterPageFile="~/CoolBizMasterPage.Master" AutoEventWireup="true" CodeBehind="frmManageUsers.aspx.cs" Inherits="CIS407Project.WebForm8" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">   
        <div style="text-align: center">
            <asp:Panel ID="Panel1" runat="server">
                <!--Label for the Username-->
                <asp:Label ID="lblUserName" runat="server" Text="User Name: "></asp:Label>
                <!--Textbox for the Username-->
                <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
                <!--Validation for User Name-->
                
                <!--Break between the username and the password-->
                <br />

                <!--Label for the Password-->
                <asp:Label ID="lblPassword" runat="server" Text="Password: "></asp:Label>
                <!--Textbox for the Password-->
                <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
                <!--Validation to make sure that the information isn't Blank-->
                <!--Break between the Password and the User role-->
                <br />
                <!--Label for Security Level-->
                <asp:Label ID="lblSecurity" runat="server" Text="Security Level: "></asp:Label>
                <!--Drop down list for user role-->
                <asp:DropDownList ID="ddlUserPermissions" runat="server">
                    <asp:ListItem>Admin</asp:ListItem>
                    <asp:ListItem>User</asp:ListItem>
                </asp:DropDownList>
                <!--Break between the Security Level and the Button-->
                <br />
                <!--Button for submitting form-->
                <asp:Button ID="btnSubmit" runat="server" Text="Add User" 
                    onclick="btnSubmit_Click" />
                <!--Break between the button and the Error Message-->
                <br />
                <!--Label for success message-->
                <asp:Label ID="lblMessage" runat="server" Text=""></asp:Label>
                <!--Breaks Between Error Message and User List-->
                <br /><br />            
            </asp:Panel>
            <!--Label for Current Users-->
            <asp:Label ID="lblCurrentUsers" runat="server" Text="Current Users:"></asp:Label>
            <center>
            <!--Grid View that is populated with User data-->
            <asp:GridView ID="grdCurrentUsers" runat="server" AutoGenerateColumns="False" 
                DataKeyNames="UserID" DataSourceID="AccessDataSource1">
                <Columns>
                    <asp:BoundField DataField="UserID" HeaderText="UserID" InsertVisible="False" 
                        ReadOnly="True" SortExpression="UserID" />
                    <asp:BoundField DataField="UserName" HeaderText="UserName" 
                        SortExpression="UserName" />
                    <asp:BoundField DataField="UserPassword" HeaderText="UserPassword" 
                        SortExpression="UserPassword" />
                    <asp:BoundField DataField="SecurityLevel" HeaderText="SecurityLevel" 
                        SortExpression="SecurityLevel" />
                    <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                </Columns>
            </asp:GridView>
            
            <asp:AccessDataSource ID="AccessDataSource1" runat="server" 
                DataFile="~/PayrollSystem_DB.mdb" 
                DeleteCommand="DELETE FROM [tblUserLogin] WHERE [UserID] = ?" 
                InsertCommand="INSERT INTO [tblUserLogin] ([UserID], [UserName], [UserPassword], [SecurityLevel]) VALUES (?, ?, ?, ?)" 
                SelectCommand="SELECT * FROM [tblUserLogin] ORDER BY [UserID]" 
                UpdateCommand="UPDATE [tblUserLogin] SET [UserName] = ?, [UserPassword] = ?, [SecurityLevel] = ? WHERE [UserID] = ?">
                <DeleteParameters>
                    <asp:Parameter Name="UserID" Type="Int32" />
                </DeleteParameters>
                <InsertParameters>
                    <asp:Parameter Name="UserID" Type="Int32" />
                    <asp:Parameter Name="UserName" Type="String" />
                    <asp:Parameter Name="UserPassword" Type="String" />
                    <asp:Parameter Name="SecurityLevel" Type="String" />
                </InsertParameters>
                <UpdateParameters>
                    <asp:Parameter Name="UserName" Type="String" />
                    <asp:Parameter Name="UserPassword" Type="String" />
                    <asp:Parameter Name="SecurityLevel" Type="String" />
                    <asp:Parameter Name="UserID" Type="Int32" />
                </UpdateParameters>
            </asp:AccessDataSource>
            </center>
        </div>         
    </form>
</asp:Content>
