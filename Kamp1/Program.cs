using System;

namespace Kamp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety = tip güvenliği
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            bool sistemeGirisYaptiMi = false; // bool mantıksal değişken
            double dolarDun = 7.45;
            double dolarBugun = 7.45;


            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış Butonu");
            }
            else if(dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış Butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi");
            }


            if (sistemeGirisYaptiMi == true )
            {
                Console.WriteLine("kullanıcı ayar butonu");
            }
            else
            {
                Console.WriteLine("Giris Yapiniz");
            }
            
        }
    }
}
