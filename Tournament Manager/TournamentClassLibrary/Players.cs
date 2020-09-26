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
        private int id;
        private string name;
        private string email;
        private Teams team;

        #region Constructor
        public Players(int id, string name, string email, Teams teamId)
        {
            this.Id = id;
            this.Name = name;
            this.Email = email;
            this.Team = teamId;
        }
        #endregion

        #region Property
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Email { get => email; set => email = value; }
        public Teams Team { get => team; set => team = value; }
        #endregion

        #region Method
        public static List<Players> ReadData(string criteria, string criteriaValue)
        {
            string sql = "";

            if (criteria == "")
            {
                sql = "SELECT p.id, p.name, p.email, p.team_id, t.name FROM players p INNER JOIN teams t ON p.team_id = t.id";
            }
            else
            {
                sql = "SELECT p.id, p.name, p.email, p.team_id, t.name FROM players p INNER JOIN teams t ON p.team_id = t.id WHERE " + criteria + " LIKE '%" + criteriaValue + "%'";
            }

            MySqlDataReader value = Connection.ExecuteQuery(sql);

            List<Players> playerList = new List<Players>();

            while (value.Read() == true)
            {
                Teams team = new Teams(int.Parse(value.GetValue(3).ToString()), value.GetValue(4).ToString());

                Players p = new Players(
                    int.Parse(value.GetValue(0).ToString()),
                    value.GetValue(1).ToString(),
                    value.GetValue(2).ToString(),
                    team);

                playerList.Add(p);
            }
            return playerList;
        }

        #endregion
    }
}
