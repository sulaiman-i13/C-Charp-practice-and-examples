using System.Reflection;

Type type = DateTime.Now.GetType();

Console.WriteLine("===================some type info======================");
Console.WriteLine($"Name: {type.Name}");
Console.WriteLine($"Full Name: {type.FullName}");
Console.WriteLine($"NameSpace: {type.Namespace}");
Console.WriteLine($"BaseType: {type.BaseType}");
Console.WriteLine($"IsAbstract: {type.IsAbstract}");
Console.WriteLine($"IsPublic: {type.IsPublic}");
Console.WriteLine($"Assembly: {type.Assembly}");

Console.WriteLine("=====================nested types====================");

Type type2 = typeof(Employee);
var nestedTypes = type2.GetNestedTypes();
foreach(var item in nestedTypes) Console.WriteLine(item);
Console.WriteLine("=====================interfaces====================");

var interfaces = type2.GetInterfaces();
foreach (var item in interfaces) Console.WriteLine(item);
Console.WriteLine("=====================instantiate object====================");
var date = Activator.CreateInstance(typeof(DateTime));
Console.WriteLine($"date: {date}");
var num = (int?)Activator.CreateInstance(typeof(int));
num = 10;
Console.WriteLine($"num : {num}");

var date2 = Activator.CreateInstance(typeof(DateTime),2024,2,12);
Console.WriteLine($"date2: {date2}");


Console.WriteLine("=====================Member Info  ====================");
var empType = typeof(Employee);
var memberInfo = empType.GetMembers();
var memberInfo2 = empType.GetMembers(BindingFlags.NonPublic|BindingFlags.Instance);
foreach (var item in memberInfo)
{
    Console.WriteLine(item);
}
Console.WriteLine("non public | Instance");
foreach (var item in memberInfo2)
{
	Console.WriteLine(item);
}
Console.WriteLine("=====================Field Info  ====================");
var fieldsInfo = empType.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);
foreach (var item in fieldsInfo)
{
	Console.WriteLine(item);
}
Console.WriteLine("=====================Properties Info  ====================");
var proertiesInfo = empType.GetProperties();
foreach (var item in proertiesInfo)
{
	Console.WriteLine(item);
}
Console.WriteLine("=====================Method Call ====================");
var emp1 = Activator.CreateInstance(empType)as Employee;
var methodInfo = emp1.GetType().GetMethod("DoWork");
methodInfo.Invoke(emp1,  new object[] { });
Console.WriteLine("=====================Method Call with params ====================");

var methodInfo2 = emp1.GetType().GetMethod("DoWorkAt");
methodInfo2.Invoke(emp1, new object[] { DateTime.Now});
class Employee :IEmployee
{
	private string _firstName;
	private string _lastName;
	public int Id { get; set; }
	public string Name { get; set; }
	
	public void DoWork() { Console.WriteLine("Work done. "); }
	public void DoWorkAt(DateTime date) { Console.WriteLine($"Work done at {date} "); }
	public override string ToString()
	{
		return $"{Id} - {Name}";
	}
	public class Manager
	{
	}
	public class TeamLeader
	{
	}
};

internal interface IEmployee
{
}