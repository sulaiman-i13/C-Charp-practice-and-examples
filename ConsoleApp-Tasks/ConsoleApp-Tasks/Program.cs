NewMethod();
#endregion
Console.ReadKey();

static void NewMethod()
{
	var list = new List<string> { "sulaiman", "ibrahem", "ismaeel" };
	Parallel.ForEach(list, x =>
	{
		Console.WriteLine(x);
		Console.WriteLine(Thread.CurrentThread.Name);
		Console.WriteLine(Thread.GetCurrentProcessorId());

	});
}