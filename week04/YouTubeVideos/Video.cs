// has the responsibility to track the:
// title, 
//author, 
//and length (in seconds) of the video. 
//comments

//Each video also has responsibility to:
//return the number of comments.

class Video
{
    public string _title;
    public string _author;
    public int _length;
    public List<Comment> _comments;
    public Video() { }
    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comment>();
    } 
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }
    public int GetCommentCount()
    {
        return _comments.Count;
    }

}



