using System;
using System.Collections.Generic;
using System.Text;

namespace TournamentClassLibrary
{
    public class Matchup
    {
        private string id;
        private Team winnerTeam;
        private int round;

        #region Constructor
        public Matchup(string id, Team winnerTeam, int round)
        {
            this.Id = id;
            this.WinnerTeam = winnerTeam;
            this.Round = round;
        }
        #endregion

        #region Property
        public string Id { get => id; set => id = value; }
        public Team WinnerTeam { get => winnerTeam; set => winnerTeam = value; }
        public int Round { get => round; set => round = value; }
        #endregion
    }
}
