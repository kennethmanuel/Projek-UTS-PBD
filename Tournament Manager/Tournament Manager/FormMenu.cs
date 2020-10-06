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
            this.Hide();
            frm.ShowDialog();
        }

        private void loadAnotherTournamentFromDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTournament form = new FormTournament();
            form.Owner = this;
            this.Hide();
            form.ShowDialog();
        }

        private void generateTournamentStartingBracketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBracketGenerator form = new FormBracketGenerator();
            form.Owner = this;
            form.ShowDialog();
        }

        private void buttonViewTeam_Click(object sender, EventArgs e)
        {
            teamAndPlayerToolStripMenuItem_Click(sender, e);
        }

        private void buttonViewPlayer_Click(object sender, EventArgs e)
        {
            teamAndPlayerToolStripMenuItem_Click(sender, e);
        }

        private void buttonView_Click(object sender, EventArgs e)
        {
            prizeToolStripMenuItem_Click(sender, e);
        }

        private void buttonViewMatchups_Click(object sender, EventArgs e)
        {
            matchToolStripMenuItem_Click_1(sender, e);
        }

        private void buttonMatchupEntries_Click(object sender, EventArgs e)
        {
            matchToolStripMenuItem_Click_1(sender, e);
        }

        private void buttonViewPairing_Click(object sender, EventArgs e)
        {
            generateTournamentStartingBracketToolStripMenuItem_Click(sender, e);
        }

        private void linkLabelAbout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/kennethmanuel/Projek-UTS-PBD");

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DialogResult konfirmasi = MessageBox.Show("Current tournament will be deleted , Are you sure?", "Konfirmasi", MessageBoxButtons.YesNo);
            if (konfirmasi == System.Windows.Forms.DialogResult.Yes)
            {
                string add = Tournaments.DeleteTournament(selectedTournament);
                if (add == "1")
                {
                    MessageBox.Show("Tournament has been deleted.", "information");

                    FormTournament form = new FormTournament();
                    form.Owner = this;
                    this.Hide();
                    form.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Fail to delete tournament. Message error: ", add);
                }
            }
        }
    }
}
