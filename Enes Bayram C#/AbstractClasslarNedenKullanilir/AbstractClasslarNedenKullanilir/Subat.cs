using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasslarNedenKullanilir
{
    public class Subat : Ay
    {
        public override int ayKacCekiyor()
        {
            return 28;
        }

        public override int kacinciYil()
        {
            return 2;
        }
    }
}
