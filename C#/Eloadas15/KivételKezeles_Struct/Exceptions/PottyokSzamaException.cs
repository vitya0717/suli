using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace KivételKezeles_Struct.Exceptions
{
    internal class PottyokSzamaException : Exception
    {
        int hibasAdat;
        string hibasFajta;

        public int HibasAdat
        { 
            get { return hibasAdat; } 
            set { hibasAdat = value; } 
        }

        public string HibasFajta
        {
            get { return hibasFajta; }
            set { hibasFajta = value; }
        }

        public override string Message => $"Hibás adat! {HibasAdat}";

        public PottyokSzamaException(int hibasAdat, string hibasFajta)
        {
            HibasAdat = hibasAdat;
            HibasFajta = hibasFajta;
        }

    }
}
