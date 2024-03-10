using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;

var config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
string constr = config.GetSection("ConnectionStrings").GetSection("default").Value!;
IDbConnection db = new SqlConnection(constr);

#region update
var walletToUpdate = new Wallet { Id = 1019, Holder = "Lama",Balance=17000m };
string sql = "update wallets set holder=@holder,balance=@balance where id=@id;";
db.Execute(sql, new { id= walletToUpdate.Id, holder = walletToUpdate.Holder, balance = walletToUpdate.Balance});
#endregion
