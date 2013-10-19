using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Bead
    {
        public int anyag;
        public string kat;
        public int vegtermek;

        public Bead(int anyag, string kat, int vegtermek)
        {
            this.anyag = anyag;
            this.kat = kat;
            this.vegtermek = vegtermek;
        }
    }
}
