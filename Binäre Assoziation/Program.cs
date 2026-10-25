namespace Binäre_Assoziation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vater fritz = new Vater();
            Kind hasli = new Kind();

            fritz.setKind(hasli);
            hasli.setVater(fritz);
        }
    }
}
