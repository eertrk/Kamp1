using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        public void Ekle(Product product)
        {

            Console.WriteLine(product.Adi + " Sepete Eklendi !");
        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat)
        {
            Console.WriteLine("Sepete Eklendi : "+ urunAdi+ aciklama+fiyat);

        }

    }
}
