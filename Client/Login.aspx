<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Client.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        body {
            display: flex;
            justify-content: center;
            align-items: center;
            min-height: 100vh;
            margin: 0;
            background:linear-gradient(to top right, #131212, #382948);
            font-family: Arial, sans-serif;
        }

        .formlogin {
            background: white;
            padding: 2rem;
            box-shadow: 0 2px 4px rgba(0, 0, 0, 0.1);
            width: 100%;
            max-width: 500px;
        }

        .Login {
            width: 100%;
        }

        .Login_h2 {
            color: #131212;
            margin-bottom: 2rem;
            text-align: center;
            font-size:60px;
            font-weight: bold;
            font-family:'Trebuchet MS', 'Lucida Sans Unicode', 'Lucida Grande', 'Lucida Sans', Arial, sans-serif;
        }

        .Login_h3 {
            color: #333;
            font-size: 20px;
            margin: 0.5rem 0;
        }

        table {
            width: 100%;
        }

        td {
            padding: 0.5rem;
        }

        .input-field {
            width: 100%;
            padding: 0.5rem;
            border: 1px solid #666;
            border-radius: 4px;
            font-size: 1rem;
        }

        .btn_login {
            background:linear-gradient(to right, #667eea, #764ba2);
            color: white;
            padding: 0.7rem 5rem;
            border: none;
            border-radius: 4px;
            cursor: pointer;
            font-size: 1rem;
            margin-top: 1rem;
            font-weight: bold;
        }

        .btn_login:hover {
            background-color: #45a049;
        }

        .label-text {
            display: block;
            margin-top: 1rem;
            color: #666;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" class="formlogin">
                <div class="Login">
            <h2 class="Login_h2">SIGN IN</h2>
    <table>
        <tr>
            <td><h3 class="Login_h3">Enter the Username</h3></td>
            <td>
                <asp:TextBox ID="txtusername" runat="server" CssClass="input-field"></asp:TextBox></td>
            <td><asp:RequiredFieldValidator ID="rfvUserName" runat="server" ErrorMessage="UserName can't be blank" ControlToValidate="txtusername" ForeColor="Red"></asp:RequiredFieldValidator></td>
        </tr>

        <tr>
            <td><h3 class="Login_h3" >Enter the Password</h3></td>
            <td>
                <asp:TextBox ID="txtPassword" runat="server" CssClass="input-field" OnTextChanged="txtPassword_TextChanged" TextMode="Password"></asp:TextBox></td>
            <td><asp:RequiredFieldValidator ID="rfvPassword" runat="server" ErrorMessage="Password can't be blank" ControlToValidate="txtPassword" ForeColor="Red"></asp:RequiredFieldValidator></td>
        </tr>

        <tr>
            <td>
                <asp:Button ID="btnSubmit" runat="server" Text="SIGN IN" OnClick="btnSubmit_Click" CssClass="btn_login"/></td>
        </tr>

    </table>
    <asp:Label ID="lblText" runat="server" CssClass="label-text"></asp:Label>
</div>
    </form>
</body>
</html>
