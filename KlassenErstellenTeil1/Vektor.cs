using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlassenErstellenTeil1
{
    internal class Vektor
    {
        // Teil 2
        private double x;
        private double y;
        private double z;

        public double X
        {
            get { return x; }
            set { x = value; }
        }

        public double Y
        {
            get { return y; }
            set { y = value; }
        }

        public double Z
        {
            get { return z; }
            set { z = value; }
        }

        public Vektor(double x, double y, double z)
        {
            // Initialisiert die XYZ-Werte.
            this.x = x;
            this.y = y;
            this.z = z;
        }

        // Parameterloser Konstruktor
        public Vektor()
        {
            x = 0;
            y = 0;
            z = 0;
        }

        public double BerechneSkalarprodukt(Vektor b)
        {
            return (b.X * this.x) + (b.Y * this.y) + (b.Z * this.z);
        }

        public static double BerechneSkalarprodukt(Vektor a, Vektor b)
        {
            return (b.X * a.x) + (b.Y * a.y) + (b.Z * a.z);
        }

        public override string ToString()
        {
            return $"{x} {y} {z}";
        }
    }
}
