Console.WriteLine("============pass args by refrecnc=========");
var x = 10;
doSomething(ref x);
void doSomething(ref int y)
{
	y = 15;
	Console.WriteLine("Y: " + y); 
}
Console.WriteLine("x: " + x);

Console.WriteLine("============pass args by refrecnc using out=========");

_doSomething(out int z);
void _doSomething(out int w)
{ 
	w = 15;
	Console.WriteLine("w: " + w);
}
Console.WriteLine("z: " + z);
Console.WriteLine("============readonly field=========");
//readonly fields use constructor only to initialize their values
var o = new SomeClass(10);
class SomeClass
{
	public readonly int x;
	public SomeClass(int x)
	{
		this.x = x;	
	}
}
