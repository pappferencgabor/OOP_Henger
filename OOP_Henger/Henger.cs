using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP_Henger
{
    public class Henger
    {
        private double magassag;
        private double sugar;
        protected static int szuletesSzamlalo = 0;

        public double GetMagassag { get => magassag; }

        public double GetSugar { get => sugar; }

        public static int SzuletesSzamlalo { get => szuletesSzamlalo; }

        public Henger(double magassag, double sugar)
        {
            this.magassag = magassag;
            this.sugar = sugar;
            szuletesSzamlalo += 1 ;
        }

        public double Terfogat()
        {
            return Math.PI * Math.Pow(sugar, 2) * magassag;
        }

        public string ToString()
        {
            return $"Jellemzők >> térfogat:{Math.Round(Terfogat(), 2)}; sugár:{sugar}; magasság:{magassag};";
        }
    }
}