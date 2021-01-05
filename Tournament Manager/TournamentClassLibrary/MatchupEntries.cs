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
        public static List<MatchupEntries> ReadData(Tournaments tournament) 
        {
            string sql =
                        "SELECT parentmatchup_id, teams_id, score " +
                        "FROM matchupentries me " +
                        "WHERE me.teams_id IN ( " +
                            "SELECT teams_id " +
                            "FROM tournamententry " +
                            "WHERE tournaments_id =  " + tournament.Id + ") "; 

            MySqlDataReader value = Connection.ExecuteQuery(sql);

            List<MatchupEntries> matchupEntriesList = new List<MatchupEntries>();

            while (value.Read() == true)
            {
                // SCORE
                double score = double.Parse(value.GetValue(2).ToString());

                // TEAM
                int teamid = int.Parse(value.GetValue(1).ToString());
                Teams team = Teams.SelectTeam(teamid);

                // MATCHUP
                // parent matchup id
                string matchupid = value.GetValue(0).ToString();
                Matchups parentMatchup = Matchups.SelectMatchup(matchupid);

                // MATCHUP ENTRY
                MatchupEntries matchupEntry = new MatchupEntries(parentMatchup, team, score);

                // add matchupentries to list
                matchupEntriesList.Add(matchupEntry);
            }

            return matchupEntriesList;
        }

        public static void Add(Matchups matchup, Teams team, double score)
        {
            string sql = "INSERT INTO matchupentries " +
                         "VALUES (" + matchup.Id + "," + team.Id + "," + score + ");";

            Connection.ExecuteDML(sql);
        }

        public static void Edit(Matchups matchup, Teams team, double score)
        {
            string sql = "UPDATE matchupentries " +
                         "SET score = " + score + " " +
                         "WHERE parentmatchup_id='" + matchup.Id + "' " +
                         "AND teams_id = '" + team.Id + "'";

            Connection.ExecuteDML(sql);
        }

        public static void Delete(Matchups matchup, Teams team)
        {
            string sql = "DELETE FROM matchupentries " +
                         "WHERE parentmatchup_id='" + matchup.Id + "' " +
                         "AND teams_id = '" + team.Id + "'";

            Connection.ExecuteDML(sql);
        }

        public string GenerateId()
        {
            string sql = "SELECT MAX(Id) FROM matchupentries";

            string newId = "";

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
