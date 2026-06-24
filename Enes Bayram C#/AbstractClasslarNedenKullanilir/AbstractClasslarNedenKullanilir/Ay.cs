using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasslarNedenKullanilir
{
   public abstract class Ay
    {
        public int gunSaati()
        {
            return 24;
        }
        public abstract int kacinciYil();
        public abstract int ayKacCekiyor();
    }
}
