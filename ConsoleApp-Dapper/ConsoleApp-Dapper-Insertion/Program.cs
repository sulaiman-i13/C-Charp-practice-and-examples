using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;

var config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
string constr = config.GetSection("ConnectionStrings").GetSection("default").Value!;
IDbConnection db = new SqlConnection(constr);

#region insert
//string sql = "insert into wallets(holder,balance)values(@holder,@balance)";
//db.Execute(sql, new { holder="Sami",balance=20000m});
#endregion
#region insert with id  return
var wallet = new Wallet { Holder = "Mazen", Balance = 14000m };
string sql2 = "insert into wallets(holder,balance)values(@holder,@balance);" +
    "select cast(scope_identity() as int);";
wallet.Id=db.Query<int>(sql2, new { holder = wallet.Holder, balance = wallet.Balance }).SingleOrDefault();
//wallet.Id=db.Query<int>(sql2, new { holder = wallet.Holder, balance = wallet.Balance }).FirstOrDefault();
Console.WriteLine(wallet);

#endregion