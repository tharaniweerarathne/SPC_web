<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SupplierForm.aspx.cs" Inherits="Client.SupplierForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>    <link rel="stylesheet" type="text/css" href="StyleSheet1.css">
</head>
<body>
    <form id="form1" runat="server">
               <div class="form">
            <h2>Supplier Registration</h2>
            <table>
                <tr>
                    <td><h3>Supplier ID</h3></td>
                    <td><asp:TextBox ID="txtSupplierId" runat="server" CssClass="input-field"></asp:TextBox></td>
                </tr>

                <tr>
                    <td><h3>Enter your Name</h3></td>
                    <td><asp:TextBox ID="txtSuppliername" runat="server" CssClass="input-field"></asp:TextBox></td>
                    <td><asp:RequiredFieldValidator ID="rfvName" runat="server" ErrorMessage="Name can't be blank" ControlToValidate="txtSuppliername" ForeColor="Red"></asp:RequiredFieldValidator></td>
                </tr>

                <tr>
                    <td><h3>Enter your Email</h3></td>
                    <td><asp:TextBox ID="txtSupplierEmail" runat="server" CssClass="input-field"></asp:TextBox></td>
                    <td><asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Email can't be blank" ControlToValidate="txtSupplierEmail" ForeColor="Red"></asp:RequiredFieldValidator></td>
                </tr>

                <tr>
                    <td><h3>Enter your Phone Number</h3></td>
                    <td><asp:TextBox ID="txtSupplierPhone" runat="server" CssClass="input-field"></asp:TextBox></td>
                    <td><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Phone number can't be blank" ControlToValidate="txtSupplierPhone" ForeColor="Red"></asp:RequiredFieldValidator></td>
                </tr>

                <tr>
                    <td>
                        <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" CssClass="btn-submit" /></td>
                </tr>

            </table>
            <asp:Label ID="lblText" runat="server" CssClass="label-text"></asp:Label>
        </div>
    </form>
</body>
</html>
