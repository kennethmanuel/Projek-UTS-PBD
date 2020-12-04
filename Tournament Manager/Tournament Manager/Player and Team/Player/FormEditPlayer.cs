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
    public partial class FormEditPlayer : Form
    {
        // List teams for comboxbox
        List<Teams> listTeams = TournamentEntry.ReadTeam(FormMenu.selectedTournament, "");

        // Selected playerid that is being edited
        int selectedPlayerId = FormPlayerTeam.selectedPlayer;

        public FormEditPlayer()
        {
            InitializeComponent();
        }

        private void FormEditPlayer_Load(object sender, EventArgs e)
        {
            // Show available team on combobox
            comboBoxTeam.DataSource = listTeams;
            comboBoxTeam.DisplayMember = "Name";
            comboBoxTeam.DropDownStyle = ComboBoxStyle.DropDownList;

            // Get selectedplayer data
            Players selectedPlayer = Players.SelectPlayer(selectedPlayerId);

            // Get selectedplayer team
            int selectedTeamId = selectedPlayer.Team.Id;
            string teamName = "";
            foreach(Teams t in listTeams)
            {
                if(t.Id == selectedTeamId)
                {
                    teamName = t.Name;
                }
            }

            // Display player data
            textBoxPlayerId.Text = selectedPlayer.Id.ToString();
            textBoxPlayerName.Text = selectedPlayer.Name;
            textBoxPlayerEmail.Text = selectedPlayer.Email;
            comboBoxTeam.SelectedIndex = comboBoxTeam.FindStringExact(teamName);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                // Get selected team
                Teams team = (Teams)comboBoxTeam.SelectedItem;

                // Create new player
                Players p = new Players(int.Parse(textBoxPlayerId.Text), textBoxPlayerName.Text, textBoxPlayerEmail.Text, team);

                // Edit player and change to the new player object
                Players.EditPlayer(p);

                // Confirmation
                MessageBox.Show("Player has been changed", "Information");

                // Refresh datagridview on FormPlayerTeam
                FormPlayerTeam formPlayerTeam = (FormPlayerTeam)this.Owner;
                formPlayerTeam.FormPlayerTeam_Load(buttonEdit, e);

                // Close form
                this.Close();
            }
            catch (Exception ex)
            {
                // Fail confirmation message
                MessageBox.Show("Player cannot be saved. Error Message: " + ex.Message, "Error");
            }
        }
    }
}
