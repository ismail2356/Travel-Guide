<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ResetPassword.aspx.cs" Inherits="GeziRehberiWEB1.ResetPassword" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Şifre Sıfırlama</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            background-color: #f0f2f5;
            display: flex;
            justify-content: center;
            align-items: center;
            height: 100vh;
            margin: 0;
        }
        #form1 {
            background-color: #fff;
            padding: 20px;
            border-radius: 8px;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
            width: 300px;
        }
        h2 {
            margin-bottom: 20px;
            font-size: 24px;
            color: #333;
            text-align: center;
        }
        .form-group {
            margin-bottom: 15px;
        }
        .form-group label {
            display: block;
            margin-bottom: 5px;
            color: #555;
        }
        .form-group input {
            width: calc(100% - 10px);
            padding: 8px;
            font-size: 14px;
            border: 1px solid #ccc;
            border-radius: 4px;
        }
        .form-group input[type="password"] {
            width: calc(100% - 16px);
        }
        .form-group input:focus {
            border-color: #007bff;
        }
        .form-group button {
            width: 100%;
            padding: 10px;
            background-color: #007bff;
            border: none;
            border-radius: 4px;
            color: #fff;
            font-size: 16px;
            cursor: pointer;
        }
        .form-group button:hover {
            background-color: #0056b3;
        }
        .form-group .message {
            margin-top: 15px;
            font-size: 14px;
            color: #d9534f;
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Şifre Sıfırlama</h2>
            <div class="form-group">
                <asp:Label ID="lblResetCode" runat="server" Text="Sıfırlama Kodu:"></asp:Label>
                <asp:TextBox ID="txtResetCode" runat="server"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Label ID="lblNewPassword" runat="server" Text="Yeni Şifre:"></asp:Label>
                <asp:TextBox ID="txtNewPassword" runat="server" TextMode="Password"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Button ID="btnResetPassword" runat="server" Text="Şifreyi Sıfırla" OnClick="btnResetPassword_Click" />
            </div>
            <div class="form-group">
                <asp:Label ID="lblMessage" runat="server" CssClass="message"></asp:Label>
            </div>
        </div>
    </form>
</body>
</html>
