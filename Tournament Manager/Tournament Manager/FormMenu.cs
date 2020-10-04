using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        public Tournaments selectedTournament;
        
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
    }
}
