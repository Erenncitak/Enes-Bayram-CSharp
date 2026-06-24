using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniAtmProjesi
{
    class Program
    {
        static void Main(string[] args)
        {
            int bakiye = 1000;
            Console.WriteLine("Atm ye Hoşgeldiniz");
            Console.WriteLine("Yapmak istediğiniz işlemi seçiniz");
            string secim = Console.ReadLine();


            if(secim == "1")
            {
                Console.WriteLine("Şuanki Bakiyeniz" + bakiye);
            }
            else if (secim == "2")
            {
                Console.WriteLine("Çekmek istediğiniz tutarı giriniz");
                int cekilecek_tutar = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Kalan Tutar :" + (bakiye - cekilecek_tutar));
            }
            else if (secim == "3")
            {
                Console.WriteLine("Yatırmak istediğiniz tutarı giriniz");
                int yatırılacak_tutar = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Yeni Bakiyeniz:" + (bakiye - yatırılacak_tutar));
            }
            else if(secim == "q")
            {
                Console.WriteLine("ATM 'den çıkış yapılıyor");
                Console.WriteLine("Çıkış yapıldı İyi günler");
            }
            else
            {
                Console.WriteLine("Lütfen geçerli bir değer giriniz");
            }
        }
    }
}
