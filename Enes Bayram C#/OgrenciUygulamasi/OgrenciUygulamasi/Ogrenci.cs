using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciUygulamasi
{
    class Ogrenci
    {
        private int ogrenciNo;
        private string isim;
        private string soyisim;
        private int vize1;
        private int vize2;
        private int final;
        private string okulIsmi;

        public Ogrenci(int _ogrenciNo, string _isim, string _soyisim, int _vize1, int _vize2, int _final, string _okulIsmi)
        {
            ogrenciNo = _ogrenciNo;
            isim = _isim;
            soyisim = _soyisim;
            vize1 = _vize1;
            vize2 = _vize2;
            final = _final;
            okulIsmi = _okulIsmi;
        }

        public void ogrenciBilgileriGöster()
        {
            Console.WriteLine("Öğrenci'nin Öğrenci Numarası: " + ogrenciNo);
            Console.WriteLine("Öğrenci'nin İsmi: " + isim);
            Console.WriteLine("Öğrenci'nin Soyismi: " + soyisim);
            Console.WriteLine("Öğrenci'nin 1.Vize Notu: " + vize1);
            Console.WriteLine("Öğrenci'nin 2.Vize Notu: " + vize2);
            Console.WriteLine("Öğrenci'nin Final Notu: " + final);
            Console.WriteLine("Öğrenci'nin Okul İsmi: " + okulIsmi);
            Console.WriteLine();
            Console.WriteLine();
        }

        public void ogrenciOrtalamasiBul()
        {
            Console.WriteLine("Öğrencinin Ortalaması: " + (vize1 * 0.25 + vize2 * 0.25 + final * 0.50));
        }

        public void okulGetir()
        {
            Console.WriteLine("Öğrencinin bulunduğu okul: " + okulIsmi);
        }

    }
}
