using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasslarNedenKullanilir
{
    public class Ocak : Ay
    {
        public override int ayKacCekiyor()
        {
            return 30;
        }

        public override int kacinciYil()
        {
            return 1;
        }
    }
}
