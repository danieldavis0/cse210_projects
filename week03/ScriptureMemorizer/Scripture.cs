public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

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
        Random random = new Random();
        List<Word> words = _words;
        int lengthOfList = words.Count();
        int wordsRemaining = numberToHide;

        while (IsCompletelyHidden() == false && wordsRemaining > 0)
        {
            long randomNumberLong = random.NextInt64(lengthOfList);
            int randomNumberInt = Convert.ToInt32(randomNumberLong);
            if (words[randomNumberInt].IsHidden() == false)
            {
                words[randomNumberInt].Hide();
                wordsRemaining += -1;
            }
        }
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
        bool completelyHidden = true;
        foreach (Word word in _words)
        {
            if (word.IsHidden() == false)
            {
                completelyHidden = false;
            }
        }
        return completelyHidden;
    }
}