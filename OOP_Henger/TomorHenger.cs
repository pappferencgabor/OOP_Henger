using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP_Henger
{
    public class TomorHenger : Henger
    {
        private double fajsuly;

        public TomorHenger(double sugar, double magassag): base(magassag, sugar)
        {
            fajsuly = 7.87;
        }

        public TomorHenger(double sugar, double magassag, double fajsuly): base(sugar, magassag)
        {
            this.fajsuly = fajsuly;
        }

        public double GetFajsuly { get => fajsuly; }

        public double Suly { get => fajsuly * Terfogat(); }

        public string ToString()
        {
            return base.ToString() + $"; fajsúly:{fajsuly}";
        }
    }
}