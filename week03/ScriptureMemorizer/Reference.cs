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

    public string GetScriptureText()
    {
        string fullReference;
        string scriptureText = "";
        string userReference = $"{_book} {_chapter}:{_verse}";
        int firstVerse = _verse;
        int lastVerse = _endVerse;
        string[] lines = System.IO.File.ReadAllLines("scriptures.txt");

        foreach (string line in lines)
        {
            string[] parts = line.Split("     ");
            fullReference = parts[0];
            if (userReference == fullReference)
            {
                if (firstVerse == lastVerse)
                {
                    scriptureText += $"{parts[1]} ";
                }
                else if (firstVerse < lastVerse)
                {
                    scriptureText += $"{parts[1]} ";
                    firstVerse += 1;
                    userReference = $"{_book} {_chapter}:{firstVerse}";
                }
            }
        }
        return scriptureText;
    }
}