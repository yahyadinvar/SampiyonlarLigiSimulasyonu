// Yahya Dinvar 

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace SampiyonlarLigiSimulasyonu
{
    public partial class Form1 : Form
    {
        // Takım türünden bir liste oluşturuluyor [1].
        List<Takim> takimlar;

        // ListBox türünden listeler oluşturuluyor.
        //List<ListBox> torba1 = new List<ListBox>();
        //List<ListBox> torba2 = new List<ListBox>();
        //List<ListBox> torba3 = new List<ListBox>();
        //List<ListBox> torba4 = new List<ListBox>();

        //List<ListBox> gruplar = new List<ListBox>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Uygulama başladığında .wav türündeki müzik dosyası başlatılıyor.
            // using System.Media kütüphanesi ile kullanılıyor.
            SoundPlayer muzik = new SoundPlayer();
            string muzikYolu = Application.StartupPath + "\\uefa.wav";
            muzik.SoundLocation = muzikYolu;
            muzik.Play();

            // Takım sınıfından bir nesne türetiliyor. İlk takım değerim olmadığı için null belirliyorum. 
            Takim yeniTakim = null;

            takimlar = new List<Takim>(); // [1].

            // Takımları yeniTakim nesnesi kullanarak Takım sınıfıma ulaşıyorum ve istenilen formatta parametreleri gönderiyorum.
            yeniTakim = new Takim("Bayern Munich","Almanya");
            takimlar.Add(yeniTakim); // takimlar listeme de ekliyorum.
            yeniTakim = new Takim("Sevilla", "İspanya");
            takimlar.Add(yeniTakim);
            yeniTakim = new Takim("Real Madrid", "İspanya");
            takimlar.Add(yeniTakim);
            yeniTakim = new Takim("Liverpool", "İngiltere");
            takimlar.Add(yeniTakim);
            yeniTakim = new Takim("Juventus", "İtalya");
            takimlar.Add(yeniTakim);
            yeniTakim = new Takim("Paris Saint-Germain", "Fransa");
            takimlar.Add(yeniTakim);
            yeniTakim = new Takim("Zenit", "Rusya");
            takimlar.Add(yeniTakim);
            yeniTakim = new Takim("Porto", "Portekiz");
            takimlar.Add(yeniTakim);
            yeniTakim = new Takim("Barcelona", "İspanya");
            takimlar.Add(yeniTakim);
            yeniTakim = new Takim("Atletico Madrid", "İspanya");
            takimlar.Add(yeniTakim);
            yeniTakim = new Takim("Manchester City", "İngiltere");
            takimlar.Add(yeniTakim);
            yeniTakim = new Takim("Manchester United", "İngiltere");
            takimlar.Add(yeniTakim);
            yeniTakim = new Takim("Borussia Dortmund", "Almanya");
            takimlar.Add(yeniTakim);
            yeniTakim = new Takim("Shaktar Donetsk", "Ukrayna");
            takimlar.Add(yeniTakim);
            yeniTakim = new Takim("Chelsea", "İngiltere");
            takimlar.Add(yeniTakim);
            yeniTakim = new Takim("Ajax", "Hollanda");
            takimlar.Add(yeniTakim);
            yeniTakim = new Takim("Dynamo Kiev", "Ukrayna");
            takimlar.Add(yeniTakim);
            yeniTakim = new Takim("Red Bull Salzburg", "Almanya");
            takimlar.Add(yeniTakim);
            yeniTakim = new Takim("RB Leipzig", "Almanya");
            takimlar.Add(yeniTakim);
            yeniTakim = new Takim("Internazionale", "İtalya");
            takimlar.Add(yeniTakim);
            yeniTakim = new Takim("Olympiacos", "Yunanistan");
            takimlar.Add(yeniTakim);
            yeniTakim = new Takim("Lazio", "İtalya");
            takimlar.Add(yeniTakim);
            yeniTakim = new Takim("Krasnodar", "Rusya");
            takimlar.Add(yeniTakim);
            yeniTakim = new Takim("Atalanta", "İtalya");
            takimlar.Add(yeniTakim);
            yeniTakim = new Takim("Lokomotiv Moskova", "Rusya");
            takimlar.Add(yeniTakim);
            yeniTakim = new Takim("Marseille", "Fransa");
            takimlar.Add(yeniTakim);
            yeniTakim = new Takim("Club Brugge", "Belçika");
            takimlar.Add(yeniTakim);
            yeniTakim = new Takim("Bor. Mönchengladbach", "Almanya");
            takimlar.Add(yeniTakim);
            yeniTakim = new Takim("Galatasaray", "Türkiye");
            takimlar.Add(yeniTakim);
            yeniTakim = new Takim("Midtjylland", "Danimarka");
            takimlar.Add(yeniTakim);
            yeniTakim = new Takim("Rennes", "Fransa");
            takimlar.Add(yeniTakim);
            yeniTakim = new Takim("Ferencvaros", "Macaristan");
            takimlar.Add(yeniTakim);
            
            // takimlar listemin içine tüm takımlar eklendikten sonra torbalara ayırıyorum
            for (int i = 0; i < takimlar.Count; i++) // takimlar.Count -> takimlar listesinin içindeki veri sayısını hesapla.
            {
                if (i < 8) // listenin içindeki ilk 8 takım 1.torba
                {
                    LstTorba1.Items.Add(takimlar[i]); // LstTorba1 adındaki listbox a, takımlar listesinin içindeki ilk 8 takımı ekle.
                    //torba1.Add(LstTorba1);
                }
                else if (i < 16)  // listenin içindeki 8 den sonra 16 ya kadar olan takımlar 2.torba
                { 
                    LstTorba2.Items.Add(takimlar[i]); // LstTorba2 adındaki listbox a, takımlar listesinin içindeki ikinci 8 takımı ekle.
                    //torba2.Add(LstTorba2);
                }
                else if (i < 24) // listenin içindeki 16 dan sonra 24 e kadar olan takımlar 3.torba
                {
                    LstTorba3.Items.Add(takimlar[i]); // LstTorba3 adındaki listbox a, takımlar listesinin içindeki üçüncü 8 takımı ekle.
                    //torba3.Add(LstTorba3);
                } 
                else if (i < 32) // listenin içindeki 24 den sonra 32 ye kadar olan takımlar 4.torba
                {
                    LstTorba4.Items.Add(takimlar[i]); // LstTorba2 adındaki listbox a, takımlar listesinin içindeki dördüncü 8 takımı ekle.
                    //torba4.Add(LstTorba4);
                }
            }

            // Torbaları dağıtmak için dört adet buton kullanıldı. Uygulama başlatıldığında sadece 1.buton aktif. 1. butona tıklanmadan diğer butonlara tıklanamaz.
            btn1Dagit.Enabled = true; btn1Dagit.BackColor = Color.Gainsboro; // 1.buton aktif ediliyor ve arka plan rengi butonun aktif oldğunu belirtmek için değiştiriliyor.
            btnTorba2Dagit.Enabled = false;
            btnTorba3Dagit.Enabled = false;
            btnTorba4Dagit.Enabled = false;

            // Grupların içerisindeki detay butonları torbalar dağıtılmadan aktif edilmiyor.
            btnGrupA.Enabled = false;
            btnGrupB.Enabled = false;
            btnGrupC.Enabled = false;
            btnGrupD.Enabled = false;
            btnGrupE.Enabled = false;
            btnGrupF.Enabled = false;
            btnGrupG.Enabled = false;
            btnGrupH.Enabled = false;
        }

        // 1. butona basıldığında 1.torbanın 8 ayrı gruba dağıtılması işlemi
        private void btn1Dagit_Click(object sender, EventArgs e)
        {
            Random rastgele = new Random(); // Rastgele sayı üretmek için Random sınıfından nesne üretiyoruz.
            List<int> secilentakimlar = new List<int>(); // Seçilen takımları tutacağım int veri tipinde bir liste tanımlıyorum.

            // For döngüsü ile takımlar listesinin eleman sayısının (32), 4'e bölümündeki değere kadar olan takımların üzerinde işlem yapıyorum.
            for (int i = 0; i < takimlar.Count / 4; i++) 
            {
                int secilenTakim = rastgele.Next(0, takimlar.Count / 4); // Rastgele bir takım seç. Bu takım takimlar sınıfının ilk 8 elemanından olsun. 
                
                // secilentakimlar listesinin içinde Contains methodu ile rastgele üretilen sayıyı ara. Bu veri secilen takımlar listesinde varsa sayacı 1 azalt. 
                // Bu sayede aynı takım seçilemiyor. Tekrar o sayaç değeri için farklı bir takım seçilene kadar devam ediyor.
                if (secilentakimlar.Contains(secilenTakim))  {
                    i--;
                }
                else
                {
                    secilentakimlar.Add(secilenTakim); // secilen takımlarda rastgele üretilen sayı yoksa secilenTakimlar listesine ekle. 
                }
            }

            // Grupları temsil eden listbox lara rastgele üretilen ve secilenTakimlar listesinde tutulan takımları sırayla gruplara ekle.
            LstGrupA.Items.Add(takimlar[secilentakimlar[0]]);
            LstGrupB.Items.Add(takimlar[secilentakimlar[1]]);
            LstGrupC.Items.Add(takimlar[secilentakimlar[2]]);
            LstGrupD.Items.Add(takimlar[secilentakimlar[3]]);
            LstGrupE.Items.Add(takimlar[secilentakimlar[4]]);
            LstGrupF.Items.Add(takimlar[secilentakimlar[5]]);
            LstGrupG.Items.Add(takimlar[secilentakimlar[6]]);
            LstGrupH.Items.Add(takimlar[secilentakimlar[7]]);

            secilentakimlar.Clear(); // secilenTakimlar listesinin sıfırlıyorum ki diğer torbalarda da aynı işlemi uygulayayım.
            btn1Dagit.Enabled = false; btn1Dagit.BackColor = Color.SlateGray; //1.torbayı temsil eden 1.buton aktif özelliği kapatılıyor ve arka plan rengi varsayılan rengine dönüyor.
            btnTorba2Dagit.Enabled = true; btnTorba2Dagit.BackColor = Color.Gainsboro; // Sıradaki buton olan 2.buton aktif ediliyor.
        }

        // 1.torba için yapılan gruplara ayırma işleminin aynısı 2.torba için de yapılıyor.
        private void btnTorba2Dagit_Click(object sender, EventArgs e)
        {
            Random rastgele = new Random();
            List<int> secilentakimlar = new List<int>();

            for (int i = takimlar.Count / 4; i < takimlar.Count / 2; i++) // takimlar listesinin 8 - 16 elamanları arasındaki takım sayısı kadar rastgele takım üretmesini sağlıyor.
            {
                int secilenTakim = rastgele.Next(takimlar.Count / 4, takimlar.Count / 2); // takimlar listesinin 8 - 16 elamanları arasındaki takımlar için yap.

                if (secilentakimlar.Contains(secilenTakim))
                {
                    i--;
                }
                else
                {
                    secilentakimlar.Add(secilenTakim);
                }
            } 
            LstGrupA.Items.Add(takimlar[secilentakimlar[0]]);
            LstGrupB.Items.Add(takimlar[secilentakimlar[1]]);
            LstGrupC.Items.Add(takimlar[secilentakimlar[2]]);
            LstGrupD.Items.Add(takimlar[secilentakimlar[3]]);
            LstGrupE.Items.Add(takimlar[secilentakimlar[4]]);
            LstGrupF.Items.Add(takimlar[secilentakimlar[5]]);
            LstGrupG.Items.Add(takimlar[secilentakimlar[6]]);
            LstGrupH.Items.Add(takimlar[secilentakimlar[7]]);

            secilentakimlar.Clear();
            btnTorba2Dagit.Enabled = false; btnTorba2Dagit.BackColor = Color.SlateGray; // 2. buton da aktif özelliği kapatılıyor.
            btnTorba3Dagit.Enabled = true; btnTorba3Dagit.BackColor = Color.Gainsboro; // 3. buton aktif ediliyor.
        }

        // Diğer torbalar için yapılan gruplara ayırma işleminin aynısı 3.torba için de yapılıyor.
        private void btnTorba3Dagit_Click(object sender, EventArgs e)
        {
            Random rastgele = new Random();
            List<int> secilentakimlar = new List<int>();

            for (int i = takimlar.Count / 2; i < (takimlar.Count /4)*3; i++) // takimlar listesinin 16 - 24 elamanları arasındaki takım sayısı kadar rastgele takım üretmesini sağlıyor.
            {
                int secilenTakim = rastgele.Next(takimlar.Count / 2, (takimlar.Count / 4) * 3); // takimlar listesinin 16 - 24 elamanları arasındaki takımlar için yap.
                if (secilentakimlar.Contains(secilenTakim))
                {
                    i--;
                }
                else
                {
                    secilentakimlar.Add(secilenTakim);
                }
            }
            LstGrupA.Items.Add(takimlar[secilentakimlar[0]]);
            LstGrupB.Items.Add(takimlar[secilentakimlar[1]]);
            LstGrupC.Items.Add(takimlar[secilentakimlar[2]]);
            LstGrupD.Items.Add(takimlar[secilentakimlar[3]]);
            LstGrupE.Items.Add(takimlar[secilentakimlar[4]]);
            LstGrupF.Items.Add(takimlar[secilentakimlar[5]]);
            LstGrupG.Items.Add(takimlar[secilentakimlar[6]]);
            LstGrupH.Items.Add(takimlar[secilentakimlar[7]]);

            secilentakimlar.Clear();
            btnTorba3Dagit.Enabled = false; btnTorba3Dagit.BackColor = Color.SlateGray; // 3. buton da aktif özelliği kapatılıyor.
            btnTorba4Dagit.Enabled = true; btnTorba4Dagit.BackColor = Color.Gainsboro; // 4. buton aktif ediliyor.
        }

        // Diğer torbalar için yapılan gruplara ayırma işleminin aynısı 4.torba için de yapılıyor.
        private void btnTorba4Dagit_Click(object sender, EventArgs e)
        {
            Random rastgele = new Random();
            List<int> secilentakimlar = new List<int>();

            for (int i = (takimlar.Count / 4) * 3; i < takimlar.Count; i++) // takimlar listesinin 24 - 32 elamanları arasındaki takım sayısı kadar rastgele takım üretmesini sağlıyor.
            {
                int secilenTakim = rastgele.Next((takimlar.Count / 4) * 3, takimlar.Count); // takimlar listesinin 24 - 32 elamanları arasındaki takımlar için yap.
                if (secilentakimlar.Contains(secilenTakim))
                {
                    i--;
                }
                else
                {
                    secilentakimlar.Add(secilenTakim);
                }
            }
            LstGrupA.Items.Add(takimlar[secilentakimlar[0]]);
            LstGrupB.Items.Add(takimlar[secilentakimlar[1]]);
            LstGrupC.Items.Add(takimlar[secilentakimlar[2]]);
            LstGrupD.Items.Add(takimlar[secilentakimlar[3]]);
            LstGrupE.Items.Add(takimlar[secilentakimlar[4]]);
            LstGrupF.Items.Add(takimlar[secilentakimlar[5]]);
            LstGrupG.Items.Add(takimlar[secilentakimlar[6]]);
            LstGrupH.Items.Add(takimlar[secilentakimlar[7]]);

            secilentakimlar.Clear();
          
            btnTorba4Dagit.Enabled = false; btnTorba4Dagit.BackColor = Color.SlateGray; // 4. buton da aktif özelliği kapatılıyor.
            // Gruplar içindeki tüm detay butonları torbalar dağıtıldığı için aktif ediliyor.
            btnGrupA.Enabled = true;
            btnGrupB.Enabled = true;
            btnGrupC.Enabled = true;
            btnGrupD.Enabled = true;
            btnGrupE.Enabled = true;
            btnGrupF.Enabled = true;
            btnGrupG.Enabled = true;
            btnGrupH.Enabled = true;
            lblUyari2.Text = "Kura çekildi.";
            
        }

        // Gruplar içindeki her bir detay butonuna tıklandığında farklı bir form sayfası olan fikstür-puan durumu sayfasına yönlendiriyorum.
        // Diğer form sayfasına giderken grupların kendi listbox ları içindeki takımları da götürmesini istiyorum.
        private void btnGrupA_Click(object sender, EventArgs e)
        {
            string[] dizi = new string[LstGrupA.Items.Count]; // Her grubun kendi içindeki listbox elemanları sayısı kadar boyutunda bir dizi oluşturuyorum.

            for (int i = 0; i < LstGrupA.Items.Count; i++)
            {
                dizi[i] = LstGrupA.Items[i].ToString(); // Listbox içindeki elemanlar sırasıyla dizi' ye atanıyor.
            }

            Detay dty = new Detay(dizi); // Diğer form sayfası olan detay formunda bir nesne türetiyorum. dizimi parametre olarak gönderiyorum. 
            // Bu sayede listbox içindeki verilerimi diğer forma taşımış oluyorum. Detay sayfasında da bu diziyi karşılıyorum.
            dty.Show(); // Detay form sayfasını açıyorum.
        }

        // 1.grup için yapılan işlemlerin aynısı yapılıyor.
        private void btnGrupB_Click(object sender, EventArgs e)
        {
            string[] dizi = new string[LstGrupB.Items.Count];

            for (int i = 0; i < LstGrupB.Items.Count; i++)
            {
                dizi[i] = LstGrupB.Items[i].ToString();
            }

            Detay dty = new Detay(dizi);
            dty.Show();
        }

        // Diğer gruplar için yapılan işlemlerin aynısı yapılıyor.
        private void btnGrupC_Click(object sender, EventArgs e)
        {
            string[] dizi = new string[LstGrupC.Items.Count];

            for (int i = 0; i < LstGrupC.Items.Count; i++)
            {
                dizi[i] = LstGrupC.Items[i].ToString();
            }

            Detay dty = new Detay(dizi);
            dty.Show();
        }

        // Diğer gruplar için yapılan işlemlerin aynısı yapılıyor.
        private void btnGrupD_Click(object sender, EventArgs e)
        {
            string[] dizi = new string[LstGrupD.Items.Count];

            for (int i = 0; i < LstGrupD.Items.Count; i++)
            {
                dizi[i] = LstGrupD.Items[i].ToString();
            }

            Detay dty = new Detay(dizi);
            dty.Show();
        }

        // Diğer gruplar için yapılan işlemlerin aynısı yapılıyor.
        private void btnGrupE_Click(object sender, EventArgs e)
        {
            string[] dizi = new string[LstGrupE.Items.Count];

            for (int i = 0; i < LstGrupE.Items.Count; i++)
            {
                dizi[i] = LstGrupE.Items[i].ToString();
            }

            Detay dty = new Detay(dizi);
            dty.Show();
        }

        // Diğer gruplar için yapılan işlemlerin aynısı yapılıyor.
        private void btnGrupF_Click(object sender, EventArgs e)
        {
            string[] dizi = new string[LstGrupF.Items.Count];

            for (int i = 0; i < LstGrupF.Items.Count; i++)
            {
                dizi[i] = LstGrupF.Items[i].ToString();
            }

            Detay dty = new Detay(dizi);
            dty.Show();
        }

        // Diğer gruplar için yapılan işlemlerin aynısı yapılıyor.
        private void btnGrupG_Click(object sender, EventArgs e)
        {
            string[] dizi = new string[LstGrupG.Items.Count];

            for (int i = 0; i < LstGrupG.Items.Count; i++)
            {
                dizi[i] = LstGrupG.Items[i].ToString();
            }

            Detay dty = new Detay(dizi);
            dty.Show();
        }

        // Diğer gruplar için yapılan işlemlerin aynısı yapılıyor.
        private void btnGrupH_Click(object sender, EventArgs e)
        {
            string[] dizi = new string[LstGrupH.Items.Count];

            for (int i = 0; i < LstGrupH.Items.Count; i++)
            {
                dizi[i] = LstGrupH.Items[i].ToString();
            }

            Detay dty = new Detay(dizi);
            dty.Show();
        }
    }
}
