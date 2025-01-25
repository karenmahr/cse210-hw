public class Word{
    private string _text;
    private bool _isHidden;

    private void Hide()
    {
        Console.WriteLine("For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");
        Console.ReadLine();

        Console.Clear();

        Console.WriteLine("___ ___ __ _____ ___ _____ ____ __ ____ ___ ____ ________ ___ ____ _________ _________ __ ___ ______ ___ ______ ___ ____ ___________ ____ ");
    }
    private void Show()
    {
        
    }
    private bool IsHidden()
    {

    }
    private string GetDisplayText()
    {
        return _text;
    }

    
    //behavior
    //Hide() : void
    //Show() : void
    //IsHidden() : bool
    //GetDisplayText() : string

}//only having access to the list