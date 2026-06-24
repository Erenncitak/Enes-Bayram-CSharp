using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kapsulleme_Odev
{
    public class Personel
    {
        private string tckimlikno;

        public string TCKİMLİKNO
        {
            get
            {
                return tckimlikno.Substring(0, 5)+"******";
            }

            set
            {
                bool kontrol = false;
                if (value.Length == 11)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        bool sayiMi = char.IsNumber(value[i]);

                        if (sayiMi)
                        {
                            // 123a4567891
                        }
                        else
                        {
                            kontrol = true;
                            break;
                        }
                    }

                    if (kontrol)
                    {
                        Console.WriteLine("TC kimlik numaranızda geçersiz karakter bulundu.!!");
                    }
                    else
                    {
                        tckimlikno = value;
                    }
                }
                else
                {
                    Console.WriteLine("Girdiğiniz TC KİMLİK NO 11 karakter değildir..");
                }
            }
        }
    }
}
