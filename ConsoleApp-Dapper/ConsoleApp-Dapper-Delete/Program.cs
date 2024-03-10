using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;

var config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
string constr = config.GetSection("ConnectionStrings").GetSection("default").Value!;
IDbConnection db = new SqlConnection(constr);

#region delete
string sql = "delete from wallets where id=@id";
db.Execute(sql, new { id=1010});
#endregion
