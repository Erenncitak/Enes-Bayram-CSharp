using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GirisUygulamasi
{
    class Program
    {
        static void Main(string[] args)
        {
            int hak_sayisi = 3;

            while (true)
            {
                Console.WriteLine("Kullanıcı adınızı giriniz");
                string kullaniciAdi = Console.ReadLine();

                Console.WriteLine("Şifrenizi adınızı giriniz");
                string sifre = Console.ReadLine();
            
            
                if(kullaniciAdi =="eren" &&  sifre == "123")
                {
                    Console.WriteLine("Tebrikler başarılı bir şekilde giriş yaptınız :)");
                    break;
                }
                else
                {
                    Console.WriteLine("Kullanıcı adınız veya şifreniz yanlış !");

                    if (hak_sayisi > 0)
                    {
                        hak_sayisi--;
                    }
                    if(hak_sayisi == 0)
                    {
                        Console.WriteLine("Hakkınız dolmuştur daha giriş yapamazsınız.");
                        break;
                    }
                
                
                }
            
            
            
            
            }
        }
    }
}
