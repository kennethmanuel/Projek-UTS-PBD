using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentClassLibrary
{
    // Masih belum (N-M relationship)
    /// <summary>
    /// Matchups show what team which team win a matchupentry
    /// </summary>
    public class Matchups
    {
        /// <summary>
        /// Matchup Id
        /// </summary>
        private string id;
        /// <summary>
        /// Team that wins the matchup
        /// </summary>
        private Teams winnerTeam;
        /// <summary>
        /// Round is the pairing number (ex: first pairing in single bracket match is round 1, the next pairing is round 2 and so on)
        /// </summary>
        private int round;

        #region Constructor
        public Matchups(string id, Teams winnerTeam, int round)
        {
            this.Id = id;
            this.WinnerTeam = winnerTeam;
            this.Round = round;
        }
        #endregion

        #region Property
        public string Id { get => id; set => id = value; }
        public Teams WinnerTeam { get => winnerTeam; set => winnerTeam = value; }
        public int Round { get => round; set => round = value; }
        #endregion

        #region Method
        // Masih salah
        public static List<Matchups> ReadData(string criteria, string criteriaValue)
        {
            string sql = "";

            if(criteria == "")
            {
                sql = "SELECT m.id, m.winnerid, m.round, t.name FROM matchup m INNER JOIN teams t ON m.winnerid = t.id";
            }
            else
            {
                sql = "SELECT m.id, m.winnerid, m.round, t.name FROM matchup m INNER JOIN teams t ON m.winnerid = t.id WHERE " + criteria + " LIKE '%" + criteriaValue + "%'";
            }

            MySqlDataReader value = Connection.ExecuteQuery(sql);

            List<Matchups> matchupList = new List<Matchups>();

            while(value.Read() == true)
            {
                Teams team = new Teams(
                    int.Parse(value.GetValue(1).ToString()),
                    value.GetValue(3).ToString());

                Matchups m = new Matchups(
                    value.GetValue(0).ToString(),
                    team,
                    int.Parse(value.GetValue(2).ToString()));

                matchupList.Add(m);
            }
            return matchupList;
        }
        #endregion
    }
}
