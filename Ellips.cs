using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP7_Polymorphism
{
    internal class Ellips : Geometri
    {
        const double pi = 3.1415926535897931;
        public double radius1 { get; set; }
        public double radius2 { get; set; }

        public Ellips (double C_Radius1 = 1, double C_Radius2 = 2)
        {
            this.radius1 = C_Radius1;
            this.radius2 = C_Radius2;
        }
        public override double Area()
        {
            area = radius1 * radius2 * pi;
            return area;
        }
    }
}
