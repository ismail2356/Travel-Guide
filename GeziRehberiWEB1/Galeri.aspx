<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Galeri</title>
    <style>
        body {
            font-family: Arial, sans-serif;
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
        }
        nav a {
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
        }
        .slideshow-container {
            position: relative;
            max-width: 800px; /* Daha iyi uyum için sabit bir genişlik */
            margin: auto;
            overflow: hidden;
            border: 1px solid #ddd;
            box-shadow: 0px 0px 10px rgba(0, 0, 0, 0.1); /* Gölgelendirme efekti */
        }
        .slides {
            display: flex;
            transition: transform 1s ease;
        }
        .slide {
            min-width: 100%;
            box-sizing: border-box;
        }
        .slide img {
            width: 100%;
            height: auto;
            display: block;
        }
        /* İleri ve geri düğmeleri */
        .prev, .next {
            cursor: pointer;
            position: absolute;
            top: 50%;
            transform: translateY(-50%);
            padding: 10px;
            background-color: rgba(0, 0, 0, 0.5);
            color: white;
            border: none;
            z-index: 100;
        }
        .prev {
            left: 0;
        }
        .next {
            right: 0;
        }
        /* Slayt indikatörleri */
        .dot-container {
            text-align: center;
            padding: 10px;
        }
        .dot {
            cursor: pointer;
            height: 15px;
            width: 15px;
            margin: 0 5px;
            background-color: #bbb;
            border-radius: 50%;
            display: inline-block;
            transition: background-color 0.3s ease;
        }
        .dot.active {
            background-color: #717171;
        }
    </style>
    <script>
        let slideIndex = 0;

        function showSlides() {
            const slides = document.querySelectorAll('.slide');
            const dots = document.querySelectorAll('.dot');
            for (let i = 0; i < slides.length; i++) {
                slides[i].style.transform = `translateX(${-slideIndex * 100}%)`;
            }
            slideIndex = (slideIndex + 1) % slides.length;

            // Aktif slayt indikatörünü güncelle
            for (let i = 0; i < dots.length; i++) {
                dots[i].classList.remove('active');
            }
            dots[slideIndex].classList.add('active');
        }

        setInterval(showSlides, 3000); // 3 saniyede bir slayt geçişi

        // Elle slayt geçişi
        function currentSlide(n) {
            slideIndex = n;
            showSlides();
        }

        // İleri ve geri düğmelerini tıklama işlevi
        function plusSlides(n) {
            showSlides(slideIndex += n);
        }
    </script>
</head>
<body onload="showSlides()">
    <form id="form1" runat="server">
        <div>
            <header>
                <h1>Galeri</h1>
            </header>
            <nav>
                <a href="Default.aspx">Ana Sayfa</a>
                <a href="Kurumsal.aspx">Kurumsal</a>
                <a href="iletisim.aspx">İletişim</a>
                <a href="Galeri.aspx">Galeri</a>
            </nav>
            <div class="content">
                
                <div class="slideshow-container">
                    <div class="slides">
                        <div class="slide">
                            <img src="assets/galeri/photo1.jpg" alt="Photo 1" />
                        </div>
                        <div class="slide">
                            <img src="assets/galeri/photo2.jpg" alt="Photo 2" />
                        </div>
                        <div class="slide">
                            <img src="assets/galeri/photo3.jpg" alt="Photo 3" />
                        </div>
                        <div class="slide">
                            <img src="assets/galeri/photo4.jpg" alt="Photo 4" />
                        </div>
                    </div>
                    <!-- İleri ve geri düğmeleri -->
                    <button type="button" class="prev" onclick="plusSlides(-1)">&#10094;</button>
                    <button type="button" class="next" onclick="plusSlides(1)">&#10095;</button>
                </div>
                <!-- Slayt indikatörleri -->
                <div class="dot-container">
                    <span class="dot" onclick="currentSlide(0)"></span>
                    <span class="dot" onclick="currentSlide(1)"></span>
                    <span class="dot" onclick="currentSlide(2)"></span>
                    <span class="dot" onclick="currentSlide(3)"></span>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
