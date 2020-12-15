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
        Matchups matchup;
        Teams team;
        double score;

        #region Constructor
        public MatchupEntries(Matchups matchup, Teams team, double score)
        {
            this.Matchup = matchup;
            this.Team = team;
            this.Score = score;
        }
        #endregion

        #region Property
        public Matchups Matchup { get => matchup; set => matchup = value; }
        public Teams Team { get => team; set => team = value; }
        public double Score { get => score; set => score = value; }
        #endregion

        #region Method
        public static List<MatchupEntries> ReadData() 
        {
            string sql =   "SELECT score, " +
                               "teams_id, t.name AS team_name, t.totalscore team_totalscore, " +
                               "m.id AS matchup_id, m.round AS matchup_round, " +
                               "twinner.id AS winner_id, twinner.name AS winner_name, twinner.totalscore AS winner_totalscore " +
                          "FROM matchupentries as me " +
                          "INNER JOIN teams AS t ON me.teams_id = t.id " +
                          "INNER JOIN matchup AS m ON me.parentmatchup_id = m.id " +
                          "INNER JOIN teams AS twinner ON m.winnerid = twinner.id ";

            MySqlDataReader value = Connection.ExecuteQuery(sql);

            List<MatchupEntries> matchupEntriesList = new List<MatchupEntries>();

            while (value.Read() == true)
            {
                // SCORE
                double score = double.Parse(value.GetValue(0).ToString());

                // TEAM
                int teamId = int.Parse(value.GetValue(1).ToString());
                string teamName = value.GetValue(2).ToString();
                double totalScore = double.Parse(value.GetValue(3).ToString());
                Teams team = new Teams(teamId, teamName, totalScore);

                // MATCHUP
                // parent matchup id
                string matchupId = value.GetValue(4).ToString();
                // matchup winner team
                int winnerId = int.Parse(value.GetValue(6).ToString());
                string winnerName = value.GetValue(7).ToString();
                double winnertotalScore = double.Parse(value.GetValue(8).ToString());
                Teams winnerTeam = new Teams(winnerId, winnerName, winnertotalScore);
                // matchup round
                int matchRound = int.Parse(value.GetValue(5).ToString());
                Matchups parentMatchup = new Matchups(matchupId, winnerTeam, matchRound);

                // MATCHUP ENTRY
                MatchupEntries matchupEntry = new MatchupEntries(parentMatchup, team, score);

                // add matchupentries to list
                matchupEntriesList.Add(matchupEntry);
            }

            return matchupEntriesList;
        }

        public void Add(Matchups matchup, Teams team, double score)
        {
            string sql = "INSERT INTO matchupentries " +
                         "VALUES (" + matchup.Id + "," + team.Id + "," + score + ");";

            Connection.ExecuteDML(sql);
        }

        public void Edit(Matchups matchup, Teams team, double score)
        {
            string sql = "UPDATE matchupentries " +
                         "SET parentmatchup_id = " + matchup.Id + ", " +
                             "teams_id = " + team.Id +
                             "score = " + score + ");";

            Connection.ExecuteDML(sql);
        }

        public void Delete(Matchups matchup)
        {
            string sql = "DELETE FROM matchupentries " +
                         "WHERE id=" + matchup.Id + ";";

            Connection.ExecuteDML(sql);
        }

        public void Delete(int matchupId)
        {
            string sql = "DELETE FROM matchupentries " +
                         "WHERE id=" + matchupId + ";";

            Connection.ExecuteDML(sql);
        }

        public string GenerateId()
        {
            string sql = "SELECT MAX(Id) FROM matchupentries";

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
