
///code used in scaffolding:
///Nuget console
///Scaffold - DbContext 'data source=.;initial catalog=TechTalk;trustservercertificate=true;integrated security=sspi;'
///'Microsoft.EntityFrameworkCore.SqlServer' 
///-context AppDbContext 
///-contextDir Data
///-OutputDir Entities

///dotnet cli
///dotnet ef dbcontext scaffold 
///'data source=.;initial catalog=TechTalk;trustservercertificate=true;integrated security=sspi;'
///Microsoft.EntityFrameworkCore.SqlServer 
///--data-annotations 
///--output-dir Entities 
///--context-dir Data 
///--context AppDbContext
Console.WriteLine("Hi");

//foreach (var item in new AppDbContext().Speakers)
//{
//    Console.WriteLine(item.FirstName);
//}