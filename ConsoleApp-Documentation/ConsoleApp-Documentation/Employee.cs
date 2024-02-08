
public class Employee
{
    private readonly string _firstName;
    private readonly string _lastName;
	public string FirtName => _firstName;

	public string LastName => _lastName;

    public Employee(string firstName, string lastName)
	{
		_firstName = firstName;
		_lastName = lastName;
	}
}