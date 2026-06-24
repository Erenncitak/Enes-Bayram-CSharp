using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciUygulamasi
{
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogr1 = new Ogrenci(1, "Eren", "ÇITAK", 70, 85, 60, "Gelişim Üniversitesi");
            //ogr1.ogrenciBilgileriGöster();
            //ogr1.ogrenciOrtalamasiBul();
            //ogr1.okulGetir();
            int i = 0;
            do
            {
                Console.WriteLine("Öğrenci Menümüze Hoşgeldiniz");
                Console.WriteLine("1-Öğrenci Bilgileri Göster");
                Console.WriteLine("2-Öğrenci Ortalaması Göster");
                Console.WriteLine("3-Öğrencinin Okulunu Öğren");
                Console.WriteLine("4-Çıkış Yap");
                int secim =Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                switch (secim)
                {
                    case 1:
                        ogr1.ogrenciBilgileriGöster();
                        break;

                    case 2:
                        ogr1.ogrenciOrtalamasiBul();
                        Console.WriteLine();
                        break;

                    case 3:
                        ogr1.okulGetir();
                        Console.WriteLine();
                        break;

                    case 4:
                        i++;
                        break;

                    default:
                        Console.WriteLine("Menü dışında bir seçenek girdiniz.!!");
                        i++;
                        break;
                }
            } while (i != 1);
        }
    }
}
