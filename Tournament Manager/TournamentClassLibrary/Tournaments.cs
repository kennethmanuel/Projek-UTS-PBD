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

        #region Constructor
        public Tournaments(int id, string name, decimal entryfee )
        {
            this.Id = id;
            this.Name = name;
            this.Entryfee = entryfee;
        }
        #endregion

        #region Property
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public decimal Entryfee { get => entryfee; set => entryfee = value; }
        #endregion

        /// <summary>
        /// Create a list of all Tournaments object.
        /// </summary>
        /// <returns>list of tournament</returns>
        public static List<Tournaments> ReadData()
        {
            string sql = "SELECT * FROM tournaments";

            MySqlDataReader value = Connection.ExecuteQuery(sql);

            List<Tournaments> tournamentList = new List<Tournaments>();

            while (value.Read() == true)
            {
                // tournamentid
                int tournamentId = int.Parse(value.GetValue(0).ToString());

                // tournament name
                string tournamentName = value.GetValue(1).ToString();

                // tournament entryfee
                decimal entryFee = decimal.Parse(value.GetValue(2).ToString());

                // tournament
                Tournaments tournament = new Tournaments(tournamentId, tournamentName, entryFee);

                tournamentList.Add(tournament);
            }

            return tournamentList;
        }

        /// <summary>
        /// Add tournament to database
        /// </summary>
        /// <param name="tournaments">Tournament that will be inserted</param>
        public static void AddTournament(Tournaments tournaments)
        {
            string sql = "INSERT INTO tournaments(id, name, entryfee) " +
                         "VALUES('" + tournaments.Id + "','" + tournaments.Name + "','" + tournaments.Entryfee + "');";

            Connection.ExecuteDML(sql);
        }

        /// <summary>
        /// Generate tournament id
        /// </summary>
        /// <returns>Create id for tournament</returns>
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
                    decimal.Parse(value.GetValue(2).ToString())
                   );

                tournamentList.Add(t);
            }
            return tournamentList;
        }
    }
}
