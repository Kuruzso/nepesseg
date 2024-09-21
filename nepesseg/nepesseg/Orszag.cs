using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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

        public bool FoVarosNepessegFelett30()
        {
           
            return fovaros_nepessege*1000 >= int.Parse(nepesseg) * 0.30;
        }

        static void suruseg(string sor, List<Orszag> adatok) {

            Console.WriteLine("4.Feladat");
         

            for (int i = 0; i < adatok.Count; i++)
            {
                if (adatok[i].orszag == "Kína")
                {
                    Console.WriteLine("Kína népsűrűssége: {0} fő/km^2", int.Parse(adatok[i].nepesseg) / adatok[i].terulet);
                                    }
            }
            return;

        }

       
    }
}
