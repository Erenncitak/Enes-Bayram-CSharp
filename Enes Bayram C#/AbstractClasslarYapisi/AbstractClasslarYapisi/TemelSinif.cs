using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasslarYapisi
{
    public abstract class TemelSinif
    {
        public void metot1()
        {
            Console.WriteLine("Metot 1 çalıştı"); // {} arasında kalan kısım metodun body
        }

        public abstract void metot2(); // Metodun imzası
    }
}
