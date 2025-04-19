<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PharmacyDashboard.aspx.cs" Inherits="Client.PharmacyDashboard" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" type="text/css" href="StyleSheet1.css">
</head>
<body>
    <form id="form1" runat="server">
            <div class="form_dashboard">
                <asp:Button ID="Button1" runat="server" Text="Log Out" CssClass="btn-logout" PostBackUrl="~/Dashboard.aspx"/>
    <h1 class="h1_dashboard">Pharmacy Dashboard</h1>

    <h2  class="h2_dashboard">Search and Order stock</h2>
    <table class="table_dashboard">

        <tr>
            <td><h3>Drug Name</h3></td>
            <td>
                <asp:DropDownList ID="dlDrug" runat="server" CssClass="dropdown1"></asp:DropDownList></td>
            <td>
                <asp:Button ID="btnSearch" runat="server" Text="Search" OnClick="btnSearch_Click" CssClass="btn-submit" /></td>
            </tr>
        

        <tr>
            <td><h2 class="h2_dashboard">Order Stock</h2></td>

       </tr> 

        <tr>
            <td><h3 class="h3_dashboard">Order ID</h3></td>
            <td><asp:TextBox ID="txtOrderID" runat="server" CssClass="input-field"></asp:TextBox></td>

        </tr>
        
        <tr>
            <td><h3>Enter the  quantity</h3></td>
            <td><asp:TextBox ID="txtQuantity" runat="server" CssClass="input-field"></asp:TextBox></td>

            <td><h3>Pharmacy Name</h3></td>
            <td><asp:DropDownList ID="dlPharmacy" runat="server" CssClass="dropdown1"></asp:DropDownList></td>
            <td>
                <asp:Button ID="btnOrderStock" runat="server" Text="Order Stock" OnClick="btnOrderStock_Click" CssClass="btn-submit"/></td>
        </tr>

        <asp:GridView ID="gvStock" runat="server"></asp:GridView>


    </table>
    <asp:Label ID="lblText" runat="server" CssClass="label-text"></asp:Label>
</div>
    </form>
</body>
</html>
