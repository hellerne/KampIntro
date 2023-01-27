using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety - tip güvenliği
            //Kendini tekrar etme
            // Değer tutucu, alias

            
            string KategoriEtiketi = "Kategoriler";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemGirisYapmisMi = false;

            if (sistemGirisYapmisMi == true)
            {
                Console.WriteLine("Hoşgeldiniz");
            }
            else
            {
                Console.WriteLine("Tekrar Deneyiniz");
            }
            Console.WriteLine(faizOrani); 


        }
    }
}
