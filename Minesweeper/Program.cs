using System;
using System.Text.RegularExpressions;

namespace Minesweeper
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int rowCount = 5;
            int colCount = 5;
            Cell[,] minefield = new Cell[rowCount, colCount];
            for (int i = 0; i < minefield.GetLength(0); i++)
            {
                for (int k = 0; k < minefield.GetLength(1); k++)
                {
                    minefield[i, k] = new Cell();
                }
            }
            minefield[3, 2].IsMine = true;
            while (true) {
                Console.Clear();
                PrintBoard(minefield);

                Console.WriteLine("Bitte Feld eingeben:  ");
                var field = Console.ReadLine();

                if (field == "q")
                {
                    break;
                }
                RevealedField(minefield, field);
                }
        }

        static void PrintBoard(Cell[,] board)
        {
            Console.Write("  ");
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
                    if (!board[i, k].IsRevealed)
                    {
                        Console.Write(" x");
                    } else if (board[i, k].IsMine)
                    {
                        Console.Write(" b");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();
            }
        }

        static void RevealedField(Cell[,] board, string field)
        {
            // Expect format: Letter followed by number, e.g. B1
            if (string.IsNullOrWhiteSpace(field) || field.Length < 2)
            {
                Console.WriteLine("Ungültiges Feldformat. Verwende Format wie B1 (Buchstabe + Zahl). Drücke eine Taste zum Fortfahren...");
                Console.ReadKey(true);
                return;
            }

            // Row: first character
            var rowChar = char.ToUpper(field[0]);
            if (rowChar < 'A' || rowChar > 'Z')
            {
                Console.WriteLine("Ungültiger Zeilenbuchstabe. Verwende A..Z. Drücke eine Taste zum Fortfahren...");
                Console.ReadKey(true);
                return;
            }

            var row = rowChar - 'A';

            // Column: extract leading digits from the remainder
            var colPart = field.Substring(1);
            var m = Regex.Match(colPart, "^\\d+");
            if (!m.Success)
            {
                Console.WriteLine("Ungültige Spaltenangabe. Verwende Format wie B1 (Buchstabe + Zahl). Drücke eine Taste zum Fortfahren...");
                Console.ReadKey(true);
                return;
            }

            if (!int.TryParse(m.Value, out var col))
            {
                Console.WriteLine("Fehler beim Verarbeiten der Spaltenzahl. Drücke eine Taste zum Fortfahren...");
                Console.ReadKey(true);
                return;
            }

            // Validate bounds
            if (row < 0 || row >= board.GetLength(0) || col < 0 || col >= board.GetLength(1))
            {
                Console.WriteLine($"Feld außerhalb des Bereichs. Gültige Zeilen: A-{(char)('A' + board.GetLength(0) - 1)}, Spalten: 0-{board.GetLength(1) - 1}. Drücke eine Taste zum Fortfahren...");
                Console.ReadKey(true);
                return;
            }

            board[row, col].IsRevealed = true;
        }
    }

    public class Cell
    {
        public bool IsRevealed { get; set; }
        public bool IsMine { get; set; }
        public bool IsFlagged { get; set; }
    }
}
