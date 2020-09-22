using System;
using System.Collections.Generic;
using System.Text;

namespace TournamentClassLibrary
{
    public class Team
    {
        private int id;
        private string name;

        #region Constructor
        public Team(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
        #endregion

        #region Property
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        #endregion
    }
}
