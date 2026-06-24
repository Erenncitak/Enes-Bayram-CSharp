using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace StaticYapiciMetotKullanimi
{
    public class Kullanici
    {
        private int kullaniciID{ get; set; }
        private string isim { get; set; }
        private string soyisim { get; set; }
        private static int maas { get; set; }


        static Kullanici()
        {
            maas = 22500;
        }

        public Kullanici(int _kullaniciID, string _isim, string _soyisim)
        {
            kullaniciID = _kullaniciID;
            isim = _isim;
            soyisim = _soyisim;
        }

        public void bilgileriGoster()
        {
            Console.WriteLine("Kullanıcı Bilgileri");
            Console.WriteLine("ID ==> " + kullaniciID);
            Console.WriteLine("İsim ==> " + isim);
            Console.WriteLine("Soyisim ==> " + soyisim);
            Console.WriteLine("Maaş : " + maas);
        }

        public void zamYap(int zamMiktari)
        {
            Console.WriteLine("Kullanıcıya Zam yapılıyor...");
            Console.WriteLine("Şuanki Maaşı : " + (maas + zamMiktari));
        }
    }
}
