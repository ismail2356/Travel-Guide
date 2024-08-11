using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NLog;


namespace GeziRehberiWEB1
{
    public partial class Default : System.Web.UI.Page
    {
        private const int PageSize = 5;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int pageIndex;
                if (!int.TryParse(Request.QueryString["page"], out pageIndex) || pageIndex < 1)
                {
                    pageIndex = 1;
                }

                List<Place> places = GetPlaces();
                int totalItems = places.Count;
                int totalPages = (int)Math.Ceiling((double)totalItems / PageSize);

                List<Place> pagedPlaces = places.GetRange((pageIndex - 1) * PageSize, Math.Min(PageSize, totalItems - (pageIndex - 1) * PageSize));
                repeaterPlaces.DataSource = pagedPlaces;
                repeaterPlaces.DataBind();

                List<PageItem> pages = new List<PageItem>();
                for (int i = 1; i <= totalPages; i++)
                {
                    pages.Add(new PageItem
                    {
                        PageNumber = i,
                        ActiveClass = (i == pageIndex) ? "active" : string.Empty
                    });
                }

                repeaterPages.DataSource = pages;
                repeaterPages.DataBind();
            }
        }

        private List<Place> GetPlaces()
        {
            return new List<Place>
            {
                new Place { Name = "Elazığ/Hazar Gölü", ImageUrl = "assets/yer3.jpg", Description = "Türkiye’nin büyüleyici doğa harikalarından biri olan ve yalnızca Elazığ için değil, bütün ülke için en önemli göllerden biri olarak değerlendirilen Hazar Gölü şehir merkezine 20 km uzaklıktadır. Deniz seviyesinden 1250 metre yüksekte olan göl yeşil ve mavinin her tonunu ziyaretçisine sunuyor.\r\n\r\nHazar Gölü çevresindeki huzurlu atmosferi ile Elazığ’ın en sevilen tatil yerlerinden biridir. Turistik olanakları da gelişmiş bir bölge olan Hazar Gölü etrafında pek çok restoran ve konaklayabileceğiniz tesisler bulunuyor. Suların altındaki batık şehirle ünlü olan Hazar Gölü’nü ve batık şehri tekne gezileri ile keşfedebilirsiniz. Benzersiz su altı fotoğrafları çekerek deneyiminizi ölümsüzleştirebileceğiniz Hazar Gölü yılın her dönemi şehrin en hareketli yerlerinden biridir." },
                new Place { Name = "Elazığ/Harput Kalesi", ImageUrl = "assets/yer4.jpg", Description = "M.Ö. 8. yüzyılda Urartular döneminde inşa edilen Harput Kalesi, bugüne dek ayakta kalabilmeyi başaran en önemli mimari şaheserlerden biridir. Şehre hakim yüksek bir tepe üzerinde yer alan ve devasa görüntüsü ile dikkatleri üzerine çekmeyi başaran Harput Kalesi, uzun tarihi boyunca pek çok egemenlik tarafından kullanılmış ve birçok efsaneye konu olmuştur.Dış ve iç kale olarak iki farklı bölüm şeklinde dizayn edilen ve dikdörtgen yapılı olan Harput Kalesi, onlarca metrelik kesme taşlarla yapıldığı için bugüne dek sağlam kalabilmeyi başarmıştır. Abbasiler, Selçuklular, Bizanslar ve Osmanlılar döneminde çarpıcı eklemeler yapılarak bugünkü haline ulaşan Harput Kalesi su sarnıcı, darphane, depo, cami, hastane ve yaşam alanları gibi farklı alanlara ev sahipliği yapıyor." },
                new Place { Name = "İstanbul/Topkapı Sarayı", ImageUrl = "assets/yer6.jpg", Description = "Osmanlı Dönemi’nde devletin yönetiminin yapıldığı saray aynı zamanda eğitim ve sultanların ikametgah yeriydi. 19. yüzyıla kadar saray olarak kullanılan yapı 1922 yılında Mustafa Kemal’in emri üzerine müze olarak kullanılmaya başlamıştır. Günümüzde de müze olarak kullanılan Topkapı Sarayı kutsal emanetler, padişah portreleri, Osmanlı Dönemi’ne ait eşyalar ve çeşitli ülkelere ait porselenlerin sergilendiği sayısız koleksiyona sahiptir." },
                new Place { Name = "İstanbul/Ayasofya Camii", ImageUrl = "assets/yer7.jpg", Description = "Fatih’te yer alan Bizans Dönemi yapılarından bir diğeri Ayasofya’dır. Görkemli mimarisiyle şehrin en tarihi yapılarından biri olan Ayasofya 537 yılından bugüne kadar aldığı hasarlar onarılarak gelmiştir. Hasar tamirlerinden sonra farklı yıllarda yeniden oluşan hasarlar en son Mimar Sinan’ın yaptığı desteklerle sağlamlaştırılmış, ufak farklı hasarları olsa da onarımlarla günümüze kadar gelmiştir.  \r\n\r\n1935 yılından 2020 yılına kadar müze olarak kullanılan Ayasofya günümüzde cami olarak kullanılmaktadır. Büyüklüğü ve ihtişamlı mimarisiyle sanat yapıtları arasında yer alan Ayasofya Camii içinde figürlü ve figürsüz mozaikler, galeri katı, papaz odaları ve 1. Mahmud kütüphanesi gibi alanlar bulunmaktadır. İbadet saatleri içinde camiyi ziyaret edebilirsiniz. " },
                new Place { Name = "İstanbul/Dolmabahçe Sarayı", ImageUrl = "assets/yer8.jpg", Description = "1850’li yıllarda inşa edilen Dolmabahçe Sarayı Beşiktaş’ta yer alan tarihi yapılardan biridir. Saltanatın kaldırılma sürecine kadar dönem padişahları ve halifeye ev sahipliği yapan saray 1924 yılında Mustafa Kemal tarafından da kullanılmış, 1984 yılında müzeye çevrilmiştir. Geleneksel Türk evi mimarisi üzerine Barok, Ampir ve Rokoko akımlarından izler taşımaktadır." },
                new Place { Name = "Van/Van Gölü", ImageUrl = "assets/yer9.jpg", Description = "Türkiye’nin yüzölçümü en geniş gölüdür. Aynı zamanda, Van Gölü dünyadaki en geniş sodalı gölü olarak da bilinir. Van ve Bitlis illeri arasında yer alan Van Gölü, yanında bulunan Nemrut Dağı’nın patlamasıyla oluşmuştur. Bu sebeple volkanik set gölüdür. \r\n\r\nEfsanevi bir canavara yer verdiği hakkında uzun yıllardır anlatılan hikayeleri ve ev sahipliği yaptığı çok sayıda balık türü ile Van Gölü, Van seyahatlerinin ilk durağıdır. Gölü daha yakından görmek ve keşfetmek istiyorsanız her mevsim gerçekleşen tekne turlarına katılabilirsiniz. " },
                new Place { Name = "Van/Akdamar Adası ve Kilisesi", ImageUrl = "assets/yer10.jpg", Description = "Van Gölü’nün içinde bulunan Akdamar Adası gölün üstünden yükseliyor. Adada 10. yüzyılda inşa edildiği düşünülen bir kilise bulunuyor. Ermeni Kralı I.Gagik tarafından inşa edilen ve Surp Harç Kilisesi ismi ile de anılan Akdamar Kilisesi Van’da yapılan tarihi ve kültürel seyahatlerin vazgeçilmez noktalarından biri oluyor. Akdamar Kilisesi 2007 yılında restorasyon çalışmasından geçmiştir. Çalışma sonrası ziyarete açılan kilise mimari özelliklerinin yanı sıra kültürel değeri sebebiyle de yoğun ilgi görür. Elbette Akdamar Adası’nın ziyaret edilmesinin tek nedeni kilise değildir. Bununla birlikte doğal güzellikleri de adanın ziyaret edilmesinin temel nedenleri arasındadır. Aynı zamanda Akdamar Adası kapsadığı 7 kilometrelik alan ile Van Gölü’nün en büyük adası olma özelliği taşıyor." },
                new Place { Name = "Van/Muradiye Şelalesi", ImageUrl = "assets/yer11.jpg", Description = "Van’ın doğusunda ve Muradiye ilçesinde yer alan, ismini bulunduğu ilçeden alan Muradiye Şelalesi Van’da mutlaka görülmesi gereken doğal güzelliklerden biridir. Muradiye Şelalesi Van Gölü’nü besleyen en önemli kaynaklardan biridir." },
                new Place { Name = "Mardin/Mardin Kalesi", ImageUrl = "assets/yer12.jpg", Description = "1600 yıllık çok köklü bir geçmişe sahip Mardin Kalesi, askeriye bir yapı olarak inşa edildi. Yer aldığı lokasyon göz önünde bulundurulduğunda bölgede yaşayan tüm medeniyetler tarafından kullanılmış olduğu görülüyor. Mardin Kalesi halk arasında “Kartal Yuvası” ismi ile anılıyor.\r\n\r\nMardin seyahatiniz esnasında mutlaka ziyaret etmeniz gereken kaleyi giriş için herhangi bir ücret talep edilmiyor. Ancak kaleye ulaşmak için uzun bir merdiven tırmanmanız gerekiyor. Eğer talep ederseniz kalenin tarihini daha yakından tanımak için tur şirketleri tarafından sunulan rehber hizmetinden faydalanabilirsiniz.\r\n\r\nMardin şehir merkezinin her noktasından görebileceğiniz Mardin Kalesine yürüyerek ulaşım oldukça kolay. Bu özelliğiyle de turistik açıdan en çok tercih edilen yapılardan biri oluyor." },
                new Place { Name = "Mardin/Deyrulzafaran Manastırı", ImageUrl = "assets/yer13.jpg", Description = "Mardin şehir merkezinde, Eskikale mevkiinde yer alan Deyrulzafaran Manastırı, merkeze yalnızca 8 km uzaklıkta konumlanıyor. D-955 üzerinden ulaşım sağlayabilirsiniz.\r\n\r\nManastırın 400’lü yıllarda inşa edildiği düşünülüyor. Süryani kiliselerinin önemli bir merkezde olan ve muhteşem mimarisiyle görenleri büyüleyen manastır, Mardin adına çok önemli bir yere sahip." },
                new Place { Name = "Nevşehir/Devrent Vadisi", ImageUrl = "assets/yer14.jpg", Description = "ayal Vadisi olarak da bilinen Devrent Vadisi, Kapadokya’da gezilecek yerler listesinde ilk sıralarda yer alıyor. Kapadokya’nın en ilginç peri bacalarının bulunduğu vadi adını da bu peribacalarının şekillerinden almıştır. Hayal gücünüzün alabildiği her şekilden peri bacaları bir arada bulunuyor. Devrent Vadisi’ndeki en popüler peri bacası ise devasa boyuttaki ve deve şeklindeki peri bacası. Doğa yürüyüşü, at safari ve trekking yapabileceğiniz bu vadi dört mevsim gezilip görülmeye değer. Tost ve gözleme gibi atıştırmalıklar ve çeşitli meşrubatlar bulunan büfeler dışında yeme içme alanları bulunmuyor. Vadiye minibüs ve özel araç ile ulaşım sağlanabilir." },
                new Place { Name = "Nevşehir/Göreme Açık Hava Müzesi", ImageUrl = "assets/yer15.jpg", Description = "Göreme kasabasının 2 kilometre doğusunda yer alan Göreme Açık Hava Müzesi 6 Aralık 1985 yılından bu yana UNESCO Dünya Miras Listesi’nde ye alıyor. M.S 4. yüzyıldan 13. yüzyıla kadar olan dönemi kapsayan ve içerisinde bir yaşam olduğu bilinen manastırı, bu kaya yerleşim yerinde gözlemlemek mümkün. Manastır eğitim sisteminin başlatıldığı yer olan bu alan günümüzde müze olarak kullanılıyor." },
                new Place { Name = "Nevşehir/Aşk Vadisi", ImageUrl = "assets/yer16.jpg", Description = "Aşıklar Vadisi ve Bağlıdere gibi pek çok isimle bilinen Aşk Vadisi, üzüm bağlarının eşlik ettiği bir yolda yürüyüş yapmanıza olanak tanır. 4900 metre uzunluğa sahip olan Aşk Vadisi, pek çok güzel ve farklı peribacalarına ev sahipliği yapıyor." },
                new Place { Name = "İzmir/Agora Açıkhava Müzesi", ImageUrl = "assets/yer17.jpg", Description = "İzmir’de bulunan ve en önemli üç ören yerinden biri olma özelliği taşıyan Agora, bugüne dek birçok farklı milletin egemenliği altına girmiş. Sütun ve kemerler üzerinde çok katlı olarak inşa edilmiş bir yapı topluluğu olan Agora, yapısı ile dünyadaki tek. Günümüzde belediye tarafından yapılan çeşitli çalışmalar ile daha başarılı hale getirilen ancak arkeolojik çalışmaların hala devam ettiği bilinen Agora Açık Hava Müzesi" },
                new Place { Name = "Bitlis/Nemrut Krater Gölü", ImageUrl = "assets/yer19.jpg", Description = "Ülkemizin dünyaca meşhur güzelliklerinden biri olan Nemrut Krater Gölü, hem oluşumundaki mucizesi hem de doğal manzarasıyla hayranlık uyandırıyor. Nemrut Krater Gölü aynı zamanda dünyadaki en büyük 2 krater gölünden biri durumunda. Toplamda 12 km’lik bir alana yayılan göl, toplamda 5 ayrı gölün birleşiminden meydana geliyor. Çevresinde yer alan kamp alanlarıyla da dikkat çeken bu tabiat güzelliği, pek çok aktiviteye uygun.\r\n\r\nSazan balığının yoğunluğu nedeniyle gölde balıkçılık oldukça yaygın. Yürüyüş yolları ve piknik için elverişli doğasıyla özellikle yaz aylarında çok sayıda kişinin ziyaret ettiği Nemrut Krater Gölünün en derin bölümü 155 metre. Gölün belli bölümlerinde yüzen insanlara tanıklık edebilirsin. Aynı ada sahip dağın dördüncü zamanda yaşadığı patlama neticesinde oluşan bu mucizevi göl, yüzlerce kuş türüne ev sahipliği yapıyor. Özetle, dünyada cenneti yaşamak istiyorsan, Bitlis’te yer alan Nemrut Krater Gölünü mutlaka gezi listenin başına almalısın." },
                new Place { Name = "Siirt/Botan Çayı", ImageUrl = "assets/yer21.jpg", Description = "Siirt’in bir diğer doğal güzelliği olan Botan Çayı, aynı adı taşıyan vadiyle özdeşleşmiş bir yer. Karşısına tarihi kaleleri ve seyir teraslarını alan bu ünlü çay, Siirt mağaralarına da oldukça yakın bir konumda. Bölge halkı, şehrin sembolik mekânlarından biri olan Botan Çayı’nı piknik yapmak için de sıklıkla kullanıyor. Aynı zamanda Dicle’nin bir kolu olarak da bilinen bu çay, Siirt dışında Batman ve Şırnak gibi şehirleri de içine alıyor.\r\n\r\nAdını önemli bir beylik olan Botan Beyliği’nden alan bölge, Ksenofon’un “Anabasis” isimli eserinde de geçiyor. Farklı şehirler arasında uzun bir yolculuk yapan Botan Çayı’nda kano başta olmak üzere pek çok aktivite gerçekleşiyor. Kaynağını bölgedeki dağlardan alan çay, Çatak Çayı ile Büyükdere ve Çukurca köylerinde birleşiyor." },
            };
        }


        public class Place
        {
            public string Name { get; set; }
            public string ImageUrl { get; set; }
            public string Description { get; set; }
        }

        public class PageItem
        {
            public int PageNumber { get; set; }
            public string ActiveClass { get; set; }
        }
    }
}