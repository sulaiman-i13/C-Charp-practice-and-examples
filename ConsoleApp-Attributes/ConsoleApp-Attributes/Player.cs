public class Player
{
    public string Name  { get; set; }
    [Skill(nameof(BallControle),10,20)]
    public int BallControle  { get; set; }
	[Skill(nameof(Dribbling), 0, 100)]
	public int Dribbling { get; set; }
}