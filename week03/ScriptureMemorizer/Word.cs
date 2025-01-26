public class Word{
    private string _text;
    private bool _isHidden;

    public Word (string text, string IsHidden)
    {
        _isHidden = false;
        _text = text;
    }
 
    private void Hide()
    {
        _isHidden = true;
    }
    private void Show()
    {
        _isHidden = false;
    }
    private bool IsHidden()
    {
        return _isHidden;
    }
    private string GetDisplayText()
    { 
        if (_isHidden == false)
        {
            return _text;
        }
        else
        {
            new string($"{"_"} {_text.Length}");
        }
    }

}