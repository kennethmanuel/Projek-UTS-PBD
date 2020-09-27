using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentClassLibrary
{
    public class Matchups
    {
        private string id;
        private Teams winnerTeam;
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
    }
}
