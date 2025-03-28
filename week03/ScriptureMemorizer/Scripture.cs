public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        
        string[] words = text.Split(" ");
        foreach (string word in words)
        {
            Word newWord = new Word(word);
            _words.Add(newWord);
        }
    }

    public void HideRandomWords(int numberToHide)
    {

    }

    public string GetDisplayText()
    {
        string text = "";
        text += $"{_reference.GetDisplayText()} ";
        foreach (Word word in _words)
        {
            text += $"{word.GetDisplayText()} ";
        }
        return text;
    }

    public bool IsCompletelyHidden()
    {
        return true;
    }
}