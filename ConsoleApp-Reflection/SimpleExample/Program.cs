var type = typeof(Program);
Console.WriteLine("Enenmy:");
do
{
	Console.WriteLine("enter monster name:");
	var input = Console.ReadLine();
	object monster = null;
	try { var monsterObjectHandler = Activator.CreateInstance(type.Assembly.GetName().Name, input);
		//because its an object handler
		monster = monsterObjectHandler.Unwrap();
	}
	catch { 
		Console.WriteLine("unknown monster");
	}



	if (input == "/") break;
	switch (monster)
	{
		case FirstMonster f:
			Console.WriteLine(f);
			break;
		case SecondMonster s:
			Console.WriteLine(s);
			break;
		case ThirdMonster t:
			Console.WriteLine(t);
			break;
	}
} while (true);


