// Microsoft'un öğretim dokümanları temel alınmıştır.
// Kaynak Bağlantısı: https://docs.microsoft.com/en-us/dotnet/csharp/tutorials/intro-to-csharp/introduction-to-classes
// netsentez-nizamettin kaya
// www.netsentez.com

using System;

namespace BankaHesabi
{
    public class Hareketler
    {
        public decimal YatirilanMiktar { get; }
        public DateTime Tarih { get; }
        public string Aciklama { get; }
    
        public Hareketler(decimal yatirilacakMiktar, DateTime tarih, string aciklama)
            {
                this.YatirilanMiktar =yatirilacakMiktar;
                this.Tarih = tarih;
                this.Aciklama = aciklama;
            }
    }

}
