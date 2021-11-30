using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace Usecase
{
    public class DataProvider
    {
        //private string connectionSTR = @"Data Source=.\SQLEXPRESS;Initial Catalog=QLNHAHANG;Integrated Security=True";
        //private string connectionSTR = @"Data Source=(localdb)\ProjectsV13; Initial Catalog=QLNHAHANG";
        private String connectionSTR = "server=.; database=QLNHAHANG;integrated security=true";
        public DataTable ExecuteQuery(string query)
        {
            DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                //command.Connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
                connection.Close();
                //command.Connection.Close();
            }
            return data;
        }

        public int ExecuteNonQuery(string query)
        {
            int data = 0;
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                //command.Connection.Open();
                data = command.ExecuteNonQuery();
                connection.Close();
                //command.Connection.Close();
            }
            return data;
        }

        public object ExecuteScalar(string query)
        {
            object data = 0;
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                //command.Connection.Open();
                data = command.ExecuteScalar();
                connection.Close();
                //command.Connection.Close();
            }
            return data;
        }
    }
}