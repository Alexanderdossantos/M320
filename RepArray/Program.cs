namespace RepArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Frage an dern User: wie gross soll der Int-Array sein?
            Console.WriteLine("Wie groß soll der Int-Array sein?");
            string strSize = Console.ReadLine();

            int size = int.Parse(strSize);
            int[] a = new int[5];
            // int[] a = new int[] {200, 450, 700, 175, 250};
            int sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                sum = sum + a[i];
            }
            Console.WriteLine(sum);
        }
    }
}
