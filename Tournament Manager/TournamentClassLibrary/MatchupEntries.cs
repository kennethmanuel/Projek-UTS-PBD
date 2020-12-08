﻿using System;
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
        public static List<MatchupEntries> ReadData(string criteria = "", string criteriaValue = "") // optional param
        {
            string sql;

            // empty arg ReadData()
            if (criteria == "")
            {
                sql = "SELECT m.ParentMatchup_Id, m.Teams_Id, m.score, mc.id, mc.winnerid, mc.round, t.name, t.totalscore" +
                      " FROM teams t" +
                      " INNER JOIN matchupentries m ON t.id = m.Teams_Id" +
                      " INNER JOIN matchup mc ON mc.id = m.ParentMatchup_Id" +
                      " ORDER BY m.ParentMatchup_Id ASC";
            }
            // with arg ReadData(id, 1)
            else
            {
                sql = "SELECT m.ParentMatchup_Id, m.Teams_Id, m.score, mc.id, mc.winnerid, mc.round, t.name, t.totalscore" +
                      " FROM teams t" +
                      " INNER JOIN matchupentries m ON t.id = m.Teams_Id" +
                      " INNER JOIN matchup mc ON mc.id = m.ParentMatchup_Id" +
                      " ORDER BY m.ParentMatchup_Id ASC WHERE " + criteria + " LIKE '%" + criteriaValue + "%'";
            }

            MySqlDataReader value = Connection.ExecuteQuery(sql);

            List<MatchupEntries> matchupEntriesList = new List<MatchupEntries>();

            while (value.Read() == true)
            {
                string parentMatchupId = value.GetValue(0).ToString();

                // winner team
                int teamId = int.Parse(value.GetValue(1).ToString());
                string teamName = value.GetValue(6).ToString();
                double totalScore = double.Parse(value.GetValue(7).ToString());
                Teams winnerTeam = new Teams(teamId, teamName, totalScore);

                int round = int.Parse(value.GetValue(5).ToString());
                
                // parent matchup
                Matchups parentMatchup = new Matchups(parentMatchupId, winnerTeam, round);

                // score
                int score = int.Parse(value.GetValue(2).ToString());

                // matchup entries
                MatchupEntries m = new MatchupEntries(parentMatchup, winnerTeam, int.Parse(value.GetValue(2).ToString()));

                // add matchupentries to list
                matchupEntriesList.Add(m);
            }
            return matchupEntriesList;
        }
        #endregion
    }
}
