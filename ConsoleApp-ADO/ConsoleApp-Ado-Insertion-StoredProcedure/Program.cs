using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;

var config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
string? constr = config.GetSection("ConnectionStrings").GetSection("default").Value;


SqlConnection connection = new SqlConnection(constr);
Wallet wallet = new Wallet { Holder = "Basel", Balance = 26000 };
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
SqlCommand command = new SqlCommand("AddWallet", connection);
command.CommandType = CommandType.StoredProcedure;
command.Parameters.Add(holder);
command.Parameters.Add(balance);
connection.Open();
command.ExecuteNonQuery();
connection.Close();

