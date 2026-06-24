using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasslarYapisi
{
    class Program
    {
        static void Main(string[] args)
        {
            // Abstract classlar tamamen kalıtım amaçla geliştirilmiştir.
            // İçerisinde tanımlanmış metot imzalarını miras alan class'lar override etmek zorundadır.

            // Abstract classlar - Normal Class arasındaki fark nedir?
            //1-Normal classlar'da metot imzası tanımı yapamaz iken Abstract classlar'da metot imzası yapılır.
            //2-Normal classlar'da new anahtar kelimesi ile nesneler oluşturulabilirken Anstract classlar'da yapamayız.

            //Anstract classlar - İnterface farkı nedir?
            // ---> Bir sınıfa abstract class'lardan sadece birini miras alabilirken , o class birden çok interface'i implenet'e edebilir.
        
            AltSinif altsinif = new AltSinif();
            altsinif.metot1();
            altsinif.metot2();


            Console.ReadLine();
        
            // TemelSinif temel = new TemelSinif(); 
        


        }
    }
}
