using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampiyonlarLigiSimulasyonu
{
    class Takim
    {
        // Takım sınıfı içinde private özellikte string veri tipinde değişkenler tanımlanıyor.
        private string takimIsmi;
        private string takimULke;

        // Takım sınıfı ile aynı isimde parametreler alan Constructors (Yapıcı) method tanımlanıyor.
        public Takim(string isim, string ulke)
        {
            takimIsmi = isim;
            takimULke = ulke;
        }

        // Kapsülleme yapılıyor. 
        // Private tanımlı değişkenlere aşağıda istenilen formatta erişilebilmesini sağlıyor.
        public string _TakimAdi
        {
            get
            {
                return takimIsmi; 
            }
            set
            {
                takimIsmi = value;
            }
        }

        // Kapsülleme yapılıyor. 
        public string _takimUlke
        {
            get
            {
                return takimULke;
            }
            set
            {
                takimULke = value;
            }
        }

        // Override ediliyor. Return geri dönüş tipinden dönen değer formatında verinin alınması sağlanıyor.
        public override string ToString()
        {
            return takimIsmi + "  (" + takimULke + ")"; // Takım ve ülke değerleri yüklenirken ülke değerlerinin parantez içinde yazılmasını istiyorum.
        }
    }
}
