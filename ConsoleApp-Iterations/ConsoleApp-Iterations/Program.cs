//practice on equality
Console.WriteLine("===========equality======================");
var emp1 = new Employee { Id = 1, Name = "Sulaiman" };
var emp2 = new Employee { Id = 2, Name = "Tony" };
Console.WriteLine(emp1.Equals(emp2));
emp2 = emp1;
Console.WriteLine(emp1.Equals(emp2));

//practis on enumeration
Console.WriteLine("===========enumeration======================");

var nums = new FiveIntegers(new int[] { 1, 2, 3, 4, 5 });
foreach (int i in nums) Console.WriteLine(i);



//practice on comparing
Console.WriteLine("===========comparing======================");

var t1 = new Temp { Value = 100 };
var t2 = new Temp { Value = 150 };
Console.WriteLine(t1.CompareTo(t2));
