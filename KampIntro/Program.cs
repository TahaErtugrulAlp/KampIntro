using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety tip güvenliği 
            string kategoriEtiketi = "Kategoriler";
            int ogrenciSayisi = 32000;
            double faizOranı = 1.45;
            bool sistemeGirisYapmisMi = true;
            double dolarDun = 8.65;
            double dolarBugun = 8.65;

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalış butonu");
            }
            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Artış Butonu");
            }
            else
            {
                Console.WriteLine("Eşittir butonu");
            }

            //Fonksiyonlar bir kod bloğunu tekrar tekrar kullanmaya yarar

            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı ayarlar butonu");
            }
            else
            {
                Console.WriteLine("Kayıt ol butonu ");
            }

        }
    }
}
