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

        #region CONTRUCTOR
        public Match(int id, Team team1Id, Team team2Id, string matchWinner, int matchRound)
        {
            Id = id;
            Team1Id = team1Id;
            Team2Id = team2Id;
            MatchWinner = matchWinner;
            MatchRound = matchRound;
        }
        #endregion

        #region PROPERTIES
        public int Id { get => id; set => id = value; }
        public Team Team1Id { get => team1Id; set => team1Id = value; }
        public Team Team2Id { get => team2Id; set => team2Id = value; }
        public string MatchWinner { get => matchWinner; set => matchWinner = value; }
        public int MatchRound { get => matchRound; set => matchRound = value; }
        #endregion

        #region METHOD
        #endregion
    }
}
