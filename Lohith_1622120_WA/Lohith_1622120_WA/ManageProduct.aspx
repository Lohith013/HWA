<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ManageProduct.aspx.cs" Inherits="Lohith_1622120_WA.ManageProduct" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        <br />
        <asp:Label ID="Label1" runat="server" Text="Enter the Product ID you want to Delete"></asp:Label>
&nbsp;:
        <asp:TextBox ID="DeleteItemTB" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="UpdateButton" runat="server" OnClick="UpdateButton_Click" Text="Update" />
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="DeleteButton" runat="server" OnClick="Button2_Click" Text="Delete" />
    </p>
</asp:Content>
