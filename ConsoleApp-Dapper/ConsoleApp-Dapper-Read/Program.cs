using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;

var config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
string constr = config.GetSection("ConnectionStrings").GetSection("default").Value!;
IDbConnection db = new SqlConnection(constr);

#region read dynamic
string sql = "select * from wallets";
foreach (var item in db.Query(sql))//return a sequence of dynamic objects
{
    Console.WriteLine(item);
}
#endregion

#region read typed
string sql2 = "select * from wallets";
foreach (var wallet in db.Query<Wallet>(sql2))//return a sequence of dynamic objects
{
    Console.WriteLine(wallet);
}
#endregion

#region read multiple
string sql3 = "select Min(balance) from wallets;" +
    "select Max(balance) from wallets;";
var multi = db.QueryMultiple(sql3);
//Console.WriteLine($"min: {multi.ReadSingle<decimal>()} max: {multi.ReadSingle<decimal>()}");
Console.WriteLine($"min: {multi.Read<decimal>().Single()} max: {multi.Read<decimal>().Single()}");
#endregion
