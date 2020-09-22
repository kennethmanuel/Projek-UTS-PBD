using System;
using System.Collections.Generic;
using System.Text;

namespace TournamentClassLibrary
{
    public class Player
    {
        #region DATA MEMBER
        private int id;
        private string name;
        private string email;
        private Team teamId;
        #endregion

        #region CONSTRUCTOR
        public Player(int id, string name, string email, Team teamId)
        {
            this.Id = id;
            this.Name = name;
            this.Email = email;
            this.TeamId = teamId;
        }
        #endregion

        #region PROPERTIES
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Email { get => email; set => email = value; }
        public Team TeamId { get => teamId; set => teamId = value; }
        #endregion

        #region METHOD
        #endregion
    }
}
