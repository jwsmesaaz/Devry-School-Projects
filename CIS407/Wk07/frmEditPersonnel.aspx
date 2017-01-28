<%@ Page Title="Edit Personnel" Language="C#" MasterPageFile="~/CoolBizMasterPage.Master" AutoEventWireup="true" CodeBehind="frmEditPersonnel.aspx.cs" Inherits="CIS407Project.WebForm7" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<form id="form1" runat="server">
    <!--Label for Editing Employees-->
    <asp:Label ID="Label1" runat="server" Text="Edit Emplyees"></asp:Label>
    <!--Break between the label and the Grid view-->
    <br />
    <!--Grid View Control-->
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
        DataKeyNames="ID" DataSourceID="AccessDataSource1">
        <Columns>
            <asp:BoundField DataField="ID" HeaderText="ID" InsertVisible="False" 
                ReadOnly="True" SortExpression="ID" />
            <asp:BoundField DataField="FirstName" HeaderText="FirstName" 
                SortExpression="FirstName" />
            <asp:BoundField DataField="LastName" HeaderText="LastName" 
                SortExpression="LastName" />
            <asp:BoundField DataField="PayRate" HeaderText="PayRate" 
                SortExpression="PayRate" />
            <asp:BoundField DataField="StartDate" HeaderText="StartDate" 
                SortExpression="StartDate" />
            <asp:BoundField DataField="EndDate" HeaderText="EndDate" 
                SortExpression="EndDate" />
            <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
        </Columns>
    </asp:GridView>
    <asp:AccessDataSource ID="AccessDataSource1" runat="server" 
        DataFile="~/PayrollSystem_DB.mdb" 
        DeleteCommand="DELETE FROM [tblPersonnel] WHERE [ID] = ?" 
        InsertCommand="INSERT INTO [tblPersonnel] ([ID], [FirstName], [LastName], [PayRate], [StartDate], [EndDate]) VALUES (?, ?, ?, ?, ?, ?)" 
        SelectCommand="SELECT * FROM [tblPersonnel] ORDER BY [ID]" 
        UpdateCommand="UPDATE [tblPersonnel] SET [FirstName] = ?, [LastName] = ?, [PayRate] = ?, [StartDate] = ?, [EndDate] = ? WHERE [ID] = ?">
        <DeleteParameters>
            <asp:Parameter Name="ID" Type="Int32" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="ID" Type="Int32" />
            <asp:Parameter Name="FirstName" Type="String" />
            <asp:Parameter Name="LastName" Type="String" />
            <asp:Parameter Name="PayRate" Type="Int32" />
            <asp:Parameter Name="StartDate" Type="DateTime" />
            <asp:Parameter Name="EndDate" Type="String" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="FirstName" Type="String" />
            <asp:Parameter Name="LastName" Type="String" />
            <asp:Parameter Name="PayRate" Type="Int32" />
            <asp:Parameter Name="StartDate" Type="DateTime" />
            <asp:Parameter Name="EndDate" Type="String" />
            <asp:Parameter Name="ID" Type="Int32" />
        </UpdateParameters>
    </asp:AccessDataSource>
    
</form>
</asp:Content>
