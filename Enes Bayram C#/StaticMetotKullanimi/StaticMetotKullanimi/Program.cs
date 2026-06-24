using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticMetotKullanimi
{
    class Program
    {
        static void Main(string[] args)
        {
            // static olmayan void metodunda data çekmek için yaptığımız yöntem. Sınıfa ait bir obje oluşturup onun üzerinden metodu çağırıyoruz.
            //Personel p1 = new Personel();
            //p1.isimSoyisimYazdir();

            // static olur ise herhangi bir objeye atama işlemine gerek olmadan direkt sınıfın kendisinden oluşturduğumuz metotdu çağırabiliriz
            Personel.isimSoyisimYazdir();

            Personel.sayilarinToplami(10, 15);

            Console.ReadLine();
        }
    }
}
