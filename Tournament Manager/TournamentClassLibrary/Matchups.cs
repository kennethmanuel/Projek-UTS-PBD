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
        public static List<Matchups> ReadData(Tournaments selectedTournament)
        {
            int tournamentId = selectedTournament.Id;
            string sql =
                    "SELECT DISTINCT m.id, round " +
                    "FROM matchup m " +
                    "INNER JOIN matchupentries me ON m.id = me.parentmatchup_id " +
                    "INNER JOIN teams t ON me.teams_id = t.id " +
                    "WHERE me.teams_id IN ( " +
                        "SELECT teams_id " +
                        "FROM tournamententry " +
                        "WHERE tournaments_id = " + selectedTournament.Id + ")";
            

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

            string newId = "";

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
                        "SET round='" + matchup.Round + "' " +
                        "WHERE Id='" + matchup.Id + "'";
            Connection.ExecuteDML(sql);
        }
        public static bool DeleteMatchup(Matchups matchup, out string exceptionMessage)
        {
            string sql = "DELETE FROM matchup " +
                        "WHERE Id='" + matchup.Id + "'";
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

        public static Matchups SelectMatchup(string matchupId)
        {
            string sql = "SELECT * FROM matchup m " +
                         "WHERE id =" + matchupId;

            MySqlDataReader value = Connection.ExecuteQuery(sql);

            value.Read();

            string id = value.GetValue(0).ToString();
            int round = int.Parse(value.GetValue(1).ToString());

            Matchups matchup = new Matchups(id, round);

            return matchup;
        }
        #endregion
    }
}
