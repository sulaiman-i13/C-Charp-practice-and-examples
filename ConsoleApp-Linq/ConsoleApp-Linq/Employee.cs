
public class Employee:IEquatable<Employee>
{
	public int Id { get; set; }
	public string Name { get; set; }
	public int? DepartmentId { get; set; }

	public bool Equals(Employee? other)
	{
		if (other is null || typeof(Employee) != other.GetType()) return false;
		return Name.Equals(other.Name);
	}
	public override int GetHashCode()
	{
		return HashCode.Combine(Name);
	}

	public override string ToString()
	{
		return $"[{Id}] - {Name}";
	}

}