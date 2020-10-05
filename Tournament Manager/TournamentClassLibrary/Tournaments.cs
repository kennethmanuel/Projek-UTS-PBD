using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
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
        public Tournaments(int id, string name, decimal entryfee)
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
        /// Create a list of all Tournaments object from a selected database.
        /// </summary>
        /// <returns></returns>
        public static List<Tournaments> ReadData()
        {
            string sql = "SELECT * FROM tournaments";

            MySqlDataReader value = Connection.ExecuteQuery(sql);

            List<Tournaments> tournamentList = new List<Tournaments>();

            while(value.Read() == true)
            {
                Tournaments t = new Tournaments(
                    int.Parse(value.GetValue(0).ToString()),
                    value.GetValue(1).ToString(),
                    decimal.Parse(value.GetValue(2).ToString()));

                tournamentList.Add(t);
            }
            return tournamentList;
        }
         public static void AddTournament(Tournaments t)
        {
            string sql = "INSERT INTO tournaments (id, name, entryfee) VALUES('" + t.Id + "','" + t.Name + "','" + t.Entryfee + "');";

            Connection.ExecuteDML(sql);
        }

        public static int GenerateCode()
        {
            string sql = "SELECT MAX(id) FROM tournaments";
            int code=1; 
            MySqlDataReader result = Connection.ExecuteQuery(sql);

            if(result.Read() == true)
            {
                int newCode = int.Parse(result.GetValue(0).ToString()) + 1;
                code = newCode;
            }
            return code;
        }
    }
}
