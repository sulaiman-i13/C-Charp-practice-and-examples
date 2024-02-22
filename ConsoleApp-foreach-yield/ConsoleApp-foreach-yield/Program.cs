#region foreach
static void ForEach<T>( IEnumerable<T> sequence)
{
	IEnumerator<T> enumerator = sequence.GetEnumerator();
	IDisposable disposable = enumerator as IDisposable;
	try
	{
		while (enumerator.MoveNext())
		{
			
            Console.WriteLine(enumerator.Current);
        }
	}
	catch (Exception)
	{

		enumerator.Reset();
	}
	finally { disposable.Dispose(); }
}
var seq1 = new List<int> { 1, 2, 3, 3, 44, 4, 5, 5, 6 };
var seq2 = new List<string> { "sulaiman", "ibrahem", "ismaeel" };
ForEach(seq1);
ForEach(seq2);

#endregion

#region yield

IEnumerable<string> SomethingToDo()
{
	for (int i = 0; i < 100; i++)
	{
		yield return $"i: {i}";
	}
}
foreach (var item in SomethingToDo())
{
    Console.WriteLine(item);
}
#endregion