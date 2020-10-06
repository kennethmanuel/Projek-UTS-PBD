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
        List<Teams> listTeams = new List<Teams>();
        int selectedPlayerId = FormPlayerTeam.selectedPlayer;

        public FormEditPlayer()
        {
            InitializeComponent();
        }

        private void FormEditPlayer_Load(object sender, EventArgs e)
        {
            listTeams = TournamentEntry.ReadTeam(FormMenu.selectedTournament,"");

            comboBoxTeam.DataSource = listTeams;
            comboBoxTeam.DisplayMember = "Name";
            comboBoxTeam.DropDownStyle = ComboBoxStyle.DropDownList;

            Players selectedPlayer = Players.SelectPlayer(selectedPlayerId);

            int selectedTeamId = selectedPlayer.Team.Id;
            string teamName = "";

            foreach(Teams t in listTeams)
            {
                if(t.Id == selectedTeamId)
                {
                    teamName = t.Name;
                }
            }

            textBoxPlayerId.Text = selectedPlayer.Id.ToString();
            textBoxPlayerName.Text = selectedPlayer.Name;
            textBoxPlayerEmail.Text = selectedPlayer.Email;
            comboBoxTeam.SelectedIndex = comboBoxTeam.FindStringExact(teamName);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                Teams team = (Teams)comboBoxTeam.SelectedItem;
                Players p = new Players(int.Parse(textBoxPlayerId.Text), textBoxPlayerName.Text, textBoxPlayerEmail.Text, team);
                Players.EditPlayer(p);
                MessageBox.Show("Player has been changed", "Information");

                FormPlayerTeam formPlayerTeam = (FormPlayerTeam)this.Owner;
                formPlayerTeam.FormPlayerTeam_Load(buttonEdit, e);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Player cannot be saved. Error Message: " + ex.Message, "Error");
            }
        }
    }
}
