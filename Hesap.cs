// Microsoft'un öğretim dokümanları temel alınmıştır.
// Kaynak Bağlantısı: https://docs.microsoft.com/en-us/dotnet/csharp/tutorials/intro-to-csharp/introduction-to-classes
// netsentez-nizamettin kaya
// www.netsentez.com

using System;
using System.Collections.Generic;

namespace BankaHesabi
{
    public class Hesap
    {
        public string HesapNo { get; }
        public string AdSoyad { get; set; }
        public decimal Kalan
        {   get
            {
                decimal kalan = 0;
                foreach (var hareket in hesapHareketleri)
                {
                    kalan += hareket.YatirilanMiktar;
                }
                return kalan;
            }
        }
        private static int hesapNoEkleme = 123;
        public List<Hareketler> hesapHareketleri = new List<Hareketler>();

        public void ParaYatir(decimal miktar, DateTime tarih, string aciklama)
        {
            if (miktar <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(miktar), "Yatırılan para negatif olmaz!");
            }
            var yatirilan = new Hareketler(miktar, tarih, aciklama);
            hesapHareketleri.Add(yatirilan);
        }

        public void ParaCek(decimal miktar, DateTime tarih, string aciklama)
        {
            if (miktar <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(miktar), "Çekilen para negatif olmaz!");
            }
            if(Kalan - miktar < 0)
            {
                throw new InvalidOperationException("Paranız yok, hepsini çekmiştiniz!");
            }
            var cekilen = new Hareketler(-miktar, DateTime.Now, aciklama);
            hesapHareketleri.Add(cekilen);

        }

        public Hesap(string adSoyad)
        {
            this.AdSoyad = adSoyad;
            hesapNoEkleme++;
            this.HesapNo = hesapNoEkleme.ToString();
        }
    }
    
}
