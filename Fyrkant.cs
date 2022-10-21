using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP7_Polymorphism
{
    internal class Fyrkant : Geometri
    {
        public double sida { get; set; }

        public Fyrkant(double C_Sida = 1)
        {
            this.sida = C_Sida;

        }
        public override double Area()
        {
            area = sida * sida;
            return area;
        }
    }
}
