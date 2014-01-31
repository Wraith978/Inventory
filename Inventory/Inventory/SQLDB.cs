using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Inventory
{
    public class SQLDB //this class contains basic functions to interact with the sql database
    {
        const string connectionString = "Data Source=uzumaki\\sqlexpress;Initial Catalog=Inventory;Integrated Security=True"; //todo: put in connection string

        public static void doSQL(string commandText, string[] parameterNames, SqlDbType[] parameterTypes, object[] parameters, int numParameters)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(commandText, connection);

                for (int i = 0; i < numParameters; i++ )
                {
                    command.Parameters.Add("@" + parameterNames[i], parameterTypes[i]);
                    command.Parameters["@" + parameterNames[i]].Value = parameters[i];
                }
                try
                {
                    connection.Open();
                    Int32 rowsAffected = command.ExecuteNonQuery();
                    Console.WriteLine("RowsAffected: {0}", rowsAffected);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public static SqlDataReader doSQLSelect(string commandText, string[] parameterNames, SqlDbType[] parameterTypes, object[] parameters, int numParameters)
        {
            SqlDataReader reader = null;
            SqlConnection connection = new SqlConnection(connectionString);
            //using (SqlConnection connection = new SqlConnection(connectionString))
            //{
                SqlCommand command = new SqlCommand(commandText, connection);

                for (int i = 0; i < numParameters; i++)
                {
                    command.Parameters.Add("@" + parameterNames[i], parameterTypes[i]);
                    command.Parameters["@" + parameterNames[i]].Value = parameters[i];
                }
                try
                {
                    connection.Open();
                    reader = command.ExecuteReader();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                return reader;
           // }
        }

    }
}
