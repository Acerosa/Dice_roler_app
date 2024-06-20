using System;

namespace DiceRollerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Dice Roller App!");

            bool keepPlaying = true;

            while (keepPlaying)
            {
                PlayGame();
                keepPlaying = AskToPlayAgain();
            }

            Console.WriteLine("Thank you for playing. Goodbye!");
        }

        static void PlayGame()
        {
            int playerPoints = 0;
            int opponentPoints = 0;
            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Press any key to roll the dice!");
                Console.ReadKey();

                int playerRandomNum = RollDice(random);
                Console.WriteLine("You rolled a " + playerRandomNum);

                int opponentRandomNum = RollDice(random);
                Console.WriteLine("Opponent rolled a " + opponentRandomNum);

                UpdatePoints(playerRandomNum, opponentRandomNum, ref playerPoints, ref opponentPoints);
                DisplayCurrentScore(playerPoints, opponentPoints);
            }

            DisplayFinalWinner(playerPoints, opponentPoints);
        }

        static int RollDice(Random random)
        {
            Console.WriteLine("....");
            System.Threading.Thread.Sleep(1000);
            return random.Next(1, 7);
        }

        static void UpdatePoints(int playerRandomNum, int opponentRandomNum, ref int playerPoints, ref int opponentPoints)
        {
            if (playerRandomNum > opponentRandomNum)
            {
                playerPoints++;
                Console.WriteLine("Player wins this round");
            }
            else if (opponentRandomNum > playerRandomNum)
            {
                opponentPoints++;
                Console.WriteLine("Opponent wins this round");
            }
            else
            {
                Console.WriteLine("Draw!");
            }
        }

        static void DisplayCurrentScore(int playerPoints, int opponentPoints)
        {
            Console.WriteLine($"The score is now - Player: {playerPoints} Opponent: {opponentPoints}");
            Console.WriteLine();
        }

        static void DisplayFinalWinner(int playerPoints, int opponentPoints)
        {
            if (playerPoints > opponentPoints)
            {
                Console.WriteLine("You are the winner!");
            }
            else if (playerPoints < opponentPoints)
            {
                Console.WriteLine("You are the loser!");
            }
            else
            {
                Console.WriteLine("It's a draw!");
            }
        }

        static bool AskToPlayAgain()
        {
            Console.WriteLine("Do you want to play again? (y/n)");
            string response = Console.ReadLine().ToLower();
            return response == "y";
        }
    }
}
