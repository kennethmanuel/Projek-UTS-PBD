using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentClassLibrary
{
    public class TournamentEntry
    {
        Tournaments tournament;
        Teams team;

        #region Constructor
        public TournamentEntry(Tournaments tournament, Teams team)
        {
            this.tournament = tournament;
            this.team = team;
        }
        #endregion

        #region Property
        public Tournaments Tournament { get => tournament; set => tournament = value; }
        public Teams Team { get => team; set => team = value; }
        #endregion

        #region Method
        // not tested.
        public static List<TournamentEntry> ReadData(string criteria, string criteriaValue)
        {
            string sql = "";

            if(criteria == "")
            {
                sql = "SELECT tr.id, tr.name, tr.entryfee, t.id, t.name FROM tournamentteams tt INNER JOIN tournaments tr ON tr.id = tt.tournaments_id INNER JOIN teams t ON tt.teams_id = t.id";
            }
            else
            {
                sql = "SELECT tr.id, tr.name, tr.entryfee, t.id, t.name FROM tournamentteams tt INNER JOIN tournaments tr ON tr.id = tt.tournaments_id INNER JOIN teams t ON tt.teams_id = t.id WHERE " + criteria + " LIKE '%" + criteriaValue + "%'";
            }

            MySqlDataReader value = Connection.ExecuteQuery(sql);

            List<TournamentEntry> tournamentTeamList = new List<TournamentEntry>();

            while(value.Read() == true)
            {
                Tournaments tournament = new Tournaments(
                    int.Parse(value.GetValue(0).ToString()),
                    value.GetValue(1).ToString(),
                    decimal.Parse(value.GetValue(2).ToString()));

                Teams team = new Teams(
                    int.Parse(value.GetValue(3).ToString()),
                    value.GetValue(4).ToString()
                    );

                TournamentEntry te = new TournamentEntry(tournament, team);
            }
            return tournamentTeamList;
        }
        #endregion
    }
} 