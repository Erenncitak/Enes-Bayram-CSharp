using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListNedir
{
    class Program
    {
        static void Main(string[] args)
        {

            ArrayList koleksiyon = new ArrayList();
            koleksiyon.Add("Eren"); // ekleme işlemi yapar
            koleksiyon.Add("Ali");
            koleksiyon.Add("Yusuf");
            koleksiyon.Add("Mehmet");

            //koleksiyon.Remove("Mehmet");  // çıkarma işlemi yapar
            //int count = koleksiyon.Count; // dizinin sayısını verir 
            //koleksiyon.Clear(); // dizideki tüm elemanları temizler
            //bool kontrol = koleksiyon.Contains("Hasan"); // parametre içerisindeki veriyi içerip içermediğini kontrol eder
            //int index = koleksiyon.IndexOf("Hasan"); // parametrede yazılı olan ifadenin kaçıncı stringte olduğunu söyler bulunmuyorsa -1 çevirir
            //koleksiyon.Insert(3, "Sercan"); // hangi indexe ne değeri gireceksek sırası ile parametrelere yazıyoruz 3.index'e "Hasan" ifadesini ekle 
            //koleksiyon.Reverse(); // Dizideki elemanları ters index numarasına göre sıralar. Diziyi ters çevirir.

            //ArrayList rakamlar = new ArrayList();
            //rakamlar.Add(5);
            //rakamlar.Add(3);
            //rakamlar.Add(1);
            //rakamlar.Add(100);
            //rakamlar.Add(2);

            //rakamlar.Sort(); // dizinin elemanlarını küçükten büyüğe doğru sıralar

            //foreach (int a in rakamlar)
            //{
            //    Console.WriteLine(a);
            //}

            int a = 10;

            string b = a.ToString();



            //Console.WriteLine("Dizinin eleman sayisi :" + count);
            //Console.WriteLine(kontrol);
            //Console.WriteLine("İndex Numarası :"+index);

            Console.ReadLine();
        }
    }
}
