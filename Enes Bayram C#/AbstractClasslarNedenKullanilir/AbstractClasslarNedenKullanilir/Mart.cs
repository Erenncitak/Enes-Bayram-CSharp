using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasslarNedenKullanilir
{
    public class Mart : Ay
    {
        public override int ayKacCekiyor()
        {
            return 31;
        }

        public override int kacinciYil()
        {
            return 3;
        }
    }
}
