using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasslarNedenKullanilir
{
    class Program
    {
        static void Main(string[] args)
        {

            // Abstract classların İnterface'e göre kullanımı bu örnekte daha mantıklı olacaktır görelim hemen.

            Ocak ocak = new Ocak();
            Console.WriteLine("Ocak gün saati : " + ocak.gunSaati());
            
            Subat subat = new Subat();
            Console.WriteLine("Şubat gün saati : " + subat.gunSaati());

            Mart mart = new Mart();
            Console.WriteLine("Mart gün saati : " + mart.gunSaati());



        }
    }
}
