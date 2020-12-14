using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TournamentClassLibrary
{
    public class Pairing
    {
        private Teams team1;
        private Teams team2;
        private int round;
        private double team1AddScore;
        private double team2AddScore;

        #region Property
        public Teams Team1 { get => team1; set => team1 = value; }
        public Teams Team2 { get => team2; set => team2 = value; }
        public int Round { get => round; set => round = value; }
        public double Team1AddScore { get => team1AddScore; set => team1AddScore = value; }
        public double Team2AddScore { get => team2AddScore; set => team2AddScore = value; }
        #endregion

        #region Constructor
        public Pairing(Teams team1, Teams team2, int round)
        {
            this.Team1 = team1;
            this.Team2 = team2;
            this.Round = round;
            this.Team1AddScore = 0;
            this.Team2AddScore = 0;
        }

        public Pairing(Teams team1, Teams team2, int round, double team1AddScore, double team2AddScore)
        {
            this.Team1 = team1;
            this.Team2 = team2;
            this.Round = round;
            this.Team1AddScore = team1AddScore;
            this.Team2AddScore = team2AddScore;
        }
        #endregion

        #region Methods
        public static List<Pairing> GeneratePairing(List<Teams> teamList)
        {
            List<Pairing> pairingList = new List<Pairing>();

            int totalTeam = teamList.Count() - 1;

            for (int x = 0; x < totalTeam; x++)
            {
                int round = 1;
                for (int y = totalTeam; y > x; y--)
                {
                    Pairing pair = new Pairing(teamList[x], teamList[y], round);

                    pairingList.Add(pair);
                    round++;
                }

            }
            return pairingList;
        }       
        public static string TestPairing(List<Pairing> pairingList)
        {
            string output = "";

            foreach(Pairing pair in pairingList)
            {
                output += pair.Team1.Name + " vs " + pair.Team2.Name + " " +  pair.Round + "\n";                
            }

            return output;

        }

        public static void InsertPairing(List<Pairing> pairList)
        {
            foreach(Pairing pair in pairList)
            {
                /////////////////////////////////////////////////////////////////////////////////////

                // INSERT Matchup
                // MatchupId
                string newMatchupId = Matchups.GenerateId();

                // WinnerId
                int winnerId;
                if(pair.Team1AddScore > pair.Team2AddScore)
                {
                    winnerId = pair.Team1.Id;
                }
                else if(pair.Team2AddScore > pair.Team1AddScore)
                {
                    winnerId = pair.Team2.Id;
                }
                else
                {
                    // SET winnerId 0 to draw
                    winnerId = 0;
                }

                // Round
                int round = pair.Round;

                // SQL
                string sql1 =
                    "INSERT INTO matchup " +
                    "VALUES ('" + newMatchupId + "','" + winnerId + "','" + round + "');";
                Connection.ExecuteDML(sql1);

                /////////////////////////////////////////////////////////////////////////////////////

                /////////////////////////////////////////////////////////////////////////////////////

                // Parent matchupid
                string parentMatchupId = newMatchupId;

                /////////////////////////////////////////////////////////////////////////////////////

                // INSERT matchupentries for team1
                // Team1 Id
                int team1Id = pair.Team1.Id;

                // Team1 Score
                double team1AddScore = pair.Team1AddScore;

                // SQL
                string sql2 =
                    "INSERT INTO matchupentries " +
                    "VALUES ('" + newMatchupId + "','" + team1Id + "','" + team1AddScore + "');";
                Connection.ExecuteDML(sql2);
                /////////////////////////////////////////////////////////////////////////////////////

                // INSERT matchupentries for team2
                // Team2 Id

                int team2Id = pair.Team2.Id;

                // Team2 Score
                double team2AddScore = pair.Team2AddScore;

                // SQL
                string sql3 =
                    "INSERT INTO matchupentries " +
                    "VALUES ('" + newMatchupId + "','" + team2Id + "','" + team2AddScore + "');";
                Connection.ExecuteDML(sql3);
                /////////////////////////////////////////////////////////////////////////////////////

                // UPDATE team1 score
                double newTeam1Score = pair.Team1.TotalScore + team1AddScore;
                string sql4 =
                    "UPDATE teams " +
                    "SET totalscore='" + newTeam1Score + "';";
                Connection.ExecuteDML(sql4);

                // Update team2 score
                double newTeam2Score = pair.Team2.TotalScore + team2AddScore;
                string sql5 =
                    "UPDATE teams " +
                    "SET totalscore ='" + newTeam2Score + "';";
                Connection.ExecuteDML(sql5);

                /////////////////////////////////////////////////////////////////////////////////////
            }
        }
        #endregion
    }
}
