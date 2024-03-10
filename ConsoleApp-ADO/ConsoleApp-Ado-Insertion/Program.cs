using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;

var config=new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
string? constr = config.GetSection("ConnectionStrings").GetSection("default").Value;


SqlConnection connection = new SqlConnection(constr);
    Wallet wallet=new Wallet {Holder="Nabil",Balance=9000 };
string sql = "insert into wallets(Holder,Balance)values(@Holder,@Balance);" +
    "select cast(scope_identity() as int);";
SqlParameter holder = new SqlParameter
{
    ParameterName = "@Holder",
    Direction=ParameterDirection.Input,
    SqlDbType = SqlDbType.VarChar,
    Value=wallet.Holder

};
SqlParameter balance = new SqlParameter
{
    ParameterName = "@Balance",
    Direction=ParameterDirection.Input,
    SqlDbType = SqlDbType.Decimal,
    Value = wallet.Balance

};
SqlCommand command = new SqlCommand(sql,connection);
command.CommandType = CommandType.Text;
command.Parameters.Add(holder);
command.Parameters.Add(balance);
connection.Open();
var id =(int) command.ExecuteScalar();
wallet.Id = id;
Console.WriteLine(wallet);
connection.Close();

