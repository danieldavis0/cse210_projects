using System;

class Program
{
    static void Main(string[] args)
    {
        bool doLoop = true;

        while (doLoop)
        {
            Console.WriteLine("Welcome to the Scripture Memorizer!\n");
            Console.WriteLine("Please enter your book of scripture(Genesis, 1 Nephi, etc..): ");
            string book = Console.ReadLine();

            Console.WriteLine("Please enter your chapter and verse reference(For example X:X or X:X-X for multiple verses): ");
            string userReference = Console.ReadLine();
            Reference reference = new Reference("brain", 3, 4);
            reference.LoadScripture(book, userReference);
            
        }
    }
}