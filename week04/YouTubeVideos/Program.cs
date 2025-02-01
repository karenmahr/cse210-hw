using System;

class Program
{
    static void Main(string[] args)
    {
    Comment comments1 = new Comment();
    comments1._name="@silvanaurso4485";
    comments1._text ="Also the Ateneo Bookstores, cataloged as one of the most beautiful in the world, have to go";

    Comment comments2 = new Comment();
    comments2._name ="@betzabejimenez1827";
    comments2._text ="Excellent video, in February I am going to go to Buenos Aires and your video only increased my excitement, thank you very much for the information!!";

    Comment comments3 = new Comment();
    comments3._name ="@FacundoMercaú";
    comments3._text ="Someday I will know Buenos Aires❤";   

    Comment comments4 = new Comment();
    comments4._name ="The southern waterfront, ecological reserve and sculpture of Lola Mora (Las Nereidas). The Japanese garden. Barrancas de Belgrano (Chinatown). The Ateneo bookstore, the Ideal candy stores, the Violetas, Café Tortoni. The churches of the downtown area. The Buenos Aires neighborhoods, each one has something worth knowing.";
    comments4._text ="@mariaalejandragigante7494";

    Comment comments5 = new Comment();
    comments5._name ="@MarianoJuarez22";
    comments5._text ="I knew how to season them but the breadcrumbs didn't stick to the breadcrumbs and with your method of passing it first through the breadcrumbs, then through the egg and again through the bread, it worked for me.";

    Comment comments6 = new Comment();
    comments6._name ="@lizaburgos";
    comments6._text ="I was looking for Milanese recipes and found the most authentic one.  Thank you. Will make them for my husband who's from Argentina.";

    Comment comments7 = new Comment();
    comments7._name ="@lurdesfalco3042";
    comments7._text ="Super delicious. I prepared them myself, a delight, everyone at home liked it, thank you very much for sharing the recipe. I turned out super good";

    Comment comments8 = new Comment();
    comments8._name ="@pablotripolon687";
    comments8._text ="thanks for the recipe!";

    Comment comments9 = new Comment();
    comments2._name ="@nicorelli";
    comments2._text ="There is no other musical piece in the world that better conveys the concept of peace, freedom, and solidarity. In its simplicity, it's a masterpiece that is easily understood by everyone. Honor and respect to John";

    Comment comments10 = new Comment();
    comments10._name ="@Robin_Hood054";
    comments2._text ="This is not song. This is timeless masterpiece .";

    Comment comments11 = new Comment();
    comments11._name ="@The-Omega-Artist";
    comments11._text ="John Lennon did manage to make the world a more hopeful and peaceful pleace for everyone. He moved many people emotionally and was a honest and caring person. May he Rest In Peace. We are all Dreamers.";      

    Comment comments12 = new Comment();
    comments12._name ="@ALLCAPS2317";
    comments12._text ="I literally can’t listen to this song without crying. Still love it, it just makes me so sad.";                                

    Video video1 = new Video();
    video1._title = "TOP 10 Things to see in Buenos Aires";
    video1._author = "Pasaporte Viajero";
    video1._length = 780;
    video1._comments = [comments1, comments2, comments3, comments4];
    video1._comments = new List<Comment> { comments1, comments2, comments3, comments4 };

    Video video2 = new Video();
    video2._title = "How to prepare Argentine style Milanese";
    video2._author = "Kevin Cocinero";
    video2._length = 600;
    video2._comments = new List<Comment> {comments5, comments6, comments7, comments8};

    Video video3 = new Video();
    video3._title = "Imagine - John Lennon";
    video3._author = "johnlennon";
    video3._length = 188;
    video3._comments = new List<Comment> { comments9, comments10, comments11, comments12 };

    List<Video> videos = new List<Video> { video1, video2, video3 };

    foreach (var video in videos)
    {
        Console.WriteLine($"Title: {video._title}\nAuthor: {video._author}\nLength: {video._length} seconds");
        Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");
        Console.WriteLine("Comments:");
        foreach (var comment in video._comments)
        {
            Console.WriteLine($"- {comment._name}: {comment._text}");
        }
        Console.WriteLine(" ");
    }    
    }
}