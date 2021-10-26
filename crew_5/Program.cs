using System;

namespace crew_5
{
    class Program
    {
        static void Main(string[] args)
        {
            double onePiece;
            double allPieces;
            double count;

            while (true)
            {

                Console.Clear();
                Console.WriteLine("screw management aplikation");
                Console.WriteLine("----------------------------------");

                Console.WriteLine(" Set one piece weight (g): ");
                double.TryParse(Console.ReadLine(), out onePiece);
                if (onePiece <= 0)
                {
                    Console.WriteLine("only value about 0 are allowed");
                }
                else
                {

                    Console.WriteLine("Set all pieces weight (g): ");
                    allPieces = double.Parse(Console.ReadLine());
                    if (allPieces <= 0)
                    {
                        Console.WriteLine();
                        Console.WriteLine("only value about 0 are allowed");
                    }
                    else
                    {
                        count = allPieces / onePiece;
                        count = Math.Floor(count);

                        Console.WriteLine();
                        Console.WriteLine($"You have {count} pieces.");
                    }
                }
                 Console.ReadLine();
            }
        }
    }
}








