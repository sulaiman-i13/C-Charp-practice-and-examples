using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;

var config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
string? constr = config.GetSection("ConnectionStrings").GetSection("default").Value;


SqlConnection connection = new SqlConnection(constr);
SqlCommand command = connection.CreateCommand();
connection.Open();
SqlTransaction transaction = connection.BeginTransaction();
command.Transaction = transaction;
SqlParameter id_from = new SqlParameter
{
    Direction = ParameterDirection.Input,
    ParameterName = "@id_from",
    SqlDbType = SqlDbType.Int,
    Value = 1
};
SqlParameter id_to = new SqlParameter
{
    Direction = ParameterDirection.Input,
    ParameterName = "@id_to",
    SqlDbType = SqlDbType.Int,
    Value = 2
};
SqlParameter balance = new SqlParameter
{
    Direction = ParameterDirection.Input,
    ParameterName = "@balance",
    SqlDbType = SqlDbType.Decimal,
    Value = 1000
};
command.Parameters.Add(id_from);
command.Parameters.Add(id_to);
command.Parameters.Add(balance);
try
{
    command.CommandText = "Update Wallets set Balance =Balance-@balance where Id =@id_from;";
    command.ExecuteNonQuery();
    command.CommandText = "Update Wallets set Balance =Balance+@balance where Id =@id_to;";
    command.ExecuteNonQuery();

    transaction.Commit();
}
catch
{
    try
    {
        transaction.Rollback();
    }
    catch 
    {

        //logging
    }
}
finally
{
    try
    {
        connection.Close();
    }
    catch { }
}


