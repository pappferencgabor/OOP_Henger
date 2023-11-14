using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP_Henger
{
    public class Cso : Henger
    {
        private double falVastagsag;

        public Cso(double sugar, double magassag): base(magassag, sugar)
        {
            falVastagsag = 1;
        }

        public Cso(double sugar, double magassag, double falvastagsag): base(magassag, sugar)
        {
            this.falVastagsag = falvastagsag;
        }

        public double FalVastagsag { get => falVastagsag; }

        public void Terfogat()
        {
            throw new System.NotImplementedException();
        }

        public string ToString()
        {
            return base.ToString() + $"; falvastagsága:{falVastagsag}";
        }
    }
}