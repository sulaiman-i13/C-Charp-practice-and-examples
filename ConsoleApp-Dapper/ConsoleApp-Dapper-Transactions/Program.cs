using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Transactions;

var config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
string constr = config.GetSection("ConnectionStrings").GetSection("default").Value!;
IDbConnection db = new SqlConnection(constr);

using(var transactionScope=new TransactionScope())
{
    var amountToTransfer = 7000m;
    var sqlReadFrom= "select * from wallets where id=@id";
    var sqlReadTo = "select * from wallets where id=@id";

    var wallet1 = db.QuerySingle<Wallet>(sqlReadFrom, new { id = 1 });
    var wallet2 = db.QuerySingle<Wallet>(sqlReadTo, new { id = 2 });
    var sqlUpdateFrom = "update wallets set balance=@balance where id=@id";
    var sqlUpdateTo = "update wallets set balance=@balance where id=@id";
    db.Execute(sqlUpdateFrom, new { id = wallet1.Id, balance = wallet1.Balance - amountToTransfer });
    db.Execute(sqlUpdateTo, new { id = wallet2.Id, balance = wallet2.Balance + amountToTransfer });
    transactionScope.Complete();

}