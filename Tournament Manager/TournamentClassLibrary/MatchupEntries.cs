using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentClassLibrary
{
    public class MatchupEntries
    {
        Matchup matchup;
        Team team;
        int score;

        #region Constructor
        public MatchupEntries(Matchup matchup, Team team, int score)
        {
            this.Matchup = matchup;
            this.Team = team;
            this.Score = score;
        }
        #endregion

        #region Property
        public Matchup Matchup { get => matchup; set => matchup = value; }
        public Team Team { get => team; set => team = value; }
        public int Score { get => score; set => score = value; }
        #endregion
    }
}
