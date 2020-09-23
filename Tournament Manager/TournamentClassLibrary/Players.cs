using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentClassLibrary
{
    public class Players
    {
        //class 'Players' plural karena ada namespace 'Player'
        private int id;
        private string name;
        private string email;
        private Team teamId;

        #region Constructor
        public Players(int id, string name, string email, Team teamId)
        {
            this.Id = id;
            this.Name = name;
            this.Email = email;
            this.TeamId = teamId;
        }
        #endregion

        #region Property
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Email { get => email; set => email = value; }
        public Team TeamId { get => teamId; set => teamId = value; }
        #endregion

        #region Method
        //public static List<Players> ReadData(string criteria, string criteriaValue)
        //{
        //    string sql = "";

        //    if(criteria =="")
        //    {
        //        sql = "SELECT * FROM player p INNER JOIN ";
        //    }
        //    else
        //    {
        //        sql = "SELECT * FROM player WHERE " + criteria + " LIKE '%" + criteriaValue + "%'";
        //    }

        //    MySqlDataReader value = Connection.ExecuteQuery(sql);

        //    List<Players> playerList = new List<Players>();

        //    while (value.Read() == true)
        //    {
        //        Team team
        //        Players p = new Players(
        //            int.Parse(value.GetValue(0).ToString()),
        //            value.GetValue(1),
        //            value.GetValue(2),
        //            value.GetValue(3),
        //            )
        //    }
        //}

        #endregion
    }
}
