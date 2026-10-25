namespace Beispiel_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Notebook notebook = new Notebook();

            Festplatte f1 = new Festplatte(notebook);
            Festplatte f2 = new Festplatte(notebook);
            Festplatte f3 = new Festplatte(notebook);
        }
    }
}
