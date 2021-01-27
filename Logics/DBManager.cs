using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Logics
{
    public class DBManager
    {
        public List<string> GermanNames { get; } = new List<string>();
        public List<string> GermanLastNames { get; } = new List<string>();
        public List<string> USSRNames { get; } = new List<string>();
        public List<string> USSRLastNames { get; } = new List<string>();
        private readonly SqlConnection connection;
        public DBManager()
        {
            connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BattleAppDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

            GetNames();

            GetLastNames();
        }
        private void GetNames()
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

        private void GetLastNames()
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
