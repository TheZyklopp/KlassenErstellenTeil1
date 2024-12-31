using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlassenErstellenTeil1
{
    internal class Linie
    {
        public Punkt StartPunkt { get; set; }
        public Punkt EndPunkt { get; set; }
        public Linie(Punkt startPunkt, Punkt endPunkt)
        {
            StartPunkt = startPunkt;
            EndPunkt = endPunkt;
        }
        // Parameterloser Konstruktor
        public Linie()
        {
            StartPunkt = new Punkt();
            EndPunkt = new Punkt();
        }
        public double Laenge()
        {
            return Math.Sqrt(Math.Pow(EndPunkt.X - StartPunkt.X, 2) + Math.Pow(EndPunkt.Y - StartPunkt.Y, 2) + Math.Pow(EndPunkt.Z - StartPunkt.Z, 2));
        
        }

        public override string ToString()
        {
            return $"{StartPunkt} und {EndPunkt}";
        }

    }
}
