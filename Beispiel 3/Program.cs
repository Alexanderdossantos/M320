using Beispiel_3;

namespace Beispiel_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kunden kunden = new Kunden("Alexander");

            Buch buch1 = new Buch(kunden);
            Buch buch2 = new Buch(kunden);
            Buch buch3 = new Buch(kunden);
        }
    }
}
