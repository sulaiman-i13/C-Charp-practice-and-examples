List<int> nums = [1, 2, 3, 4, 5, 6, 6, 7, 7, 8, 9, 9, 9, 0, 0, 0, 1, 1, 11, 4, 2, 2,];
Print(nums, n => n % 2 == 0);
static void Print(IEnumerable<int> numbers,Filter<int,bool> filter)
{
	Console.Write("[");

	foreach ( var item in numbers)
	{
       
        if (filter(item))
		{
			Console.Write(item+ ",");
			
		}
		
    }
	Console.Write("]");
}
delegate T2 Filter<in T1, out T2>(T1 c);
