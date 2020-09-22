using System;
using System.Collections.Generic;
using System.Text;

namespace TournamentClassLibrary
{
    public class Team
    {
        #region DATA MEMBER
        private int id;
        private string name;
        #endregion

        #region CONSTRUCTOR
        public Team(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
        #endregion

        #region PROPERTIES
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        #endregion

        #region METHOD
        #endregion
    }
}
