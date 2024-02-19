using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercizioVettori
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double m1 = 6 * Math.Pow(10, 24);
            double m2 = 7 * Math.Pow(10, 22);
            double m3 = m2;
            double m4 = m2;
            double G = 6.67 * Math.Pow(10,(-11));
            double l= 400 * Math.Pow(10,6);


            Vettore F12 = new Vettore((G*m1*m2)/Math.Pow(l,2), 0);
            Vettore F14 = new Vettore(0, (G * m1 * m2) / Math.Pow(l, 2));
            Vettore F13 = new Vettore(((G * m1 * m2) / Math.Pow(l * Math.Sqrt(2), 2) / Math.Sqrt(2)), (G * m1 * m2) / Math.Pow(l * Math.Sqrt(2), 2) / Math.Sqrt(2));
            Vettore T=new Vettore(F12.X+F13.X+F14.X,F12.Y+F13.Y+F14.Y);

        }
    }
}
