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

        // Selected tournament from FormTournament.cs
        public static Tournaments selectedTournament;

        public FormMenu()
        {
            InitializeComponent();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            // Get selectedTournament from FormTournament.cs
            formTournament = (FormTournament)this.Owner;
            selectedTournament = formTournament.selectedTournament;

            // Change selected tournament label with the proper one
            labelTournamentValue.Text = selectedTournament.Name;
        }

        private void FormMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Close program
            Application.Exit();
        }

        private void teamAndPlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Open FormPlayerTeam
            FormPlayerTeam form = new FormPlayerTeam();
            form.Owner = this;
            this.Hide();
            form.ShowDialog();
        }

        private void matchToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            // Open FormMatch
            FormMatch form = new FormMatch();
            form.Owner = this;
            this.Hide();
            form.ShowDialog();
        }

        private void prizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Open FormPrize
            FormPrize frm = new FormPrize();
            frm.Owner = this;
            this.Hide();
            frm.ShowDialog();
        }

        private void loadAnotherTournamentFromDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Open FormTournament
            FormTournament form = new FormTournament();
            form.Owner = this;
            this.Hide();
            form.ShowDialog();
        }

        private void generateTournamentStartingBracketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Open FormBracketGenerator
            FormBracketGenerator form = new FormBracketGenerator();
            form.Owner = this;
            form.ShowDialog();
        }

        private void buttonViewTeam_Click(object sender, EventArgs e)
        {
            // Open FormPlayerTeam
            teamAndPlayerToolStripMenuItem_Click(sender, e);
        }

        private void buttonViewPlayer_Click(object sender, EventArgs e)
        {
            // Open FormPlayerTeam
            teamAndPlayerToolStripMenuItem_Click(sender, e);
        }

        private void buttonView_Click(object sender, EventArgs e)
        {
            // Open FormPrize
            prizeToolStripMenuItem_Click(sender, e);
        }

        private void buttonViewMatchups_Click(object sender, EventArgs e)
        {
            // Open FormMatch
            matchToolStripMenuItem_Click_1(sender, e);
        }

        private void buttonMatchupEntries_Click(object sender, EventArgs e)
        {
            // Open FormMatch
            matchToolStripMenuItem_Click_1(sender, e);
        }

        private void buttonViewPairing_Click(object sender, EventArgs e)
        {
            // Open FormBracketGenerator
            generateTournamentStartingBracketToolStripMenuItem_Click(sender, e);
        }

        private void linkLabelAbout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Open GitHub URL on browser
            System.Diagnostics.Process.Start("https://github.com/kennethmanuel/Projek-UTS-PBD");
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            // Confirm delete message
            DialogResult konfirmasi = MessageBox.Show("Current tournament will be deleted , Are you sure?", "Konfirmasi", MessageBoxButtons.YesNo);

            // Confirm deletion
            if (konfirmasi == System.Windows.Forms.DialogResult.Yes)
            {
                bool sucess = Tournaments.DeleteTournament(selectedTournament, out string exceptionMessage);

                if (sucess)
                {
                    MessageBox.Show("Tournament has been deleted.", "information");

                    FormTournament form = new FormTournament();
                    form.Owner = this;
                    this.Hide();
                    form.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Fail to delete tournament: " + exceptionMessage);
                }
            }
        }

        private void buttonNextRound_Click(object sender, EventArgs e)
        {
            // Cek apakah semua skor sudah terisi
            // Ganti Round di tournament jadi Round + 1
            // Jika sudah, lakukan pairing!
                // 1. Pairing round robin
                // 
            // 

        }
    }
}
