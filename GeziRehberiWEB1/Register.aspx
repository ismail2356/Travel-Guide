<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="GeziRehberiWEB1.Register" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Register</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            background-color: #f4f4f4;
            margin: 0;
            padding: 0;
            display: flex;
            justify-content: center;
            align-items: center;
            height: 100vh;
        }

        #register-container {
            background-color: #fff;
            border-radius: 8px;
            box-shadow: 0 2px 4px rgba(0, 0, 0, 0.1);
            padding: 20px;
            width: 300px;
            text-align: center;
        }

        h2 {
            margin-bottom: 20px;
        }

        label {
            display: block;
            margin-bottom: 10px;
            font-weight: bold;
        }

        input[type="text"],
        input[type="password"],
        input[type="submit"] {
            width: 100%;
            padding: 10px;
            margin-bottom: 20px;
            border-radius: 4px;
            border: 1px solid #ccc;
            box-sizing: border-box;
        }

        input[type="submit"] {
            background-color: #4caf50;
            color: white;
            border: none;
            cursor: pointer;
            font-size: 16px;
        }

        input[type="submit"]:hover {
            background-color: #45a049;
        }

        .message {
            color: red;
            margin-top: 10px;
        }

        .link-button {
            background: none;
            border: none;
            color: #007bff;
            text-decoration: underline;
            cursor: pointer;
            margin-bottom: 10px;
        }

        .link-button:hover {
            color: #0056b3;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div id="register-container">
            <h2>Kayıt Ol</h2>
            <label for="txtFirstName">Ad:</label>
            <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
            <label for="txtLastName">soyad:</label>
            <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
            <label for="txtUsername">Kullanıcı Adı:</label>
            <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
            <label for="txtEmail">E-posta:</label>
            <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
            <label for="txtPassword">Şifre:</label>
            <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
            <asp:Button ID="btnRegister" runat="server" Text="Kayıt Ol" OnClick="btnRegister_Click" />
            <asp:Button ID="btnBackToLogin" runat="server" Text="Geri Dön" CssClass="link-button" PostBackUrl="~/Login.aspx" />
            <asp:Label ID="lblMessage" runat="server" CssClass="message"></asp:Label>
        </div>
    </form>
</body>
</html>
