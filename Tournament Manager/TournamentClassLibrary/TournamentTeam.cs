using System;
using System.Collections.Generic;
using System.Text;

namespace TournamentClassLibrary
{
    public class TournamentTeam
    {
        #region DATA MEMBER
        private string id;
        private Team team;
        private Tournament tournament;
        #endregion

        #region CONSTRUCTOR
        public TournamentTeam(string id, Team team, Tournament tournament)
        {
            this.Id = id;
            this.Team = team;
            this.Tournament = tournament;
        }
        #endregion

        #region PROPERTIES
        public string Id { get => id; set => id = value; }
        public Team Team { get => team; set => team = value; }
        public Tournament Tournament { get => tournament; set => tournament = value; }
        #endregion

        #region METHOD
        #endregion
    }
}
