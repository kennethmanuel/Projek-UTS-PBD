using System;
using System.Collections.Generic;
using System.Text;

namespace TournamentClassLibrary
{
    public class Round
    {
        #region DATA MEMBER
        private int id;
        private DateTime schedule;
        private string roundWinner;
        private Match match;
        #endregion

        #region CONSTRUCTOR
        public Round(int id, DateTime schedule, string roundWinner, Match match)
        {
            this.Id = id;
            this.Schedule = schedule;
            this.RoundWinner = roundWinner;
            this.Match = match;
        }
        #endregion

        #region PROPERTIES
        public int Id { get => id; set => id = value; }
        public DateTime Schedule { get => schedule; set => schedule = value; }
        public string RoundWinner { get => roundWinner; set => roundWinner = value; }
        public Match Match { get => match; set => match = value; }
        #endregion

        #region METHOD
        #endregion
    }
}
