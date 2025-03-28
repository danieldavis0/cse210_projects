public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public void Show()
    {
        _isHidden = false;
    }

    public bool IsHidden()
    {
        if (_isHidden == true)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public string GetDisplayText()
    {
        string text = "";
        if (_isHidden)
        {
            string cleanText = _text.TrimEnd(new char[] {'.', '!', '?', ';', ':', ','});
            int length = cleanText.Length;
            for (int i = 0; i < length; i++)
            {
                text += "_";
            }
        }

        else
        {
            text = _text;
        }

        return text;
    }
}