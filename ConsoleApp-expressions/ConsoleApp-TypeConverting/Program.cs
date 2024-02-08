Console.WriteLine("==========BitConverter==============");

int num = 4000;
byte[] bits = BitConverter.GetBytes(num);
foreach (var item in bits)
{
	Console.WriteLine(item);
}
Console.WriteLine("===========binary=============");
foreach (var item in bits)
{
	Console.WriteLine(Convert.ToString(item, 2).PadLeft(8, '0'));
}
Console.WriteLine("===========CharArray=============");
var name = "sulaiman";
var nameArr = name.ToCharArray();
foreach (var item in nameArr) Console.WriteLine(item);
Console.WriteLine("===========ascii in decimal=============");

foreach (var item in nameArr)
	Console.WriteLine(Convert.ToInt32(item));
Console.WriteLine("===========ascii in hex=============");

foreach (var item in nameArr)
	Console.WriteLine(Convert.ToString(Convert.ToInt32(item),16));
Console.WriteLine("===========ascii to char=============");
var ascii = "73,75,6c,61,69,6d,61,6e".Split(",");
foreach(var item in ascii)
{
	var i = Convert.ToInt32(item, 16);
    Console.WriteLine((char)i);
}
Console.WriteLine("===========hex to decimal=============");
var _hex1 = "b82";
var _hex2 = "ff";
int dec1 = Convert.ToInt32(_hex1, 16);
int dec2 = Convert.ToInt32(_hex2, 16);
int dec3 = int.Parse(_hex2, System.Globalization.NumberStyles.HexNumber);
Console.WriteLine(dec1);
Console.WriteLine(dec2);
Console.WriteLine(dec3);
