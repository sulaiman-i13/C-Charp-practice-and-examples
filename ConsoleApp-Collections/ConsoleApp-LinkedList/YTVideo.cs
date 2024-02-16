class YTVideo
{
	public YTVideo(string name, string description, double duration)
	{
		Name = name;
		Description = description;
		Duration = duration;
	}
	public override string ToString()
	{
		return $"{Name} - {Description} [{Duration} h]";
	}
	public string Name { get; set; }
	public string Description { get; set; }
	public double Duration { get; set; }
}