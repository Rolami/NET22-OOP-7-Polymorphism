using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP7_Polymorphism
{
    internal class Cirkel : Geometri
    {

        public double radius { get; set; }
       
        public Cirkel (double C_Radius = 1)
        {
            this.radius = C_Radius;
        }

        const double pi = 3.1415926535897931;

        public override double Area()
        {
            area = Math.Pow(radius, 2) * pi;
            return area;
        }
    }

}
