//practice on equality

//practis on enumeration



//practice on comparing
class Temp : IComparable
{
	public int Value { get; set; }

	public int CompareTo(object? obj)
	{
		if (obj is null)
		{
			return 1;
		}
		var temp = obj as Temp;
		return this.Value.CompareTo(temp!.Value);
	}
}