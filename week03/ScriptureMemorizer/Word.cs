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

    private void Show()
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
            int length = _text.Length;
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