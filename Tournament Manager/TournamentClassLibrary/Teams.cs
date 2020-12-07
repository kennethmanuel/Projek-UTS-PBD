using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentClassLibrary
{
    public class Teams
    {
        private int id;
        private string name;
        private double totalScore;

        #region Constructor
        public Teams(int id, string name, double totalScore)
        {
            this.Id = id;
            this.Name = name;
            this.TotalScore = totalScore;
        }
        #endregion

        #region Property
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public double TotalScore { get => totalScore; set => totalScore = value; }
        #endregion

        #region Methods
        /// <summary>
        /// Create a list of Teams object from a selected database with a specified criteria.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="criteriaValue"></param>
        /// <returns></returns>
        public static List<Teams> ReadData(string criteria, string criteriaValue)
        {
            string sql = "";

            if(criteria == "")
            {
                sql = "SELECT * FROM teams";
            }
            else
            {
                sql = "SELECT * FROM teams WHERE " + criteria + " LIKE '%" + criteriaValue + "%'";
            }

            MySqlDataReader value = Connection.ExecuteQuery(sql);

            List<Teams> teamList = new List<Teams>();

            while(value.Read() == true)
            {
                int teamId = int.Parse(value.GetValue(0).ToString());
                string teamName = value.GetValue(1).ToString();
                double totalScore = double.Parse(value.GetValue(2).ToString());

                Teams t = new Teams(teamId, teamName, totalScore);

                teamList.Add(t);
            }
            return teamList;
        }

        /// <summary>
        /// Create list of a Teams object from a selected database with all criteria selected.
        /// </summary>
        /// <param name="criteriaValue"></param>
        /// <returns></returns>
        public static List<Teams> BatchSearch(string criteriaValue)
        {
            string sql = "SELECT * FROM teams WHERE id LIKE '%" + criteriaValue + "%' OR name LIKE '%" + criteriaValue + "%'";

            MySqlDataReader value = Connection.ExecuteQuery(sql);

            List<Teams> teamList = new List<Teams>();

            while (value.Read() == true)
            {
                int teamId = int.Parse(value.GetValue(0).ToString());
                string teamName = value.GetValue(1).ToString();
                double totalScore = double.Parse(value.GetValue(2).ToString());

                Teams t = new Teams(teamId, teamName, totalScore);

                teamList.Add(t);
            }

            return teamList;
        }

        /// <summary>
        /// Add new team to database
        /// </summary>
        /// <param name="p"></param>
        public static void AddTeams(Teams t, Tournaments selectedTournament)
        {
            string sql = 
                // INSERT to teams
                "INSERT INTO teams(id, name, totalscore) " +
                "VALUES ('" + t.Id + "','"
                            + t.Name.Replace("'", "\\'") 
                            + "','" + t.totalScore + "'); " +
                // INSERT to tournamentEntry
                "INSERT INTO tournamententry " +
                "VALUES ('"+ selectedTournament.Id + "', '" + t.Id + "');";

            Connection.ExecuteDML(sql);
        }

        /// <summary>
        /// EditTeam from database
        /// </summary>
        /// <param name="t"></param>
        public static void EditTeams(Teams t)
        {
            string sql = "UPDATE teams " +
                         "SET name='" + t.Name.Replace("'", "\\'") + "' " +
                         "SET totalscore'" + t.TotalScore + "' " +
                         "WHERE id='" + t.Id + "'";

            Connection.ExecuteDML(sql);
        }

        /// <summary>
        /// Delete team
        /// </summary>
        /// <param name="team">Teaem that will be deleted</param>
        /// <param name="errorMessage">Error message for debugging</param>
        /// <returns></returns>
        public static bool DeleteTeams(Teams team, out string errorMessage)
        {
            errorMessage = "";

            string sql = 
                         // DELETE from Player
                         "DELETE FROM players " +
                         "WHERE team_id=" + team.Id + "; " +
                         // DELETE FROM TournamentEntry
                         "DELETE FROM tournamententry " +
                         "WHERE teams_id = " + team.Id + "; " +
                         // DELETE FROM Teams
                         "DELETE FROM Teams " +
                         "WHERE Id = '" + team.Id + "';";

            try
            {
                Connection.ExecuteDML(sql);
                return true;
            }
            catch (MySqlException ex)
            {
                errorMessage = ex.Message;
                return false;
            }
        }

        /// <summary>
        /// Generate new Id
        /// </summary>
        /// <returns></returns>
        public static string GenerateCode()
        {
            string sql = "SELECT MAX(Id) FROM Teams";
            int code;
            MySqlDataReader result = Connection.ExecuteQuery(sql);

            if (result.Read() == true)
            {
                code = int.Parse(result.GetValue(0).ToString()) + 1;
            }
            else
            {
                code = 1;
            }
            return code.ToString();
        }

        /// <summary>
        /// Select a team based on its id
        /// </summary>
        /// <param name="teamId"></param>
        /// <returns></returns>
        public static Teams SelectTeam(int teamId)
        {
            string sql = "SELECT * FROM teams t " +
                         "WHERE t.id=" + teamId;

            MySqlDataReader value = Connection.ExecuteQuery(sql);

            value.Read();

            string teamName = value.GetValue(1).ToString();
            double totalScore = double.Parse(value.GetValue(2).ToString());

            Teams t = new Teams(teamId, teamName, totalScore);

            return t;
        }
        
        #endregion
    }
}
