
using System.ComponentModel.DataAnnotations.Schema;

//[Table("tblTweets")]

public class Tweet
{
    public int TweetId { get; set; }
    public int UserId { get; set; }
    public string TweetText { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; }
    public override string ToString()
    {
        return $"{TweetText} {CreatedAt:yyyy MM dddd}";
    }
}

