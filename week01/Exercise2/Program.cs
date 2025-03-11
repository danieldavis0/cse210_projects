using System;

class Program
{
    static void Main(string[] args)
    {
        string passStatus = "";
        string sign = "";
        string letterGrade = "";

        Console.Write("What is your grade percentage? ");
        string userInput = Console.ReadLine();

        float grade = float.Parse(userInput);

        // Getting the modulus operator of the given grade to check if "+" or "-" needs to be added to the grade
        float lastDigit = grade % 10;

        if (lastDigit >= 7)
        {
            sign = "+";
        }

        else if (lastDigit < 3)
        {
            sign = "-";
        }

        else
        {
            sign = "";
        }

        // Checking if the grade is enough to pass or not
        if (grade >= 70) {
            passStatus = "Congratulations! You passed the class!";
        }

        else 
        {
            passStatus = "Stay focused and you'll get it next time!";
        }

        // Assigning the appropriate letter grade from the grade percentage
        if (grade >= 90)
        {
            letterGrade = "A";

            if (grade >= 93) 
            {
                sign = "";
            }
        }

        else if (grade >= 80)
        {
            letterGrade = "B";
        }

        else if (grade >= 70)
        {
            letterGrade = "C";
        }

        else if (grade >= 60)
        {
            letterGrade = "D";
        }

        else
        {
            letterGrade = "F";
            sign = "";
        }

        Console.WriteLine($"Your final grade is: {letterGrade}{sign}");
        Console.WriteLine(passStatus);
    }
}