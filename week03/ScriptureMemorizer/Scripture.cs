using System.Net.Quic;

public class Scripture{
    _reference = Reference; //hace conexion con reference
    private List<Word> _words = new List<Word>();
    //1word==_ and go like that
    //behaviors. The "display text" refers to the text with some words shown normally, and some replaced by underscores.
    public string Scripture()
    {
        _reference = ("Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.");

    }
    public string HideRandomWords()
    {
        Random random = new Random();
        int index = random.Next(_numberToHide.Count);
        return _numberToHide[void]; //return underscore
    }
    public void GetDisplayText()
    {
        Console.WriteLine{};
        return;
    }
      
    //IsCompletelyHidden() : bool

}
//for each word in this text, word will be called
//review step 5
//step 7 explains what a boolean is
// la escritura en si esta en scripture