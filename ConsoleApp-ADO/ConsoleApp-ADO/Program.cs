using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;

var config=new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
string? constr = config.GetSection("ConnectionStrings").GetSection("default").Value;


SqlConnection  connection = new SqlConnection(constr);
string sql = "select * from wallets";
SqlCommand command = new SqlCommand(sql,connection);
command.CommandType = CommandType.Text;
connection.Open();
SqlDataReader reader = command.ExecuteReader();
Wallet wallet;
while (reader.Read())
{
    //wallet = new Wallet
    //{
    //    Id = (int)reader["Id"],
    //    Balance = (decimal?)reader["Balance"],
    //    Holder = (string)reader["Holder"]
    //};
    wallet = new Wallet
    {
        Id = reader.GetInt32("Id"),
        Balance = reader.GetDecimal("Balance"),
        Holder = reader.GetString("Holder")
    };
    Console.WriteLine(  wallet);
}
connection.Close();

