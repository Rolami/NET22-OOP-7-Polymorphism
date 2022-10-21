using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP7_Polymorphism
{
    internal class Paralellogram : Rektangel
    {
        //properties ärvs från Rektangel
        public Paralellogram(double C_Base = 1, double C_Height = 2)
        {
            this._base = C_Base;
            this._height = C_Height;
        }


        //public override double Area()
        //{
        //    area = _base * _height;
        //    return area;
        //}
    }
}
