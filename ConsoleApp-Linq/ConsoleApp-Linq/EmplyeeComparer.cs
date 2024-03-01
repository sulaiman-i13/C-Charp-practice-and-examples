
#region higher order function example,pure function

///- pure functions prefer declarative over imparative coding
///- pure functions are robust and testable
///- functional programming is a programming paradigme
///			for developping softwares using functions
///	- pure function is the key part for functional programming

//var list = new List<int>() { 1, 2, 3, 4 };

//foreach(var item in list.Filter(i=>i%2==0)) Console.WriteLine(item);

//public  static class Extensions { 
//	public static IEnumerable<T> Filter<T>(this IEnumerable<T> source,Func<T,bool> predicate)
//{
//	foreach(var item in source)
//	{
//		if (predicate(item))
//		{
//			yield return item;
//		}
//	}
//}
//}
#endregion

#region where defferd execution
//List<string> myList=new List<string>() { "sulaiman","ibrahem","Ismaeel", "Tony", "Fadi", "Maher","ALi" };

////fluent:
//var list=myList.Where(m=>m.Contains("s"));
////extension method
//list = Enumerable.Where(myList,m => m.Contains("s"));
////query syntax
//list = from item in myList
//	   where item.Contains("s")
//	   select item;

//foreach (var item in list) Console.WriteLine(item);


#endregion



#region projection

//var list = new List<string>{ "sulaiman", "ibrahem", "ismaeel" };
//var list2 = new List<int>{ 94, 61, 46 };
//select
//var result = list.Select(e => e.ToUpper());
//result = from item in list
//         select item.ToUpper();

//select many
//var result=list.SelectMany(x => x.ToCharArray());

//result=from word in list
//      from letter in word
//      select letter;


//zip
//var result= list.Zip(list2);

//foreach (var item in result)
//{
//    Console.WriteLine($"{item.First},{item.Second}");
//}

//var result = list.Zip(list2, (first, second) => { return $"{first} {second}"; });

//foreach (var item in result)
//{
//    Console.WriteLine(item);
//}

#endregion

#region sorting


//var list =new List<int>() { 1,2,3,9,7,6,3,6,2,7,8,54,3,356,8,78,9};
////method one ascending
//var result = list.OrderBy(x=>x);
////method two ascending
//result = from item in list
//       orderby item ascending
//       select item;
////method one descending

//result = list.OrderByDescending(x => x);
////method two descending

//result = from i in list
//         orderby i descending
//         select i;
//foreach (var item in result)
//{
//    Console.Write(item+", ");
//}

#endregion

#region sorting part 2
class EmplyeeComparer : IComparer<Employee>
{
	public int Compare(Employee x, Employee y)
	{
        if (x.Id == y.Id)
            return x.Name.CompareTo(y.Name);
        else
            return x.Id.CompareTo(y.Id); 
	}
}
//var result = list.OrderBy(e => e.Id).ThenBy(e => e.Name);
//foreach (var item in result) Console.WriteLine(item);
#endregion


#region

#endregion


#region

#endregion


#region

#endregion



#region

#endregion



#region

#endregion


#region

#endregion



#region

#endregion




#region

#endregion