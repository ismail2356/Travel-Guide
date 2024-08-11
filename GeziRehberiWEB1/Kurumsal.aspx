<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Kurumsal.aspx.cs" Inherits="GeziRehberiWEB1.Kurumsal" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Kurumsal</title>
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
        .corporate-info {
            margin-top: 20px;
        }
        .corporate-info h2 {
            border-bottom: 2px solid #4CAF50;
            padding-bottom: 10px;
        }
        .corporate-info p {
            margin: 15px 0;
            line-height: 1.6;
        }
        .team {
            display: flex;
            flex-wrap: wrap;
            gap: 20px;
            margin-top: 30px;
        }
        .team-member {
            flex: 1 1 calc(33% - 20px);
            background-color: #f9f9f9;
            padding: 20px;
            border-radius: 10px;
            box-shadow: 0 2px 4px rgba(0, 0, 0, 0.1);
            text-align: center;
        }
        .team-member img {
            border-radius: 50%;
            width: 100px;
            height: 100px;
        }
        .team-member h3 {
            margin: 10px 0 5px;
        }
        .team-member p {
            margin: 0;
            color: #777;
        }
    </style>
   <script>
       let logData = {
           page: 'Kurumsal',
           enterTime: new Date().toISOString(),
           leaveTime: null,
           mouseMoves: [],
           clicks: []
       };

       document.addEventListener('mousemove', (event) => {
           logData.mouseMoves.push({ x: event.clientX, y: event.clientY, time: new Date().toISOString() });
       });

       document.addEventListener('click', (event) => {
           logData.clicks.push({ x: event.clientX, y: event.clientY, time: new Date().toISOString(), element: event.target.tagName });
       });

       window.addEventListener('beforeunload', () => {
           logData.leaveTime = new Date().toISOString();
           navigator.sendBeacon('LogHandler.ashx', JSON.stringify(logData));
       });
   </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <header>
                <h1>Kurumsal</h1>
            </header>
            <nav>
                <a href="Default.aspx">Ana Sayfa</a>
                <a href="Kurumsal.aspx">Kurumsal</a>
                <a href="iletisim.aspx">İletişim</a>
                <a href="Galeri.aspx">Galeri</a>
            </nav>
            <div class="content">
                <div class="corporate-info">
                    <h2>Hakkımızda</h2>
                    <p>
                        Gezi Rehberi, turizm sektöründe öncü bir kuruluş olarak, müşterilerine en iyi hizmeti sunmayı amaçlamaktadır. Misyonumuz, her müşterimize unutulmaz bir gezi deneyimi yaşatmaktır.
                    </p>
                    <p>
                        Şirketimiz, yılların getirdiği deneyimle sektörde kendine sağlam bir yer edinmiştir. Profesyonel ekibimiz ve geniş hizmet yelpazemizle, her türlü gezi ihtiyacınızı karşılamaktayız.
                    </p>
                </div>
                <div class="team">
                    <div class="team-member">
                        <img src="assets/team1.jpg" alt="Team Member 1">
                        <h3>Ahmet Yılmaz</h3>
                        <p>CEO</p>
                    </div>
                    <div class="team-member">
                        <img src="assets/team2.jpg" alt="Team Member 2">
                        <h3>Muhammed Demir</h3>
                        <p>Pazarlama Müdürü</p>
                    </div>
                    <div class="team-member">
                        <img src="assets/team3.jpg" alt="Team Member 3">
                        <h3>Mehmet Öz</h3>
                        <p>Operasyon Müdürü</p>
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
