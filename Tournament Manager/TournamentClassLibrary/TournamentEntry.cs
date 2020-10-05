using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace TournamentClassLibrary
{
    /// <summary>
    /// Tournament entry show what team join what tournament
    /// </summary>
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
        /// <summary>
        /// Create a list of team object that participate on the selectedTournament 
        /// </summary>
        /// <param name="selectedTournament">Selected tournament</param>
        /// <returns></returns>
        public static List<Teams> ReadTeam(Tournaments selectedTournament, string criteria)
        {
            int tournamentId = selectedTournament.Id;
            string sql = "";

            if(criteria=="")
            {
                sql = "SELECT * FROM teams t WHERE t.id IN (SELECT teams_id FROM tournamententry WHERE tournaments_id=" + tournamentId + ")";
            }
            else
            {
                sql = "SELECT * FROM teams t WHERE t.id IN (SELECT teams_id FROM tournamententry WHERE tournaments_id=" + tournamentId + ") AND ( t.name LIKE '%" + criteria + "%' OR t.id LIKE '%" + criteria + "%')";
            }

            MySqlDataReader value = Connection.ExecuteQuery(sql);

            List<Teams> teamList = new List<Teams>();

            while(value.Read() == true)
            {
                Teams team = new Teams(
                    int.Parse(value.GetValue(0).ToString()),
                    value.GetValue(1).ToString()
                    );

                teamList.Add(team);
            }
            return teamList;
        }

        /// <summary>
        /// Create a list of player that participate on the selectedTournament
        /// </summary>
        /// <param name="selectedTournament"></param>
        /// <param name="criteria"></param>
        /// <returns></returns>
        public static List<Players> ReadPlayer(Tournaments selectedTournament, string criteria)
        {
            int tournamentid = selectedTournament.Id;
            string sql = "";

            if(criteria == "")
            {
                sql = "SELECT p.id, p.name, p.email, p.team_id, t.name FROM players p INNER JOIN teams t ON p.team_id = t.id WHERE p.team_id IN (SELECT tt.teams_id FROM tournamententry tt WHERE tournaments_id=" + tournamentid + ")";
            }
            else
            {
                sql = "SELECT p.id, p.name, p.email, p.team_id, t.name FROM players p INNER JOIN teams t ON p.team_id = t.id WHERE p.team_id IN (SELECT tt.teams_id FROM tournamententry tt WHERE tournaments_id=" + tournamentid + ") AND ( p.id LIKE '%" + criteria + "%' OR p.name LIKE '%" + criteria + "%' OR p.email LIKE '%" + criteria + "%' or t.name LIKE '%" + criteria + "%' )"; 
            }

            MySqlDataReader value = Connection.ExecuteQuery(sql);

            List<Players> listPlayer = new List<Players>();

            while(value.Read() == true)
            {
                Teams team = new Teams(int.Parse(value.GetValue(3).ToString()), value.GetValue(4).ToString());

                Players p = new Players(
                    int.Parse(value.GetValue(0).ToString()),
                    value.GetValue(1).ToString(),
                    value.GetValue(2).ToString(),
                    team);

                listPlayer.Add(p);
            }
            return listPlayer;
        }
        #endregion
    }
} 