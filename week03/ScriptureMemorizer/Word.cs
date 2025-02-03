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
        _isHidden = false;        
    }

    public void Hide()
    {
        _isHidden=true;
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

    public string GetDisplayText()
    { 
        if (_isHidden)
        {
            return new string($"{"_"} {_text.Length}");
        }
        else
        {
            return _text;
        }
    }
}   