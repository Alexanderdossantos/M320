using System;
using System.Security.Cryptography.X509Certificates;

namespace MyMath
{
    internal class Program
    {
        static void Main(string[] args) {
            int a = ReadInt();
            int b = ReadInt();

            var res = MyMath.Calc_ggT(a, b);
            Console.WriteLine($"$Resultat: {res}");
        }

        public static int ReadInt() {
            Console.Write("Bitte geben Sie eine ganze Zahl ein: ");
            string s = Console.ReadLine();
            int zahl = int.Parse(s);

            return zahl;

        }

    }

    public class MyMath { 
        public static int Calc_ggT(int a, int b) {
            int z;
            while (b != 0) {
                z = a % b;
                a = b;
                b = z;
            }
            return a;
        }
    }

}
