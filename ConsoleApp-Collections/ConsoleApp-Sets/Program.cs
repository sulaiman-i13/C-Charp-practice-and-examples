//in these examples comparison depends on employee name:


///HashSet<T> features:
///internally :HashTable
///Hash based looukups
///stores keys only
///no duplication
///no indexing

HashSet<Employee> hashEmps =
[
	new Employee(1, "Sulaiman"),
	new Employee(2, "Tony"),
	new Employee(3, "Rami"),
	new Employee(4, "Fadi"),
	new Employee(5, "Sulaiman"),
];
hashEmps.Add(new Employee(6, "Ibrahem"));
hashEmps.UnionWith(new HashSet<Employee> { new Employee(8, "Ali"), new Employee(9, "Ahmed"), });
Console.WriteLine("+++++++++++HashSet+++++++++++++++");
foreach (var item in hashEmps)
{
	Console.WriteLine(item);
}

///HashSet<T> features:
///internally :Linear search
///Keeps elements in order
///no duplication
///no indexing
///slower than HashSet

SortedSet<Employee> sortedEmps =
[
	new Employee(1, "Sulaiman"),
	new Employee(2, "Tony"),
	new Employee(3, "Rami"),
	new Employee(4, "Fadi"),
	new Employee(5, "Sulaiman"),
];
sortedEmps.Add(new Employee(6, "Ibrahem"));

Console.WriteLine("+++++++++++SortedSet+++++++++++++++");
foreach (var item in sortedEmps)
{
	Console.WriteLine(item);
}
