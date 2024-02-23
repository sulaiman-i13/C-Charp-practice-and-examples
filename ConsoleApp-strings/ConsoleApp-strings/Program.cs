using System.Text;

#region conversion to string example

//Console.WriteLine($"{"char",-12}{"binary",12}{"octal",12}{"dec",12}{"hex",12}");
//Console.WriteLine($"{"----",-12}{"------",12}{"-----",12}{"---",12}{"---",12}");
//for (byte i = 0; i < 255; i++)
//{
//	var ch = Convert.ToChar(i);
//var binary=Convert.ToString(i,2).PadLeft(8,'0');
//var octal=Convert.ToString(i,8).PadLeft(8, '0');
//	var dec=Convert.ToString(i,10).PadLeft(8, '0');
//	var hex=Convert.ToString(i,16).PadLeft(8, '0');
//	Console.WriteLine($"{ch,-12}{binary,12}{octal,12}{dec,12}{hex,12}");
//}
#endregion
#region string istansiation

////quoted string literals
//string str1="sulaiman";
//Console.WriteLine(	str1);

////constructor
//char[] letters = new char[] { 's','u','l','i','m','a','n' };
//var str2 = new string(letters);
//Console.WriteLine(str2);

////repeating character

//var str3 = new string('s', 10);
//Console.WriteLine(str3);


////pointer to char array
//string? str4 =null;
//unsafe
//{
//	fixed( char*  ptr = letters)
//	{
//		str4 = new string(ptr);
//        Console.WriteLine(str4);
//    }
//}

////pointer to bytearray
//string? str5=null;
//sbyte[] sbytes = new sbyte[] { 65, 66, 67, 68, 69 };
//unsafe
//{
//	fixed(sbyte* ptr= sbytes)
//	{
//		str5 = new string(ptr);
//        Console.WriteLine(str5);
//    }
//}

////conctination
//var str6 = "sula" + "iman";
//Console.WriteLine(str6);
//var str7 = $"{"sula"}{"iman"}";
//Console.WriteLine(str7);

#endregion
#region string formatting


//var sentence = "I am Sulaiman, I love web development with dot net";
//var index = sentence.IndexOf("Sulaiman");
//var str1 = sentence.Substring(index, 8);
//Console.WriteLine(str1);


//var str2 = string.Format(
//	"Hi, im Suliman." +
//	"I started to think of programming since {0:yyyy}," +
//	"but i didnt know how " +
//	"i bought my first pc in {1:yyyy}"
//	, new DateTime(2009), new DateTime(2008, 11, 22)
//	);
//Console.WriteLine(str2);

//var str3 = $"""
//	Hi, im Suliman.
//	I started to think of programming since {new DateTime(2009):yyyy}, 
//	but i didnt know how 
//	i bought my first pc in {new DateTime(2008, 11, 22):yyyy}
//	i spent {1100:c0}
//	""";

//Console.WriteLine(str3);
#endregion
#region string comparison


//var graphem1 = "\u0061";
//var graphem2 = "\u0308";
//var graphem12 = graphem1 + graphem2;
//var graphem3 = "\u00e4";
//Console.WriteLine(graphem1);
//Console.WriteLine(graphem2);
//Console.WriteLine(graphem12);
//Console.WriteLine(graphem3);
//Console.WriteLine(string.Equals(graphem12, graphem3, StringComparison.CurrentCulture));
//Console.WriteLine(string.Equals(graphem12, graphem3, StringComparison.Ordinal));
//Console.WriteLine(string.Equals(graphem12.Normalize(), graphem3.Normalize(), StringComparison.Ordinal));
#endregion
#region string intern pool

//var str1 = "sulaiman";
//var str2 = new string(str1);//when we use string constructor it
//							//goes and instanciate anew object directly without pass on string internpool
//							//so that they will have a different references in memory
//var str3 = string.Intern(str1);

//Console.WriteLine(str1 == str2);//true
//Console.WriteLine(string.ReferenceEquals(str1, str2));//false

//Console.WriteLine(str1 == str3);//true
//Console.WriteLine(string.ReferenceEquals(str1, str3));//true


//Console.WriteLine(str2 == str3);//true
//Console.WriteLine(string.ReferenceEquals(str2, str3));//false


#endregion
#region copyto
//var str1 = "sulaiman";
//var chArray = "full stack developer,00000000".ToCharArray();
//str1.CopyTo(0, chArray, chArray.Length-str1.Length, str1.Length);
//foreach(var ch in chArray) Console.Write(ch);
#endregion
#region compare
//var str1 = "Sulaiman";
//var str2 = "sulaiman";
//Console.WriteLine(string.Compare(str1, str2, true));//0
//Console.WriteLine(string.Compare(str1,str2,false));//1
//Console.WriteLine(string.Compare(str2,str1,false));//-1
#endregion
#region contains
//var str = "Sulaiman";
//Console.WriteLine(str.StartsWith("s",StringComparison.OrdinalIgnoreCase));
//Console.WriteLine(str.EndsWith("n",StringComparison.OrdinalIgnoreCase));
//Console.WriteLine(str.Contains("lai"));
//Console.WriteLine(str.IndexOf("m"));
#endregion
#region null or empty or white space
//var str1 = "";
//var str2 = " ";
//string? str3 = null;
//var str4 = string.Empty;
//Console.WriteLine($"{string.IsNullOrEmpty(str1)}");//true
//Console.WriteLine($"{string.IsNullOrEmpty(str2)}");//false
//Console.WriteLine($"{string.IsNullOrEmpty(str3)}");//true
//Console.WriteLine($"{string.IsNullOrEmpty(str4)}");//true


//Console.WriteLine($"{string.IsNullOrWhiteSpace(str1)}");//true
//Console.WriteLine($"{string.IsNullOrWhiteSpace(str2)}");//true
//Console.WriteLine($"{string.IsNullOrWhiteSpace(str3)}");//true
//Console.WriteLine($"{string.IsNullOrWhiteSpace(str4)}");//true

#endregion
#region string modify

//var str = "suaivajne";
//str = str.Insert(2, "l");//sulaivajne
//str = str.Replace("v", "m");//sulaimajne
//str = str.Remove(7, 1); //sulaimane
//str = str.Substring(0, 8);//sulaiman
//Console.WriteLine(str);
#endregion
#region case

//var str = "Sulaiman";
//Console.WriteLine(str.ToLower());
//Console.WriteLine(str.ToLowerInvariant());
//Console.WriteLine(str.ToUpper());
//Console.WriteLine(str.ToUpperInvariant());
#endregion
#region trim

//var str = "   sulaiman   ";
//var str2 = "+++sulaiman+++";
//Console.WriteLine(str.TrimStart());
//Console.WriteLine(str.TrimEnd());
//Console.WriteLine(str.Trim());
//Console.WriteLine(str2.TrimStart('+'));
//Console.WriteLine(str2.TrimEnd('+'));
//Console.WriteLine(str2.Trim('+'));
#endregion
#region to char array
//var str = "sulaiman";
//char[] chArray = str.ToCharArray();
//foreach (var item in chArray)
//{
//    Console.WriteLine(item);
//}
#endregion
#region splitting

//var str = "s u l a i m a n";
//string[] list = str.Split();
//foreach(var i in list) Console.WriteLine(i);
#endregion
#region join
//string[] arr = ["sulaiman", "ibrahem", "ismaeel",];
//var str = string.Join(" ", arr);
//Console.WriteLine(str);
#endregion
#region string builder example

//var sb = new StringBuilder();
//sb.Append(new char[] { 's', 'u', 'l' });
//sb.AppendFormat("{0}{1}{2}", "a", "i", "m");
//sb.Insert(6, "ann");
//sb.Replace("nn", "n");
//Console.WriteLine(sb.ToString());


#endregion

#region string builder length,capacity and max capacity

//var sb = new StringBuilder();//capacity 0
//Console.WriteLine($"length: {sb.Length}, capacity: {sb.Capacity}, max capacity: {sb.MaxCapacity} .");
//sb.Append("I am Suliman I. ,Web developer ."); //capacity 32
//Console.WriteLine($"length: {sb.Length}, capacity: {sb.Capacity}, max capacity: {sb.MaxCapacity} .");
//sb.Append(".");//capacity 64
//Console.WriteLine($"length: {sb.Length}, capacity: {sb.Capacity}, max capacity: {sb.MaxCapacity} .");
#endregion
#region instanciate string builder with capacity
//var sb = new StringBuilder(9);
//Console.WriteLine(sb.Capacity);
//sb.Append("Hi,this is sulaiman");
//Console.WriteLine(sb.Capacity);
//sb.Append("ASP.NET Core Web Developper");
//Console.WriteLine(sb.Capacity);
//sb.Append("Practic is the solution");
//Console.WriteLine(sb.Capacity);

//foreach (var chunk in sb.GetChunks())
//{
//    Console.WriteLine(chunk);
//}
#endregion
#region instanciate string builder a string and capacity
//var sb = new StringBuilder("Hello World, ",4);
//Console.WriteLine(sb.Capacity);
//sb.Append("Hi,this is sulaiman");
//Console.WriteLine(sb.Capacity);
//sb.Append("ASP.NET Core Web Developper");
//Console.WriteLine(sb.Capacity);

#endregion
#region instanciate string builder a string,index,length and capacity
//var sb = new StringBuilder("Hello World,this is sulaiman",20,8,7);
//Console.WriteLine(sb.Capacity);
//sb.Append("ASP.NET Core Web Developper");
//Console.WriteLine(sb.Capacity);

#endregion

#region string builer chaining append 
//var sb = new StringBuilder();
//sb.Append("Sulaiman ").Append("Ibrahem ").Append("Ismaeel.");
//Console.WriteLine(sb.ToString());

#endregion

#region string builer  append join, clear
//var sb = new StringBuilder();
//var arr = new string[] { "Sulaiman", "Ibrahem", "Ismaeel" };
//sb.AppendJoin(" ", arr);
//Console.WriteLine(sb.ToString());
//sb.Clear();
//sb.AppendJoin(" ", arr.Reverse());
//Console.WriteLine(sb.ToString());

#endregion

#region string builder chuncks

//var sb = new StringBuilder();
//sb.Append("Hi,this is sulaiman");
//Console.WriteLine(sb.Capacity);

//sb.Append("ASP.NET Core Web Developper");
//Console.WriteLine(sb.Capacity);

//sb.Append("Practic is the solution");
//Console.WriteLine(sb.Capacity);

//sb.Append("A claim is a statement about a subject by an issuer." +
//	" Claims represent attributes of the\r\nsubject that are useful" +
//	" in the context of authentication and authorization operations." +
//	"\r\nSubjects and issuers are both entities that are part of an " +
//	"identity scenario. Some typical\r\nexamples of a subject are:" +
//	" a user, an application or service, a device, or a computer");
//Console.WriteLine(sb.Capacity);
//foreach (var chunk in sb.GetChunks())
//{
//	Console.WriteLine($"chunk : {chunk} , length:{chunk.Length}");
//}
#endregion
#region string builder copyto
//var sb = new StringBuilder("sulaiman");
//char[] chars=new char[sb.Length];
//sb.CopyTo(0,chars,0,chars.Length);

//foreach (var item in chars)
//{
//    Console.WriteLine(item);
//}
#endregion
