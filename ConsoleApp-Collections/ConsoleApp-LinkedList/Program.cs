using System.ComponentModel.DataAnnotations;

LinkedList<YTVideo> playlist = new LinkedList<YTVideo>();
Console.WriteLine("=========add last====");

playlist.AddLast(new YTVideo("hello C#", "C# for beginners", 10));
playlist.AddLast(new YTVideo("hello Js", "Js for beginners", 5));
playlist.AddLast(new YTVideo("hello C++", "C++ for beginners", 20));
playlist.AddLast(new YTVideo("hello Java", "Java for beginners", 10));

Display();
Console.WriteLine("=========add first====");
playlist.AddFirst(new YTVideo("hello Kotlen", "Kotlen for beginners", 7));
Display();

Console.WriteLine("=========add after first node====");
playlist.AddAfter(playlist.First,new YTVideo("hello Dart", "Dart for beginners", 5));
Display();

Console.WriteLine("=========add before first node====");
playlist.AddBefore(playlist.First, new YTVideo("hello C", "C for beginners", 25));
Display();

Console.WriteLine("=========add after second node====");
playlist.AddAfter(playlist.First.Next, new YTVideo("hello Rust", "Rust for beginners", 9));
Display();

void Display()
{
	Console.WriteLine(playlist.Count);
	foreach (YTVideo item in playlist)
	{
		Console.WriteLine(item);

	}
}