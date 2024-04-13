using ConsoleApp.EF.SaveData.Data;
using ConsoleApp.EF.SaveData.Entities;
using ConsoleApp.EF.SaveData.Helpers;
using Microsoft.EntityFrameworkCore;

#region basic save

//DatabaseHelper.RecreateCleanDatabase();
//using (var context = new AppDbContext())
//{
//    var author = new Author
//    {
//        Id = 13,
//        FName = "Suliman",
//        LName = "Ismaeel"
//    };
//    context.Authors.Add(author);
//    context.SaveChanges();
//}
#endregion


#region basic update


//using (var context = new AppDbContext())
//{
//    var author = context.Authors.FirstOrDefault(a=>a.Id==13);
//        author.FName = "Suliman I.";

//    context.SaveChanges();
//}
#endregion
#region basic delete


//using (var context = new AppDbContext())
//{
//    var author = context.Authors.FirstOrDefault(a => a.Id == 13);
//    context.Authors.Remove(author);
//    context.SaveChanges();
//}
#endregion

#region basic update


//using (var context = new AppDbContext())
//{
//    var author = context.Authors.FirstOrDefault(a => a.Id == 13);

//    context.SaveChanges();
//}
#endregion

#region basic multiple operation with single save

//DatabaseHelper.RecreateCleanDatabase();
//using (var context = new AppDbContext())
//{
//    var author1 = new Author { Id = 1, FName = "suliaman", LName = "ismael" };
//    context.Authors.Add(author1);
//    var author2 = new Author { Id = 2, FName = "azam", LName = "salameh" };
//    context.Authors.Add(author2);
//    var author3 = new Author { Id = 3, FName = "khalil", LName = "mahmoud" };
//    context.Authors.Add(author3);

//    context.SaveChanges();
//}
#endregion

#region basic add related entity


//using (var context = new AppDbContext())
//{
//    var author = context.Authors.FirstOrDefault(a => a.Id == 1);
//    author.Books.Add(new Book { Id = 1, Title = "Book #1", });
//    context.SaveChanges();
//}
#endregion

#region as tracked entity


//using (var context = new AppDbContext())
//{
//    Console.WriteLine("at first=============");
//    Console.WriteLine(context.ChangeTracker.DebugView.LongView);
//    var author = context.Authors.FirstOrDefault(a => a.Id == 1);
//    Console.WriteLine("after query=============");
//        Console.WriteLine(context.ChangeTracker.DebugView.LongView);
//    author.FName = "Suliaman";
//    Console.WriteLine("after edit=============");
//    context.Entry(author).State = EntityState.Modified;
//    Console.WriteLine(context.ChangeTracker.DebugView.LongView);
//    context.SaveChanges();
//    Console.WriteLine("after save changes=============");
//    Console.WriteLine(context.ChangeTracker.DebugView.LongView);
//}
#endregion

#region as no tracked entity


//using (var context = new AppDbContext())
//{
//    Console.WriteLine("at first=============");
//    Console.WriteLine(context.ChangeTracker.DebugView.LongView);
//    var author = context.Authors.FirstOrDefault(a => a.Id == 1);
//    Console.WriteLine("after query=============");
//    Console.WriteLine(context.ChangeTracker.DebugView.LongView);
//   }
#endregion

#region attach object
//using (var context =new AppDbContext())
//{
//var author = new Author { Id = 1, FName = "suliaman", LName = "ismael" };
//    context.Attach(author);
//    author.FName = "Suliman I.";
//    context.SaveChanges();
//}

#endregion

#region Update() by default attach the object if its state is deattached
//using (var context = new AppDbContext())
//{
//    var author = new Author { Id = 1, FName = "suliaman", LName = "ismael" };
//    context.Update(author);
//    Console.WriteLine(context.ChangeTracker.DebugView.LongView);
//    context.SaveChanges();
//    Console.WriteLine(context.ChangeTracker.DebugView.LongView);

//}

#endregion
#region delete principle
//using (var context = new AppDbContext())
//{
//    DatabaseHelper.RecreateCleanDatabase();
//    DatabaseHelper.PopulateDatabase();
//    var author = new Author { Id = 1 };
//    context.Remove(author);
//    Console.WriteLine(context.ChangeTracker.DebugView.LongView);
//    context.SaveChanges();
//    Console.WriteLine(context.ChangeTracker.DebugView.LongView);

//}

#endregion
#region delete principle quered by another context
//using (var context = new AppDbContext())
//{
//    DatabaseHelper.RecreateCleanDatabase();
//    DatabaseHelper.PopulateDatabase();
//    var book = DatabaseHelper.GetDisconnectedBook();
//    context.Attach(book);
//    context.Remove(book);
//    Console.WriteLine(context.ChangeTracker.DebugView.LongView);
//    context.SaveChanges();
//    Console.WriteLine(context.ChangeTracker.DebugView.LongView);

//}
#endregion

#region excuteUpdate
using (var context = new AppDbContext())
{
    context.Books.Where(b => b.AuthorId == 1)
        .ExecuteUpdate(
        p => p.SetProperty(
            b => b.Title,
            b => b.Title.ToUpper()
            )
        );
}
#endregion

#region excuteDelete
using (var context = new AppDbContext())
{
    context.Books.Where(b => b.Title.StartsWith("Book")).ExecuteDelete();
}
#endregion