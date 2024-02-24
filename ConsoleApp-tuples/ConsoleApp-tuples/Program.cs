
#region tuple example 1 ref tuple
//var t = Calcu.Calculate("sulaiman");
//Console.WriteLine(t);
//Console.WriteLine(t.Item1);
//Console.WriteLine(t.Item2);
//static class Calcu
//{
//	static Random rand =new Random();
//	public static Tuple<string ,string> Calculate(string name)
//	{
//		return Tuple.Create(name, (rand.NextDouble() * 10).ToString("f2"));
//	}
//}
#endregion
#region tuple example 2 ref tuple
//var t = Calcu.Calculate("sulaiman");
//Console.WriteLine(t);
//Console.WriteLine(t.Item1);
//Console.WriteLine(t.Item2);
//static class Calcu
//{
//	static Random rand = new Random();
//	public static Tuple<string, string> Calculate(string name)
//	{
//		return new Tuple<string, string>(name, (rand.NextDouble() * 10).ToString("f2"));

//	}
//}
#endregion



#region tuple example 3 value tuple
//var t = Calcu.Calculate("sulaiman");
//Console.WriteLine(t);
//Console.WriteLine(t.Item1);
//Console.WriteLine(t.Item2);
//static class Calcu
//{
//	static Random rand = new Random();
//	public static ValueTuple<string, string> Calculate(string name)
//	{
//		return ValueTuple.Create<string,string>(name, (rand.NextDouble() * 10).ToString("f2"));

//	}
//}
#endregion

#region tuple example 4 value tuple
//var t = Calcu.Calculate("sulaiman");
//Console.WriteLine(t);
//Console.WriteLine(t.Item1);
//Console.WriteLine(t.Item2);
//static class Calcu
//{
//	static Random rand = new Random();
//	public static ValueTuple<string, string> Calculate(string name)
//	{
//		return new ValueTuple<string, string>(name, (rand.NextDouble() * 10).ToString("f2"));

//	}
//}
#endregion

#region tuple example 5 value tuple
//var t = Calcu.Calculate("sulaiman");
//Console.WriteLine(t);
//Console.WriteLine(t.Item1);
//Console.WriteLine(t.name);
//Console.WriteLine(t.Item2);
//Console.WriteLine(t.value);
//static class Calcu
//{
//	static Random rand = new Random();

//	//we can name the return values like this: "name" and "value":
//	public static (string name, string value) Calculate(string name)
//	{
//		//we can return this:
//		//return new ValueTuple<string,string>(name, (rand.NextDouble() * 10).ToString("f2"));
//		//or this:
//		//return  ValueTuple.Create<string,string>(name, (rand.NextDouble() * 10).ToString("f2"));
//		//or this:
//		return (name, (rand.NextDouble() * 10).ToString("f2"));

//	}
//}
#endregion

#region deconstruction
//wrong example:
//Tuple<int, string> t1 = new Tuple<int, string>();
////we cant override the fields ,theu are readonly
///and also reference tuples are immutable
//t1.Item1 = 10;
//t1.Item2 = "sulaiman";

//Tuple<int, string> t1 = new Tuple<int, string>(1,"sulaiman");
//(var id, var name) = t1;
//Console.WriteLine(id);
//Console.WriteLine(name);


//var t1 = new ValueTuple<int, string>();
/////and also value tuples are mutable
/////so i can give values to field and override them after instanciation
//t1.Item1 = 10;
//t1.Item2 = "sulaiman";
//(var id, var name) = t1;
//Console.WriteLine(id);
//Console.WriteLine(name);

(int, string,int) t1 = (1, "su",10);
t1.Item2 = "sulaiman";
Console.WriteLine(t1);
#endregion

