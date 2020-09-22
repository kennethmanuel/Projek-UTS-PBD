using System;
using System.Collections.Generic;
using System.Text;

namespace TournamentClassLibrary
{
    public class TournamentPrize
    {
        #region DATA MEMBER
        private Prize prize;
        private Tournament tournament;
        #endregion

        #region CONSTRUCTOR
        public TournamentPrize(Prize prize, Tournament tournament)
        {
            this.Prize = prize;
            this.Tournament = tournament;
        }
        #endregion

        #region PROPERTIES
        public Prize Prize { get => prize; set => prize = value; }
        public Tournament Tournament { get => tournament; set => tournament = value; }
        #endregion

        #region METHOD
        #endregion
    }
}
