class Employee
{
	public int Id { get; set; }
	public string Name { get; set; }
	public override bool Equals(object? obj)
	{
		if (obj == null || !(obj is Employee)) return false;
		var emp = obj as Employee;
		return emp.Id == Id && emp.Name == Name;

	}

	public override int GetHashCode()
	{
		//var hash = 13;
		//hash = (hash * 17) + Id.GetHashCode();
		//hash = (hash * 17) + Name.GetHashCode();
		//return hash;
		//Or we can use this easy way:
		return HashCode.Combine(Id, Name);
	}
}