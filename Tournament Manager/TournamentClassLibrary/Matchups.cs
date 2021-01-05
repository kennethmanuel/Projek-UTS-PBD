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
        private DateTime date;
        #endregion

        #region Constructor
        public Matchups(string id, int round, DateTime date)
        {
            this.Id = id;         
            this.Round = round;
            this.Date = date;
        }
        #endregion

        #region Property
        public string Id { get => id; set => id = value; }
        public int Round { get => round; set => round = value; }      
        public DateTime Date { get => date; set => date = value; }
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
                    "SELECT DISTINCT m.id, round, date " +
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

                // matchup date
                DateTime matchupDate = DateTime.Parse(value.GetValue(2).ToString());

                Matchups matchup = new Matchups(matchupId, matchupRound, matchupDate);

                matchupList.Add(matchup);
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
            string sql = "INSERT INTO matchup(id, round, date) " +
                           "VALUES ('" + matchup.Id + "','" + matchup.Round + "','" + matchup.date.ToString("yyyy-MM-dd") + "')";

            Connection.ExecuteDML(sql);
        }
        /// <summary>
        /// Edit spesific matchup
        /// </summary>
        /// <param name="matchup"></param>
        public static void EditMatchup(Matchups matchup)
        {
            string sql = "UPDATE matchup " +
                        "SET round='" + matchup.Round + "', " +
                            "date= '" + matchup.date.ToString("yyyy-MM-dd") + "' " +
                        "WHERE Id='" + matchup.Id + "'";

            Connection.ExecuteDML(sql);
        }
        public static void DeleteMatchup(Matchups matchup)
        {
            string sql = "DELETE FROM matchup " +
                    "WHERE Id='" + matchup.Id + "'";
            Connection.ExecuteDML(sql);
        }

        public static Matchups SelectMatchup(string matchupId)
        {
            string sql = "SELECT * FROM matchup m " +
                         "WHERE id =" + matchupId;

            MySqlDataReader value = Connection.ExecuteQuery(sql);

            value.Read();

            string id = value.GetValue(0).ToString();
            int round = int.Parse(value.GetValue(1).ToString());
            DateTime date = DateTime.Parse(value.GetValue(2).ToString());

            Matchups matchup = new Matchups(id, round, date);

            return matchup;
        }

        public static Matchups SelectMatchup(int matchupId)
        {
            string sql = "SELECT * FROM matchup m " +
                         "WHERE id =" + matchupId;

            MySqlDataReader value = Connection.ExecuteQuery(sql);

            value.Read();

            string id = value.GetValue(0).ToString();
            int round = int.Parse(value.GetValue(1).ToString());
            DateTime date = DateTime.Parse(value.GetValue(2).ToString());

            Matchups matchup = new Matchups(id, round, date);

            return matchup;
        }

        public static List<MatchupEntries> GetEntries(Matchups matchup)
        {
            string sql = "SELECT * FROM matchupentries " +
                         "WHERE parentmatchup_id = " + matchup.Id;

            MySqlDataReader value = Connection.ExecuteQuery(sql);

            List<MatchupEntries> matchupEntriesList = new List<MatchupEntries>();

            while(value.Read())
            {
                string parentId = value.GetValue(0).ToString();
                Matchups parentMatchup = Matchups.SelectMatchup(parentId);

                int teamid = int.Parse(value.GetValue(1).ToString());
                Teams team = Teams.SelectTeam(teamid);

                double score = double.Parse(value.GetValue(2).ToString());

                MatchupEntries matchupEntry = new MatchupEntries(parentMatchup, team, score);

                matchupEntriesList.Add(matchupEntry);
            }

            return matchupEntriesList;
        }
        #endregion
    }
}
