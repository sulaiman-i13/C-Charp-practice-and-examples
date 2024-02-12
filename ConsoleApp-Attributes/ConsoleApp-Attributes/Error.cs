internal class Error
{
	public Error(string name,string message)
	{
		Message = message;
		Name = name;
	}

	public string Name { get; set; }
    public string Message { get; set; }
	public override string ToString()
	{
		return $"{Name} {Message}";
	}
}