using System;

class Program
{
    static void Main(string[] args)
    {   
        string userInput = "yes";
        while (userInput == "yes")
        {
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101);
            int numberOfAttempts = 0;
            int userGuess = 0;
            Console.WriteLine("Welcome to Guess My Number!");
            Console.WriteLine("What is your guess? ");
            while (userGuess != magicNumber)
            {
                userInput = Console.ReadLine();
                userGuess = int.Parse(userInput);
                numberOfAttempts += 1;
                if (userGuess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else if (userGuess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else
                {
                    Console.WriteLine($"You guessed it! It took you {numberOfAttempts} tries.");
                    Console.WriteLine("Would you like to play again? (yes/no) ");
                    while (userInput != "yes" && userInput != "no")
                    {
                        userInput = Console.ReadLine();
                        if (userInput != "yes" && userInput != "no")
                        {
                            Console.WriteLine("Please enter a valid response");
                        }
                    }
                    
                }
            }
            
        }
        
    }
}