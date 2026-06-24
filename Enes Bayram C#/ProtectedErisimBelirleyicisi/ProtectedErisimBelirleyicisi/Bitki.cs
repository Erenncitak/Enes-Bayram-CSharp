using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtectedErisimBelirleyicisi
{
    public class Bitki // Mirası veren class olduğu için SuperClass, BaseClass, MainClass
    {
        public int bitkiID{ get; set; }
        protected string bitkiIsmi{ get; set; }
        protected string bitkiRengi{ get; set; }
    }
}
