using System;
using System.Collections.Generic;
using System.Text;

namespace TournamentClassLibrary
{
    public class Match
    {
        #region DATA MEMBER
        private int id;
        private Team team1Id;
        private Team team2Id;
        private string matchWinner;
        private int matchRound;
        #endregion


        public int Id { get => id; set => id = value; }
        public Team Team1Id { get => team1Id; set => team1Id = value; }
        public Team Team2Id { get => team2Id; set => team2Id = value; }
        public string MatchWinner { get => matchWinner; set => matchWinner = value; }
        public int MatchRound { get => matchRound; set => matchRound = value; }


    }
}
