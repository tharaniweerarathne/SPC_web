<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SearchOrder.aspx.cs" Inherits="Client.SearchOrder" %>

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
    <h1 class="h1_dashboard">Orders</h1>
    <table>
        <tr>
            <td><h3>Pharmacy Name</h3></td>
            <td>
                <asp:DropDownList ID="dlPharmacy" runat="server" CssClass="dropdown1"></asp:DropDownList></td>
            <td>
                <asp:Button ID="btnSearch" runat="server" Text="Search" OnClick="btnSearch_Click" CssClass="btn-submit" /></td>
        </tr>

        <asp:GridView ID="gvStock" runat="server"></asp:GridView>

    </table>
    <asp:Label ID="lblText" runat="server" CssClass="label-text"></asp:Label>
</div>
    </form>
</body>
</html>
