Console.WriteLine($"===================================Indexers===================================");
//indexer example
var ipAsText = "192.168.1.1";
var ip = new Ip(ipAsText.Split("."));
Console.WriteLine($"first segment: {ip[0]}");
Console.WriteLine($"second segment: {ip[1]}");
Console.WriteLine($"third segment: {ip[2]}");
Console.WriteLine($"fourth segment: {ip[3]}");
class Ip
{
	private readonly string[] _ipSegments;
	public string this[int segNumber]
	{
		set
		{
			_ipSegments[segNumber] = value;
		}
		get
		{
			return _ipSegments[segNumber];
		}
	}
	public Ip(string[] ipSegments)
	{
		_ipSegments = ipSegments;
	}
}