using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace TournamentClassLibrary
{
    public class Tournaments
    {
        private int id;
        private string name;
        private decimal entryfee;
        private int currentRound;

        #region Constructor
        public Tournaments(int id, string name, decimal entryfee, int currentRound)
        {
            this.Id = id;
            this.Name = name;
            this.Entryfee = entryfee;
            this.CurrentRound = currentRound;
        }
        #endregion

        #region Property
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public decimal Entryfee { get => entryfee; set => entryfee = value; }
        public int CurrentRound { get => currentRound; set => currentRound = value; }
        #endregion

        /// <summary>
        /// Create a list of all Tournaments object from a selected database.
        /// </summary>
        /// <returns></returns>
        public static List<Tournaments> ReadData()
        {
            string sql = "SELECT * FROM tournaments";

            MySqlDataReader value = Connection.ExecuteQuery(sql);

            List<Tournaments> tournamentList = new List<Tournaments>();

            while (value.Read() == true)
            {
                int tournamentId = int.Parse(value.GetValue(0).ToString());
                string tournamentName = value.GetValue(1).ToString();
                decimal entryFee = decimal.Parse(value.GetValue(2).ToString());
                int round = int.Parse(value.GetValue(3).ToString());
                   
                Tournaments t = new Tournaments(tournamentId, tournamentName, entryFee, round);

                tournamentList.Add(t);
            }
            return tournamentList;
        }

        /// <summary>
        /// Get current tournament's round
        /// </summary>
        /// <returns>-1 is error, 1 is round 1, 2 is round 2, and so on.</returns>
        public int GetCurrentRound()
        {
            string sql = "SELECT currentround " +
                         "FROM tournaments " +
                         "WHERE name = '" + this.Name + "'";

            MySqlDataReader value = Connection.ExecuteQuery(sql);

            int round = -1;

            if(value.Read())
            {
                round = int.Parse(value.GetValue(0).ToString());
            }
            return round;
        }

        /// <summary>
        /// Add tournament to db
        /// </summary>
        /// <param name="t">Tournament that will be inserted</param>
        public static void AddTournament(Tournaments t)
        {
            string sql = "INSERT INTO tournaments (id, name, entryfee, round) VALUES('" + t.Id + "','" + t.Name + "','" + t.Entryfee + "','" + t.CurrentRound + "');";

            Connection.ExecuteDML(sql);
        }

        /// <summary>
        /// Generate tournament's id
        /// </summary>
        /// <returns></returns>
        public static int GenerateCode()
        {
            string sql = "SELECT MAX(id) FROM tournaments";
            int code = 1;
            MySqlDataReader result = Connection.ExecuteQuery(sql);

            if (result.Read() == true)
            {
                code = int.Parse(result.GetValue(0).ToString()) + 1;
            }
            return code;
        }

        /// <summary>
        /// Delete tournament
        /// </summary>
        /// <param name="t">Tournament name</param>
        /// <param name="exceptionMessage">Error message for debugging</param>
        /// <returns>true = delete success, false = delete failed</returns>
        public static bool DeleteTournament(Tournaments t, out string exceptionMessage)
        {
            string sql = "DELETE FROM tournaments WHERE id=" + t.Id;
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
        /// Get a list of single tournament (GAK JELAS SOPO SING NGGAE METHOD IKI??)
        /// </summary>
        /// <param name="selected"></param>
        /// <returns></returns>
        public static List<Tournaments> ReadCombo(Tournaments selected)
        {
            int tournamentsId = selected.Id;
            string sql = "SELECT * FROM tournaments where id='" + tournamentsId + "'";

            MySqlDataReader value = Connection.ExecuteQuery(sql);

            List<Tournaments> tournamentList = new List<Tournaments>();

            while (value.Read() == true)
            {
                Tournaments t = new Tournaments(
                    int.Parse(value.GetValue(0).ToString()),
                    value.GetValue(1).ToString(),
                    decimal.Parse(value.GetValue(2).ToString()),
                    int.Parse(value.GetValue(3).ToString()));

                tournamentList.Add(t);
            }
            return tournamentList;
        }
    }
}
