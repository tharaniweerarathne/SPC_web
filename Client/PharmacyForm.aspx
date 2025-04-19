<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PharmacyForm.aspx.cs" Inherits="Client.PharmacyForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" type="text/css" href="StyleSheet1.css">
</head>
<body>
    <form id="form1" runat="server">
            <div class="form">
    <h2>Pharmacy Registration</h2>
    <table>
        <tr>
            <td><h3>Pharmacy ID</h3></td>
            <td><asp:TextBox ID="txtPharmacyId" runat="server" CssClass="input-field"></asp:TextBox></td>
        </tr>

        <tr>
            <td><h3>User ID</h3></td>
            <td><asp:TextBox ID="txtUserId" runat="server" CssClass="input-field"></asp:TextBox></td>
        </tr>

        <tr>
            <td><h3>Enter Pharmacy Name</h3></td>
            <td><asp:TextBox ID="txtPharmacyname" runat="server" CssClass="input-field"></asp:TextBox></td>
            <td><asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Name can't be blank" ControlToValidate="txtPharmacyname" ForeColor="Red"></asp:RequiredFieldValidator></td>
        </tr>

        <tr>
            <td><h3>Enter the Location</h3></td>
            <td><asp:TextBox ID="txtLocation" runat="server" CssClass="input-field"></asp:TextBox></td>
            <td><asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Location can't be blank" ControlToValidate="txtLocation" ForeColor="Red"></asp:RequiredFieldValidator></td>
        </tr>

        <tr>
            <td><h3>Enter the Contact No</h3></td>
            <td><asp:TextBox ID="txtContactNumber" runat="server" CssClass="input-field"></asp:TextBox></td>
            <td><asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Contact Number can't be blank" ControlToValidate="txtContactNumber" ForeColor="Red"></asp:RequiredFieldValidator></td>
        </tr>

        <tr>
            <td><h3>Enter the Username</h3></td>
            <td><asp:TextBox ID="txtUsername" runat="server" CssClass="input-field"></asp:TextBox></td>
            <td><asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="UserName can't be blank" ControlToValidate="txtUsername" ForeColor="Red"></asp:RequiredFieldValidator></td>
        </tr>

        <tr>
            <td><h3>Enter the Password</h3></td>
            <td><asp:TextBox ID="txtPassword" runat="server" CssClass="input-field"></asp:TextBox></td>
            <td><asp:RequiredFieldValidator ID="rfvPassword" runat="server" ErrorMessage="Password can't be blank" ControlToValidate="txtPassword" ForeColor="Red"></asp:RequiredFieldValidator></td>
        </tr>

        <tr>
            <td>
                <asp:Button ID="btnSubmit" runat="server" CssClass="btn-submit" Text="Add Details" OnClick="btnSubmit_Click" /></td>
        </tr>

    </table>
    <asp:Label ID="lblText" runat="server" CssClass="label-text"></asp:Label>
</div>
    </form>
</body>
</html>
