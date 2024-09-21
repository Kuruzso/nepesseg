using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nepesseg
{
    internal class Orszag
    {
        public string orszag;
        public int terulet;
        public string nepesseg;
        public string fovaros;
        public int fovaros_nepessege;

        public Orszag(string sor)
        {
            string[] darabok = sor.Split(';');
            this.orszag = darabok[0]; 
            this.terulet = Convert.ToInt32(darabok[1]);
            this.nepesseg = darabok[2];
            this.fovaros = darabok[3];
            this.fovaros_nepessege = Convert.ToInt32(darabok[4]);
        }
    }
}
