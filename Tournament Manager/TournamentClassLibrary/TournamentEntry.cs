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
        /// Create list of participating team on selected tournament
        /// </summary>
        /// <param name="selectedTournament">Selected tournament</param>
        /// <param name="criteriaValue">Search value for team (team name or team id)</param>
        /// <returns>List of team participating on the selected tournament</returns>
        public static List<Teams> ReadTeam(Tournaments selectedTournament, string criteriaValue = "")
        {
            int tournamentId = selectedTournament.Id;

            string sql;

            if(criteriaValue=="")
            {
                sql = "SELECT * FROM teams t " +
                      "WHERE t.id IN (SELECT teams_id " +
                                     "FROM tournamententry " +
                                     "WHERE tournaments_id = " + tournamentId + ")";
            }
            else
            {
                sql = "SELECT * " +
                      "FROM teams t " +
                      "WHERE t.id IN (SELECT teams_id " +
                                     "FROM tournamententry " +
                                     "WHERE tournaments_id=" + tournamentId + ") " +
                                     "AND ( t.name LIKE '%" + criteriaValue + "%' " +
                                     "OR t.id LIKE '%" + criteriaValue + "%')";
            }

            MySqlDataReader value = Connection.ExecuteQuery(sql);

            List<Teams> teamList = new List<Teams>();

            while(value.Read() == true)
            {
                // team id
                int teamId = int.Parse(value.GetValue(0).ToString());
                
                // team name
                string teamName = value.GetValue(1).ToString();

                // team total score
                double totalScore = double.Parse(value.GetValue(2).ToString());

                // team
                Teams team = new Teams(teamId, teamName, totalScore);

                // add team to list
                teamList.Add(team);
            }

            return teamList;
        }

        /// <summary>
        /// Create a list of player that participate on the selectedTournament
        /// </summary>
        /// <param name="selectedTournament">Selected tournament</param>
        /// <param name="criteriaValue">Search value for player search (player name, player email or player's team name)</param>
        /// <returns>List of player participate in selected tournament</returns>
        public static List<Players> ReadPlayer(Tournaments selectedTournament, string criteriaValue = "")
        {
            int tournamentid = selectedTournament.Id;

            string sql;

            // no criteria (ex: ReadPlayer(tournament)
            if(criteriaValue == "")
            {
                sql = "SELECT p.id, p.name, p.email, p.team_id, t.name, t.totalscore " +
                      "FROM players p " +
                      "INNER JOIN teams t ON p.team_id = t.id " +
                      "WHERE p.team_id IN (SELECT tt.teams_id " +
                                          "FROM tournamententry tt " +
                                          "WHERE tournaments_id=" + tournamentid + ")";
            }
            // with criteria (ex: ReadPlayer(tournament, 'beth harmon')
            else
            {
                sql = "SELECT p.id, p.name, p.email, p.team_id, t.name, t.totalscore " +
                      "FROM players p " +
                      "INNER JOIN teams t ON p.team_id = t.id " +
                      "WHERE p.team_id IN (SELECT tt.teams_id " +
                                          "FROM tournamententry tt " +
                                          "WHERE tournaments_id=" + tournamentid + ") " +
                                          "AND ( p.id LIKE '%" + criteriaValue + "%' " +
                                                     "OR p.name LIKE '%" + criteriaValue + "%' " +
                                                     "OR p.email LIKE '%" + criteriaValue + "%' " +
                                                     "OR t.name LIKE '%" + criteriaValue + "%' )"; 
            }

            MySqlDataReader value = Connection.ExecuteQuery(sql);

            List<Players> listPlayer = new List<Players>();

            while(value.Read() == true)
            {
                // team
                int teamId = int.Parse(value.GetValue(3).ToString());
                string teamName = value.GetValue(4).ToString();
                double teamTotalScore = double.Parse(value.GetValue(5).ToString());
                Teams team = new Teams(teamId, teamName, teamTotalScore);

                // player id
                int playerId = int.Parse(value.GetValue(0).ToString());

                // player name
                string playerName = value.GetValue(1).ToString();
                
                // player email
                string playerEmail = value.GetValue(2).ToString();

                // player
                Players p = new Players(playerId, playerName, playerEmail, team);

                // add to list
                listPlayer.Add(p);
            }

            return listPlayer;
        }
        
        /// <summary>
        /// See how much participating team in selected tournament
        /// </summary>
        /// <param name="tournaments">Selected tournaments</param>
        /// <returns>Total of participating team</returns>
        public static int CalculateParticipant(Tournaments tournaments)
        {
            string sql = "SELECT COUNT(*) " +
                         "FROM tournamententry " +
                         "WHERE Tournaments_Id=" + tournaments.Id;

            MySqlDataReader participantQry =  Connection.ExecuteQuery(sql);

            participantQry.Read();

            int participant = int.Parse(participantQry.GetValue(0).ToString());

            return participant;
        }
        #endregion
    }
} 