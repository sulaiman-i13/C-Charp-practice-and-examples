using System.ComponentModel.DataAnnotations.Schema;

//[Table("tblUsers")]
public class User
{
    public int Id { get; set; }
    public string UserName { get; set; } = string.Empty;
    public override string ToString()
    {
        return $"{UserName}";
    }
}

