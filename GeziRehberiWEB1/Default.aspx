<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="GeziRehberiWEB1.Default" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Ana Sayfa</title>
    <style>
        body {
            font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
            background-color: #f4f4f9;
            margin: 0;
            padding: 0;
        }
        header {
            background-color: #4CAF50;
            color: white;
            padding: 20px;
            text-align: center;
            box-shadow: 0 2px 4px rgba(0, 0, 0, 0.1);
        }
        nav {
            margin: 0;
            padding: 15px;
            background-color: #333;
            display: flex;
            justify-content: center;
        }
        nav a {
            color: white;
            padding: 14px 20px;
            text-decoration: none;
            text-align: center;
            transition: background-color 0.3s, color 0.3s;
        }
        nav a:hover {
            background-color: #ddd;
            color: black;
        }
        .content {
            padding: 40px;
            max-width: 1200px;
            margin: 0 auto;
        }
        .place {
            border: 1px solid #ddd;
            border-radius: 8px;
            background-color: white;
            margin-bottom: 20px;
            padding: 20px;
            text-align: center;
            box-shadow: 0 4px 8px rgba(0, 0, 0, 0.1);
            transition: transform 0.3s;
        }
        .place:hover {
            transform: translateY(-5px);
        }
        .place img {
            max-width: 100%;
            height: auto;
            border-radius: 8px;
        }
        .pagination {
            text-align: center;
            margin-top: 20px;
        }
        .pagination a {
            margin: 0 5px;
            text-decoration: none;
            color: #4CAF50;
            padding: 8px 12px;
            border-radius: 4px;
            border: 1px solid #4CAF50;
            transition: background-color 0.3s, color 0.3s;
        }
        .pagination a:hover, .pagination a.active {
            background-color: #4CAF50;
            color: white;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <header>
                <h1>Hoşgeldiniz!</h1>
            </header>
            <nav>
                <a href="Default.aspx">Ana Sayfa</a>
                <a href="Kurumsal.aspx">Kurumsal</a>
                <a href="iletisim.aspx">İletişim</a>
                <a href="Galeri.aspx">Galeri</a>
            </nav>
            <div class="content">
                <asp:Repeater ID="repeaterPlaces" runat="server">
                    <ItemTemplate>
                        <div class="place">
                            <h2><%# Eval("Name") %></h2>
                            <img src='<%# Eval("ImageUrl") %>' alt='<%# Eval("Name") %>' />
                            <p><%# Eval("Description") %></p>
                        </div>
                    </ItemTemplate>
                </asp:Repeater>
                <div class="pagination">
                    <asp:Repeater ID="repeaterPages" runat="server">
                        <ItemTemplate>
                            <a href="Default.aspx?page=<%# Eval("PageNumber") %>" class='<%# Eval("ActiveClass") %>'><%# Eval("PageNumber") %></a>
                        </ItemTemplate>
                    </asp:Repeater>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
