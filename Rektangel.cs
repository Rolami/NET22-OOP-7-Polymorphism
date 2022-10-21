using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP7_Polymorphism
{
    internal class Rektangel : Geometri
    {
        public double _base { get; set; }
        public double _height { get; set; }

        public Rektangel(double C_Base = 1, double C_Height = 2)
        {
            this._base = C_Base;
            this._height = C_Height;
        }


        public override double Area()
        {
            area = _base * _height;
            //string print = $"Base {_base} and Height {_height} gives an area of : {area}";
            return area;
        }

    }
}
