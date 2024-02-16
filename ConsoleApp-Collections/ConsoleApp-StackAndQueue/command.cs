public class Command
{
	public Command(string name)
	{
		Name = name;
	}
	public override string ToString()
	{
		return $"name:{Name}";
	}
	public string Name { get; set; }

}
