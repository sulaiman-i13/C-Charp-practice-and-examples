










public class Employee
{
	public Employee(int id, string name, int reportTo)
	{
		Id = id;
		Name = name;
		ReportTo = reportTo;
	}

	public int	Id { get; set; }
    public string Name { get; set; }
    public int ReportTo { get; set; }
	public override string ToString()
	{
		return $"id:{Id},name: {Name}, report to: {ReportTo}";
	}
}
