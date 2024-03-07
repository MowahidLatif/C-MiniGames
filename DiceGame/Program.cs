namespace DiceGame;

class Program
{
    static void Main(string[] args)
    {
        int playerWin = 0;
        int aiWin = 0;
        int totalRounds = 0;
        Console.WriteLine("Welcome to the Dice Game!");
        Console.WriteLine("The Goal is to roll a higher number than your opponent, good luck!");

        while (totalRounds < 10) {
            System.Console.WriteLine("Click any key to enter a number.");
            int playerGuess = GuessRandomNumber();
            Console.ReadKey();
            Console.WriteLine("Your Guess: " + playerGuess);
            int aiGuess = GuessRandomNumber();
                Console.WriteLine("AI Guess: " + aiGuess);

            if (playerGuess < aiGuess) {
                playerWin++;
            } else {
                aiWin++;
            }

            System.Console.WriteLine("Current Score: " + "You: " + playerWin + " AI: " + aiWin);
            totalRounds++;
        }

        System.Console.WriteLine("Game Over, here are the results: ");

        if (playerWin > aiWin) {
            System.Console.WriteLine("You Win!");
        } else if (playerWin < aiWin) {
            System.Console.WriteLine("AI Wins");
        } else {
            System.Console.WriteLine("DRAW, One must win, try again!");
        }

        Console.ReadKey();
    }

    static int GuessRandomNumber()
    {
        Random random = new Random();
        return random.Next(1, 7);
    }
}
