using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
// using Microsoft.Data.SqlClient;

namespace EmployeeClock.DAL
{
    public class DBcontext
    {

         //"Server=DAVID-ADLER;Database=company1;User Id=sa;Password= 1234;";
        // Data Source=DAVID-ADLER;User ID=sa;Password=1234;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False
        private string _connectionString;
        public DBcontext()
        {
            _connectionString = GetConnString();
        }

        private string GetConnString()
        {
            IConfiguration builder = new ConfigurationBuilder()
             .AddJsonFile("secret.json", optional: true) // Add secrets.json
             .Build();

            string cs = builder["ConnectionString"];
            if (string.IsNullOrEmpty(cs)) throw new Exception("Cannot read conn string from secrets");
            return cs!;
        }
        public DataTable MakeQuery(string query)
        {
            DataTable output = new DataTable();
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    try
                    {
                        conn.Open();
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(output);
                        }
                    }
                    catch (SqlException ex) { 
                    Console.WriteLine("an error" + ex.Message);
                    }
                }
            }
        return output;
        }
        public DataTable AdapterQuery(string query)
        {
            DataTable output = new DataTable();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    Task.Run(() => adapter.Fill(output));


                }
                catch (Exception ex)
                {
                    Console.WriteLine("an error" + ex.Message);

                }
                return output;
            }
        }
        public SqlDataReader CommandReader(string query)
        {
            SqlDataReader output = null;

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand comm = new SqlCommand(query, conn);
                     output = comm.ExecuteReader();
                    //Load(output);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("an error" + ex.Message);

                }

            }
            return output;
        }

        public int CommandNonQuery(string query)
        {
            int output = -1;
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand comm = new SqlCommand(query, conn);
                    output = comm.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    Console.WriteLine("an error" + ex.Message);

                }
            }
        return output;
        }

        public int? CommandScalar(string query)
        {
            int? output = -1;
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand comm = new SqlCommand(query, conn);
                    output = (int?)comm.ExecuteScalar();

                }
                catch (Exception ex)
                {
                    Console.WriteLine("an error" + ex.Message);

                }
            }
            return output;
        }

    }
}
