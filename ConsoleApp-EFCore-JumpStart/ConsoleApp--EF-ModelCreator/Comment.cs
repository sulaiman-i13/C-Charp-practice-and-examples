using System.ComponentModel.DataAnnotations.Schema;

//[Table("tblComments")]
public class Comment
{
    public int CommentId { get; set; }
    public int UserId { get; set; }
    public int TweetId { get; set; }
    public string CommentText { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; }
    public override string ToString()
    {
        return $"\t {CommentText} {CreatedAt:yyyy MM dddd}";
    }
}

