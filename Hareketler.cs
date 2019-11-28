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