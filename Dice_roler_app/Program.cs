using System;

namespace Dice_roller_app
{
    // Define the main program class
    class Program
    {
        // Define the Main method, the entry point of the program
        static void Main(string[] args)
        {
            // Declare variables to store the random numbers for player and opponent
            int playerRandomNum;
            int opponentRandomNum;

            // Initialize player and opponent points to zero
            int playerPoints = 0;
            int opponentPoints = 0;

            // Create a Random object to generate random numbers
            Random random = new Random();

            // Loop to simulate 10 rounds of dice rolls
            for (int i = 0; i < 10; i++)
            {
                // Prompt the user to press any key to roll the dice
                Console.WriteLine("Press any key to roll the dice!");
                Console.ReadKey();

                // Generate a random number between 1 and 6 for the player
                playerRandomNum = random.Next(1, 7);

                // Simulate a delay to create suspense
                Console.WriteLine("....");
                System.Threading.Thread.Sleep(1000);

                // Display the player's roll result
                Console.WriteLine("You rolled a " + playerRandomNum);

                // Generate a random number between 1 and 6 for the opponent
                opponentRandomNum = random.Next(1, 7);

                // Display the opponent's roll result
                Console.WriteLine("Opponent rolled a " + opponentRandomNum);

                // Determine the round winner and update points accordingly
                if (playerRandomNum > opponentRandomNum)
                {
                    playerPoints++; // Increment player points if player wins
                    Console.WriteLine("Player wins this round");
                }
                else if (opponentRandomNum > playerRandomNum)
                {
                    opponentPoints++; // Increment opponent points if opponent wins
                    Console.WriteLine("Opponent wins this round");
                }
                else
                {
                    // Declare a draw if both rolls are equal
                    Console.WriteLine("Draw!");
                }

                // Display the current score
                Console.WriteLine("The score is now - Player: " + playerPoints + " The score is now - Opponent: " + opponentPoints);
                Console.WriteLine();
            }

            // Determine and display the final winner after 10 rounds
            if (playerPoints > opponentPoints)
            {
                Console.WriteLine("You are the winner");
            }
            else if (playerPoints < opponentPoints)
            {
                Console.WriteLine("You are the loser!");
            }
            else
            {
                Console.WriteLine("It's a draw!");
            }

            // Wait for a final key press before exiting
            Console.ReadKey();
        }
    }
}

