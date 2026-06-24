using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiziOrnek1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = { 10, 10, 20, 30, 20, 30, 40, 50, 40, 50, 70, 55, 65, 70, 55, 65, 5, 20, 35, 65, 5, 20, 35, 65, 80 };

            Console.WriteLine("Dizide aranmasını istediğiniz sayiyi giriniz");
            int deger = Convert.ToInt32(Console.ReadLine());
            int dizideBulunma = 0;


            for (int i = 0; i < sayilar.Length; i++)
            {
                if (sayilar[i] == deger)
                {
                    dizideBulunma++;
                }
            }
            if(dizideBulunma == 0)
            {
                    Console.WriteLine("Girdiğiniz değer dizide bulunamadı");
            }
            else
            {
                Console.WriteLine("Girdiğiniz değer ==> " + deger);
                Console.WriteLine("Girdiğiniz değerden " + dizideBulunma + " adet vardır");
            }
                
        }
    }
}
