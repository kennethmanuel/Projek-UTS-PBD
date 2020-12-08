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
        public static List<Players> ReadData(string criteria = "", string criteriaValue = "")
        {
            string sql;

            // no arg (ex: ReadData())
            if (criteria == "")
            {
                sql = "SELECT p.id, p.name, p.email, p.team_id, t.name, t.totalscore " +
                      "FROM players p " +
                      "INNER JOIN teams t ON p.team_id = t.id";
            }
            // with arg (ex: ReadData(name, 'beth harmon'))
            else
            {
                sql = "SELECT p.id, p.name, p.email, p.team_id, t.name, t.totalscore " +
                      "FROM players p " +
                      "INNER JOIN teams t ON p.team_id = t.id " +
                      "WHERE " + criteria + " " +
                      "LIKE '%" + criteriaValue + "%'";
                
            }

            MySqlDataReader value = Connection.ExecuteQuery(sql);

            List<Players> playerList = new List<Players>();

            while (value.Read() == true)
            {
                // player id
                int playerId = int.Parse(value.GetValue(0).ToString());

                // player name
                string playerName = value.GetValue(1).ToString();

                // player email
                string playerEmail = value.GetValue(2).ToString();

                // player team
                int teamId = int.Parse(value.GetValue(3).ToString());
                string teamName = value.GetValue(4).ToString();
                double teamTotalScore = double.Parse(value.GetValue(5).ToString());
                Teams team = new Teams(teamId, teamName, teamTotalScore);

                // player
                Players p = new Players(playerId, playerName, playerEmail, team);

                // add to list
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
            string sql = "SELECT p.id, p.name, p.email, p.team_id, t.name, t.totalscore " +
                         "FROM players p " +
                         "INNER JOIN teams t ON p.team_id = t.id " +
                         "WHERE p.id LIKE '%" + criteriaValue + "%' " +
                         "OR p.name LIKE '%" + criteriaValue + "%' " +
                         "OR p.EMAIL LIKE '%" + criteriaValue + "%' " +
                         "OR t.name LIKE '%" + criteriaValue + "%'";

            MySqlDataReader value = Connection.ExecuteQuery(sql);

            List<Players> playerList = new List<Players>();

            while (value.Read() == true)
            {
                // id
                int playerId = int.Parse(value.GetValue(0).ToString());

                // name
                string playerName = value.GetValue(1).ToString();

                // email
                string playerEmail = value.GetValue(2).ToString();

                // team
                int teamId = int.Parse(value.GetValue(3).ToString());
                string teamName = value.GetValue(4).ToString();
                double teamTotalScore = double.Parse(value.GetValue(5).ToString());
                Teams team = new Teams(teamId, teamName, teamTotalScore);

                // player
                Players p = new Players(playerId, playerName, playerEmail, team); 

                // add to list
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
            string sql = "SELECT p.id, p.name, p.email, p.team_id, t.name, t.totalscore " +
                         "FROM players p " +
                         "INNER JOIN teams t ON p.team_id = t.id  " +
                         "WHERE p.id=" + playerId;

            MySqlDataReader value = Connection.ExecuteQuery(sql);

            value.Read();

            // name
            string playerName = value.GetValue(1).ToString();

            // email
            string playerEmail = value.GetValue(2).ToString();

            // team
            int teamId = int.Parse(value.GetValue(3).ToString());
            string teamName = value.GetValue(4).ToString();
            double teamTotalScore = double.Parse(value.GetValue(5).ToString());
            Teams team = new Teams(teamId, teamName, teamTotalScore);

            // player
            Players p = new Players(playerId, playerName, playerEmail, team); 

            return p;
        }

        /// <summary>
        /// Add Player to database
        /// </summary>
        /// <param name="p"></param>
        public static void AddPlayer(Players p)
        {
            string sql = "INSERT INTO players(Id, Name, Email, Team_id) " +
                         "VALUES ('" + p.Id + "','" + p.Name.Replace("'", "\\'") + "','" + p.Email + "','" + p.Team.Id + "')";

            Connection.ExecuteDML(sql);
        }

        /// <summary>
        /// Edit player from database
        /// </summary>
        /// <param name="p"></param>
        public static void EditPlayer(Players p)
        {
            string sql = "UPDATE players " +
                         "SET Name='" + p.Name.Replace("'", "\\'") + "',Email='" + p.Email + "',Team_Id='" + p.Team.Id + "'" +

                         "WHERE Id='" + p.Id + "'";
            Connection.ExecuteDML(sql);
        }

        /// <summary>
        /// Delete Player from database
        /// </summary>
        /// <param name="pl"></param>
        /// <returns></returns>
        public static bool DeletePlayer(Players p, out string exceptionMessage)
        {
            string sql = "DELETE FROM players " +
                         "WHERE Id='" + p.Id + "'";

            exceptionMessage = "";

            try
            {
                Connection.ExecuteDML(sql);
                return true;
            }
            catch(MySqlException ex)
            {
                exceptionMessage = ex.Message;
                return false;
            }
        }

        /// <summary>
        /// Generate new Id
        /// </summary>
        /// <returns></returns>
        public static string GenerateId()
        {
            string sql = "SELECT MAX(Id) FROM Players";

            string newId;

            MySqlDataReader result = Connection.ExecuteQuery(sql);

            if (result.Read())
            {
                int newIdInt = int.Parse(result.GetValue(0).ToString()) + 1;
                newId = newIdInt.ToString();
            }
            else
            {
                newId = "1";
            }

            return newId;
        }
        #endregion
    }
}
