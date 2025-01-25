using System.Net.Quic;

public class Scripture{
 
    private Reference _reference;
    private List<Word> _words = new List<Word>();
    

    public Scripture(Reference _reference, string _text)
    {
        _reference = reference;
        _words = text.Split("").Select(Word=>new Word(word)).ToList();
    }
    Reference reference = new Reference("John", 3, 16); 
    Scripture scripture = new Scripture(text, "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");
    public string HideRandomWords(int numberToHide)
    {
        Random randomGenerator = new Random();
        string result = "";

        for (int i=0; i< numberToHide; i++)
        {
            int randomIndex=randomGenerator.Next(_words.Count);
        }
        return result;
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
