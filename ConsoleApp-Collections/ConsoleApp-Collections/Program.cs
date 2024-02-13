using System.ComponentModel.DataAnnotations.Schema;

Console.WriteLine("=-=-=-=-=-=-=-=-= Lists =-=-=-=-=-=-=-=-=-=-==-=-=\n\n");
List<int> nums = new List<int>();
Console.WriteLine("========================= Add=================");
nums.Add(1);
nums.Add(2);
nums.Add(3);
foreach (int i in nums)Console.WriteLine($"nums:{i}");
Console.WriteLine("==================== AddRange ====================== ");

nums.AddRange(new int[]{11,22,33,44,55});
foreach (int i in nums) Console.WriteLine($"nums:{i}");

Console.WriteLine("==================Insert in 1==================");

nums.Insert(1, 999);
foreach (int i in nums) Console.WriteLine($"nums:{i}");

Console.WriteLine("================== InsertRange in 1==================");
nums.InsertRange(1, new int[] { 88, 77 });
foreach (int i in nums) Console.WriteLine($"nums:{i}");
Console.WriteLine("================== Count & Capacity==================");
Console.WriteLine($"Count : { nums.Count}, Capacity : {nums.Capacity}");


Console.WriteLine("================== RemoveAt 0 ==================");
nums.RemoveAt(0);
foreach (int i in nums) Console.WriteLine($"nums:{i}");

Console.WriteLine("================== Remove 88 ==================");
nums.Remove(88);
foreach (int i in nums) Console.WriteLine($"nums:{i}");

Console.WriteLine("================== RemoveAll ==================");
nums.RemoveAll(n=>n%2==0);
foreach (int i in nums) Console.WriteLine($"nums:{i}");

Console.WriteLine("=-=-=-=-=-=-=-=-= Dictionaries =-=-=-=-=-=-=-=-=-=-==-=-=\n\n");
Dictionary<char, List<string>> letters = new Dictionary<char, List<string>>();

string articel = "A type defines the structure and behavior of any data in C#" +
	" The declaration of a type may include its members base type interfaces it implements" +
	" and operations permitted for that type A variable is a label that" +
	" refers to an instance of a specific type";

foreach (string word in articel.Split(" "))
{
	foreach (var ch in word)
	{
		if (!letters.ContainsKey(ch))
		{
		
			letters.Add(ch, new List<string>{ word.ToLower() });
		}
		else
		{
			letters[ch].Add(word);
		}
	}
}
foreach (var item in letters)
{
    Console.WriteLine($"Key : {item.Key}\n");
	foreach (var word in item.Value)
	{
		Console.WriteLine($"{word}");

	}
	Console.WriteLine("----------\n\n");
}
Console.WriteLine("==================== IGrouping===============");
var emps = new List<Employee>() {
	new Employee(1,"suliaman",-1),
	new Employee(2,"Ramin",1),
	new Employee(3,"Tony",1),
	new Employee(4,"Suhail",2),
	new Employee(5,"Sami",2),
};

var managers = emps.GroupBy(e => e.ReportTo);
foreach (var i in managers)
{
	Console.WriteLine($"key: {i.Key}");
	foreach (var v in i)
	{
		Console.WriteLine($" value: {v}");

	}
}
Console.WriteLine("==================== IGrouping toDictionary===============");
var manageDictionary = managers.ToDictionary(k => k.Key, v => v.ToList());
foreach (var i in manageDictionary)
{
	Console.WriteLine($"key: {i.Key} ");
	foreach (var v in i.Value)
	{
		Console.WriteLine($" value: {v}");

	}
}

Console.WriteLine("==================== ToLookup===============");

var managers2 = emps.ToLookup(e => e.ReportTo);
foreach (var i in managers2)
{
	foreach (var v in i.ToList())
	{
		Console.WriteLine($"Key: {i.Key}, value: {v}");

	}
}
Console.WriteLine("==================== ILookup to Dictionary===============");

var managerDictionary2 = managers2.ToDictionary(k=>k.Key,v=>v.ToList());
foreach (var i in managerDictionary2)
{
	Console.WriteLine($"Key: {i.Key},Manager Name:{(emps.FirstOrDefault(e => e.Id == i.Key)?.Name)??"this is the Boss"}");

	foreach (var v in i.Value)
	{
		Console.WriteLine($"value: {v}");

	}
    Console.WriteLine("==========");
}