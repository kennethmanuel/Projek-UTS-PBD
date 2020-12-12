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
        public Teams(int id, string name, double totalScore = 0)
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
        /// <param name="criteria">Search criteria for team (ex: "id" or "name")</param>
        /// <param name="criteriaValue">Search value for selected criteria (ex: "1" or "team secret")</param>
        /// <returns></returns>
        public static List<Teams> ReadData(string criteria = "", string criteriaValue = "")
        {
            string sql;

            if(criteria == "")
            {
                sql = "SELECT * " +
                      "FROM teams";
            }
            else
            {
                sql = "SELECT * " +
                      "FROM teams " +
                      "WHERE " + criteria + " " +
                      "LIKE '%" + criteriaValue + "%'";
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
        /// Create list of team from all tournament.
        /// </summary>
        /// <param name="criteriaValue">Search value from all criteria.</param>
        /// <returns>List of team with selected criteria.</returns>
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
        /// Add team to specific tournament.
        /// </summary>
        /// <param name="team">Team that will be added.</param>
        /// <param name="selectedTournament">Selected tournament.</param>
        public static void AddTeams(Teams team, Tournaments selectedTournament)
        {
            string sql = 
                // INSERT to teams
                "INSERT INTO teams(id, name, totalscore) " +
                "VALUES ('" + team.Id + "','"
                            + team.Name.Replace("'", "\\'") 
                            + "','" + team.totalScore + "'); " +
                // INSERT to tournamentEntry
                "INSERT INTO tournamententry " +
                "VALUES ('"+ selectedTournament.Id + "', '" + team.Id + "');";

            Connection.ExecuteDML(sql);
        }

        /// <summary>
        /// EditTeam from database
        /// </summary>
        /// <param name="teams"></param>
        public static void EditTeams(Teams teams)
        {
            string sql = "UPDATE teams " +
                         "SET name ='" + teams.Name.Replace("'", "\\'") + "', " +
                             "totalscore ='" + teams.TotalScore + "' " +
                         "WHERE id='" + teams.Id + "'";

            Connection.ExecuteDML(sql);
        }

        /// <summary>
        /// Edit Point from database
        /// </summary>
        /// <param name="teams"></param>
        public static void EditPoint(Teams teams)
        {
            string sql = "UPDATE teams " +
                         "SET totalscore ='" + teams.TotalScore + "' " +
                         "WHERE id='" + teams.Id + "'";

            Connection.ExecuteDML(sql);
        }

        /// <summary>
        /// Delete specific team.
        /// </summary>
        /// <param name="teamId">Team that will be deleted's id.</param>
        /// <param name="errorMessage">Error message for debugging.</param>
        /// <returns>Return true if success, false otherwise.</returns>
        public static bool DeleteTeams(int teamId, out string errorMessage)
        {
            errorMessage = "";

            string sql = 
                         // DELETE from Player
                         "DELETE FROM players " +
                         "WHERE team_id=" + teamId + "; " +
                         // DELETE FROM TournamentEntry
                         "DELETE FROM tournamententry " +
                         "WHERE teams_id = " + teamId + "; " +
                         // DELETE FROM Teams
                         "DELETE FROM Teams " +
                         "WHERE Id = '" + teamId + "';";

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
        /// Generate new team Id.
        /// </summary>
        /// <returns>New id for team.</returns>
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
        /// Select a team with specific id.
        /// </summary>
        /// <param name="teamId">Team's id that will be selected</param>
        /// <returns>Return a team corresponding selected team id</returns>
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
