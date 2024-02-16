// See https://aka.ms/new-console-template for more information
class Employee:IComparable
{
	public Employee(int id, string name)
	{
		Id = id;
		Name = name;
	}
	public override bool Equals(object? obj)
	{
		if (obj == null) return false;
		var emp = obj as Employee;
		return emp.Name.Equals(Name);
	}
	public override int GetHashCode()
	{
		return HashCode.Combine(Name);
	}
	public override string ToString()
	{
		return $"{Id} - {Name}";
	}

	public int CompareTo(object? obj)
	{
		if (obj is null) return 1;
		var emp = obj as Employee;
		return Name.CompareTo(emp.Name);
	}

	public int Id { get; set; }
	public string Name { get; set; }
}