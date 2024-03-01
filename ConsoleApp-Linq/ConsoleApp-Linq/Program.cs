
#region higher order function example,pure function


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


//var list = new List<int>() { 1, 2, 3, 9, 7, 6, 3, 6, 2, 7, 8, 54, 3, 356, 8, 78, 9 };
//var arr = new int[] { 1, 2, 3, 9, 7, 6, 3, 6, 2, 7, 8, 54, 3, 356, 8, 78, 9 };
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

//var result = arr.Reverse();
//foreach (var item in result)
//{
//    Console.Write(item + ", ");
//}

#endregion

#region sorting part 2
//var list = new List<Employee>()
//{
//    new Employee{Id=1,Name="sulaiman"},
//    new Employee{Id=1,Name="ibrahem"},
//    new Employee{Id=3,Name="ahmed"},
//    new Employee{Id=4,Name="saleh"},
//    new Employee{Id=5,Name="tony"},
//    new Employee{Id=5,Name="nabil"},
//    new Employee{Id=5,Name="fadi"},
//};
////var result = list.OrderBy(e => e.Id).ThenBy(e => e.Name);
//var result = list.OrderBy(e => e,new EmplyeeComparer());
//foreach (var item in result) Console.WriteLine(item);
#endregion


#region partitioning

//var list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 4, 5, 0, 4, 3, 21, 1, 1, 23, 45, 6 };
//var result = list.Take(10);
// result = list.TakeLast(10);
//result = list.TakeWhile(x => x != 0);
//result = list.Skip(10);
//result = list.SkipLast(10);
//result = list.SkipWhile(x=>x!=0);
//var result2 = list.Chunk(5);
//foreach (var item in result2) {
//    foreach (var i in item)
//	{
//        Console.WriteLine(i);
//    };
//    Console.WriteLine("==========");
//}

#endregion


#region pagination
//var list = new List<Employee>()
//{
//    new Employee{Id=1,Name="sulaiman"},
//    new Employee{Id=1,Name="ibrahem"},
//    new Employee{Id=3,Name="ahmed"},
//    new Employee{Id=4,Name="saleh"},
//    new Employee{Id=5,Name="tony"},
//    new Employee{Id=5,Name="nabil"},
//    new Employee{Id=5,Name="fadi1"},
//    new Employee{Id=5,Name="fadi2"},
//    new Employee{Id=5,Name="fadi3"},
//    new Employee{Id=5,Name="fadi4"},
//    new Employee{Id=5,Name="fadi5"},
//    new Employee{Id=5,Name="fadi6"},
//    new Employee{Id=5,Name="fadi7"},
//    new Employee{Id=5,Name="fadi8"},
//    new Employee{Id=5,Name="fadi9"},
//    new Employee{Id=5,Name="fadi10"},
//    new Employee{Id=5,Name="fadi11"},
//    new Employee{Id=5,Name="fadi12"},
//    new Employee{Id=5,Name="fadi13"},
//    new Employee{Id=5,Name="fadi14"},
//    new Employee{Id=5,Name="fadi15"},
//    new Employee{Id=5,Name="fadi16"},
//    new Employee{Id=5,Name="fadi17"},
//    new Employee{Id=5,Name="fadi18"},
//};
//int page=1;
//int size=10;
//Console.WriteLine("Enter page number");
//if(int.TryParse(Console.ReadLine().ToString(),out int pageNo))
//{
//     page = pageNo;
//}
//Console.WriteLine("Enter size of page");
//if(int.TryParse(Console.ReadLine().ToString(),out int pageSize))
//{
//     size = pageSize;
//}
//var result = list.Paginate(page, size);
//var resultCount = result?.Count();
//var startRecord = ((page-1) * size)+1;
//var endRecord = resultCount<size?startRecord+resultCount-1:startRecord + size-1;
//var totalPages = (int)Math.Ceiling((decimal)list.Count / size);
//Console.WriteLine($"page{{{page}}} from {totalPages} pages, contain employees form [{startRecord}] to [{endRecord}]");
//foreach (var item in result)
//{
//    Console.WriteLine(item);
//}
#endregion


#region quantifiers

//var list = new List<Employee>(){
//new Employee{Id=1,Name="emp1"},
//new Employee{Id=2,Name="emp2"},
//new Employee{Id=3,Name="emp3"},
//new Employee{Id=4,Name="emp4"},
//new Employee{Id=5,Name="emp5"},
//new Employee{Id=6,Name="emp6"},
//new Employee{Id=7,Name="emp7"},
//new Employee{Id=8,Name="emp8"},
//new Employee{Id=9,Name="emp9"},
//new Employee{Id=10,Name="emp10"},
//new Employee{Id=11,Name="emp11"},
//new Employee{Id=12,Name="emp12"},
//};
//var result=list.Any(e=>e.Id==10);
//result = list.All(e => e.Name.Contains("emp"));
//result=list.Contains(new Employee { Id = 10, Name = "emp10" });
//Console.WriteLine(result);

#endregion



#region grouping (groupby=>defferd) ,( tolookup=>immediate)
//var list = new List<Employee>(){
//new Employee{Id=1,Name="emp1"},
//new Employee{Id=2,Name="emp1"},
//new Employee{Id=3,Name="emp2"},
//new Employee{Id=4,Name="emp2"},
//new Employee{Id=5,Name="emp6"},
//new Employee{Id=6,Name="emp6"},
//new Employee{Id=7,Name="emp6"},
//new Employee{Id=8,Name="emp9"},
//new Employee{Id=9,Name="emp9"},
//new Employee{Id=10,Name="emp10"},
//new Employee{Id=11,Name="emp10"},
//new Employee{Id=12,Name="emp10"},
//};
////method syntax
//var result = list.GroupBy(e => e.Name);
////query syntax
//result = from emp in list
//         group emp by emp.Name;
//foreach (var item in result)
//{
//	Console.WriteLine($"======{item.Key}======");
//	foreach (var i in item) Console.WriteLine(i);

//}
//immedaite exec fit the situatioin when we want to do many processes on the data
//var result2 = list.ToLookup(e => e.Name);
//Console.WriteLine(result2.Count);
//Console.WriteLine(result2.Contains("emp10"));
//foreach (var item in result2)
//{
//    Console.WriteLine($"======{item.Key}======");
//    foreach (var i in item) Console.WriteLine(i);

//}
#endregion



#region join operations
//var employees = new List<Employee>(){
//new Employee{Id=1,Name="emp1",DepartmentId=1},
//new Employee{Id=2,Name="emp2",DepartmentId=1},
//new Employee{Id=3,Name="emp3",DepartmentId=1},
//new Employee{Id=4,Name="emp4",DepartmentId=1},
//new Employee{Id=5,Name="emp5", DepartmentId = 2},
//new Employee{Id=6,Name="emp6", DepartmentId = 2},
//new Employee{Id=7,Name="emp7", DepartmentId = 2},
//new Employee{Id=8,Name="emp8", DepartmentId = 3},
//new Employee{Id=9,Name="emp9", DepartmentId = 3},
//new Employee{Id=10,Name="emp10", DepartmentId = 3},
//new Employee{Id=11,Name="emp11", DepartmentId = 4},
//new Employee{Id=12,Name="emp12" , DepartmentId = 4},
//};
//var departments = new List<Department>()
//{
//	new Department{Id=1,Name="Department1"},
//	new Department{Id=2,Name="Department2"},
//	new Department{Id=3,Name="Department3"},
//	new Department{Id=4,Name="Department4"},
//};

//var result = employees.Join(
//	departments,
//	e=>e.DepartmentId,
//	d=>d.Id,
//	(e, d) => new {EmployeeName=e.Name,DepartmentName=d.Name}
//	);

//result = from e in employees
//		 join d in departments
//		 on e.DepartmentId equals d.Id
//		 select new { EmployeeName = e.Name, DepartmentName = d.Name };
//foreach (var item in result) Console.WriteLine(item);

#endregion


#region groupJoin


using ConsoleApp_Linq;
using System.Linq.Expressions;

///- pure functions prefer declarative over imparative coding
///- pure functions are robust and testable
///- functional programming is a programming paradigme
///			for developping softwares using functions
///	- pure function is the key part for functional programming
//var employees = new List<Employee>(){
//new Employee{Id=1,Name="emp1",DepartmentId=1},
//new Employee{Id=2,Name="emp2",DepartmentId=1},
//new Employee{Id=3,Name="emp3",DepartmentId=1},
//new Employee{Id=4,Name="emp4",DepartmentId=1},
//new Employee{Id=5,Name="emp5", DepartmentId = 2},
//new Employee{Id=6,Name="emp6", DepartmentId = 2},
//new Employee{Id=7,Name="emp7", DepartmentId = 2},
//new Employee{Id=8,Name="emp8", DepartmentId = 3},
//new Employee{Id=9,Name="emp9", DepartmentId = 3},
//new Employee{Id=10,Name="emp10", DepartmentId = 3},
//new Employee{Id=11,Name="emp11", DepartmentId = 4},
//new Employee{Id=12,Name="emp12" , DepartmentId = 4},
//};
//var departments = new List<Department>()
//{
//	new Department{Id=1,Name="Department1"},
//	new Department{Id=2,Name="Department2"},
//	new Department{Id=3,Name="Department3"},
//	new Department{Id=4,Name="Department4"},
//};

//var result = departments.GroupJoin(
//	employees,
//	d => d.Id,
//	e => e.DepartmentId,
//	(d, emps) => new { department = d.Name, employees = emps.Select(e=>e.Name) }

//	);

//foreach (var item in result)
//{
//	Console.WriteLine(item.department);
//	foreach (var e in item.employees)
//	{
//		Console.WriteLine("\t" + e);
//	}
//}
//var result2 = from d in departments
//		 join e in employees
//		 on d.Id equals e.DepartmentId
//		 into _group
//		 select _group;
//foreach (var item in result2)
//{
//	foreach (var e in item)
//	{
//        Console.WriteLine("\t"+e.Name);
//    }
//    Console.WriteLine("--------");
//}


#endregion


#region empty list
////this is an empty list object has created in memory
////var list = new List<Question>();
////this is an empty Enumerable,this is a differd execution here
//var list = Enumerable.Empty<Question>();
////return the lst sequence or the defualt of type Question
////var lst2 = list.DefaultIfEmpty();
//var lst2 = list.DefaultIfEmpty(Question.Default);
//lst2.ToQuiz();
#endregion




#region  Range   -- differed execution

//var range = Enumerable.Range(1, 15);
//foreach (var item in range)
//{
//    Console.Write($" {item}");
//}

//var list = QuestionBank.GetQuestionRange(range);
//list.ToQuiz();

#endregion



#region Repeat

//var question = QuestionBank.PickOne();
//var questions = Enumerable.Repeat(question, 10).ToList();
//Console.WriteLine(ReferenceEquals(questions[0], questions[1]));//true
//questions.ToQuiz();

#endregion


#region ElementAt
//var questions = QuestionBank.All;
//var q10 = questions.ElementAt(10);
//Index was out of range=>this will throw an exception
//var q100 = questions.ElementAt(100);
//to resolve this problem we can use this:
//var q100 = questions.ElementAtOrDefault(100);
//but it still going to throw an exception if the sequence is null
//questions = null;
//var q100 = questions.ElementAtOrDefault(100);

//Console.WriteLine(q100);


#endregion




#region First, Last, Single

//var q = QuestionBank.All.First();

//q=QuestionBank.All.First(q=>q.Title.Contains("10"));
//q=QuestionBank.All.First(q=>q.Title.Contains("100"));//Invalid Operation Exception:
//q=QuestionBank.All.FirstOrDefault(q=>q.Title.Contains("100"));
//q = QuestionBank.All.Last();
//q = QuestionBank.All.LastOrDefault();
//q = QuestionBank.All.LastOrDefault(q=>q.Title.Contains("s"));
//q = QuestionBank.All.Single(q => q.Title.Contains("10"));
//q = QuestionBank.All.Single(q => q.Title.Contains("100"));// Invalid Operation Exception
//q = QuestionBank.All.SingleOrDefault(q => q.Title.Contains("100"));
//q = QuestionBank.All.SingleOrDefault(q => q.Title.Contains("s"));//Invalid Operation Exception

//Console.WriteLine(q);
#endregion



#region SequenceEqual

//var questions = QuestionBank.GetQuestionRange(Enumerable.Range(1, 5));
//var list1 = questions;
//var list2 = questions;

//var list1 = QuestionBank.GetQuestionRange(Enumerable.Range(1, 5));
//var list2 = QuestionBank.GetQuestionRange(Enumerable.Range(1, 5));

//Console.WriteLine(list1.SequenceEqual(list2));//false why? we have to override Equals & GetGashCode

#endregion




#region concatination

//var list1 = QuestionBank.Randomiaze(5);
//var list2 = QuestionBank.Randomiaze(5);
//var list3 = list1.Concat(list2);
//var listOfTitles = list1.Select(q => q.Title).Concat(list2.Select(q => q.Title));
//foreach (var item in listOfTitles)
//{
//    Console.WriteLine(item);
//}

#endregion



#region Aggrigation

//var names = new string[] { "Ali", "Salem", "Abeer","Reem" };
///old ways
////method one:
//string namesAsString=string.Empty;
//foreach (var item in names) namesAsString += $"{item} ,";
//Console.WriteLine(namesAsString.TrimEnd(','));
////method two
//var namesAsString2 = string.Join(',', names);
//Console.WriteLine(	namesAsString2);

///Aggreigate
//var namesAsString = names.Aggregate((first, second) =>
//{
//	Console.WriteLine($"first: {first},second: {second}");
//	return $"{first}, {second}";
//});
//Console.WriteLine(namesAsString);


//int[] numbers = [1, 2, 3, 4, 5, 6];
//var total = 0;
//foreach (var n in numbers) total += n;
//Console.WriteLine(total);


//var questions = QuestionBank.All;
//int titleLengths = questions.Aggregate(0,
//	(f,s)=>{ return f + s.Title.Length; }
//		);
//Console.WriteLine(	titleLengths);


//int max = questions.Max(q => q.Title.Length);
//	Console.WriteLine(max);
//var maxBy = questions.MaxBy(q => q.Title.Length);
//Console.WriteLine(maxBy);

//int min = questions.Min(q => q.Title.Length);
//Console.WriteLine(min);
//var minBy = questions.MinBy(q => q.Title.Length);
//Console.WriteLine(minBy);

//var count = questions.Count();

//var qs = QuestionBank.All;
//var sum = qs.Sum(x => x.Choises.Count);
//Console.WriteLine(sum);


#endregion


#region sets operations
//var meeting1 = MeetingHelper.All[0];
//var meeting2 = MeetingHelper.All[1];
//Console.WriteLine(meeting1);
//Console.WriteLine(meeting2);
////concat
//var meeting1And2Praticipants = meeting1.Participants.Concat(meeting2.Participants);
////disctict
//var meeting1And2PraticipantsDistinct = meeting1.Participants.Concat(meeting2.Participants).Distinct();
//var meeting1And2PraticipantsDistinct2 = meeting1And2Praticipants.DistinctBy(e => e.Id);
////except
//var meeting1ExceptMeeting2Praticipants = meeting1.Participants.Except(meeting2.Participants);
//var meeting1ExceptMeeting2Praticipants2 = meeting1.Participants
//					.ExceptBy(meeting2.Participants.Select(e=>e.Id),e=>e.Id);
////intersect
//var meeting1IntersectMeeting2Praticipants = meeting1.Participants.Intersect(meeting2.Participants);
//var meeting1IntersectMeeting2Praticipants2 = meeting1.Participants.IntersectBy(meeting2.Participants.Select(k=>k.Id),k=>k.Id);
////union
//var meeting1UnionMeeting2Praticipants = meeting1.Participants.Union(meeting2.Participants);
//var meeting1UnionMeeting2Praticipants2 = meeting1.Participants.UnionBy(meeting2.Participants,k=>k.Id);

//foreach (var p in meeting1UnionMeeting2Praticipants2)
//{ Console.WriteLine(p); }
#endregion




#region Expressions
//Func<int, bool> IsEven = n => n % 2 == 0;
//Expression<Func<int, bool>>IsEvenExpression= n => n % 2 == 0;

//Console.WriteLine(IsEven(10));
//Console.WriteLine(IsEven.Invoke(10));
//Console.WriteLine(IsEvenExpression.Compile().Invoke(10));


#endregion


#region Expression Decompose Example

//Expression<Func<int, bool>> IsNegative = n => n < 0;

//ParameterExpression parameter= IsNegative.Parameters[0];
//BinaryExpression body = (BinaryExpression)IsNegative.Body;
//ParameterExpression leftSide =(ParameterExpression)body.Left;
//ExpressionType operation = body.NodeType;
//ConstantExpression rightSide = (ConstantExpression)body.Right;

//Console.WriteLine($"{parameter.Name} =>{leftSide} {operation} {rightSide}");


#endregion


#region expression example from scratch
//func<int,bool> IsEven=n=>n%2==0

//ParameterExpression p = Expression.Parameter(typeof(int), "p");
//ConstantExpression zero = Expression.Constant(0, typeof(int));
//ConstantExpression two = Expression.Constant(2, typeof(int));
//BinaryExpression modelo=Expression.Modulo(p,two);
//var equal=Expression.Equal(modelo,zero);
//var isEven = Expression.Lambda<Func<int, bool>>(equal, [p]).Compile();
//Console.WriteLine(isEven(10));

#endregion



#region IQueryable

// IQueryable<Employee> emps = EmployeeHelper.All;
// foreach (var item in emps)
// {
// 	Console.WriteLine(	item);
// }
#endregion





#region ToDictionary


var employees = EmployeeHelper.All;
Dictionary<int,Employee> dict= employees.ToDictionary(x=>x.Id);
var lookup= employees.ToLookup(x=>x.Id).ToDictionary(x=>x.Key,x=>x.ToList());
var group = employees.GroupBy(x => x.Id).ToDictionary(x => x.Key, x => x.ToList());

#endregion







