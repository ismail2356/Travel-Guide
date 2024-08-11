<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="iletisim.aspx.cs" Inherits="GeziRehberiWEB1.iletisim" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>İletişim</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            background-image: url('assets/view.jpg'); 
            background-size: cover; 
            background-repeat: no-repeat; 
            margin: 0;
            padding: 0;
        }
        header {
            background-color: #4CAF50;
            color: white;
            padding: 15px;
            text-align: center;
        }
        nav {
            margin: 0;
            padding: 10px;
            background-color: #333;
            overflow: hidden;
        }
        nav a {
            float: left;
            display: block;
            color: white;
            padding: 14px 20px;
            text-decoration: none;
            text-align: center;
        }
        nav a:hover {
            background-color: #ddd;
            color: black;
        }
        .content {
            padding: 20px;
            background-color: rgba(255, 255, 255, 0.8);
            margin: 20px;
            border-radius: 10px;
        }
        .contact-info {
            margin-top: 20px;
        }
        .contact-info h3 {
            margin-bottom: 10px;
        }
        .contact-info p {
            margin: 5px 0;
        }
        .contact-form {
            margin-top: 30px;
        }
        .contact-form label {
            display: block;
            margin: 10px 0 5px;
        }
        .contact-form input, .contact-form textarea {
            width: 100%;
            padding: 10px;
            margin-bottom: 10px;
            border: 1px solid #ccc;
            border-radius: 5px;
        }
        .contact-form button {
            background-color: #4CAF50;
            color: white;
            padding: 10px 20px;
            border: none;
            border-radius: 5px;
            cursor: pointer;
        }
        .contact-form button:hover {
            background-color: #45a049;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <header>
                <h1>İletişim</h1>
            </header>
            <nav>
                <a href="Default.aspx">Ana Sayfa</a>
                <a href="Kurumsal.aspx">Kurumsal</a>
                <a href="iletisim.aspx">İletişim</a>
                <a href="Galeri.aspx">Galeri</a>
            </nav>
            <div class="content">
                <h2>İletişim Bilgileri</h2>
                <div class="contact-info">
                    <h3>Adres:</h3>
                    <p>1234 Gezi Caddesi, Gezgin Mahallesi, İstanbul</p>
                    
                    <h3>Telefon:</h3>
                    <p>+90 212 345 67 89</p>
                    
                    <h3>E-posta:</h3>
                    <p>info@gezi.com</p>
                </div>
                <div class="contact-form">
                    <h2>Bize Ulaşın</h2>
                    <label for="name">Adınız</label>
                    <input type="text" id="name" name="name" required />
                    
                    <label for="email">E-posta</label>
                    <input type="email" id="email" name="email" required />
                    
                    <label for="message">Mesajınız</label>
                    <textarea id="message" name="message" rows="4" required></textarea>
                    
                    <button type="submit">Gönder</button>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
