using ConsoleApp.EF.Migrations.Entities;

//using (var context = new AppDbContext())
//{
//    Participant p1 = new Coporate { Id = 7, FName = "a", LName = "a",Company="c",JobTitle="j" };
//    Participant p2 = new Coporate { Id = 5, FName = "a", LName = "a",Company="c",JobTitle="j" };
//    Participant p3 = new Coporate { Id = 6, FName = "a", LName = "a",Company="c",JobTitle="j" };


//    context.Participants.AddRange([p1, p2, p3]);
//    context.SaveChanges();
//}
using (var context = new AppDbContext())
{
	//Console.WriteLine(context.Participants.First().FName);
	foreach (var item in context.Participants.OfType<Coporate>())
	{
		Console.WriteLine(item.FName);
	}
}