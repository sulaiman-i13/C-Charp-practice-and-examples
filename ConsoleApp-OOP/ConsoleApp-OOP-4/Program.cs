Console.WriteLine($"===================================delegates ex: ===================================");
var emp = new Employee { Id = 1, IsManager = true, Name = "Sulaiman", Salary = 2000M, ExperYears = 3 };
var total = TotalSalary.Count(emp, (emp, totalSalary) =>
{
	if (emp.ExperYears >= 10)
	{
		return totalSalary = totalSalary + totalSalary * 0.1m;
	}
	else if (emp.ExperYears >= 5) return totalSalary = totalSalary + totalSalary * 0.05m;
	else if (emp.ExperYears >= 3) return totalSalary = totalSalary + totalSalary * 0.03m;
	else return totalSalary;
}
);
Console.WriteLine($"total salary : {total}");

class Employee
{
	public int Id { get; set; }
	public string Name { get; set; }
	public decimal Salary { get; set; }
	public bool IsManager { get; set; }
	public int ExperYears { get; set; }
}
delegate decimal ExperienceYearsDel(Employee employee, decimal totalSalary);
class TotalSalary
{
	const decimal Discount = 0.02m;
	const decimal Managerbonus = 0.1m;
	public static decimal Count(Employee employee, ExperienceYearsDel experienceYearsDel)
	{
		if (employee == null) return 0;
		var totalSalery = employee.Salary;
		if (employee.IsManager)
		{
			totalSalery = totalSalery + totalSalery * Managerbonus;
		}
		totalSalery = experienceYearsDel(employee, totalSalery);
		totalSalery = totalSalery - totalSalery * Discount;

		return totalSalery;
	}
}