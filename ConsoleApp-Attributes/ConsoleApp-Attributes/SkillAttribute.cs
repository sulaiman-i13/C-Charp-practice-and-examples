
[AttributeUsage(AttributeTargets.Property)]
public class SkillAttribute : Attribute
{
	public string Name { get; private set; }
	public int Min { get; private set; }
	public int Max { get; private set; }
	public SkillAttribute(string name, int min,int max)
	{
		Name = name;
		Min = min;
		Max = max;
	}
	public bool IsValid(object obj)
	{
		int value = (int)obj;
		return value >= Min && value <= Max;
	}


}