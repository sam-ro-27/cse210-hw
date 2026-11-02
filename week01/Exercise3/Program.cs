using System;

class Program

{
    static void Main()
    {
        // Prompt the user for parts 1 or 2, where the user for the magic number...
        // console.write("What is the magic number? ");
        //int magicNumber = int.Parse(Console.ReadLine());

        //for part 3, where we use a random number generator to generate the number
        Console.WriteLine("Time to play a numerical guessing game!");
        Random random = new();
        int secretNumber = random.Next(1, 101);

        // Keep asking until the user guesses correctly.
        while (true)
        {
            Console.Write("Enter a number between 1 and 100: ");
            string input = Console.ReadLine() ?? "";

            if (!int.TryParse(input, out int guess) || guess < 1 || guess > 100)
            {
                Console.WriteLine("Please enter a whole number between 1 and 100.");
                continue;
            }

            if (guess == secretNumber)
            {
                Console.WriteLine("Congratulations! You guessed the number.");
                break;
            }

            Console.WriteLine(guess < secretNumber ? "Higher. Try again." : "Lower. Try again.");
        }
    }
}