using System.Security.Cryptography.X509Certificates;

public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = verse;
    }

    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse;
    }

    public string GetDisplayText()
    {
        if (_verse == _endVerse)
        {
            return $"{_book} {_chapter}:{_verse}";
        }
        else
        {
            return $"{_book} {_chapter}:{_verse}-{_endVerse}";
        }
        
    }

    public void LoadScripture(string userBook, string userReference)
    {
        
        string[] reference = userReference.Split(":");
        string chapter = reference[0];
        string userVerse = reference[1];
        string fullReference;
        

        if (userVerse.Contains("-"))
        {
            string[] verses = userVerse.Split("-");
            int verse = Int32.Parse(verses[0]);
            int endVerse = Int32.Parse(verses[1]);
            _verse = verse;
            _endVerse = endVerse;
            userReference = $"{userBook} {chapter}:{verse}";
            int verseAmount = endVerse - verse;
        }

        else
        {
            int verse = Int32.Parse(userVerse);
            _verse = verse;
            userReference = $"{userBook} {chapter}:{verse}";
        }
        
        string[] lines = System.IO.File.ReadAllLines("scriptures.txt");

        

        foreach (string line in lines)
        {
            
            
            
            string[] parts = line.Split("     ");

            fullReference = parts[0];

            if (userReference == fullReference)
            {
                string scriptureText = parts[1];
                Console.WriteLine(scriptureText);
            }
            
        }
    }
}