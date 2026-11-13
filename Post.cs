class Post
{
    public string Text;
    public int Likes;
    public List<string> Comments = new List<string>();

    public void SetPost(string text)
    {
        Text = text;
    }

    public void AddLike()
    {
        Likes++;
    }

    public void AddComment(string comment)
    {
        Comments.Add(comment);
    }

    public string GetInfo()
    {
        string info = $"Text = {Text}\n";
        info += $"Likes : {Likes}\n\n";
        info += "Comments :\n";

        foreach (string comment in Comments)
        {
            info += comment + "\n";
        }

        return info;
    }
}