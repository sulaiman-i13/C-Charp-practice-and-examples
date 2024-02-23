
#nullable enable annotations
string? name = default;
Console.WriteLine(name.Length);

#nullable restore annotations

#region nullable ex

Nullable<int> mark = default;//null
//Or we can use
int?mark1 = default(int?);//null
int? mark2= default;//null
int? mark3= new Nullable<int>();//null
int? mark4 = new();//0
Console.WriteLine(mark4);//0
if (mark is null) { Console.WriteLine("mark one is null"); }
if(!mark.HasValue) { Console.WriteLine("mark one dont have a value"); }
#endregion


 void setMajor(string? major)
{

	string m = major?? "unknown";
    Console.WriteLine(m + " "+m.Length);
}
setMajor(null);

