using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
        /// <summary>
        /// Create list that contains Players object from all database with specified criteria.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="criteriaValue"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Create list that contains Players object from selected database with all criteria selected.
        /// </summary>
        /// <param name="criteriaValue"></param>
        /// <returns></returns>
        public static List<Players> BatchSearch(string criteriaValue)
        {
            string sql = "SELECT p.id, p.name, p.email, p.team_id, t.name FROM players p INNER JOIN teams t ON p.team_id = t.id WHERE p.id LIKE '%" + criteriaValue + "%' OR p.name LIKE '%" + criteriaValue + "%' OR p.EMAIL LIKE '%" + criteriaValue + "%' or t.name LIKE '%" + criteriaValue + "%'";

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


        /// <summary>
        /// Select a player as object based on its id
        /// </summary>
        /// <param name="playerId"></param>
        /// <returns></returns>
        public static Players SelectPlayer(int playerId)
        {
            string sql = "SELECT p.id, p.name, p.email, p.team_id, t.name FROM players p INNER JOIN teams t ON p.team_id = t.id  WHERE p.id=" + playerId;

            MySqlDataReader value = Connection.ExecuteQuery(sql);

            value.Read();
            
            Teams team = new Teams(int.Parse(value.GetValue(3).ToString()), value.GetValue(4).ToString());

            Players p = new Players(
                    int.Parse(value.GetValue(0).ToString()),
                    value.GetValue(1).ToString(),
                    value.GetValue(2).ToString(),
                   team);
           
            return p;
        }

        /// <summary>
        /// Add Player to database
        /// </summary>
        /// <param name="p"></param>
        public static void AddPlayer(Players p)
        {
            string sql = "insert into players(Id, Name, Email, Team_id) values ('" + p.Id + "','" + p.Name.Replace("'", "\\'") + "','" + p.Email + "','" + p.Team.Id + "')";
            Connection.ExecuteDML(sql);
        }

        /// <summary>
        /// Edit player from database
        /// </summary>
        /// <param name="p"></param>
        public static void EditPlayer(Players p)
        {
            string sql = "update players set Name='" + p.Name.Replace("'", "\\'") + "',Email='" + p.Email + "',Team_Id='" + p.Team.Id +
                "'where Id='" + p.Id + "'";
            Connection.ExecuteDML(sql);
        }

        /// <summary>
        /// Delete Player from database
        /// </summary>
        /// <param name="pl"></param>
        /// <returns></returns>
        public static string DeletePlayer(Players pl)
        {
            string sql = "Delete from players where Id='" + pl.Id + "'";
            try
            {
                Connection.ExecuteDML(sql);
                return "1";
            }
            catch(MySqlException ex)
            {
                return ex.Message + ". Sql Command: " + sql;
            }
        }

        /// <summary>
        /// Generate new Id
        /// </summary>
        /// <returns></returns>
        public static string GenerateCode()
        {
            string sql = "select max(Id) from Players";
            string code = "";
            MySqlDataReader result = Connection.ExecuteQuery(sql);

            if (result.Read() == true)
            {
                int newCode = int.Parse(result.GetValue(0).ToString()) + 1;
                code = newCode.ToString();
            }
            else
            {
                code = "1";
            }
            return code;
        }
        #endregion
    }
}
