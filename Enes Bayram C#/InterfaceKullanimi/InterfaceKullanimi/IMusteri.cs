using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceKullanimi
{
    public interface IMusteri
    {
        void ekle();  // Interfacelerde bulunan metotların erişim belirleyicileri ve {içeriği} olmaz 
        void sil();
        void guncelle();
        void getir();


    }
}
