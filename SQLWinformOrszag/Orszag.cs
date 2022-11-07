using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLWinformOrszag
{
    internal class Orszag
    {

        readonly int Id;
        readonly string OrszagNev;
        readonly string Fovaros;
        readonly double Terulet;
        readonly double Nepesseg;
        readonly string AllamForma;

        public int Id1 => Id;

        public string OrszagNev1 => OrszagNev;

        public string Fovaros1 => Fovaros;

        public double Terulet1 => Terulet;

        public double Nepesseg1 => Nepesseg;

        public string AllamForma1 => AllamForma;

        public Orszag(int id, string orszagNev, string fovaros, double terulet, double nepesseg, string allamForma)
        {
            Id = id;
            OrszagNev = orszagNev;
            Fovaros = fovaros;
            Terulet = terulet;
            Nepesseg = nepesseg * 1000;
            AllamForma = allamForma;
        }

        public override string ToString()
        {
            return OrszagNev;
        }

    }
}
