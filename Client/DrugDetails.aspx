<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DrugDetails.aspx.cs" Inherits="Client.DrugDetails" %>

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
       <asp:Button ID="Button2" runat="server" Text="Log Out" CssClass="btn-logout" PostBackUrl="~/Dashboard.aspx"/>
    </ul>
</nav>
                <div class="form">
    <h2>Add New Drug Details</h2>
    <table>
        <tr>
            <td><h3>Drug ID</h3></td>
            <td><asp:TextBox ID="txtDrugId" runat="server" CssClass="input-field"></asp:TextBox></td>
        </tr>

        <tr>
            <td><h3>Enter the Name</h3></td>
            <td><asp:TextBox ID="txtDrugrname" runat="server" CssClass="input-field"></asp:TextBox></td>
            <td><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Name can't be blank" ControlToValidate="txtDrugrname" ForeColor="Red"></asp:RequiredFieldValidator></td>
        </tr>

        <tr>
            <td><h3>Enter the Category</h3></td>
            <td><asp:TextBox ID="txtcategory" runat="server" CssClass="input-field"></asp:TextBox></td>
            <td><asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Category can't be blank" ControlToValidate="txtcategory" ForeColor="Red"></asp:RequiredFieldValidator></td>
        </tr>

        <tr>
            <td><h3>Enter the Quantity</h3></td>
            <td><asp:TextBox ID="txtQuantity" runat="server" CssClass="input-field"></asp:TextBox></td>
            <td><asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Quantity can't be blank" ControlToValidate="txtQuantity" ForeColor="Red"></asp:RequiredFieldValidator></td>
        </tr>

        <tr>
            <td><h3>Enter the price</h3></td>
            <td><asp:TextBox ID="txtDrugPrice" runat="server" CssClass="input-field"></asp:TextBox></td>
            <td><asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Price can't be blank" ControlToValidate="txtDrugPrice" ForeColor="Red"></asp:RequiredFieldValidator></td>
        </tr>

        <tr>
            <td><h3>Enter the Source Type</h3></td>
            <td>
                <asp:DropDownList ID="dlSource" runat="server" CssClass="dropdown1">
                    <asp:ListItem>Manufactured plants </asp:ListItem>
                    <asp:ListItem>Externally purchased </asp:ListItem>
                </asp:DropDownList></td>
        </tr>

        <tr>
            <td>
                <asp:Button ID="Button1" runat="server" Text="Add Details" CssClass="btn-submit" OnClick="Button1_Click" /></td>
        </tr>

    </table>
    <asp:Label ID="lblText" runat="server" CssClass="label-text"></asp:Label>
</div>
    </form>
</body>
</html>
