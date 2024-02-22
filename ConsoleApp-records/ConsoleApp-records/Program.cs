
#region Records c#9
var p01 =new Point { X=0, Y=0 };
var p02=new Point { X=1, Y=1 };
var p03=new Point { X=1, Y=1 };

Console.WriteLine($"p1:{p01}");
Console.WriteLine($"p2:{p02}");
Console.WriteLine($"p3:{p03}");
Console.WriteLine($"p1==p2:{p01==p02}");
Console.WriteLine($"p1 Equals p2:{p01.Equals(p02)}");

Console.WriteLine($"p2==p3:{p02==p03}");
Console.WriteLine($"p1 Equals p2:{p02.Equals(p03)}");

Console.WriteLine($"p1 HashCode:{p01.GetHashCode()}");
Console.WriteLine($"p2 HashCode:{p02.GetHashCode()}");
Console.WriteLine($"p3 HashCode:{p03.GetHashCode()}");
#endregion


#region positional Records: Immutable by default
var p1 =new Point2(10, 10);
var p2 =new Point2(20, 20);

//cant change the state
//p1.x = 10;

Console.WriteLine(	"p1: "+p1);
Console.WriteLine(	"p2: "+p2);

//deconstruction
(var x, var y) = p1;
Console.WriteLine("x: "+	x);
Console.WriteLine(	"y: "+y);

// icant intialize boject by object initializer if i
//want to to that i need to add a parameterless ctor
var p3 = new Point2 { x = 30, y = 30 };
Console.WriteLine("p3 : "+p3);


#endregion


#region struct record c# 10 not immutable by default

var p11 =new Point3(100, 200);
Console.WriteLine(p11);

p11.x = 200;
Console.WriteLine(p11);

#endregion

#region immutable struct record => by adding readonly keyword

var p111 = new Point4(100, 200);
Console.WriteLine(p111);
Console.WriteLine(p111);

var p1111 = new Point5();
var p2222 = new Point5(900);

Console.WriteLine(p1111.x);
Console.WriteLine(p1111);
Console.WriteLine(p2222);

#endregion

#region using "with" keyword:

var p05 = p01 with { X = 1000 };
Console.WriteLine("p05 "+  p05);

var p5 = p1 with { x = 2000 };
Console.WriteLine("p5 "+p5);

var p55 = p11 with { x = 3000 };
Console.WriteLine("p55 "+p55);

var p555 = p111 with { x = 4000 };
Console.WriteLine("p555 "+p555);

var p5555 = p1111 ;
Console.WriteLine("p5555 "+p5555);

#endregion