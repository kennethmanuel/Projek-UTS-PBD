using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tournament_Manager.Match;
using TournamentClassLibrary;

namespace Tournament_Manager
{
    public partial class FormMenu : Form
    {
        FormTournament formTournament;
        public static Tournaments selectedTournament;

        public FormMenu()
        {
            InitializeComponent();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            formTournament = (FormTournament)this.Owner;
            selectedTournament = formTournament.selectedTournament;
            labelTournamentName.Text = selectedTournament.Name;
        }

        private void FormMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void teamAndPlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPlayerTeam form = new FormPlayerTeam();
            form.Owner = this;
            this.Hide();
            form.ShowDialog();
        }

        private void matchToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FormMatch form = new FormMatch();
            form.Owner = this;
            this.Hide();
            form.ShowDialog();
        }

        private void buttonTestTournamentLoad_Click(object sender, EventArgs e)
        {
            FormTournament form = new FormTournament();
            form.Owner = this;
            form.ShowDialog();
        }

        private void prizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPrize frm = new FormPrize();
            frm.Owner = this;
            frm.ShowDialog();
        }

        private void loadAnotherTournamentFromDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTournament form = new FormTournament();
            form.Owner = this;
            this.Hide();
            form.ShowDialog();
        }

        private void buttonGeneratePairingSE_Click(object sender, EventArgs e)
        {
            listBoxPairingSE.Items.Clear();

            List<Teams> listTeam = TournamentEntry.ReadTeam(selectedTournament, "");

            Random rnd = new Random();

            for (int i = listTeam.Count() - 1; i > 0; i--)
            {
                Teams temp = listTeam[i];
                int index = rnd.Next(0, i + 1);
                listTeam[i] = listTeam[index];
                listTeam[index] = temp;
            }

            var teamstack = new Stack<Teams>(listTeam);

            while (teamstack.Count != 0 && teamstack.Count()!= 1)
            {
                listBoxPairingSE.Items.Add(teamstack.Pop().Name + " vs " + teamstack.Pop().Name);
            }
            listBoxPairingSE.Items.Add(teamstack.Pop().Name + " vs bye");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBoxPairingRR.Items.Clear();

            List<Teams> listTeam = TournamentEntry.ReadTeam(selectedTournament, "");

            int listteamcount = listTeam.Count();
            int iterasi = listteamcount - 1;
            for (int i = 0; i <= iterasi; i++ )
            {
                for(int j=i+1; j<=listteamcount-1; j++)
                {
                    listBoxPairingRR.Items.Add(listTeam[i].Name + " vs " + listTeam[j].Name);
                }
            }
        }
        
    }
}
