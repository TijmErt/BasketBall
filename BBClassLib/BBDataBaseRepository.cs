using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBClassLib
{
    public class BBDataBaseRepository
    {
        private static SqlConnection databaseConnection = new SqlConnection("Server=mssqlstud.fhict.local;Database=dbi486333_basketbal;User Id=dbi486333_basketbal;Password=Basketbal");

        public BBDataBaseRepository()
        {

        }

        private SqlDataReader QueryForDataBase(string Query)
        {
            SqlCommand cmd = new SqlCommand(Query, databaseConnection);
            cmd.CommandTimeout = 60;

            if (databaseConnection.State == ConnectionState.Open)
            {
                databaseConnection.Close();
            }

            databaseConnection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            return (reader);
            
        }
        public SqlDataReader GetClubData()
        {
            return QueryForDataBase("SELECT * FROM Club");
        }
        public SqlDataReader GetLeeftijdsCatagorieData()
        {
            return QueryForDataBase("SELECT * FROM LeeftijdsCategorieën");
        }

        public SqlDataReader GetGebruikerData()
        {
            return QueryForDataBase("SELECT * From Gebruiker");
        }

        public SqlDataReader GetTeamData()
        {
            return QueryForDataBase("SELECT * From Team");
        }

        public SqlDataReader GetSpecificData(string query)
        {
            return QueryForDataBase(query);
        }

        public SqlDataReader UpdateSpecificData(string query)
        {
            return QueryForDataBase(query);
        }
    }
}
