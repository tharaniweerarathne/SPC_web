<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddStock.aspx.cs" Inherits="Client.AddStock" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <link rel="stylesheet" type="text/css" href="StyleSheet1.css">
</head>
<body>
    <form id="form1" runat="server">
<nav>
    <ul class="navbar">
        <li><a href="AddStock.aspx">Search and Add stock</a></li>
         <li><a href="DrugDetails.aspx">Add New Drug Details</a></li>
        <li><a href="SearchOrder.aspx">View Orders</a></li>
       <asp:Button ID="Button1" runat="server" Text="Log Out" CssClass="btn-logout" PostBackUrl="~/Dashboard.aspx"/>
    </ul>
</nav>

            <div class="form_dashboard">
    <h2 class="h1_Staffdashboard">Welcome to the Staff Dashboard!</h2>
    <h1 class="h1_dashboard">Add new stock</h1>
    <table>
        <tr>
            <td><h3>Drug Name</h3></td>
            <td>
                <asp:DropDownList ID="dlDrug" runat="server" CssClass="dropdown1"></asp:DropDownList></td>
            <td>
                <asp:Button ID="btnSearch" runat="server" Text="Search" OnClick="btnSearch_Click" CssClass="btn-submit"/></td>
        </tr>

        <tr>
            <td><h3>Enter the new quantity</h3></td>
            <td><asp:TextBox ID="txtStockQuantity" runat="server" CssClass="input-field"></asp:TextBox></td>
            <td>
                <asp:Button ID="btnAddStock" runat="server" Text="Add Stock" OnClick="btnAddStock_Click" CssClass="btn-submit" /></td>
        </tr>

        <asp:GridView ID="gvStock" runat="server"></asp:GridView>

    </table>
    <asp:Label ID="lblText" runat="server" CssClass="label-text"></asp:Label>
</div>
    </form>
</body>
</html>
