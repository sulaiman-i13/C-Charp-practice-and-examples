using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;

var config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
string? constr = config.GetSection("ConnectionStrings").GetSection("default").Value;


SqlConnection connection = new SqlConnection(constr);
string sql = "delete from wallets  where Id=@Id;";

SqlParameter id = new SqlParameter
{
    ParameterName = "@Id",
    Direction = ParameterDirection.Input,
    SqlDbType = SqlDbType.Int,
    Value = 1008

};
SqlCommand command = new SqlCommand(sql, connection);
command.CommandType = CommandType.Text;
command.Parameters.Add(id);
connection.Open();
command.ExecuteNonQuery();
connection.Close();

