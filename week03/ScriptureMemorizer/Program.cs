// For my creative additions I have added a way for the user to input a scripture reference of their choice
// to be used for the program. The scripture text is imported from the 'scriptures.txt' file, which is
// loaded through the 'Reference' class, using the 'GetScriptureText' method.

using System;

class Program
{
    static void Main(string[] args)
    {
        bool doLoop = true;
        Reference reference;
        Scripture scripture;

        Console.WriteLine("Welcome to the Scripture Memorizer!\n");
        Console.WriteLine("Please enter your book of scripture(Genesis, 1 Nephi, Doctrine and Covenants, etc..): ");
        string book = Console.ReadLine();

        Console.WriteLine("Please enter your chapter and verse reference(For example X:X or X:X-X for multiple verses): ");
        string userChapterVerse = Console.ReadLine();
        string[] userReference = userChapterVerse.Split(":");
        int chapter = Int32.Parse(userReference[0]);
        string verse = userReference[1];

        if (verse.Contains("-"))
        {
            string[] verses = verse.Split("-");

            reference = new Reference(book, chapter, Int32.Parse(verses[0]), Int32.Parse(verses[1]));
        }

        else
        {
            reference = new Reference(book, chapter, Int32.Parse(verse));
        }
        string text = reference.GetScriptureText();
        scripture = new Scripture(reference, text);

        while (doLoop)
        {
            Console.Clear();
            Console.WriteLine($"{scripture.GetDisplayText()}");
            Console.WriteLine("\nPress enter to continue or type 'quit' to finish: ");
            string userInput = Console.ReadLine();
            if (userInput == "quit" || scripture.IsCompletelyHidden())
            {
                doLoop = false;
            }
            else
            {
                scripture.HideRandomWords(3);
            }
        }
    }
}