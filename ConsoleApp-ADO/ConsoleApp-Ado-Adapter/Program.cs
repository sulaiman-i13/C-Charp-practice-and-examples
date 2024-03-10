using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;

var config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
string? constr = config.GetSection("ConnectionStrings").GetSection("default").Value;


SqlConnection connection = new SqlConnection(constr);
string sql = "select * from wallets";
var adapter = new SqlDataAdapter(sql,connection);
var dt = new DataTable();
adapter.Fill(dt);

foreach(DataRow row in dt.Rows)
{
    var wallet = new Wallet
    {
        Id = Convert.ToInt32(row["Id"]),
        Balance = Convert.ToDecimal(row["Balance"]),
        Holder = Convert.ToString(row["Holder"]),
    };
    Console.WriteLine(wallet);
}


