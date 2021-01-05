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

        #region Property
        public Teams Team1 { get => team1; set => team1 = value; }
        public Teams Team2 { get => team2; set => team2 = value; }
        public int Round { get => round; set => round = value; }        
        #endregion

        #region Constructor
        public Pairing(Teams team1, Teams team2, int round)
        {
            this.Team1 = team1;
            this.Team2 = team2;
            this.Round = round;            
        }

        public Pairing(Teams team1, Teams team2, int round, double team1AddScore, double team2AddScore)
        {
            this.Team1 = team1;
            this.Team2 = team2;
            this.Round = round;          
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

        }
        #endregion
    }
}
