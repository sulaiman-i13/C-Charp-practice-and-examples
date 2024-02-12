
using ConsoleApp_Attributes;
using System.Reflection;
//to how debugger attribute

var update = new Update(1, "first update");
var update2 = new Update(1, "first update");

var players = new List<Player>
{
	new Player{Name="Sulaiman",BallControle=15,Dribbling=40},
	new Player{Name="tony",BallControle=14,Dribbling=60},
	new Player{Name="Sami",BallControle=100,Dribbling=50},
	new Player{Name="Maher",BallControle=19,Dribbling=90},
};
var errors = new List<Error>();
foreach (var player in players)
{
	var props = player.GetType().GetProperties();
	
	foreach (var prop in props)
	{
		
		var skillAttr = prop.GetCustomAttribute<SkillAttribute>();
		if(skillAttr != null)
		{
			if (!skillAttr.IsValid(prop.GetValue(player)))
			{
				errors.Add(new Error(prop.Name, $"value must be in {skillAttr.Min} - {skillAttr.Max}"));
			}
		}
	}
	if (errors.Count > 0)
	{
		foreach (var item in errors)
		{
            Console.WriteLine(item);
        }
	}
	else
	{
        Console.WriteLine($"Player {player.Name} info is Valid");
    }
}