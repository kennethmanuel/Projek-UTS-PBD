using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentClassLibrary
{
    /// <summary>
    /// Matchups show what team which team win a matchupentry
    /// </summary>
    public class Matchups
    {
        #region Data Member
        private string id;        
        private int round;
        #endregion

        #region Constructor
        public Matchups(string id, int round)
        {
            this.Id = id;         
            this.Round = round;
        }
        #endregion

        #region Property
        public string Id { get => id; set => id = value; }
        public int Round { get => round; set => round = value; }      
        #endregion

        #region Method
        /// <summary>
        /// Create list of matchups.
        /// </summary>
        /// <param name="criteria">Criteria for search (id, winnerid, round, winner_name, winner_totalscore).</param>
        /// <param name="criteriaValue"></param>
        /// <returns></returns>
        public static List<Matchups> ReadData(Tournaments selectedTournament, string criteriaValue = "")
        {
            int tournamentId = selectedTournament.Id;
            string sql;

            if (criteriaValue == "")
            {
                sql = "SELECT m.id, m.round " +
                      "FROM matchup m " +                      
                      "WHERE m.id IN (SELECT teams_id " +
                                     "FROM tournamententry " +
                                     "WHERE tournaments_id = " + tournamentId + ")";
            }
            else
            {
                sql = "SELECT m.id, m.round, t.name , t.totalscore " +
                      "FROM matchup m " +
                      "INNER JOIN teams t ON m.teamid = t.id " +
                     "WHERE t.id IN (SELECT teams_id " +
                                     "FROM tournamententry " +
                                     "WHERE tournaments_id = " + tournamentId + ")" + 
                      "AND (m.id LIKE '%" + criteriaValue + "%' " +                    
                      "OR m.round LIKE '%" + criteriaValue + "%' " +
                      "OR t.name LIKE '%" + criteriaValue + "%' " +
                      "OR t.totalscore LIKE '%" + criteriaValue + "%' )";
            }

            MySqlDataReader value = Connection.ExecuteQuery(sql);

            List<Matchups> matchupList = new List<Matchups>();

            while (value.Read() == true)
            {
                // matchup id
                string matchupId = value.GetValue(0).ToString();              

                // matchup round
                int matchupRound = int.Parse(value.GetValue(1).ToString());

                Matchups m = new Matchups(matchupId, matchupRound);

                matchupList.Add(m);
            }

            return matchupList;
        }

        public static string GenerateId()
        {
            string sql = "SELECT MAX(Id) FROM matchup;";

            string newId;

            MySqlDataReader result = Connection.ExecuteQuery(sql);

            if (result.Read() && result.GetValue(0) != null)
            {
                int newIdInt = int.Parse(result.GetValue(0).ToString()) + 1;
                newId = newIdInt.ToString();
            }
            else
            {
                newId = "1";
            }

            return newId;
        }
        /// <summary>
        /// Add spesific matchup to database
        /// </summary>
        /// <param name="matchup"></param>
        public static void AddMatchup(Matchups matchup)
        {
            string sql = "INSERT INTO matchup(id, round) " +
                           "VALUES ('" + matchup.Id + "','" + matchup.Round + "')";
            Connection.ExecuteDML(sql);
        }
        /// <summary>
        /// Edit spesific matchup
        /// </summary>
        /// <param name="matchup"></param>
        public static void EditMatchup(Matchups matchup)
        {
            string sql = "UPDATE matchup " +
                        " SET round='" + matchup.Round + "' " +
                        "WHERE Id='" + matchup.Id + "'";
            Connection.ExecuteDML(sql);
        }
        public static bool DeleteMatchup(Matchups matchup, out string exceptionMessage)
        {
            string sql = "DELETE FROM matchup " +
                        " WHERE Id='" + matchup.Id + "'";
            exceptionMessage = "";
            try
            {
                Connection.ExecuteDML(sql);
                return true;
            }
            catch(MySqlException ex)
            {
                exceptionMessage = ex.Message;
                return false;
            }
        }
        #endregion
    }
}
