using System;

namespace Minesweeper
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int rowCount = 5;
            int colCount = 5;
            bool[,] minefield = new bool[rowCount, colCount];

            while (true) {
                Console.Clear();
                PrintBoard(minefield);

                Console.WriteLine("Bitte Feld eingeben:  ");
                var field = Console.ReadLine();

                if (field == "q")
                {
                    break;
                }
                UncoveredField(minefield, field);
                }
        }

        static void PrintBoard(bool[,] board)
        {
            Console.Write(" ");
            for (int i = 0; i < board.GetLength(1); i++)
            {
                Console.Write($"{i + 1}");
            }
            Console.WriteLine();


            for (int i = 0; i < board.GetLength(0); i++)
            {
                Console.Write($"{(char)(65 + i)}");
                for (int k = 0; k < board.GetLength(1); k++)
                {
                    if (!board[i, k])
                    {
                        Console.Write("x");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }

        static void UncoveredField(bool[,] board, string field)
        {
            // C2

            var rowChar = field.Substring(0, 1);
            var row = (int)char.Parse(rowChar);
            row -= 65;

            var colChar = field.Substring(1);
            var col = int.Parse(colChar);


            board[row, col] = true;
        }
    }
}
