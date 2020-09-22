using System;

namespace TournamentClassLibrary
{
    public class Tournament
    {
        #region DATA MEMBER
        private int id;
        private string name;
        private decimal entryfee;
        #endregion

        #region CONSTRUCTOR
        public Tournament(int id, string name, decimal entryfee)
        {
            this.Id = id;
            this.Name = name;
            this.Entryfee = entryfee;
        }
        #endregion

        #region PROPERTIES
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public decimal Entryfee { get => entryfee; set => entryfee = value; }
        #endregion

        #region METHOD
        #endregion
    }
}
