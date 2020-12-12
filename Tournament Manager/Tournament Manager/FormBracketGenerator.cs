using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TournamentClassLibrary;

namespace Tournament_Manager
{
    public partial class FormBracketGenerator : Form
    {
        public FormBracketGenerator()
        {
            InitializeComponent();
        }

        private void buttonGeneratePairingSE_Click(object sender, EventArgs e)
        {
            listBoxPairingSE.Items.Clear();

            List<Teams> listTeam = TournamentEntry.ReadTeam(FormMenu.selectedTournament, "");

            Random rnd = new Random();

            for (int i = listTeam.Count() - 1; i > 0; i--)
            {
                Teams temp = listTeam[i];
                int index = rnd.Next(0, i + 1);
                listTeam[i] = listTeam[index];
                listTeam[index] = temp;
            }

            var teamstack = new Stack<Teams>(listTeam);

            while (teamstack.Count != 0 && teamstack.Count() != 1)
            {
                listBoxPairingSE.Items.Add(teamstack.Pop().Name + " vs " + teamstack.Pop().Name);
            }
            if(teamstack.Count ==1)
            {
                listBoxPairingSE.Items.Add(teamstack.Pop().Name + " vs bye");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBoxPairingRR.Items.Clear();

            List<Teams> listTeam = TournamentEntry.ReadTeam(FormMenu.selectedTournament, "");

            int listteamcount = listTeam.Count();
            int iterasi = listteamcount - 1;
            for (int i = 0; i <= iterasi; i++)
            {
                for (int j = i + 1; j <= listteamcount - 1; j++)
                {
                    listBoxPairingRR.Items.Add(listTeam[i].Name + " vs " + listTeam[j].Name);
                }
            }
        }

        private void FormBracketGenerator_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner.Show();

        }

        private void FormBracketGenerator_Load(object sender, EventArgs e)
        {

        }
    }
}
