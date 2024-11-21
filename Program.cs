using System;

namespace guessNumber
{
    class Program
    {
        static void Main(string[] args)
        {

            bool isCorrectGuess = false;
            int maxGuesses = 3;
            int score = 0;

            Random random = new Random();
            

            System.Console.WriteLine("Welcome to the number guessing game.");
            System.Console.WriteLine("A number between 1 and 10 will be generated.");
            System.Console.WriteLine("If you guess the correct nuumber you win!");
            Console.WriteLine("If you guess correctly on the first try, you earn 3 points, on the second try 2 points, and on the third try 1 point.");


            int rannum = random.Next(1, 11);

            for (int attempt = 1; attempt <= maxGuesses && !isCorrectGuess; attempt++)
            {
                    System.Console.WriteLine("Please enter your guess : ");
                    int guess = Convert.ToInt32(Console.ReadLine());

                    if (guess > rannum)
                    {
                        System.Console.WriteLine("The number guess is too high.");
                    }
                    else if (guess < rannum)
                    {
                        System.Console.WriteLine("The number guess is too low.");
                    }
                    else
                    {
                        System.Console.WriteLine("You guessed Correctly!");
                        isCorrectGuess = true;

                        score=maxGuesses-attempt+1;
                        System.Console.WriteLine($"Your score is {score}.");
                    }
                     if (attempt < maxGuesses)
                    {
                    Console.WriteLine($"Attempts remaining: {maxGuesses - attempt}");
                    }
                }
            if (!isCorrectGuess)
            {
                Console.WriteLine("You've used all your guesses. Better luck next time!");
                Console.WriteLine($"The correct number was: {rannum}");
            }
            else{
                 System.Console.WriteLine("------------------------------------");
                 Console.WriteLine("Congratulations! You won the game.");
                 System.Console.WriteLine("------------------------------------");
            }
        }
    }
}