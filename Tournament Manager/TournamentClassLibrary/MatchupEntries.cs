using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace TournamentClassLibrary
{
    /// <summary>
    /// Matchup entries show a team's single match
    /// </summary>
    public class MatchupEntries
    {
        #region Data Member
        /// <summary>
        /// Show 
        /// </summary>
        Matchups matchup;
        Teams team;
        int score;
        #endregion

        #region Constructor
        public MatchupEntries(Matchups matchup, Teams team, int score)
        {
            this.Matchup = matchup;
            this.Team = team;
            this.Score = score;
        }
        #endregion

        #region Property
        public Matchups Matchup { get => matchup; set => matchup = value; }
        public Teams Team { get => team; set => team = value; }
        public int Score { get => score; set => score = value; }
        #endregion

        #region Method
        /// <summary>
        /// Create list that contains matchup entries object from all database with specified criteria.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="criteriaValue"></param>
        /// <returns></returns>
        public static List<MatchupEntries> ReadData(string criteria, string criteriaValue)
        {
            string sql = "";

            if (criteria == "")
            {
                sql = "SELECT m.ParentMatchup_Id, m.Teams_Id, m.score, mc.id, mc.round, t.name" +
                    " FROM teams t" +
                    " INNER JOIN matchupentries m ON t.id = m.Teams_Id" +
                    " INNER JOIN matchup mc ON mc.id = m.ParentMatchup_Id" +
                    " ORDER BY `m`.`ParentMatchup_Id` ASC";
            }
            else
            {
                sql = "SELECT m.ParentMatchup_Id, m.Teams_Id, m.score, mc.id, mc.round, t.name" +
                    " FROM teams t" +
                    " INNER JOIN matchupentries m ON t.id = m.Teams_Id" +
                    " INNER JOIN matchup mc ON mc.id = m.ParentMatchup_Id" +
                    " ORDER BY `m`.`ParentMatchup_Id` ASC WHERE " + criteria + " LIKE '%" + criteriaValue + "%'";
            }

            MySqlDataReader value = Connection.ExecuteQuery(sql);

            List<MatchupEntries> matchupEntriesList = new List<MatchupEntries>();

            while (value.Read() == true)
            {
                Teams team = new Teams(
                    int.Parse(value.GetValue(1).ToString()),
                    value.GetValue(5).ToString());

                Matchups mc = new Matchups(value.GetValue(3).ToString(),
                    team,
                    int.Parse(value.GetValue(4).ToString()));



                MatchupEntries m = new MatchupEntries(mc, team, int.Parse(value.GetValue(2).ToString()));

                matchupEntriesList.Add(m);
            }
            return matchupEntriesList;
        }
        #endregion
    }
}
