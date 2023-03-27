using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kivetelkezeles
{
    class EgyTizKozottException : Exception
    {
        public int ertek;

        public EgyTizKozottException(int value)
        {
            this.ertek = value;
        }


        public override string Message => "Nincs olyan, hogy 0 vagy 10-nél több....";
    }
}
