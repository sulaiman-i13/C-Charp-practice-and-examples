public static class Extensions
{
	public static IEnumerable<T> Paginate<T>(this IEnumerable<T> source, int page = 1, int size = 10)
	{
		if (page <= 0) page = 1;
		if(size <= 0) size = 10;

		var result=source.Skip((page-1)*size).Take(size);
		return result;
	}

}