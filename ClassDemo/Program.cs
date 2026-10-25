using System;

namespace ClassDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rechteck r1 = new Rechteck();
            r1.Hoehe = 1;
            r1.Breite = 2;
            r1.Position = new Punkt() { X = 3, Y = 3 };
            r1.Linienfarbe = "grün";

            r1.Zeichne();
            r1.Verschiebe(2, 3);
            r1.Skalieren(0.5);
            r1.Zeichne();
        }
    }

    public class Rechteck {

        // public int Id; // Klassenvariable oder Attribut
        public readonly int Id; // ReadOnly-Klassenvariable oder Attribut
        public double Hoehe { get; set; } // Property
        // public double Breite { get; } // ReadOnly-Property
        public double Breite { get; set; }

        public Punkt Position { get; set; }

        public string Linienfarbe { get; set; }


        public void Verschiebe(double dx, double dy)
        {
            double newX = Position.X + dx;
            double newY = Position.Y + dy;
            Position = new Punkt() { X = newX, Y = newY };
        }
    public void Skalieren(double faktor)
        {
            Breite = Breite * faktor;
            Hoehe = Hoehe * faktor;
        }

        public void Zeichne()
        {
            Console.WriteLine($"Rechteck: Position=({Position.X}, {Position.Y}), Breite={Breite}, Höhe={Hoehe}, Linienfarbe={Linienfarbe}");
        }
    }

    public class Punkt
    {
        public double X { get; set; }
        public double Y { get; set; }
    }
}
