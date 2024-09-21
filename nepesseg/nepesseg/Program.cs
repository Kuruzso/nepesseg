using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nepesseg
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Orszag> adatok = new List<Orszag>();
            StreamReader sr = new StreamReader("adatok-utf8.txt");
            sr.ReadLine();
            while (!sr.EndOfStream)
            {
                adatok.Add(new Orszag(sr.ReadLine()));
            }
            sr.Close();




            for (int i = 0; i < adatok.Count; i++)
            {
             
                if (adatok[i].nepesseg.EndsWith("g"))
                {
                    
                    string levalaszt = adatok[i].nepesseg.TrimEnd('g');

                    
                    if (int.TryParse(levalaszt, out int szam))
                    {
                        
                        int szorzottszam = szam * 10000;

                       
                        adatok[i].nepesseg = szorzottszam.ToString();
                    }
                    
                }
            }
            //3.Feladat
            Console.WriteLine("3.Feladat");
            Console.WriteLine("A beolvasott országok száma {0}. ",adatok.Count());
            Console.WriteLine();
            //4.feladat
            Console.WriteLine("4.Feladat");

            for (int i = 0; i < adatok.Count; i++)
            {
                if (adatok[i].orszag == "Kína")
                {
                    Console.WriteLine("Kína népsűrűssége: {0} fő/km^2",int.Parse(adatok[i].nepesseg) / adatok[i].terulet);
                }
            }


            Console.ReadLine();
        }
    }
}
