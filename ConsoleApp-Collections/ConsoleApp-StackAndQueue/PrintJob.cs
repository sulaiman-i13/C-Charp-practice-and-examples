class PrintJob
{
    public string Text { get; set; }

	public PrintJob(string text)
	{
		Text = text;
	}
	public override string ToString()
	{
		return Text;
	}
}