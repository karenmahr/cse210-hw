using System;

class Program
{
    static void Main(string[] args)
    {
    Comment comments1 = new Comment();
    comments1._name="lalala";
    comments1._text ="blablabla";

    Comment comments2 = new Comment();
    comments2._name ="lalala";
    comments2._text ="blablabla";

    Comment comments3 = new Comment();
    comments3._name ="lalala";
    comments3._text ="blablabla";   

    Comment comments4 = new Comment();
    comments4._name ="lalala";
    comments4._text ="blablabla";

    Comment comments5 = new Comment();
    comments5._name ="lalala";
    comments5._text ="blablabla";

    Comment comments6 = new Comment();
    comments6._name ="lalala";
    comments6._text ="blablabla";

    Comment comments7 = new Comment();
    comments7._name ="lalala";
    comments7._text ="blablabla";

    Comment comments8 = new Comment();
    comments8._name ="lalala";
    comments8._text ="blablabla";

    Comment comments9 = new Comment();
    comments2._name ="lalala";
    comments2._text ="blablabla";

    Comment comments10 = new Comment();
    comments10._name ="lalala";
    comments2._text ="blablabla";

    Comment comments11 = new Comment();
    comments11._name ="lalala";
    comments11._text ="blablabla";      

    Comment comments12 = new Comment();
    comments12._name ="lalala";
    comments12._text ="blablabla";                                

    Video video1 = new Video();
    video1._title = "aa";
    video1._author = "bb";
    video1._length = 1;
    video1._comments = [comments1, comments2, comments3, comments4];

    Video video2 = new Video();
    video2._title = "aa";
    video2._author = "bb";
    video2._length = 1;
    video2._comments = [comments5, comments6, comments7, comments8];

    Video video3 = new Video();
    video3._title = "aa";
    video3._author = "bb";
    video3._length = 1;
    video3._comments = [comments9, comments10, comments11, comments12];

   


    }
}