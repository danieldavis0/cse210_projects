using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int inputNumber = 1;
        int sum = 0;
        int largestNumber = -999999999;
        int smallestPositiveNumber = 999999999;
        bool hasPositive = false;
        List<int> numbers = new List<int>();
        while (inputNumber != 0)
        {
            Console.Write("Please enter a number: ");
            string userInput = Console.ReadLine();
            inputNumber = int.Parse(userInput);
            if (inputNumber != 0)
            {
                numbers.Add(inputNumber);
            }
        }

        foreach (int number in numbers)
        {
            sum += number;
            if (number > largestNumber)
            {
                largestNumber = number;
            }
            if (number > 0)
            {
                if (number < smallestPositiveNumber)
                {
                    smallestPositiveNumber = number;
                }

                hasPositive = true;
            }
        }

        
        float averageNumber = sum / numbers.Count;

        numbers.Sort();

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {averageNumber}");

        if (hasPositive)
        {
            Console.WriteLine($"The smallest positive number is: {smallestPositiveNumber}");
        }
        else
        {
            Console.WriteLine("The smallest positive number is: N/A");
        }

        Console.WriteLine("The sorted list is:");

        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}