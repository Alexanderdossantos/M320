namespace Wassserfass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Wasserfass fass = new Wasserfass(100);

            ReturnCode rc = fass.Befuellen(50);

            if (rc == ReturnCode.Ok)
            {
                Console.WriteLine("Befüllen erfolgreich");
            }
            else
            {
                Console.WriteLine("Fehler beim Befüllen");
            }

            rc = fass.Befuellen(60);

            if (rc == ReturnCode.Ueberfuellt)
            {
                Console.WriteLine("Fass würde überfüllt werden!");
            }
        }
    }
}