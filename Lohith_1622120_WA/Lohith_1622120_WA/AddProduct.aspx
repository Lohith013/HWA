<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddProduct.aspx.cs" Inherits="Lohith_1622120_WA.AddProduct" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
<br />
<p>
    <table class="nav-justified">
        <tr>
            <td style="width: 382px">Product Name</td>
            <td>
                <asp:TextBox ID="ProdNameTB" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 382px">Product Category</td>
            <td>
                <asp:DropDownList ID="ProductCategoryDD" runat="server" OnSelectedIndexChanged="ProductCategoryDD_SelectedIndexChanged">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td style="width: 382px">Unit Price</td>
            <td>
                <asp:TextBox ID="UnitPriceTB" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 382px">Total Number Available</td>
            <td>
                <asp:TextBox ID="TotalAvailTB" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 382px">Manufactured Date</td>
            <td>
                <asp:TextBox ID="MFGDateTB" runat="server"></asp:TextBox>
            </td>
        </tr>
    </table>
</p>
<p>
    <asp:Label ID="SuccessMsgLabel" runat="server" Text="Label"></asp:Label>
</p>
<p>
    <asp:Button ID="AddButton" runat="server" OnClick="AddButton_Click" Text="Add Product" />
    <br />
</p>
</asp:Content>
