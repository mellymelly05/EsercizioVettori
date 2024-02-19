using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace EsercizioVettori
{
    internal class Vettore
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Vettore(double X, double Y)
        {
            X = X;
            Y = Y;
        }


        //somma vettoriale
        public static Vettore operator +(Vettore a, Vettore b)
        {
            return new Vettore(a.X + b.X, a.Y + b.Y);
        }

        //diferenza tra due vettori
        public static Vettore operator -(Vettore a, Vettore b)
        {
            return new Vettore(a.X - b.X, a.Y - b.Y);
        }

        //prodotto tra vettore e ubo scalare
        public static Vettore operator *(Vettore a, double b)
        {
            return new Vettore(a.X * b, a.Y * b);
        }

        //Divisione tra un vettore e uno scalare 
        public static Vettore operator /(Vettore a, double b)
        {
            return new Vettore(a.X / b, a.Y / b);
        }

        //prodotto scalare 
        public double ProdottoScalere(Vettore a,Vettore b)
        {
           return ((a.X * b.X) + (a.Y * b.Y));
        }

        public static Vettore operator *(double b,Vettore a)
        {
            return new Vettore(a.X * b, a.Y * b);
        }

        public static Vettore Parse(string s)
        {
            string[] a= s.Split(',');
            double X= double.Parse(a[0]);
            double Y= double.Parse(a[1]);
            return new Vettore(X, Y);
        }


    }
}
