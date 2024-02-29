using System.Diagnostics;

namespace Number_Guessing_game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool playAgain = true;

            Console.WriteLine("Hello buddy welcome to the number guessing game");
            Console.WriteLine();

            Console.WriteLine("Can u let us know your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name + " sit back and enjoy the game");
            Console.WriteLine();

            while (playAgain)
            {
                Console.WriteLine("Guess a Number from 1 to 20\n if you guess correctly you win");

                Random random = new Random();
                int randomGuess = random.Next(1, 21);
                string response;

                bool guessedCorrectly = false;

                while (!guessedCorrectly)
                {
                    int plGuess = Convert.ToInt32(Console.ReadLine());

                    if (plGuess > randomGuess)
                    {
                        Console.WriteLine("The guessed number is too high!");
                    }
                    else if (plGuess < randomGuess)
                    {
                        Console.WriteLine("The guessed number is too low!");
                    }
                    else
                    {
                        Console.WriteLine("Congratulations " + name + " You guessed Correctly");
                        Console.WriteLine("*** YOU WIN ****");
                        guessedCorrectly = true;
                    }
                }

                Console.WriteLine("Would you like to play again (Y/N)");
                response = Console.ReadLine().ToUpper();

                if (response != "Y")
                {
                    playAgain = false;
                    Console.WriteLine("Thank you " + name + " For playing this number guessing game");
                }
            }
        }
    }
}
