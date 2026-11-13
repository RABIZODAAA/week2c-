

// class Student
// {
//     public string FirstName;
//     public string LastName;
//     public int Age;

//     public void GetInfo()
//     {
//         Console.WriteLine($"FullName: {FirstName} {LastName}");
//         Console.WriteLine($"Age: {Age}");
//     }

//     public int GetAge()
//     {
//         return Age;
//     }
// }

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