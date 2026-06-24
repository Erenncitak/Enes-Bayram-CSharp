using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Şekil uygulamasına hoşgeldiniz !");

            while (true)
            {
                Console.WriteLine("İşlem Seçiniz");
                Console.WriteLine("1- Dikdörtgen İşlemleri");
                Console.WriteLine("2- Üçgen İşlemleri");
                Console.WriteLine("3- Kare İşlemleri");
                Console.WriteLine("4- Q'ya basarak çıkınız");

                string secim = Console.ReadLine();

                if (secim == "q")
                {
                    Console.WriteLine("Ana menüden çıkış yapılıyor...");
                    break;
                }

                else if (secim == "1")
                {
                    while (true)
                    {
                        Console.WriteLine("1-Dikdörtgen alan hesapla");
                        Console.WriteLine("2-Dikdörtgen bilgileri göster");
                        Console.WriteLine("3-Dikdörtgen çıkış yap");

                        string secimDikdortgen = Console.ReadLine();

                        if(secimDikdortgen == "1")
                        {
                            Console.WriteLine("Kısa kenarı giriniz : ");
                            int kısaKenar = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Uzun kenarı giriniz : ");
                            int uzunKenar= Convert.ToInt32(Console.ReadLine());
                            Dikdortgen dikdortgen = new Dikdortgen("Dikdörtgen",kısaKenar,uzunKenar);
                            dikdortgen.sekilHesapla();
                        }
                        else if(secimDikdortgen == "2")
                        {
                            Console.WriteLine("Kısa kenarı giriniz : ");
                            int kısaKenar = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Uzun kenarı giriniz : ");
                            int uzunKenar = Convert.ToInt32(Console.ReadLine());
                            Dikdortgen dikdortgen = new Dikdortgen("Dikdörtgen", kısaKenar, uzunKenar);
                            dikdortgen.sekilBilgileriGoster();
                        }
                        else if(secimDikdortgen == "3")
                        {
                            Console.WriteLine("Dikdörtgen işlemlerinden çıkılıyor...");
                            break;
                        }
                    }
                }

                else if (secim == "2")
                {
                    while (true)
                    {
                        Console.WriteLine("1-Üçgen alan hesapla");
                        Console.WriteLine("2-Üçgen bilgileri göster");
                        Console.WriteLine("3-Üçgen çıkış yap");

                        string secimUcgen= Console.ReadLine();

                        if(secimUcgen == "1")
                        {
                            Console.WriteLine("Üçgenin taban alanını giriniz : ");
                            int tabanAlani = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Üçgenin yüksekliğini giriniz : ");
                            int yukseklik= Convert.ToInt32(Console.ReadLine());
                            Ucgen ucgen = new Ucgen("Üçgen",tabanAlani,yukseklik);
                            ucgen.sekilHesapla();
                        }
                        else if (secimUcgen == "2")
                        {
                            Console.WriteLine("Üçgenin taban alanını giriniz : ");
                            int tabanAlani = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Üçgenin yüksekliğini giriniz : ");
                            int yukseklik = Convert.ToInt32(Console.ReadLine());
                            Ucgen ucgen = new Ucgen("Üçgen", tabanAlani, yukseklik);
                            ucgen.sekilBilgileriGoster();
                        }
                        else if (secimUcgen == "3")
                        {
                            Console.WriteLine("Üçgen işlemlerinden çıkılıyor...");
                            break;
                        }

                    }
                }

                else if (secim == "3")
                {
                    while (true)
                    {
                        Console.WriteLine("1-Kare alan hesapla");
                        Console.WriteLine("2-Kare bilgileri göster");
                        Console.WriteLine("3-Kare çıkış yap");

                        string secimKare = Console.ReadLine();

                        if (secimKare == "1")
                        {
                            Console.WriteLine("Karenin kanarını giriniz : ");
                            int kenar = Convert.ToInt32(Console.ReadLine());
                            Kare kare = new Kare("Kare",kenar);
                            kare.sekilHesapla();
                        }
                        else if (secimKare == "2")
                        {
                            Console.WriteLine("Karenin kanarını giriniz : ");
                            int kenar = Convert.ToInt32(Console.ReadLine());
                            Kare kare = new Kare("Kare", kenar);
                            kare.sekilBilgileriGoster();
                        }
                        else if (secimKare == "3")
                        {
                            Console.WriteLine("Kare işlemlerinden çıkılıyor...");
                            break;
                        }
                    }
                }

                else
                {
                    Console.WriteLine("Lütfen menüde bulunanlar arasında bir seçim yapınız.!!!");
                }

            }

        }
    }
}
