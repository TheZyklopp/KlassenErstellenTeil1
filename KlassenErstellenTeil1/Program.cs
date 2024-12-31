using System;
namespace KlassenErstellenTeil1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Teil1
            //X, Y, Z
            Punkt endPunkt = new Punkt(3,2,4);
            Punkt startPunkt = new Punkt(2, 1, 2);

            //schreibt die werte nochmal aus. Benutzt die ToString methode.
            Console.WriteLine($"startPunkt{startPunkt.ToString()}");
            Console.WriteLine($"endPunkt{endPunkt.ToString()}");

            //Methode1 startPunkt = this
            double abstand = startPunkt.AbstandZu(endPunkt);
            Console.WriteLine($"{abstand}");
            //Methode2
            double zwichen = Punkt.AbstandZwischen(startPunkt, endPunkt);
            Console.WriteLine(zwichen);

            //Teil2
            Vektor a = new Vektor(3, 2, 4);
            Vektor b = new Vektor(6, 4, 6);

            Console.WriteLine($"Vektor a {a.ToString()}");
            Console.WriteLine($"vektor b {b.ToString()}");

            double skalar = a.BerechneSkalarprodukt(b);
            Console.WriteLine(skalar);

            double skalar2 = Vektor.BerechneSkalarprodukt(a, b);
            Console.WriteLine(skalar2);

            //teil3
            Punkt StartPunkt = new Punkt(1, 5, 6);
            Punkt EndPunkt = new Punkt(4, 6, 8);


            // Erstellen einer Linie und Berechnung der Länge
            Linie linie = new Linie(StartPunkt, EndPunkt);
            double linienLaenge = linie.Laenge();
            Console.WriteLine($"Länge der Linie: {linienLaenge}");
        }
    }
}
