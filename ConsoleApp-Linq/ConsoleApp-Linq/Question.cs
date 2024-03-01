
public class Question
{
	public string Title { get; set; }
    public List<Choise> Choises { get; set; }
    public int CorrectAnswer { get; set; }
    public static readonly Question Default  = new Question()
    {
        Title=">>>>>>>>>>Title goes here<<<<<<<<<<",
        Choises=new List<Choise>()
        {
            new Choise{Order=1,Description="description goes here"},
            new Choise{Order=2,Description="description goes here"},
            new Choise{Order=3,Description="description goes here"},
            new Choise{Order=4,Description="description goes here"}
        },
        CorrectAnswer=0
    };
    public override string ToString() {
        string choises=string.Empty;
        foreach (var item in Choises)
        {
            choises += $"\n\t{item.Order}) {item.Description}";
        }
        return $"{Title} {choises}";
    }
}
