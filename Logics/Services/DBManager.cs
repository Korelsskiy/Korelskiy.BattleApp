using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Logics
{
    public class DBManager
    {
        private readonly SqlConnection connection;
        public static List<string> GermanNames { get; } = new List<string>();
        public static List<string> GermanLastNames { get; } = new List<string>();
        public static List<string> USSRNames { get; } = new List<string>();
        public static List<string> USSRLastNames { get; } = new List<string>();
        
        public DBManager()
        {
            connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BattleAppDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

            GetNames();

            GetLastNames();
        }
        public void GetNames()
        {
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM Names", connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string germanName = reader["GermanName"].ToString();
                    string ussrName = reader["USSRName"].ToString();

                    GermanNames.Add(germanName);
                    USSRNames.Add(ussrName);
                }

                reader.Close();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        public void GetLastNames()
        {
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM LastNames", connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string germanLastName = reader["GermanLastName"].ToString();
                    string ussrLastName = reader["USSRLastName"].ToString();

                    GermanLastNames.Add(germanLastName);
                    USSRLastNames.Add(ussrLastName);
                }

                reader.Close();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
