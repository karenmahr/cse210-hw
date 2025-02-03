//ATTRIBUTE _book:string
//ATTRIBUTE _chapter:int
//ATTRIBUTE _verse:int
//ATTRIBUTE_endVerse_:int

//CONSTRUCTOR book:string, chapter:int, verse:int
//CONSTRUCTOR book:string, chapter:int, startverse:int, endVerse_:int

//METHOD: GetDisplayText():string

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
            return $"{_book} {_chapter} : {_verse}";
        }
        else
        {
            return $"{_book} {_chapter} : {_verse} - {_endVerse}";
        
        }
    }  
}

