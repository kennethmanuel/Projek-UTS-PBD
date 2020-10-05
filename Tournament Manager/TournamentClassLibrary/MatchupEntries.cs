using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentClassLibrary
{
    /// <summary>
    /// Matchup entries show a team's single match
    /// </summary>
    public class MatchupEntries
    {
        /// <summary>
        /// Show 
        /// </summary>
        Matchups matchup;
        Teams team;
        int score;

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
    }
}
