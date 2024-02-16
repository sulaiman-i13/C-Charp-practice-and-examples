using System.IO.Compression;

////file stream write example
//FileFunc1();
////file stream read and write example
//FileFunc2();
////file Adapter write  example
//FileFunc3();
////file Adapter read  example
//FileFunc4();
////File.ReadAllText
//FileFunc5();
////File.WriteAllText
//FileFunc6();
//Deflate Stream
FileFunc7();


static void FileFunc1()
{
	var path = @"C:\Users\Sulaiman\Projects\DotNetProjects\C-Charp-practice-and-examples\ConsoleApp-IOStream\ConsoleApp-IOStream\myText.txt";
	using (var file = new FileStream(path, FileMode.Open, FileAccess.ReadWrite))
	{
		file.Position = file.Length <= 0 ? 0 : file.Length;
		Console.WriteLine("Name: " + file.Name);
		Console.WriteLine("length: " + file.Length);
		Console.WriteLine("can read? " + file.CanRead);
		Console.WriteLine("can write? " + file.CanWrite);
		Console.WriteLine("can seek? " + file.CanSeek);
		Console.WriteLine("can timeout ? " + file.CanTimeout);
		Console.WriteLine("position: " + file.Position);
		for (byte i = 65; i < 123; i++)
		{
			file.WriteByte(i);
		}
		file.WriteByte(Convert.ToByte("13"));
	}
}
static void FileFunc2()
{
	var path = @"C:\Users\Sulaiman\Projects\DotNetProjects\C-Charp-practice-and-examples\ConsoleApp-IOStream\ConsoleApp-IOStream\myText.txt";
	var path2 = @"C:\Users\Sulaiman\Projects\DotNetProjects\C-Charp-practice-and-examples\ConsoleApp-IOStream\ConsoleApp-IOStream\myText2.txt";

	using (var file = new FileStream(path, FileMode.Open, FileAccess.Read))
	{
		var bytesToRead = file.Length;
		var bytesRead = 0;
		var data = new byte[file.Length];
		while (bytesToRead>0)
		{
			var n = file.Read(data, bytesRead, (int)bytesToRead);
			if (n == 0) break;
			bytesToRead -= n;
			bytesRead += n;
		}
		foreach(var item in data) Console.Write((char)item);

		using (var file2 = new FileStream(path2, FileMode.OpenOrCreate, FileAccess.Write))
		{
			file2.Write(data, 0, data.Length);
            Console.WriteLine("write is done");
        }


	}
}
static void FileFunc3()
{
	var path = @"C:\Users\Sulaiman\Projects\DotNetProjects\C-Charp-practice-and-examples\ConsoleApp-IOStream\ConsoleApp-IOStream\myText3.txt";
	using (var sw = new StreamWriter(path))
	{
		sw.WriteLine("Tony is a duck");
		sw.WriteLine("Tony is a duck");
		sw.WriteLine("Tony is a duck");
	}
}
static void FileFunc4()
{
	var path = @"C:\Users\Sulaiman\Projects\DotNetProjects\C-Charp-practice-and-examples\ConsoleApp-IOStream\ConsoleApp-IOStream\myText3.txt";
	using (var sw = new StreamReader(path))
	{
        while(sw.Peek()>0) Console.Write((char)(sw.Read()));
		string line;
		using (var sw2=new StreamReader(path))
			while ((line = sw2.ReadLine()) is not null) Console.WriteLine(line);
    }
}
static void FileFunc5()
{
	var path = @"C:\Users\Sulaiman\Projects\DotNetProjects\C-Charp-practice-and-examples\ConsoleApp-IOStream\ConsoleApp-IOStream\myText3.txt";
	var text = File.ReadAllText(path);
    Console.WriteLine(text);
}
static void FileFunc6()
{
	var path = @"C:\Users\Sulaiman\Projects\DotNetProjects\C-Charp-practice-and-examples\ConsoleApp-IOStream\ConsoleApp-IOStream\myText4.txt";
	var text = "hello world! ";
	File.WriteAllText(path,text);
}
static void FileFunc7()
{
	using(var stream = File.Create("data.bin"))
	{
		using(var ds=new DeflateStream(stream, CompressionMode.Compress))
		{
			ds.WriteByte(65);
			ds.WriteByte(66);
		}
	}
	using(var stream = File.OpenRead("data.bin"))
	{
		using(var ds=new DeflateStream(stream, CompressionMode.Decompress))
		{
			for (int i = 0; i < stream.Length; i++)
			{
                Console.WriteLine((char)ds.ReadByte());
            }
		}
	}
}