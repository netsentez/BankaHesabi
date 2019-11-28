using System;

namespace BankaHesabi
{
    class Program
    {
        //İŞLEMLER:
        static void Main(string[] args)
        {
            //Kendi adıma hesap açıyorum:
            var hesap = new Hesap("Nizamettin Kaya");
            
            //Hesap numarama, kaydedilen kimliğime bakıyorum:
            Console.WriteLine("-------------");
            Console.WriteLine($"Hesap No: {hesap.HesapNo}");
            Console.WriteLine($"Ad Soyad: {hesap.AdSoyad}");
            Console.WriteLine("-------------");
            Console.WriteLine();

            //Hesabıma 1000 TL yatırıyorum:
            hesap.ParaYatir(1000, DateTime.Now, "Bol kazançlar!");

            //Hesabımdan 150 TL çekiyorum:
            hesap.ParaCek(150, DateTime.Now, "Kitap parası.");

            //Hesabımdan 75 TL çekiyorum:
            hesap.ParaCek(75, DateTime.Now, "Kulaklık parası.");

            //Hesabıma 500 TL yatırıyorum:
             hesap.ParaYatir(500, DateTime.Now, "Bol kazançlar!");

            //Hesap hareketlerime ve mevcut yeküne Bakıyorum:
            foreach (var islem in hesap.hesapHareketleri)
            {
                Console.WriteLine($"İşlem Tarihi: {islem.Tarih}, Çekilen/Yatırılan Miktar: {islem.YatirilanMiktar}, Açıklama: {islem.Aciklama}.");
            }
            Console.WriteLine("-------------");
            Console.WriteLine($"Yekün: {hesap.Kalan} TL.");
        }

    }
}
