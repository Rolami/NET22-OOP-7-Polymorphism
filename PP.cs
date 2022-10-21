using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP7_Polymorphism
{

    //Pixel Printer
    internal class PP
    {
        public static void Printy()
        {
            Geometri sq1 = new Rektangel(3.6,7.5);
            Console.WriteLine($"\nArean av Rektangeln är lika med : {sq1.Area():F2}");

            Geometri fk1 = new Fyrkant(9.6);
            Console.WriteLine($"\nArean av Fyrkanten är lika med : {fk1.Area():F2}");


            Geometri c1 = new Cirkel(7);
            Console.WriteLine($"\nArean av Cirkeln är lika med : {c1.Area():F2}");

            Geometri pg1 = new Paralellogram(6.3, 9);
            Console.WriteLine($"\nArean av Paralellogrammet är lika med : {pg1.Area():F2}");

            Geometri ep1 = new Ellips(6.3, 9);
            Console.WriteLine($"\nArean av Ellipsen är lika med : {ep1.Area():F2}");

        }


    }
}
