using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NedenInterfaceKullaniriz
{
    public class SqlServer : IMusteri
    {
        public void ekle()
        {
            Console.WriteLine("SqlServer ekledi");
        }

        public void guncelle()
        {
            Console.WriteLine("SqlServer güncelledi");
        }

        public void sil()
        {
            Console.WriteLine("SqlServer sildi");
        }
    }
}
