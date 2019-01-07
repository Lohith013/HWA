<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ViewProd.aspx.cs" Inherits="Lohith_1622120_WA.ViewProd" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


    <p>
    <br />
    <table class="nav-justified">
        <tr>
            <td class="modal-lg" style="width: 223px">Product Name</td>
            <td>
                <asp:TextBox ID="ProdNameTB" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="modal-lg" style="width: 223px">Product Category</td>
            <td>
                <asp:TextBox ID="ProdCatTB" runat="server"></asp:TextBox>
            </td>
        </tr>
    </table>
</p>
<p>
    &nbsp;</p>
<p>
    <asp:Button ID="ViewButton" runat="server" OnClick="ViewButton_Click" Text="View" />
</p>
<p>
   
    <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
   
</p>
<p>
</p>


</asp:Content>
