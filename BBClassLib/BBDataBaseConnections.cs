using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBClassLib
{
    public class BBDataBaseConnections
    {
        private static SqlConnection databaseConnection = new SqlConnection("Server=mssqlstud.fhict.local;Database=dbi486333_basketbal;User Id=dbi486333_basketbal;Password=Basketbal");
        public BBDataBaseConnections()
        {

        }

        private SqlDataReader GetQueryFromDataBase(string Query)
        {
            SqlCommand cmd = new SqlCommand(Query, databaseConnection);
            cmd.CommandTimeout = 60;
            SqlDataReader reader;
            databaseConnection.Open();
            reader = cmd.ExecuteReader();
            return (reader);
        }

        public SqlDataReader GetPlayersInfoFromTeam(int gebruikerID)
        {
            return GetQueryFromDataBase("SELECT Gebruiker.FirstName, Gebruiker.LastName, DATEDIFF(year, BirthDate, GETDATE()) as leeftijd as leeftijd,  Club.ClubName FROM Gebruiker, Club WHERE Gebruiker.ID = '" + gebruikerID + "' ");
        }

        public SqlDataReader UpdatePlayersAssosciatedTeam()
        {
            return GetQueryFromDataBase("UPDATE");
        }
        public SqlDataReader ComboBoxTeamData(int TeamID)
        {
            return GetQueryFromDataBase("SELECT team.TeamName, Team.ID FROM Team, Club WHERE Team.Club_ID = Club.ID");
        }
        public SqlDataReader ComboBoxClubData(int TeamID)
        {
            return GetQueryFromDataBase("SELECT Club.ClubName, club.ID FROM Club");
        }

    }
}
