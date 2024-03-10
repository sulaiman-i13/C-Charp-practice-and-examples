using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;

var config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
string? constr = config.GetSection("ConnectionStrings").GetSection("default").Value;


SqlConnection connection = new SqlConnection(constr);
Wallet wallet = new Wallet { Id=1003,Holder = "Rafi", Balance = 9000 };
string sql = "update wallets set Holder=@Holder,Balance=@Balance where Id=@Id;";
SqlParameter holder = new SqlParameter
{
    ParameterName = "@Holder",
    Direction = ParameterDirection.Input,
    SqlDbType = SqlDbType.VarChar,
    Value = wallet.Holder

};
SqlParameter balance = new SqlParameter
{
    ParameterName = "@Balance",
    Direction = ParameterDirection.Input,
    SqlDbType = SqlDbType.Decimal,
    Value = wallet.Balance

};
SqlParameter id = new SqlParameter
{
    ParameterName = "@Id",
    Direction = ParameterDirection.Input,
    SqlDbType = SqlDbType.Int,
    Value = wallet.Id

};
SqlCommand command = new SqlCommand(sql, connection);
command.CommandType = CommandType.Text;
command.Parameters.Add(holder);
command.Parameters.Add(balance);
command.Parameters.Add(id);
connection.Open();
command.ExecuteNonQuery();
connection.Close();

