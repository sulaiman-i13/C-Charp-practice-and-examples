
//StackExample();
QueueExample();
static void StackExample() {
	Stack<Command> unDo = new Stack<Command>();
	Stack<Command> redoDo = new Stack<Command>();
	var input = string.Empty;
Console.WriteLine("enter a command or [\\] to exit:");
Console.WriteLine("\t\tyou can write [back] to get a step back");
Console.WriteLine("\t\tyou can write [redo] to get a step forward");
while (true)
{

	input = Console.ReadLine();
	if (input == null || input == "\\") break;
	if (input != "back" && input != "redo")
	{
		var command = new Command(input);
		unDo.Push(command);
	}


	if (input == "back")
	{
		if (unDo.Count > 0)
		{
			var c = unDo.Pop();
			redoDo.Push(c);
		}
	}
	else if (input == "redo")
	{
		if (redoDo.Count > 0)
		{
			var r = redoDo.Pop();
			unDo.Push(r);
		}
	}


		

		Console.WriteLine("============UnDo stack=============");

	foreach (var item in unDo)
	{
		Console.ForegroundColor = ConsoleColor.Green;
		Console.WriteLine(item);
	}
		Console.ForegroundColor = ConsoleColor.White;

		Console.WriteLine("=============ReDo stack============");
	foreach (var item in redoDo)
	{
		Console.ForegroundColor = ConsoleColor.Red;
		Console.WriteLine(item);
	}
	Console.ForegroundColor = ConsoleColor.White;
}
}
static void QueueExample()
{
	Queue<PrintJob> printJobs = new Queue<PrintJob>();
	Console.WriteLine("enter a Text to print or [\\] to exit:");
	Console.WriteLine("enter [print] to print your texts ");
	while (true)
	{
		var input = string.Empty;
		
		input = Console.ReadLine();
		if (input == "\\") break;
		else if (input == "print") Print();
		else
		printJobs.Enqueue(new PrintJob(input));
        Console.WriteLine("======Print List:========");
        foreach (var item in printJobs)
		{
			Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(item);
        }
		Console.ForegroundColor = ConsoleColor.White;



	}
	void Print()
	{
        Console.Write("ready to print");
		while(printJobs.Count>0)
		{
			Console.ForegroundColor = ConsoleColor.Green;
			for (int i = 0; i < 3; i++)
			{
				Thread.Sleep(500);
				Console.Write(".");
			}
            Console.WriteLine("\n");
			var item = printJobs.Dequeue();
            Console.Write(item);

        }
		Console.WriteLine("\n");
		Console.ForegroundColor = ConsoleColor.White;


	}
}

