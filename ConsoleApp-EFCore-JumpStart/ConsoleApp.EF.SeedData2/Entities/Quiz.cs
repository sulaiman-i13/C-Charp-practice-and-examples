namespace ConsoleApp.EF.Migrations.Entities
{
    public abstract class Quiz
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public Course Course { get; set; } = null!;
        
    }
    public class MultipleChoiceQuiz : Quiz
    {
        public string OptionA { get; set; } = string.Empty;
        public string OptionB { get; set; } = string.Empty;
        public string OptionC { get; set; } = string.Empty;
        public string OptionD { get; set; } = string.Empty;
        public char CorrectAnswer { get; set; }
    }
    public class TrueFalseQuiz : Quiz
    {
        
        public bool CorrectAnswer { get; set; }
    }
}
