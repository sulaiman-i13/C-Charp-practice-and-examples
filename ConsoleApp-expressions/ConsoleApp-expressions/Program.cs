using System.Diagnostics.Metrics;

Console.WriteLine("==============switch===================");
var name = "sulaiman";
switch (name)
{
	case "sulaiman": Console.WriteLine("<=s="); break;
	case "Ibrahem": Console.WriteLine("=i="); break;
	case "Ismaeel": Console.WriteLine("=i=>"); break;
	default: Console.WriteLine("no name"); break;
}
Console.WriteLine("==============switch on type===================");
object o = 1;
switch (o)
{
	case int:
		Console.WriteLine("its int");
		break;
	case float:
		Console.WriteLine("its float");
		break;
	case string:
		Console.WriteLine("its string");
		break;

}
Console.WriteLine("==============switch predicate ===================");

bool b = true;
switch (b)
{
	case bool i when i==true:
		Console.WriteLine("its true");
		break;
	case bool i when i==false:
		Console.WriteLine("its false");
		break;


}
Console.WriteLine("==============switch expression ===================");
var cardNumber = 7;
var cardName = cardNumber switch
{
	1 => "Ase",
	11 => "Jack",
	12 => "Queen",
	13 => "King",
	_=>cardNumber.ToString()
};
Console.WriteLine(cardName);


Console.WriteLine("==============fibonacci ===================");

for (int counter=0,prev = 0, current = 1;counter < 10; counter++ ){

	int newNumber = prev + current;
	prev = current;
	current = newNumber;
    Console.WriteLine(	$"Current: { current}");
}
Console.WriteLine("==============Odd Numbers ===================");
for(int i = 0; i < 10; i++)
{
	if (i % 2 != 0) { Console.WriteLine($"i: {i}"); }
}