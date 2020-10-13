using System;

namespace Heads_tails
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Calls for Random function and creates new instance
             * which generates either 0 or 1. 
            */
            Random flip = new Random();
            int computerGuess = flip.Next(0, 2);

            // 0 is heads, 1 is tails

            Console.WriteLine(computerGuess);
            Console.WriteLine(@"Welcome to my ""Flip a coin"" game.");
            Console.WriteLine("In order to win you must guess which side the coin lands on. ");
            System.Threading.Thread.Sleep(3500);
            Console.Clear();

            Console.Write(@"Please pick your guess(H or T): ");

            string userGuess = Console.ReadLine();

            if (computerGuess == 0 && userGuess == "H")
            {
                Console.WriteLine($"It's {computerGuess} aka HEADS. You won !");
            }

            else if (computerGuess == 1 && userGuess == "T")
            {
                Console.WriteLine($"It's {computerGuess} aka TAILS. You won !");
            }

            else
            {
                if (computerGuess == 0 && userGuess == "T")
                {
                    Console.WriteLine($"It's {computerGuess} aka HEADS. You lost !");
                }

                else if (computerGuess == 1 && userGuess == "H")
                {
                    Console.WriteLine($"It's {computerGuess} aka TAILS. You lost !");
                }
            }

        }
    }
}
