using System.Net.Quic;

public class Scripture{
    _reference = Reference; 
    private List<Word> _words = new List<Word>();
    
    public string Scripture(string reference, string text)
    {
        _reference = ("John 3:16");
        _text =("For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");

    }
    public string HideRandomWords()
    {
        Random random = new Random();
        int index = random.Next(_words.Count);
        return _words[index]; 
    }
    public string GetDisplayText()
    {
       //esto es lo que tiene que ver el usuario cuando apreta enter
    }

    public bool IsCompletelyHidden ();
    {
        if _reference == false
        {
            end program;
}
    }

}

{
        Console.WriteLine("For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");
        Console.ReadLine();

        Console.Clear();

        Console.WriteLine("___ ___ __ _____ ___ _____ ____ __ ____ ___ ____ ________ ___ ____ _________ _________ __ ___ ______ ___ ______ ___ ____ ___________ ____ ");
    }
