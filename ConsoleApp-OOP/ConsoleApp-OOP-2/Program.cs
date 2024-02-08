
class someClass
{
	//property types
	public int Prop1 { get; set; }
	public int Prop2 { get; private set; }
	public int Prop3 { get; }
	public bool Prop4 => Prop1 % 2 == 0;
	public int Prop5
	{
		get
		{
			return 0;
		}
	}
	public int Prop6 { get; } = 10;
	public int Prop7 { get; set; } = 10;
	public int Prop8 { get; init; }
	public int Prop9
	{
		get
		{
			return 5;
		}
		set
		{
			Prop1 = value;
		}
	}

}