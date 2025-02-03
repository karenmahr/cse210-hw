using System.Net.Quic;
//ATTRIBUTE _reference:Reference
//ATTRIBUTE _words:List<Word>

//CONSTRUCTOR (Reference:Reference, text:string)
 
//METHOD HideRandomWords (numberToHide:int):void
//METHOD GetDisplayText():string
//METHOD IsCompletelyHidden():bool
public class Scripture
{
 
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();        
    }
    private void HideRandomWords(int numberToHide)
    {
        Random randomGenerator = new Random();
        for (int i = 0; i < numberToHide; i++)
        {
            int randomIndex = randomGenerator.Next(_words.Count);
            if (_words[randomIndex].IsHidden) // Hide only visible words
            {
                _words[randomIndex].Hide();
            }
        }
    }
    private string GetDisplayText()
    {
        return $"{_reference} {_words}";
       //esto es lo que tiene que ver el usuario cuando apreta enter
    }

    private bool IsCompletelyHidden()
    {
        foreach (var word in _words)
        {
            if (wordtext == true)
            {
                Environment.Exit(0); 
            }
        }
        return IsCompletelyHidden();
    }

}


