using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SampiyonlarLigiSimulasyonu
{
    public partial class Detay : Form
    {
        string[] dizim; // Form1 olan kura çekimi sayfamda her bir grup için içinde bulunan verileri detay sayfasına aktarmak için tanımlanan string tipte dizim.
        
        public Detay(string[] gelenDizi) // Butona tıklandığında gönderilen dizimi burada gelenDizi[] şeklinde parametre olarak alıyorum.
        {
            InitializeComponent();
            dizim = gelenDizi; // Detay sayfamda tanımlanan 'dizim' diğer sayfadan gelenDizi yi atıyorum. Artık bu sayfada diğer sayfadan gelen verilerimi kullanbilirim.
        }
        
        private void Detay_Load(object sender, EventArgs e)
        {
            // Fikstür atamak için yine secilenTakimlar listemi oluşturuyorum.
            Random rastgele = new Random(); 
            List<int> secilentakimlar = new List<int>();
            
            // 1.hafta
            for (int i = 0; i < dizim.Length; i++) // Her bir grup için detay butonu ile gönderdiğim elamanlarımın sayısı kadar
            {
                var secilenTakim = rastgele.Next(0, dizim.Length);

                if (secilentakimlar.Contains(secilenTakim)) // Kendi ile maç yapması engelleniyor.
                {
                    i--;
                }
                else
                {
                    secilentakimlar.Add(secilenTakim);
                }
            }
            label1.Text = dizim[secilentakimlar[0]]; 
            label2.Text = dizim[secilentakimlar[1]]; 
            label3.Text = dizim[secilentakimlar[2]]; 
            label4.Text = dizim[secilentakimlar[3]]; 
            
            secilentakimlar.Clear(); // Her hafta için ayrı ele aldığım için yine secilentakimlar listemi sıfırlıyorum.


            // 2.hafta
            for (int i = 0; i < dizim.Length; i++)
            {
                var secilenTakim = rastgele.Next(0, dizim.Length);

                if (secilentakimlar.Contains(secilenTakim))
                {
                    i--;
                }
                else
                {
                    secilentakimlar.Add(secilenTakim);
                }
            }
            // İlk hafta fikstürü ile kıyaslıyorum. Label ları kontrol ediyorum.
            for (int k = 0; k < secilentakimlar.Count; k++)
            {
                if (label1.Text == dizim[secilentakimlar[k]].ToString())
                {
                    label6.Text = dizim[secilentakimlar[k]].ToString();
                }
                if (label2.Text == dizim[secilentakimlar[k]].ToString())
                {
                    label5.Text = dizim[secilentakimlar[k]];
                }
                if (label3.Text == dizim[secilentakimlar[k]].ToString())
                {
                    label8.Text = dizim[secilentakimlar[k]].ToString();
                }
                if (label4.Text == dizim[secilentakimlar[k]].ToString())
                {
                    label7.Text = dizim[secilentakimlar[k]].ToString();
                }
            }
            //label5.Text = dizim[secilentakimlar[0]];
            //label6.Text = dizim[secilentakimlar[1]];
            //label7.Text = dizim[secilentakimlar[2]];
            //label8.Text = dizim[secilentakimlar[3]];

            secilentakimlar.Clear();


            // 3.hafta
            for (int i = 0; i < dizim.Length; i++)
            {
                var secilenTakim = rastgele.Next(0, dizim.Length);

                if (secilentakimlar.Contains(secilenTakim))
                {
                    i--;
                }
                else
                {
                    secilentakimlar.Add(secilenTakim);
                }
            }
            labell9.Text = dizim[secilentakimlar[0]];
            labell10.Text = dizim[secilentakimlar[1]];
            labell11.Text = dizim[secilentakimlar[2]];
            labell12.Text = dizim[secilentakimlar[3]];

            secilentakimlar.Clear();


            // 4.hafta
            for (int i = 0; i < dizim.Length; i++)
            {
                var secilenTakim = rastgele.Next(0, dizim.Length);

                if (secilentakimlar.Contains(secilenTakim))
                {
                    i--;
                }
                else
                {
                    secilentakimlar.Add(secilenTakim);
                }
            }
            label13.Text = dizim[secilentakimlar[0]];
            label14.Text = dizim[secilentakimlar[1]];
            label15.Text = dizim[secilentakimlar[2]];
            label16.Text = dizim[secilentakimlar[3]];

            secilentakimlar.Clear();

            // 5.hafta
            for (int i = 0; i < dizim.Length; i++)
            {
                var secilenTakim = rastgele.Next(0, dizim.Length);

                if (secilentakimlar.Contains(secilenTakim))
                {
                    i--;
                }
                else
                {
                    secilentakimlar.Add(secilenTakim);
                }
            }
            label17.Text = dizim[secilentakimlar[0]];
            label18.Text = dizim[secilentakimlar[1]];
            label19.Text = dizim[secilentakimlar[2]];
            label20.Text = dizim[secilentakimlar[3]];

            secilentakimlar.Clear();

            // 6.hafta
            for (int i = 0; i < dizim.Length; i++)
            {
                var secilenTakim = rastgele.Next(0, dizim.Length);

                if (secilentakimlar.Contains(secilenTakim))
                {
                    i--;
                }
                else
                {
                    secilentakimlar.Add(secilenTakim);
                }
            }
            labell21.Text = dizim[secilentakimlar[0]];
            labell22.Text = dizim[secilentakimlar[1]];
            label23.Text = dizim[secilentakimlar[2]];
            label24.Text = dizim[secilentakimlar[3]];

            secilentakimlar.Clear();
        }

        // Sonuşlar butonuna tıklanıyor.
        private void btnOyna_Click(object sender, EventArgs e)
        {
            Random rastgele = new Random();
            List<int> secilentakimlar = new List<int>();

            // İlk hafta fikstürüm benim referans fikstürüm. Bundan sonraki fikstürleri label1,label2,label3,label4 birer takım adıymış gibi düşündüm.
            // Bu label lara ilk hafta rastgele denk gelen takımlara göre diğer haftaların koşullamalarını sağlıyorum.
            int label1puan1 = 0; // label1 deki takımımın puanını label1puan1 değişkeninde tutuyorum.
            int label2puan2 = 0; // label2 deki takımımın puanını label2puan2 değişkeninde tutuyorum.
            int label3puan3 = 0; // label2 deki takımımın puanını label3puan3 değişkeninde tutuyorum.
            int label4puan4 = 0; // label2 deki takımımın puanını label4puan4 değişkeninde tutuyorum.
            
            // Aynı şekilde goller de öyle
            int label1gol = 0;
            int label2gol = 0;
            int label3gol = 0;
            int label4gol = 0;


            for (int i = 0; i < 24; i++) // 6 hafta var 24 maç oynanıyor. Bu yüzden 24 adet skor label i tanımlıyorum.
            {
                var secilenSkor = rastgele.Next(0, 9); // Her takım max 8 gol atabiliyor.
                secilentakimlar.Add(secilenSkor);
            }

            // 24 label a sırayla rastgele üretilen skorları atıyorum.
            lblSkor1.Text = secilentakimlar[0].ToString();
            lblSkor2.Text = secilentakimlar[1].ToString();
            lblSkor3.Text = secilentakimlar[2].ToString();
            lblSkor4.Text = secilentakimlar[3].ToString();
            lblSkor5.Text = secilentakimlar[4].ToString();
            lblSkor6.Text = secilentakimlar[5].ToString();
            lblSkor7.Text = secilentakimlar[6].ToString();
            lblSkor8.Text = secilentakimlar[7].ToString();
            lblSkor9.Text = secilentakimlar[8].ToString();
            lblSkor10.Text = secilentakimlar[9].ToString();
            lblSkor11.Text = secilentakimlar[10].ToString();
            lblSkor12.Text = secilentakimlar[11].ToString();
            lblSkor13.Text = secilentakimlar[12].ToString();
            lblSkor14.Text = secilentakimlar[13].ToString();
            lblSkor15.Text = secilentakimlar[14].ToString();
            lblSkor16.Text = secilentakimlar[15].ToString();
            lblSkor17.Text = secilentakimlar[16].ToString();
            lblSkor18.Text = secilentakimlar[17].ToString();
            lblSkor19.Text = secilentakimlar[18].ToString();
            lblSkor20.Text = secilentakimlar[19].ToString();
            lblSkor21.Text = secilentakimlar[20].ToString();
            lblSkor22.Text = secilentakimlar[21].ToString();
            lblSkor23.Text = secilentakimlar[22].ToString();
            lblSkor24.Text = secilentakimlar[23].ToString();

            // 1.hafta puanlar
            // 1. haftam referans haftam olduğu için temel koşullandırmalarımı yapıyorum.
            if (Convert.ToInt32(lblSkor1.Text) > Convert.ToInt32(lblSkor2.Text)) // label larda int' a tür dönüşümü yapılıyor.
            {
                label1puan1 += 3; // label1 deki takım galip geldiğinde +3 puan
                label1gol += Convert.ToInt32(lblSkor1.Text); // Galip geldiği durumda attığı + gol sayısı
            }
            if (Convert.ToInt32(lblSkor2.Text) > Convert.ToInt32(lblSkor1.Text))
            {
                label2puan2 += 3; // label2 deki takım galip geldiğinde +3 puan
                label2gol += Convert.ToInt32(lblSkor2.Text);
            }
            if (Convert.ToInt32(lblSkor1.Text) == Convert.ToInt32(lblSkor2.Text))
            {
                label1puan1 += 1; // Beraber ise iki label daki takıma da +1 puan
                label2puan2 += 1;
                label1gol += Convert.ToInt32(lblSkor1.Text);
                label2gol += Convert.ToInt32(lblSkor2.Text);
            }
            if (Convert.ToInt32(lblSkor3.Text) > Convert.ToInt32(lblSkor4.Text))
            {
                label3puan3 += 3;
                label3gol += Convert.ToInt32(lblSkor3.Text);
            }
            if (Convert.ToInt32(lblSkor4.Text) > Convert.ToInt32(lblSkor3.Text))
            {
                label4puan4 += 3;
                label4gol += Convert.ToInt32(lblSkor4.Text);
            }
            if (Convert.ToInt32(lblSkor3.Text) == Convert.ToInt32(lblSkor4.Text))
            {
                label3puan3 += 1;
                label4puan4 += 1;
                label3gol += Convert.ToInt32(lblSkor3.Text);
                label4gol += Convert.ToInt32(lblSkor4.Text);
            }
            //Bundan sonraki haftalarda ilk haftamda  rastgele üretilen 4 adet label daki takımlar göre işlem yapıyorum.


            // 2. hafta puanlar
            if (Convert.ToInt32(lblSkor5.Text) > Convert.ToInt32(lblSkor6.Text)) // 2.hafta ilk ev sahibi label in deplasman dan büyük olma durumu
            {
                // label5 in hangi takım olduğunu bulmak için label1,label2,label3,label4 referans olan takımlarımdan hangisine eşitse ona göre işlem yaptırıyorum.
                // Tüm haftalar için bu durum tekrarlıyor. Bu sayede il haftadaki label daki takımlara göre diğer haftalarda hangi label da hangi takım var ulaşıyorum.
                if (label1.Text == label5.Text)
                {
                    label1puan1 += 3;
                    label1gol += Convert.ToInt32(lblSkor5.Text);
                }
                if (label2.Text == label5.Text)
                {
                    label2puan2 += 3;
                    label2gol += Convert.ToInt32(lblSkor5.Text);
                }
                if (label3.Text == label5.Text)
                {
                    label3puan3 += 3;
                    label3gol += Convert.ToInt32(lblSkor5.Text);
                }
                if (label4.Text == label5.Text)
                {
                    label4puan4 += 3;
                    label4gol += Convert.ToInt32(lblSkor5.Text);
                }
            }
            if (Convert.ToInt32(lblSkor6.Text) > Convert.ToInt32(lblSkor5.Text))
            {
                if (label1.Text == label6.Text)
                {
                    label1puan1 += 3;
                    label1gol += Convert.ToInt32(lblSkor6.Text);
                }
                if (label2.Text == label6.Text)
                {
                    label2puan2 += 3;
                    label2gol += Convert.ToInt32(lblSkor6.Text);
                }
                if (label3.Text == label6.Text)
                {
                    label3puan3 += 3;
                    label3gol += Convert.ToInt32(lblSkor6.Text);
                }
                if (label4.Text == label6.Text)
                {
                    label4puan4 += 3;
                    label4gol += Convert.ToInt32(lblSkor6.Text);
                }
            }
            if (Convert.ToInt32(lblSkor5.Text) == Convert.ToInt32(lblSkor6.Text))
            {
                if (label1.Text == label5.Text)
                {
                    label1puan1 += 1;
                    label1gol += Convert.ToInt32(lblSkor5.Text);
                }
                if (label2.Text == label5.Text)
                {
                    label2puan2 += 1;
                    label2gol += Convert.ToInt32(lblSkor5.Text);
                }
                if (label3.Text == label5.Text)
                {
                    label3puan3 += 1;
                    label3gol += Convert.ToInt32(lblSkor5.Text);
                }
                if (label4.Text == label5.Text)
                {
                    label4puan4 += 1;
                    label4gol += Convert.ToInt32(lblSkor5.Text);
                }
                if (label1.Text == label6.Text)
                {
                    label1puan1 += 1;
                    label1gol += Convert.ToInt32(lblSkor6.Text);
                }
                if (label2.Text == label6.Text)
                {
                    label2puan2 += 1;
                    label2gol += Convert.ToInt32(lblSkor6.Text);
                }
                if (label3.Text == label6.Text)
                {
                    label3puan3 += 1;
                    label3gol += Convert.ToInt32(lblSkor6.Text);
                }
                if (label4.Text == label6.Text)
                {
                    label4puan4 += 1;
                    label4gol += Convert.ToInt32(lblSkor6.Text);
                }
            }
            if (Convert.ToInt32(lblSkor7.Text) > Convert.ToInt32(lblSkor8.Text))
            {
                if (label1.Text == label7.Text)
                {
                    label1puan1 += 3;
                    label1gol += Convert.ToInt32(lblSkor7.Text);
                }
                if (label2.Text == label7.Text)
                {
                    label2puan2 += 3;
                    label2gol += Convert.ToInt32(lblSkor7.Text);
                }
                if (label3.Text == label7.Text)
                {
                    label3puan3 += 3;
                    label3gol += Convert.ToInt32(lblSkor7.Text);
                }
                if (label4.Text == label7.Text)
                {
                    label4puan4 += 3;
                    label4gol += Convert.ToInt32(lblSkor7.Text);
                }
            }
            if (Convert.ToInt32(lblSkor8.Text) > Convert.ToInt32(lblSkor7.Text))
            {
                if (label1.Text == label8.Text)
                {
                    label1puan1 += 3;
                    label1gol += Convert.ToInt32(lblSkor8.Text);
                }
                if (label2.Text == label8.Text)
                {
                    label2puan2 += 3;
                    label2gol += Convert.ToInt32(lblSkor8.Text);
                }
                if (label3.Text == label8.Text)
                {
                    label3puan3 += 3;
                    label3gol += Convert.ToInt32(lblSkor8.Text);
                }
                if (label4.Text == label8.Text)
                {
                    label4puan4 += 3;
                    label4gol += Convert.ToInt32(lblSkor8.Text);
                }
            }
            if (Convert.ToInt32(lblSkor7.Text) == Convert.ToInt32(lblSkor8.Text))
            {
                if (label1.Text == label7.Text)
                {
                    label1puan1 += 1;
                    label1gol += Convert.ToInt32(lblSkor7.Text);
                }
                if (label2.Text == label7.Text)
                {
                    label2puan2 += 1;
                    label2gol += Convert.ToInt32(lblSkor7.Text);
                }
                if (label3.Text == label7.Text)
                {
                    label3puan3 += 1;
                    label3gol += Convert.ToInt32(lblSkor7.Text);
                }
                if (label4.Text == label7.Text)
                {
                    label4puan4 += 1;
                    label4gol += Convert.ToInt32(lblSkor7.Text);
                }
                if (label1.Text == label8.Text)
                {
                    label1puan1 += 1;
                    label1gol += Convert.ToInt32(lblSkor8.Text);
                }
                if (label2.Text == label8.Text)
                {
                    label2puan2 += 1;
                    label2gol += Convert.ToInt32(lblSkor8.Text);
                }
                if (label3.Text == label8.Text)
                {
                    label3puan3 += 1;
                    label3gol += Convert.ToInt32(lblSkor8.Text);
                }
                if (label4.Text == label8.Text)
                {
                    label4puan4 += 1;
                    label4gol += Convert.ToInt32(lblSkor8.Text);
                }
            }

            // 3. hafta puanlar
            // ilk haftamda  rastgele üretilen 4 adet label daki takımlar göre işlem yapıyorum.

            if (Convert.ToInt32(lblSkor9.Text) > Convert.ToInt32(lblSkor10.Text))
            {
                if (label1.Text == labell9.Text)
                {
                    label1puan1 += 3;
                    label1gol += Convert.ToInt32(lblSkor9.Text);
                }
                if (label2.Text == labell9.Text)
                {
                    label2puan2 += 3;
                    label2gol += Convert.ToInt32(lblSkor9.Text);
                }
                if (label3.Text == labell9.Text)
                {
                    label3puan3 += 3;
                    label3gol += Convert.ToInt32(lblSkor9.Text);
                }
                if (label4.Text == labell9.Text)
                {
                    label4puan4 += 3;
                    label4gol += Convert.ToInt32(lblSkor9.Text);
                }
            }
            if (Convert.ToInt32(lblSkor10.Text) > Convert.ToInt32(lblSkor9.Text))
            {
                if (label1.Text == labell10.Text)
                {
                    label1puan1 += 3;
                    label1gol += Convert.ToInt32(lblSkor10.Text);
                }
                if (label2.Text == labell10.Text)
                {
                    label2puan2 += 3;
                    label2gol += Convert.ToInt32(lblSkor10.Text);
                }
                if (label3.Text == labell10.Text)
                {
                    label3puan3 += 3;
                    label3gol += Convert.ToInt32(lblSkor10.Text);
                }
                if (label4.Text == labell10.Text)
                {
                    label4puan4 += 3;
                    label4gol += Convert.ToInt32(lblSkor10.Text);
                }
            }
            if (Convert.ToInt32(lblSkor9.Text) == Convert.ToInt32(lblSkor10.Text))
            {
                if (label1.Text == labell9.Text)
                {
                    label1puan1 += 1;
                    label1gol += Convert.ToInt32(lblSkor9.Text);
                }
                if (label2.Text == labell9.Text)
                {
                    label2puan2 += 1;
                    label2gol += Convert.ToInt32(lblSkor9.Text);
                }
                if (label3.Text == labell9.Text)
                {
                    label3puan3 += 1;
                    label3gol += Convert.ToInt32(lblSkor9.Text);
                }
                if (label4.Text == labell9.Text)
                {
                    label4puan4 += 1;
                    label4gol += Convert.ToInt32(lblSkor9.Text);
                }
                if (label1.Text == labell10.Text)
                {
                    label1puan1 += 1;
                    label1gol += Convert.ToInt32(lblSkor10.Text);
                }
                if (label2.Text == labell10.Text)
                {
                    label2puan2 += 1;
                    label2gol += Convert.ToInt32(lblSkor10.Text);
                }
                if (label3.Text == labell10.Text)
                {
                    label3puan3 += 1;
                    label3gol += Convert.ToInt32(lblSkor10.Text);
                }
                if (label4.Text == labell10.Text)
                {
                    label4puan4 += 1;
                    label4gol += Convert.ToInt32(lblSkor10.Text);
                }
            }
            if (Convert.ToInt32(lblSkor11.Text) > Convert.ToInt32(lblSkor12.Text))
            {
                if (label1.Text == labell11.Text)
                {
                    label1puan1 += 3;
                    label1gol += Convert.ToInt32(lblSkor11.Text);
                }
                if (label2.Text == labell11.Text)
                {
                    label2puan2 += 3;
                    label2gol += Convert.ToInt32(lblSkor11.Text);
                }
                if (label3.Text == labell11.Text)
                {
                    label3puan3 += 3;
                    label3gol += Convert.ToInt32(lblSkor11.Text);
                }
                if (label4.Text == labell11.Text)
                {
                    label4puan4 += 3;
                    label4gol += Convert.ToInt32(lblSkor11.Text);
                }
            }
            if (Convert.ToInt32(lblSkor12.Text) > Convert.ToInt32(lblSkor11.Text))
            {
                if (label1.Text == labell12.Text)
                {
                    label1puan1 += 3;
                    label4gol += Convert.ToInt32(lblSkor12.Text);
                }
                if (label2.Text == labell12.Text)
                {
                    label2puan2 += 3;
                    label2gol += Convert.ToInt32(lblSkor12.Text);
                }
                if (label3.Text == labell12.Text)
                {
                    label3puan3 += 3;
                    label3gol += Convert.ToInt32(lblSkor12.Text);
                }
                if (label4.Text == labell12.Text)
                {
                    label4puan4 += 3;
                    label4gol += Convert.ToInt32(lblSkor12.Text);
                }
            }
            if (Convert.ToInt32(lblSkor11.Text) == Convert.ToInt32(lblSkor12.Text))
            {
                if (label1.Text == labell11.Text)
                {
                    label1puan1 += 1;
                    label1gol += Convert.ToInt32(lblSkor11.Text);
                }
                if (label2.Text == labell11.Text)
                {
                    label2puan2 += 1;
                    label2gol += Convert.ToInt32(lblSkor11.Text);
                }
                if (label3.Text == labell11.Text)
                {
                    label3puan3 += 1;
                    label3gol += Convert.ToInt32(lblSkor11.Text);
                }
                if (label4.Text == labell11.Text)
                {
                    label4puan4 += 1;
                    label4gol += Convert.ToInt32(lblSkor11.Text);
                }
                if (label1.Text == labell12.Text)
                {
                    label1puan1 += 1;
                    label1gol += Convert.ToInt32(lblSkor12.Text);
                }
                if (label2.Text == labell12.Text)
                {
                    label2puan2 += 1;
                    label2gol += Convert.ToInt32(lblSkor12.Text);
                }
                if (label3.Text == labell12.Text)
                {
                    label3puan3 += 1;
                    label3gol += Convert.ToInt32(lblSkor12.Text);
                }
                if (label4.Text == labell12.Text)
                {
                    label4puan4 += 1;
                    label4gol += Convert.ToInt32(lblSkor12.Text);
                }
            }

            // 4. hafta puanlar
            // ilk haftamda  rastgele üretilen 4 adet label daki takımlar göre işlem yapıyorum.
            if (Convert.ToInt32(lblSkor13.Text) > Convert.ToInt32(lblSkor14.Text))
            {
                if (label1.Text == label13.Text)
                {
                    label1puan1 += 3;
                    label1gol += Convert.ToInt32(lblSkor13.Text);
                }
                if (label2.Text == label13.Text)
                {
                    label2puan2 += 3;
                    label2gol += Convert.ToInt32(lblSkor13.Text);
                }
                if (label3.Text == label13.Text)
                {
                    label3puan3 += 3;
                    label3gol += Convert.ToInt32(lblSkor13.Text);
                }
                if (label4.Text == label13.Text)
                {
                    label4puan4 += 3;
                    label4gol += Convert.ToInt32(lblSkor13.Text);
                }
            }
            if (Convert.ToInt32(lblSkor14.Text) > Convert.ToInt32(lblSkor13.Text))
            {
                if (label1.Text == label14.Text)
                {
                    label1puan1 += 3;
                    label1gol += Convert.ToInt32(lblSkor14.Text);
                }
                if (label2.Text == label14.Text)
                {
                    label2puan2 += 3;
                    label2gol += Convert.ToInt32(lblSkor14.Text);
                }
                if (label3.Text == label14.Text)
                {
                    label3puan3 += 3;
                    label3gol += Convert.ToInt32(lblSkor14.Text);
                }
                if (label4.Text == label14.Text)
                {
                    label4puan4 += 3;
                    label4gol += Convert.ToInt32(lblSkor14.Text);
                }
            }
            if (Convert.ToInt32(lblSkor13.Text) == Convert.ToInt32(lblSkor14.Text))
            {
                if (label1.Text == label13.Text)
                {
                    label1puan1 += 1;
                    label1gol += Convert.ToInt32(lblSkor13.Text);
                }
                if (label2.Text == label13.Text)
                {
                    label2puan2 += 1;
                    label2gol += Convert.ToInt32(lblSkor13.Text);
                }
                if (label3.Text == label13.Text)
                {
                    label3puan3 += 1;
                    label3gol += Convert.ToInt32(lblSkor13.Text);
                }
                if (label4.Text == label13.Text)
                {
                    label4puan4 += 1;
                    label4gol += Convert.ToInt32(lblSkor13.Text);
                }
                if (label1.Text == label14.Text)
                {
                    label1puan1 += 1;
                    label1gol += Convert.ToInt32(lblSkor14.Text);
                }
                if (label2.Text == label14.Text)
                {
                    label2puan2 += 1;
                    label2gol += Convert.ToInt32(lblSkor14.Text);
                }
                if (label3.Text == label14.Text)
                {
                    label3puan3 += 1;
                    label3gol += Convert.ToInt32(lblSkor14.Text);
                }
                if (label4.Text == label14.Text)
                {
                    label4puan4 += 1;
                    label4gol += Convert.ToInt32(lblSkor14.Text);
                }
            }
            if (Convert.ToInt32(lblSkor15.Text) > Convert.ToInt32(lblSkor16.Text))
            {
                if (label1.Text == label15.Text)
                {
                    label1puan1 += 3;
                    label1gol += Convert.ToInt32(lblSkor15.Text);
                }
                if (label2.Text == label15.Text)
                {
                    label2puan2 += 3;
                    label2gol += Convert.ToInt32(lblSkor15.Text);
                }
                if (label3.Text == label15.Text)
                {
                    label3puan3 += 3;
                    label3gol += Convert.ToInt32(lblSkor15.Text);
                }
                if (label4.Text == label15.Text)
                {
                    label4puan4 += 3;
                    label4gol += Convert.ToInt32(lblSkor15.Text);
                }
            }
            if (Convert.ToInt32(lblSkor16.Text) > Convert.ToInt32(lblSkor15.Text))
            {
                if (label1.Text == label16.Text)
                {
                    label1puan1 += 3;
                    label1gol += Convert.ToInt32(lblSkor16.Text);
                }
                if (label2.Text == label16.Text)
                {
                    label2puan2 += 3;
                    label2gol += Convert.ToInt32(lblSkor16.Text);
                }
                if (label3.Text == label16.Text)
                {
                    label3puan3 += 3;
                    label3gol += Convert.ToInt32(lblSkor16.Text);
                }
                if (label4.Text == label16.Text)
                {
                    label4puan4 += 3;
                    label4gol += Convert.ToInt32(lblSkor16.Text);
                }
            }
            if (Convert.ToInt32(lblSkor15.Text) == Convert.ToInt32(lblSkor16.Text))
            {
                if (label1.Text == label15.Text)
                {
                    label1puan1 += 1;
                    label1gol += Convert.ToInt32(lblSkor15.Text);
                }
                if (label2.Text == label15.Text)
                {
                    label2puan2 += 1;
                    label2gol += Convert.ToInt32(lblSkor15.Text);
                }
                if (label3.Text == label15.Text)
                {
                    label3puan3 += 1;
                    label3gol += Convert.ToInt32(lblSkor15.Text);
                }
                if (label4.Text == label15.Text)
                {
                    label4puan4 += 1;
                    label4gol += Convert.ToInt32(lblSkor15.Text);
                }
                if (label1.Text == label16.Text)
                {
                    label1puan1 += 1;
                    label1gol += Convert.ToInt32(lblSkor16.Text);
                }
                if (label2.Text == label16.Text)
                {
                    label2puan2 += 1;
                    label2gol += Convert.ToInt32(lblSkor16.Text);
                }
                if (label3.Text == label16.Text)
                {
                    label3puan3 += 1;
                    label3gol += Convert.ToInt32(lblSkor16.Text);
                }
                if (label4.Text == label16.Text)
                {
                    label4puan4 += 1;
                    label4gol += Convert.ToInt32(lblSkor16.Text);
                }
            }
            // 5. hafta puanlar
            // ilk haftamda  rastgele üretilen 4 adet label daki takımlar göre işlem yapıyorum.
            if (Convert.ToInt32(lblSkor17.Text) > Convert.ToInt32(lblSkor18.Text))
            {
                if (label1.Text == label17.Text)
                {
                    label1puan1 += 3;
                    label1gol += Convert.ToInt32(lblSkor17.Text);
                }
                if (label2.Text == label17.Text)
                {
                    label2puan2 += 3;
                    label2gol += Convert.ToInt32(lblSkor17.Text);
                }
                if (label3.Text == label17.Text)
                {
                    label3puan3 += 3;
                    label3gol += Convert.ToInt32(lblSkor17.Text);
                }
                if (label4.Text == label17.Text)
                {
                    label4puan4 += 3;
                    label4gol += Convert.ToInt32(lblSkor17.Text);
                }
            }
            if (Convert.ToInt32(lblSkor18.Text) > Convert.ToInt32(lblSkor17.Text))
            {
                if (label1.Text == label18.Text)
                {
                    label1puan1 += 3;
                    label1gol += Convert.ToInt32(lblSkor18.Text);
                }
                if (label2.Text == label18.Text)
                {
                    label2puan2 += 3;
                    label2gol += Convert.ToInt32(lblSkor18.Text);
                }
                if (label3.Text == label18.Text)
                {
                    label3puan3 += 3;
                    label3gol += Convert.ToInt32(lblSkor18.Text);
                }
                if (label4.Text == label18.Text)
                {
                    label4puan4 += 3;
                    label4gol += Convert.ToInt32(lblSkor18.Text);
                }
            }
            if (Convert.ToInt32(lblSkor17.Text) == Convert.ToInt32(lblSkor18.Text))
            {
                if (label1.Text == label17.Text)
                {
                    label1puan1 += 1;
                    label1gol += Convert.ToInt32(lblSkor17.Text);
                }
                if (label2.Text == label17.Text)
                {
                    label2puan2 += 1;
                    label2gol += Convert.ToInt32(lblSkor17.Text);
                }
                if (label3.Text == label17.Text)
                {
                    label3puan3 += 1;
                    label3gol += Convert.ToInt32(lblSkor17.Text);
                }
                if (label4.Text == label17.Text)
                {
                    label4puan4 += 1;
                    label4gol += Convert.ToInt32(lblSkor17.Text);
                }
                if (label1.Text == label18.Text)
                {
                    label1puan1 += 1;
                    label1gol += Convert.ToInt32(lblSkor18.Text);
                }
                if (label2.Text == label18.Text)
                {
                    label2puan2 += 1;
                    label2gol += Convert.ToInt32(lblSkor18.Text);
                }
                if (label3.Text == label18.Text)
                {
                    label3puan3 += 1;
                    label3gol += Convert.ToInt32(lblSkor18.Text);
                }
                if (label4.Text == label18.Text)
                {
                    label4puan4 += 1;
                    label4gol += Convert.ToInt32(lblSkor18.Text);
                }
            }
            if (Convert.ToInt32(lblSkor19.Text) > Convert.ToInt32(lblSkor20.Text))
            {
                if (label1.Text == label19.Text)
                {
                    label1puan1 += 3;
                    label1gol += Convert.ToInt32(lblSkor19.Text);
                }
                if (label2.Text == label19.Text)
                {
                    label2puan2 += 3;
                    label2gol += Convert.ToInt32(lblSkor19.Text);
                }
                if (label3.Text == label19.Text)
                {
                    label3puan3 += 3;
                    label3gol += Convert.ToInt32(lblSkor19.Text);
                }
                if (label4.Text == label19.Text)
                {
                    label4puan4 += 3;
                    label4gol += Convert.ToInt32(lblSkor19.Text);
                }
            }
            if (Convert.ToInt32(lblSkor20.Text) > Convert.ToInt32(lblSkor19.Text))
            {
                if (label1.Text == label20.Text)
                {
                    label1puan1 += 3;
                    label1gol += Convert.ToInt32(lblSkor20.Text);
                }
                if (label2.Text == label20.Text)
                {
                    label2puan2 += 3;
                    label2gol += Convert.ToInt32(lblSkor20.Text);
                }
                if (label3.Text == label20.Text)
                {
                    label3puan3 += 3;
                    label3gol += Convert.ToInt32(lblSkor20.Text);
                }
                if (label4.Text == label20.Text)
                {
                    label4puan4 += 3;
                    label4gol += Convert.ToInt32(lblSkor20.Text);
                }
            }
            if (Convert.ToInt32(lblSkor19.Text) == Convert.ToInt32(lblSkor20.Text))
            {
                if (label1.Text == label19.Text)
                {
                    label1puan1 += 1;
                    label1gol += Convert.ToInt32(lblSkor19.Text);
                }
                if (label2.Text == label19.Text)
                {
                    label2puan2 += 1;
                    label2gol += Convert.ToInt32(lblSkor19.Text);
                }
                if (label3.Text == label19.Text)
                {
                    label3puan3 += 1;
                    label3gol += Convert.ToInt32(lblSkor19.Text);
                }
                if (label4.Text == label19.Text)
                {
                    label4puan4 += 1;
                    label4gol += Convert.ToInt32(lblSkor19.Text);
                }
                if (label1.Text == label20.Text)
                {
                    label1puan1 += 1;
                    label1gol += Convert.ToInt32(lblSkor20.Text);
                }
                if (label2.Text == label20.Text)
                {
                    label2puan2 += 1;
                    label2gol += Convert.ToInt32(lblSkor20.Text);
                }
                if (label3.Text == label20.Text)
                {
                    label3puan3 += 1;
                    label3gol += Convert.ToInt32(lblSkor20.Text);
                }
                if (label4.Text == label20.Text)
                {
                    label4puan4 += 1;
                    label4gol += Convert.ToInt32(lblSkor20.Text);
                }
            }

            // 6. hafta puanlar
            // ilk haftamda  rastgele üretilen 4 adet label daki takımlar göre işlem yapıyorum.
            if (Convert.ToInt32(lblSkor21.Text) > Convert.ToInt32(lblSkor22.Text))
            {
                if (label1.Text == labell21.Text)
                {
                    label1puan1 += 3;
                    label1gol += Convert.ToInt32(lblSkor21.Text);
                }
                if (label2.Text == labell21.Text)
                {
                    label2puan2 += 3;
                    label2gol += Convert.ToInt32(lblSkor21.Text);
                }
                if (label3.Text == labell21.Text)
                {
                    label3puan3 += 3;
                    label3gol += Convert.ToInt32(lblSkor21.Text);
                }
                if (label4.Text == labell21.Text)
                {
                    label4puan4 += 3;
                    label4gol += Convert.ToInt32(lblSkor21.Text);
                }
            }
            if (Convert.ToInt32(lblSkor22.Text) > Convert.ToInt32(lblSkor21.Text))
            {
                if (label1.Text == labell22.Text)
                {
                    label1puan1 += 3;
                    label1gol += Convert.ToInt32(lblSkor22.Text);
                }
                if (label2.Text == labell22.Text)
                {
                    label2puan2 += 3;
                    label2gol += Convert.ToInt32(lblSkor22.Text);
                }
                if (label3.Text == labell22.Text)
                {
                    label3puan3 += 3;
                    label3gol += Convert.ToInt32(lblSkor22.Text);
                }
                if (label4.Text == labell22.Text)
                {
                    label4puan4 += 3;
                    label4gol += Convert.ToInt32(lblSkor22.Text);
                }
            }
            if (Convert.ToInt32(lblSkor21.Text) == Convert.ToInt32(lblSkor22.Text))
            {
                if (label1.Text == labell21.Text)
                {
                    label1puan1 += 1;
                    label1gol += Convert.ToInt32(lblSkor21.Text);
                }
                if (label2.Text == labell21.Text)
                {
                    label2puan2 += 1;
                    label2gol += Convert.ToInt32(lblSkor21.Text);
                }
                if (label3.Text == labell21.Text)
                {
                    label3puan3 += 1;
                    label3gol += Convert.ToInt32(lblSkor21.Text);
                }
                if (label4.Text == labell21.Text)
                {
                    label4puan4 += 1;
                    label4gol += Convert.ToInt32(lblSkor21.Text);
                }
                if (label1.Text == labell22.Text)
                {
                    label1puan1 += 1;
                    label1gol += Convert.ToInt32(lblSkor22.Text);
                }
                if (label2.Text == labell22.Text)
                {
                    label2puan2 += 1;
                    label2gol += Convert.ToInt32(lblSkor22.Text);
                }
                if (label3.Text == labell22.Text)
                {
                    label3puan3 += 1;
                    label3gol += Convert.ToInt32(lblSkor22.Text);
                }
                if (label4.Text == labell22.Text)
                {
                    label4puan4 += 1;
                    label4gol += Convert.ToInt32(lblSkor22.Text);
                }
            }
            if (Convert.ToInt32(lblSkor23.Text) > Convert.ToInt32(lblSkor24.Text))
            {
                if (label1.Text == label23.Text)
                {
                    label1puan1 += 3;
                    label1gol += Convert.ToInt32(lblSkor23.Text);
                }
                if (label2.Text == label23.Text)
                {
                    label2puan2 += 3;
                    label2gol += Convert.ToInt32(lblSkor23.Text);
                }
                if (label3.Text == label23.Text)
                {
                    label3puan3 += 3;
                    label3gol += Convert.ToInt32(lblSkor23.Text);
                }
                if (label4.Text == label23.Text)
                {
                    label4puan4 += 3;
                    label4gol += Convert.ToInt32(lblSkor23.Text);
                }
            }
            if (Convert.ToInt32(lblSkor24.Text) > Convert.ToInt32(lblSkor23.Text))
            {
                if (label1.Text == label24.Text)
                {
                    label1puan1 += 3;
                    label1gol += Convert.ToInt32(lblSkor24.Text);
                }
                if (label2.Text == label24.Text)
                {
                    label2puan2 += 3;
                    label2gol += Convert.ToInt32(lblSkor24.Text);
                }
                if (label3.Text == label24.Text)
                {
                    label3puan3 += 3;
                    label3gol += Convert.ToInt32(lblSkor24.Text);
                }
                if (label4.Text == label24.Text)
                {
                    label4puan4 += 3;
                    label4gol += Convert.ToInt32(lblSkor24.Text);
                }
            }
            if (Convert.ToInt32(lblSkor23.Text) == Convert.ToInt32(lblSkor24.Text))
            {
                if (label1.Text == label23.Text)
                {
                    label1puan1 += 1;
                    label1gol += Convert.ToInt32(lblSkor23.Text);
                }
                if (label2.Text == label23.Text)
                {
                    label2puan2 += 1;
                    label2gol += Convert.ToInt32(lblSkor23.Text);
                }
                if (label3.Text == label23.Text)
                {
                    label3puan3 += 1;
                    label3gol += Convert.ToInt32(lblSkor23.Text);
                }
                if (label4.Text == label23.Text)
                {
                    label4puan4 += 1;
                    label4gol += Convert.ToInt32(lblSkor23.Text);
                }
                if (label1.Text == label24.Text)
                {
                    label1puan1 += 1;
                    label1gol += Convert.ToInt32(lblSkor24.Text);
                }
                if (label2.Text == label24.Text)
                {
                    label2puan2 += 1;
                    label2gol += Convert.ToInt32(lblSkor24.Text);
                }
                if (label3.Text == label24.Text)
                {
                    label3puan3 += 1;
                    label3gol += Convert.ToInt32(lblSkor24.Text);
                }
                if (label4.Text == label24.Text)
                {
                    label4puan4 += 1;
                    label4gol += Convert.ToInt32(lblSkor24.Text);
                }
            }


            // Puan Sıralaması

            // Puan sıralaması için puanları bir diziye atıyorum bu diziyi büyükten küçüğe sıralıyorum. Sonra dizi elemanlarını labellar ile kontrol ediyorum.
            // Hangi takımın kaç puan aldığını buluyorum.

            //int[] puanDizisi = new int[4];
            //puanDizisi[0] = label1puan1;
            //puanDizisi[1] = label2puan2;
            //puanDizisi[2] = label3puan3;
            //puanDizisi[3] = label4puan4;

            //int gecici;

            //for (int i = 0; i < puanDizisi.Length; i++)
            //{
            //    for (int j = i; j < puanDizisi.Length; j++)
            //    {
            //        if (puanDizisi[j] > puanDizisi[i])
            //        {
            //            gecici = puanDizisi[i];
            //            puanDizisi[i] = puanDizisi[j];
            //            puanDizisi[j] = gecici;
            //        }
            //    }
            //}


            // Karışık sıralama
            lbltakim1.Text = label1.Text;
            lbltakim2.Text = label2.Text;
            lbltakim3.Text = label3.Text;
            lbltakim4.Text = label4.Text;

            lbltakimP1.Text = label1puan1.ToString();
            lbltakimP2.Text = label2puan2.ToString();
            lbltakimP3.Text = label3puan3.ToString();
            lbltakimP4.Text = label4puan4.ToString();

            lblgol1.Text = label1gol.ToString();
            lblgol2.Text = label2gol.ToString();
            lblgol3.Text = label3gol.ToString();
            lblgol4.Text = label4gol.ToString();

            //// 1. olan takımı bulma
            //if (puanDizisi[0] == label1puan1)
            //{
            //    lbltakimP1.Text = puanDizisi[0].ToString();
            //    lbltakim1.Text = label1.Text;
            //    lblgol1.Text = label1gol.ToString();
            //}
            //if (puanDizisi[0] == label2puan2)
            //{
            //    lbltakimP1.Text = puanDizisi[0].ToString();
            //    lbltakim1.Text = label2.Text;
            //    lblgol1.Text = label2gol.ToString();
            //}
            //if (puanDizisi[0] == label3puan3)
            //{
            //    lbltakimP1.Text = puanDizisi[0].ToString();
            //    lbltakim1.Text = label3.Text;
            //    lblgol1.Text = label3gol.ToString();
            //}
            //if (puanDizisi[0] == label4puan4)
            //{
            //    lbltakimP1.Text = puanDizisi[0].ToString();
            //    lbltakim1.Text = label4.Text;
            //    lblgol1.Text = label4gol.ToString();
            //}

            //// 2.olan takımı bulma
            //if (puanDizisi[1] == label1puan1)
            //{
            //    lbltakimP2.Text = puanDizisi[1].ToString();
            //    lbltakim2.Text = label1.Text;
            //    lblgol2.Text = label1gol.ToString();
            //}
            //if (puanDizisi[1] == label2puan2)
            //{
            //    lbltakimP2.Text = puanDizisi[1].ToString();
            //    lbltakim2.Text = label2.Text;
            //    lblgol2.Text = label2gol.ToString();
            //}
            //if (puanDizisi[1] == label3puan3)
            //{
            //    lbltakimP2.Text = puanDizisi[1].ToString();
            //    lbltakim2.Text = label3.Text;
            //    lblgol2.Text = label3gol.ToString();
            //}
            //if (puanDizisi[1] == label4puan4)
            //{
            //    lbltakimP2.Text = puanDizisi[1].ToString();
            //    lbltakim2.Text = label4.Text;
            //    lblgol2.Text = label4gol.ToString();
            //}

            //// 3.olan takımı bulma
            //if (puanDizisi[2] == label1puan1)
            //{
            //    lbltakimP3.Text = puanDizisi[2].ToString();
            //    lbltakim3.Text = label1.Text;
            //    lblgol3.Text = label1gol.ToString();
            //}
            //if (puanDizisi[2] == label2puan2)
            //{
            //    lbltakimP3.Text = puanDizisi[2].ToString();
            //    lbltakim3.Text = label2.Text;
            //    lblgol3.Text = label2gol.ToString();
            //}
            //if (puanDizisi[2] == label3puan3)
            //{
            //    lbltakimP3.Text = puanDizisi[2].ToString();
            //    lbltakim3.Text = label3.Text;
            //    lblgol3.Text = label3gol.ToString();
            //}
            //if (puanDizisi[2] == label4puan4)
            //{
            //    lbltakimP3.Text = puanDizisi[2].ToString();
            //    lbltakim3.Text = label4.Text;
            //    lblgol3.Text = label4gol.ToString();
            //}

            //// 4.olan takımı bulma
            //if (puanDizisi[3] == label1puan1)
            //{
            //    lbltakimP4.Text = puanDizisi[3].ToString();
            //    lbltakim4.Text = label1.Text;
            //    lblgol4.Text = label1gol.ToString();
            //}
            //if (puanDizisi[3] == label2puan2)
            //{
            //    lbltakimP4.Text = puanDizisi[3].ToString();
            //    lbltakim4.Text = label2.Text;
            //    lblgol4.Text = label2gol.ToString();
            //}
            //if (puanDizisi[3] == label3puan3)
            //{
            //    lbltakimP4.Text = puanDizisi[3].ToString();
            //    lbltakim4.Text = label3.Text;
            //    lblgol4.Text = label3gol.ToString();
            //}
            //if (puanDizisi[3] == label4puan4)
            //{
            //    lbltakimP4.Text = puanDizisi[3].ToString();
            //    lbltakim4.Text = label4.Text;
            //    lblgol4.Text = label4gol.ToString();
            //}
            btnOyna.Enabled = false;
        }

        
    }
}
