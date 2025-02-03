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
        foreach (var word in text.Split(' '))
        {
            _words.Add(new Word(word));
        }     
    }
    private void HideRandomWords(int numberToHide)
    {
        Random randomGenerator = new Random();
        int hiddenCount = 0;        

        while (hiddenCount < numberToHide)
        {
            int randomIndex = randomGenerator.Next(_words.Count);
            if (!_words[randomIndex].IsHidden())
            {
                _words[randomIndex].Hide();
                hiddenCount++;
            }
        }
    }
    private string GetDisplayText()
    {
        List<string> displayWords = new List<string>();
        foreach (var word in _words)
        {
            displayWords.Add(word.GetDisplayText());
        }
        return $"{_reference.GetDisplayText()} {string.Join(" ", displayWords)}";
    }

    private bool IsCompletelyHidden()
    {
        foreach (var word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }

}


