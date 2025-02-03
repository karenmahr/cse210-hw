//ATTRIBUTE: _text string
//ATTRIBUTE: _isHidden bool

//CONSTRUCTOR: text: string

//METHOD Hide():void
//METHOD Show():void
//METHOD IsHidden():bool
//GetDisplayText():string

public class Word{
    private string _text;
    private bool _isHidden;

    public Word (string text)
    {
        _text = text;
    }

    public bool Hide()
    {
        return _isHidden;
    }    
    public void SetHide(bool value)
    {
        _isHidden = value;
    }
    private void Show()
    {
        _isHidden = false;
    }
    public void GetShow()
    {
        Show();
    }

    public bool IsHidden()
    {
        return _isHidden;
    }    

    public void SetIsHidden(bool value)
    {
        _isHidden = value;
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
        return GetDisplayText();
    }

}