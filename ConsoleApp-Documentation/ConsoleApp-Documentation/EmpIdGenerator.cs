/// <summary>
/// the main generator class
/// </summary>
/// <remarks>
/// this class generate the id for a new employee
/// </remarks>
class EmpIdGenerator
{
	/// <summary>
	/// process  <paramref name="employee"></paramref> and  <paramref name="hireDate" ></paramref> 
	/// </summary>
	/// <param name="employee"></param>
	/// <param name="hireDate"></param>
	public EmpIdGenerator(Employee employee, DateTime hireDate)
	{
		this.employee = employee;
		HireDate = hireDate;
	}

	public Employee employee { get; set; }
	public DateTime HireDate { get; set; }

	/// <summary>
	/// generate method
	///<list type="bullet">
	///<item>
	///<term>F</term>
	///<description>first letter of employee first name </description>
	/// </item>
	///<item>
	///<term>L</term>
	///<description>first letter of employee last name </description>
	/// </item>
	///<item>
	///<term>guid</term>
	///<description>first 8 letters of a random GUID string ex:59455207 </description>
	/// </item>
	/// <item>
	///<term>yyyyMMdd</term>
	///<description>date in format yyyyMMdd </description>
	/// </item>
	///</list>
	///</summary>
	/// <returns>string value "FL-guid-yyyyMMdd"</returns>
	public string Generate()
	{
		var firstSegment = employee.FirtName[0];
		var secondSegment = employee.LastName[0];
		var thirdSegment = Guid.NewGuid().ToString().Substring(0, 8);
		var fourthSegment = HireDate;
		return $"{firstSegment}{secondSegment}-{thirdSegment}-{fourthSegment:yyyyMMdd}";
	}
}
