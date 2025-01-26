using System.Net.Quic;

public class Scripture
{
 
    private Reference _reference;
    private List<Word> _words;
    

    public Scripture(string reference, string text)
    {
        _reference = reference;
        _words = text.Split("").Select(Word=>new Word(word)).ToList();
    }
    public string HideRandomWords(int numberToHide)
    {
        Random randomGenerator = new Random();
        for (int i = 0; i < numberToHide; i++)
        {
            int randomIndex = randomGenerator.Next(_words.Count);
            if (!_words[randomIndex].IsHidden) // Hide only visible words
            {
                _words[randomIndex].Hide();
            }
        }

        return GetDisplayText();
    }
    public string GetDisplayText()
    {
        return $"{_reference} {_words}";
       //esto es lo que tiene que ver el usuario cuando apreta enter
    }

    public bool IsCompletelyHidden()
    {
        foreach (var word in _words)
        {
            if (wordtext == true)
            {
                Environment.Exit(0);
            }
        }
    }

}


