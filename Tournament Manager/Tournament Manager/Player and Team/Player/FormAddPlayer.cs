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
    public partial class FormAddPlayer : Form
    {
        // Available team on combobox
        List<Teams> listteam = new List<Teams>();

        public FormAddPlayer()
        {
            InitializeComponent();
        }

        private void FormAddPlayer_Load(object sender, EventArgs e)
        {
            // Get available team
            listteam = TournamentEntry.ReadTeam(FormMenu.selectedTournament, "");

            // Show available team on combobox
            comboBoxTeam.DataSource = listteam;
            comboBoxTeam.DisplayMember = "Name";
            comboBoxTeam.DropDownStyle = ComboBoxStyle.DropDownList;

            // Generate playerid
            string newCode = Players.GenerateId();

            // Fill generated playerid on form
            textBoxPlayerId.Text = newCode;

            // Disable editing player id texbox
            textBoxPlayerId.Enabled = false;

            // Focus player name textbox
            textBoxPlayerName.Focus();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // Get selected team
                Teams team = (Teams)comboBoxTeam.SelectedItem;

                // Create player 
                Players p = new Players(int.Parse(textBoxPlayerId.Text), textBoxPlayerName.Text, textBoxPlayerEmail.Text, team);

                // Add player to db
                Players.AddPlayer(p);

                // Confirmation message
                MessageBox.Show("Player has been Saved", "Information");
            }
            catch (Exception ex)
            {
                // Fail confirmation message
                MessageBox.Show("Player cannot be saved. Error Message: " + ex.Message, "Error");
            }
        }

        private void FormAddPlayer_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Show FormTeamPlayer
            FormPlayerTeam frm = (FormPlayerTeam)this.Owner;
            frm.FormPlayerTeam_Load(buttonAdd, e);

            // Close FormAddPlayer
            this.Close();
        }
    }
}
