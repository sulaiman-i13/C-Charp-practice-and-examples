using System;
using System.Reflection;

var type = typeof(Program);
Console.WriteLine($"type: {type}");
Console.WriteLine($"assembly:  {type.Assembly}");
Console.WriteLine($"FullName:  {type.Assembly.FullName}");
Console.WriteLine($"CodeBase:  {type.Assembly.CodeBase}");
Console.WriteLine($"Location:  {type.Assembly.Location}");
Console.WriteLine("=====================Assembly========================");
Console.WriteLine($"Assembly.GetExecutingAssembly() : {Assembly.GetExecutingAssembly()}");
Console.WriteLine($"Assembly.GetCallingAssembly() : {Assembly.GetCallingAssembly()}");
Console.WriteLine($"Assembly.GetEntryAssembly() : {Assembly.GetEntryAssembly()}");
Console.WriteLine("========================GetName()=====================");
Console.WriteLine($"FullName: {type.Assembly.GetName().FullName}");
Console.WriteLine($"Version: {type.Assembly.GetName().Version}");
Console.WriteLine($"Name: {type.Assembly.GetName().Name}");
Console.WriteLine($"GetPublicKeyToken: {type.Assembly.GetName().GetPublicKeyToken}");
Console.WriteLine($"CodeBase: {type.Assembly.GetName().CodeBase}");
Console.WriteLine( "========reource================");
var stream=type.Assembly.GetManifestResourceStream("ConsoleApp-Assemblies.countries.json");
var br = new BinaryReader(stream).ReadBytes((int)stream.Length) ;
foreach (var item in br)
{
    Console.WriteLine((char)item);
}
stream.Close();
