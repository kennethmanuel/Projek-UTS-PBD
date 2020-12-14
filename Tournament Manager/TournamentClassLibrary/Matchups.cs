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
        private Teams winnerTeam;
        private int round;
        #endregion

        #region Constructor
        public Matchups(string id, Teams winnerTeam, int round)
        {
            this.Id = id;
            this.WinnerTeam = winnerTeam;
            this.Round = round;
        }
        #endregion

        #region Property
        public string Id { get => id; set => id = value; }
        public Teams WinnerTeam { get => winnerTeam; set => winnerTeam = value; }
        public int Round { get => round; set => round = value; }
        #endregion

        #region Method
        /// <summary>
        /// Create list of matchups.
        /// </summary>
        /// <param name="criteria">Criteria for search (id, winnerid, round, winner_name, winner_totalscore).</param>
        /// <param name="criteriaValue"></param>
        /// <returns></returns>
        public static List<Matchups> ReadData(string criteria = "", string criteriaValue = "")
        {
            string sql;

            if(criteria == "")
            {
                sql = "SELECT m.id, m.winnerid, m.round, t.name as winner_name, t.totalscore winner_totalscore " +
                      "FROM matchup m " +
                      "INNER JOIN teams t ON m.winnerid = t.id";
            }
            else
            {
                sql = "SELECT m.id, m.winnerid, m.round, t.name as winner_name, t.totalscore winner_totalscore " +
                      "FROM matchup m " +
                      "INNER JOIN teams t ON m.winnerid = t.id " +
                      "WHERE " + criteria + " " +
                      "LIKE '%" + criteriaValue + "%'";
            }

            MySqlDataReader value = Connection.ExecuteQuery(sql);

            List<Matchups> matchupList = new List<Matchups>();

            while(value.Read() == true)
            {
                // matchup id
                string matchupId = value.GetValue(0).ToString();

                // winner team
                int teamId = int.Parse(value.GetValue(1).ToString());
                string teamName = value.GetValue(3).ToString();
                double teamTotalScore = double.Parse(value.GetValue(4).ToString());
                Teams team = new Teams(teamId, teamName, teamTotalScore);

                // matchup round
                int matchupRound = int.Parse(value.GetValue(2).ToString());

                Matchups m = new Matchups(matchupId, team, matchupRound);

                matchupList.Add(m);
            }

            return matchupList;
        }

        public static string GenerateId()
        {
            string sql = "SELECT MAX(Id) FROM matchup;";

            string newId;

            MySqlDataReader result = Connection.ExecuteQuery(sql);

            if(result.Read())
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
        #endregion
    }
}
