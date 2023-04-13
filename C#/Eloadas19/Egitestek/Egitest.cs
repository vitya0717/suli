using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egitestek
{
    public abstract class Egitest
    {
        private string nev;

        protected Egitest(string nev)
        {
            this.nev = nev;
        }

        public String Nev
        {
            get { return nev; }
            set { nev = value; }
        }

        protected Egitest()
        {

        }


    }
}
